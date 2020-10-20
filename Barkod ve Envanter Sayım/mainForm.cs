using BarcodeLib;
using Barkod_ve_Envanter_Sayım.Forms;
using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Barkod_ve_Envanter_Sayım
{
    public partial class mainForm : Form
    {

        Database dbConnection;
        UrunlerMapping urunlerMapping;
        SettingsForm settingsForm;
        PrintingExample printingExample;
        Dictionary<string,double> dictionary_reduceInventory;
        public mainForm()
        {
            InitializeComponent();
            this.Show();
            //form yüklendiğinde focusun barkod textbox'ında olması için
            this.ActiveControl = barcode_textbox;
            //default values
            piece_numericUpDown.Text = "1";

            this.Size = new Size(1366, 768);
            dictionary_reduceInventory = new Dictionary<string, double>();
        }


        private void urunEkle_button_Click(object sender, EventArgs e)
        {
            
            if (barcode_textbox.Text != String.Empty) 
            {
                urunlerMapping = new UrunlerMapping();
                dbConnection = new Database();
                dbConnection.Baglan();
                urunlerMapping = dbConnection.ReturnProduct(barcode_textbox.Text);
                if (urunlerMapping.isim != null)
                {
                    float fiyat = float.Parse(piece_numericUpDown.Text) * float.Parse(urunlerMapping.fiyat);
                    //barcode'u eklememizin nedeni envanterden item azaltmak için gerekli.
                    string[] row = new string[] { urunlerMapping.isim, "%"+urunlerMapping.kdv , float.Parse(piece_numericUpDown.Text).ToString(), fiyat.ToString("0.00") + "₺",barcode_textbox.Text ,urunlerMapping.fiyat,urunlerMapping.shortName};
                    dataGridView_products.Rows.Add(row);
                    lastProduct_label.Text = urunlerMapping.isim;
                    lastProductPrice_label.Text = fiyat.ToString("0.00") + "₺";
                    lastProductPiece_label.Text = row[1];
                    totalPrice_label.Text = (float.Parse(totalPrice_label.Text.Remove(totalPrice_label.Text.Length - 1)) + fiyat).ToString("0.00") + "₺";
                    //okutulmuş ürünleri stoktan düşürmek için barkodları ve adet gerekli
                    //eğer sözlükte olan ürünse miktarı artır, değilse ekle
                    if (dictionary_reduceInventory.ContainsKey(barcode_textbox.Text))
                    {
                        dictionary_reduceInventory[barcode_textbox.Text] += float.Parse(piece_numericUpDown.Text);
                    }
                    else 
                    {
                        dictionary_reduceInventory.Add(barcode_textbox.Text,float.Parse(piece_numericUpDown.Text));
                    }
                    
                    barcode_textbox.Text = String.Empty;
                    piece_numericUpDown.Text = "1";
                }
                else 
                {
                    MessageBox.Show("Ürün Bulunamamıştır");
                    barcode_textbox.Text = String.Empty;
                }
                dbConnection.BaglantiyiKes();
                
            }
            //gridview'deki selected rows'u sıfırlamak için
            dataGridView_products.ClearSelection();
        }

        private void check_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                urunEkle_button_Click(sender, e);
                //enter basıldığında hata sesini engellemek için
                e.SuppressKeyPress = true; 
            }
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void deleteProduct_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_products.SelectedRows)
            {
                dataGridView_products.Rows.Remove(row);
                totalPrice_label.Text = (float.Parse(totalPrice_label.Text.Remove(totalPrice_label.Text.Length - 1)) - float.Parse(row.Cells[3].Value.ToString().Remove(row.Cells[3].Value.ToString().Length-1))) + "₺";
                dictionary_reduceInventory[row.Cells[4].Value.ToString()] -= float.Parse(row.Cells[2].Value.ToString());
            }
            dataGridView_products.ClearSelection();
        }

        private void clearProducts_button_Click(object sender, EventArgs e)
        {
            dataGridView_products.Rows.Clear();
            totalPrice_label.Text = "0.00₺";
            dictionary_reduceInventory.Clear();
        }

        private void all_things_focusbarcode_KeyDown(object sender, MouseEventArgs e)
        {
            //nereye tıklanırsa tıklansın her zaman focus barkodda olucak
            this.ActiveControl = barcode_textbox;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            List<UrunlerMapping> urunlerMappingList = new List<UrunlerMapping>();
            urunlerMappingList = addProductstoShopping();
            printingExample = new PrintingExample();
            try
            {
                printingExample.PrintPage(sender, e, urunlerMappingList, cash_textBox.Text);
                clearDataGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("Urunler yazdırılırken bir hata oluştu");
            }
            
        }

        private void fisYazdir_button_Click(object sender, EventArgs e)
        {
            //print fonksiyonu tetiklendiğinde printDocument_PrintPage fonksiyonu çalışacak
            receipt_printDocument.Print();
        }

        private void checkInventory_button_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }

        private void decreaseInventory_button_Click(object sender, EventArgs e)
        {
            decreaseInventory();
            clearDataGridView();
        }

        private void createProductBarcode_button_Click(object sender, EventArgs e)
        {
            CreateProductForm createProductForm = new CreateProductForm();
            createProductForm.Show();
        }

        private void dailyTurnover_button_Click(object sender, EventArgs e)
        {
            TurnoverForm turnoverForm = new TurnoverForm();
            turnoverForm.Show();
        }

        private void completeShopping_button_Click(object sender, EventArgs e)
        {
            addProductstoShopping();
        }




        //GEREKLİ FONKSİYONLAR
        //GEREKLİ FONKSİYONLAR

        private void decreaseInventory() 
        {
            dbConnection = new Database();
            dbConnection.Baglan();
            dbConnection.ReduceInventory(dictionary_reduceInventory);
            dbConnection.BaglantiyiKes();
        }
        private void searchReceipt_button_Click(object sender, EventArgs e)
        {
            ReadReceiptForm readReceiptForm = new ReadReceiptForm();
            readReceiptForm.Show();
        }
        private void startDay_button_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection = new Database();
                dbConnection.Baglan();
                dbConnection.addTurnover();
            }
            catch (Exception)
            {
                MessageBox.Show("Gün eklenirken hata oluştu.");
            }
        }
        private List<UrunlerMapping> addProductstoShopping() 
        {
            List<UrunlerMapping> urunlerMappingList = new List<UrunlerMapping>();
            UrunlerMapping urunlerMapping;
            string shoppingID = "";

            //nakit değeri kontrolü için
            try
            {
                float.Parse(cash_textBox.Text.Replace(',', '.'));
                decreaseInventory();

            try
            {
                //DATABASE İŞLEMLERİ (ALIŞVERİŞ EKLEME,URUN_ADET TABLOSUNA EKLEME YAPMA AŞAĞIDA OLACAK)
                dbConnection = new Database();
                dbConnection.Baglan();
                Barcode barcodeLib = new Barcode();
                //alışveriş için barkod üretiyoruz
                barcodeLib.Encode(TYPE.EAN13, "979975" + (100001 + Int32.Parse(dbConnection.GetBarcodeCode("select id from alisverisler order by id desc limit 1"))));
                dbConnection.addShopping(barcodeLib.RawData);
                //alışveriş barkodunu database'e ekledik
                shoppingID = dbConnection.getShoppingID(barcodeLib.RawData);
                //DATABASE İŞLEMLERİ
        }
            catch (Exception)
            {
                MessageBox.Show("Alışveriş barkodu oluşturulurken hata oluştu");
            }


            foreach (DataGridViewRow row in dataGridView_products.Rows)
                {
                    urunlerMapping = new UrunlerMapping();
                    urunlerMapping.barcode = row.Cells[4].Value.ToString();
                    urunlerMapping.isim = row.Cells[0].Value.ToString();
                    urunlerMapping.adet = row.Cells[2].Value.ToString();
                    urunlerMapping.fiyat = row.Cells[5].Value.ToString();
                    urunlerMapping.shortName = row.Cells[6].Value.ToString();
                    urunlerMapping.kdv = row.Cells[1].Value.ToString().Remove(0, 1);
                    urunlerMappingList.Add(urunlerMapping);
                    //urun_adet tablosuna bütün ürünlerin eklenmesi
                    
                    dbConnection.addUrun_Adet(shoppingID, dbConnection.getProductID(urunlerMapping.barcode), urunlerMapping.adet, dbConnection.getTurnoverID());
                    
                }
                clearDataGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen geçerli bir nakit değeri giriniz.", "UYARI");
            }

            dbConnection.BaglantiyiKes();
            return urunlerMappingList;
        }
        private void clearDataGridView() 
        {
            dataGridView_products.Rows.Clear();
            totalPrice_label.Text = "0.00₺";
            dictionary_reduceInventory.Clear();
        }
    }
}
