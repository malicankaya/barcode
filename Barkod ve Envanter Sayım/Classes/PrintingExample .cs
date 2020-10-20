using System;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using Barkod_ve_Envanter_Sayım.Classes;
using BarcodeLib;

namespace Barkod_ve_Envanter_Sayım
{
    class PrintingExample
    {
        StringFormat stringFormatCenter;
        CompanyInfos companyInfos;
        Database dbConnection;
        string shoppingBarcode;
        //printer 0-190 arası
        //max karakter 28
        public void PrintPage(object sender, PrintPageEventArgs e, List<UrunlerMapping> urunlerMappingList,string cash)
        {
            dbConnection = new Database();
            dbConnection.Baglan();
            //fonksiyon ismi getID fakat ne istersek onu getirebiliyor.
            shoppingBarcode = dbConnection.getID("select top 1 barcode from alisverisler order by id desc limit 1");

            companyInfos = new CompanyInfos();
            Graphics graphics = e.Graphics;
            stringFormatCenter = new StringFormat();
            stringFormatCenter.Alignment = StringAlignment.Center;
            stringFormatCenter.LineAlignment = StringAlignment.Center;
            //fiyatın sağa sabitlenmesi için
            StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);

            Font regular = new Font(FontFamily.GenericMonospace, 7.5f, FontStyle.Bold);
            Font low = new Font(FontFamily.GenericMonospace, 6f, FontStyle.Bold);

            //alışveriş için barkod üretimi
            GenerateBarcode generateBarcode = new GenerateBarcode();
            Image i = generateBarcode.GetBarcode(shoppingBarcode, 100,50);


            //print header
            graphics.DrawString(companyInfos.name, regular, Brushes.Black, new Rectangle(0, 20, 190, 0), stringFormatCenter);
            graphics.DrawString(companyInfos.ownerName, regular, Brushes.Black, new Rectangle(0, 35, 190, 0), stringFormatCenter);
            graphics.DrawString(companyInfos.addressLine1, regular, Brushes.Black, new Rectangle(0, 50, 190, 0), stringFormatCenter);
            graphics.DrawString(companyInfos.addressLine2, regular, Brushes.Black, new Rectangle(0, 65, 190, 0), stringFormatCenter);
            graphics.DrawString(companyInfos.vdInfo, low, Brushes.Black, new Rectangle(0, 80, 190, 0), stringFormatCenter);
            graphics.DrawString("TARİH", regular, Brushes.Black, 10, 95);
            graphics.DrawString(": " + DateTime.Now.ToString("dd.MM.yyyy") + "", regular, Brushes.Black, 45, 95);
            graphics.DrawString("SAAT", regular, Brushes.Black, 10, 110);
            graphics.DrawString(": " + DateTime.Now.ToString("HH:mm") + "", regular, Brushes.Black, 45, 110);

            int y = 120;
            double totalPrice = 0;
            float topkdv = 0;

            foreach (UrunlerMapping urunlerMapping in urunlerMappingList)
            {
                y += 15;

                if (urunlerMapping.adet == "1")
                {
                    graphics.DrawString(urunlerMapping.shortName, regular, Brushes.Black, new Rectangle(0, y, 190, 0));
                    graphics.DrawString(float.Parse(urunlerMapping.fiyat).ToString("0.00") + "*", regular, Brushes.Black, new Rectangle(0, y, 190, 0), format);
                    
                }
                else
                {
                    graphics.DrawString(urunlerMapping.adet + " ADET X " + float.Parse(urunlerMapping.fiyat).ToString("0.00"), regular, Brushes.Black, new Rectangle(0, y, 190, 0));
                    y += 15;
                    graphics.DrawString(urunlerMapping.shortName, regular, Brushes.Black, new Rectangle(0, y, 190, 0));
                    graphics.DrawString((float.Parse(urunlerMapping.adet) * float.Parse(urunlerMapping.fiyat)).ToString("0.00")+"*", regular, Brushes.Black, new Rectangle(0, y, 190, 0), format);
                }
                
                totalPrice += float.Parse((float.Parse(urunlerMapping.adet) * float.Parse(urunlerMapping.fiyat)).ToString("0.00"));
                topkdv += (float.Parse(urunlerMapping.fiyat) * float.Parse(urunlerMapping.adet) * int.Parse(urunlerMapping.kdv) / 100);
            }
            graphics.DrawLine(Pens.Black, 10, y+=25, 180, y);
            y += 8;
            graphics.DrawString("TOPKDV", regular, Brushes.Black, new Rectangle(15, y, 190, 0));
            graphics.DrawString(topkdv.ToString("0.00") + "*", regular, Brushes.Black, new Rectangle(0, y, 190, 0), format);
            y += 15;
            graphics.DrawString("TOPLAM", regular, Brushes.Black, new Rectangle(15, y, 190, 0));
            graphics.DrawString(totalPrice.ToString("0.00")+"*", regular, Brushes.Black, new Rectangle(0, y, 190, 0), format);
            y += 20;
            graphics.DrawLine(Pens.Black, 10, y, 180, y);
            y += 10;
            graphics.DrawString("NAKİT", regular, Brushes.Black, new Rectangle(15, y, 190, 0));
            graphics.DrawString(float.Parse(cash).ToString("0.00") + "*", regular, Brushes.Black, new Rectangle(0, y, 190, 0), format);
            y += 15;
            graphics.DrawString("PARAÜSTÜ", regular, Brushes.Black, new Rectangle(15, y, 190, 0));
            graphics.DrawString((float.Parse(cash) - totalPrice).ToString("0.00") + "*", regular, Brushes.Black, new Rectangle(0, y, 190, 0), format);
            y += 15;
            graphics.DrawString("Yine bekleriz...", regular, Brushes.Black, new Rectangle(0, y, 190, 0));
            y += 15;
            graphics.DrawString("KASİYER: Kadir CERAN", regular, Brushes.Black, new Rectangle(0, y, 190, 0));
            y += 15;
            graphics.DrawImage(i, new PointF(0, y));
            //print footer
            //

            //graphics.DrawImage(i, new PointF(0, 0));

            regular.Dispose();
            low.Dispose();
        }
        public void PrintBarcode(object sender, PrintPageEventArgs e,UrunlerMapping urunlerMapping) 
        {
            stringFormatCenter = new StringFormat();
            stringFormatCenter.Alignment = StringAlignment.Center;
            stringFormatCenter.LineAlignment = StringAlignment.Center;
            Graphics graphics = e.Graphics;
            GenerateBarcode generateBarcode = new GenerateBarcode();
            Image i = generateBarcode.GetBarcode(urunlerMapping.barcode,100,180);
            Font font = new Font(FontFamily.GenericMonospace, 15f, FontStyle.Bold);
            graphics.DrawString(urunlerMapping.isim.ToUpper(), font, Brushes.Black, new Rectangle(0, 20, 190, 0), stringFormatCenter);
            graphics.DrawString(urunlerMapping.fiyat, font, Brushes.Black, new Rectangle(0, 40, 190, 0), stringFormatCenter);
            graphics.DrawImage(i, new PointF(0, 60));
        }
    }
}
