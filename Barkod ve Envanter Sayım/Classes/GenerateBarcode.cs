using BarcodeLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barkod_ve_Envanter_Sayım
{
    class GenerateBarcode
    {
        public Image GetBarcode(string bcode, int width,int height) 
        {
            Image image = null;
            Barcode barcode = new Barcode(bcode, TYPE.EAN13);
            //barcode.ForeColor = Color.Black;
            //barcode.BackColor = Color.White;
            //barcode.IncludeLabel = false;
            //barcode.LabelPosition = LabelPositions.TOPCENTER;//code的显示位置
            barcode.ImageFormat = System.Drawing.Imaging.ImageFormat.Png;//图片格式
            //barcode.Height = height;//图片高度设置(px单位)
            //barcode.Width = width;//图片宽度设置(px单位)

            image = barcode.Encode(TYPE.EAN13, bcode, Color.Black,Color.White,width,height);
            return image;
        }
    }
}
