using BarcodeLib;
using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Barkod_ve_Envanter_Sayım
{
    class CreateProductForm : Form
    {
        private TableLayoutPanel tableLayoutPanel1;
        private Label productName_label;
        private Label price_label;
        private Label inventory_label;
        private Button addProduct_button;
        private TextBox productName_textBox;
        private TextBox price_textBox;
        private TextBox inventory_textBox;
        private Label shortName_label;
        private TextBox shortName_textBox;
        private Label addProductsKDV_label;
        private TextBox addProductsKDV_textBox;
        private PrintDocument barcode_printDocument;
        private PrintPreviewDialog barcode_printPreviewDialog;
        private Database dbConnection;
        UrunlerMapping urunlerMapping;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProductForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.productName_label = new System.Windows.Forms.Label();
            this.inventory_textBox = new System.Windows.Forms.TextBox();
            this.inventory_label = new System.Windows.Forms.Label();
            this.productName_textBox = new System.Windows.Forms.TextBox();
            this.price_label = new System.Windows.Forms.Label();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.shortName_label = new System.Windows.Forms.Label();
            this.shortName_textBox = new System.Windows.Forms.TextBox();
            this.addProductsKDV_label = new System.Windows.Forms.Label();
            this.addProductsKDV_textBox = new System.Windows.Forms.TextBox();
            this.addProduct_button = new System.Windows.Forms.Button();
            this.barcode_printDocument = new System.Drawing.Printing.PrintDocument();
            this.barcode_printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.5132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.4868F));
            this.tableLayoutPanel1.Controls.Add(this.productName_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inventory_textBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.inventory_label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.productName_textBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.price_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.price_textBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.shortName_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.shortName_textBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.addProductsKDV_label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.addProductsKDV_textBox, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 243);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // productName_label
            // 
            this.productName_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productName_label.AutoSize = true;
            this.productName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName_label.Location = new System.Drawing.Point(3, 6);
            this.productName_label.Name = "productName_label";
            this.productName_label.Size = new System.Drawing.Size(81, 36);
            this.productName_label.TabIndex = 1;
            this.productName_label.Text = "ÜRÜN İSMİ";
            this.productName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inventory_textBox
            // 
            this.inventory_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inventory_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_textBox.Location = new System.Drawing.Point(90, 156);
            this.inventory_textBox.Name = "inventory_textBox";
            this.inventory_textBox.Size = new System.Drawing.Size(248, 24);
            this.inventory_textBox.TabIndex = 8;
            // 
            // inventory_label
            // 
            this.inventory_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inventory_label.AutoSize = true;
            this.inventory_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_label.Location = new System.Drawing.Point(3, 150);
            this.inventory_label.Name = "inventory_label";
            this.inventory_label.Size = new System.Drawing.Size(81, 36);
            this.inventory_label.TabIndex = 3;
            this.inventory_label.Text = "STOK ADEDİ";
            this.inventory_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productName_textBox
            // 
            this.productName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName_textBox.Location = new System.Drawing.Point(90, 12);
            this.productName_textBox.Name = "productName_textBox";
            this.productName_textBox.Size = new System.Drawing.Size(248, 24);
            this.productName_textBox.TabIndex = 5;
            // 
            // price_label
            // 
            this.price_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.Location = new System.Drawing.Point(3, 102);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(81, 36);
            this.price_label.TabIndex = 2;
            this.price_label.Text = "ÜRÜN FİYAT";
            this.price_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price_textBox
            // 
            this.price_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.price_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_textBox.Location = new System.Drawing.Point(90, 108);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(248, 24);
            this.price_textBox.TabIndex = 7;
            // 
            // shortName_label
            // 
            this.shortName_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.shortName_label.AutoSize = true;
            this.shortName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortName_label.Location = new System.Drawing.Point(3, 56);
            this.shortName_label.Name = "shortName_label";
            this.shortName_label.Size = new System.Drawing.Size(81, 32);
            this.shortName_label.TabIndex = 8;
            this.shortName_label.Text = "ÜRÜN FİŞ İSMİ";
            this.shortName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shortName_textBox
            // 
            this.shortName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.shortName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortName_textBox.Location = new System.Drawing.Point(90, 60);
            this.shortName_textBox.MaxLength = 19;
            this.shortName_textBox.Name = "shortName_textBox";
            this.shortName_textBox.Size = new System.Drawing.Size(248, 24);
            this.shortName_textBox.TabIndex = 6;
            // 
            // addProductsKDV_label
            // 
            this.addProductsKDV_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductsKDV_label.AutoSize = true;
            this.addProductsKDV_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductsKDV_label.Location = new System.Drawing.Point(3, 208);
            this.addProductsKDV_label.Name = "addProductsKDV_label";
            this.addProductsKDV_label.Size = new System.Drawing.Size(81, 18);
            this.addProductsKDV_label.TabIndex = 10;
            this.addProductsKDV_label.Text = "KDV";
            this.addProductsKDV_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addProductsKDV_textBox
            // 
            this.addProductsKDV_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductsKDV_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductsKDV_textBox.Location = new System.Drawing.Point(90, 205);
            this.addProductsKDV_textBox.MaxLength = 2;
            this.addProductsKDV_textBox.Name = "addProductsKDV_textBox";
            this.addProductsKDV_textBox.Size = new System.Drawing.Size(248, 24);
            this.addProductsKDV_textBox.TabIndex = 9;
            // 
            // addProduct_button
            // 
            this.addProduct_button.Location = new System.Drawing.Point(111, 261);
            this.addProduct_button.Name = "addProduct_button";
            this.addProduct_button.Size = new System.Drawing.Size(140, 53);
            this.addProduct_button.TabIndex = 10;
            this.addProduct_button.Text = "ÜRÜN EKLE";
            this.addProduct_button.UseVisualStyleBackColor = true;
            this.addProduct_button.Click += new System.EventHandler(this.createProduct_button_Click);
            // 
            // barcode_printDocument
            // 
            this.barcode_printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.barcode_printDocument_PrintPage);
            // 
            // barcode_printPreviewDialog
            // 
            this.barcode_printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.barcode_printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.barcode_printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.barcode_printPreviewDialog.Document = this.barcode_printDocument;
            this.barcode_printPreviewDialog.Enabled = true;
            this.barcode_printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("barcode_printPreviewDialog.Icon")));
            this.barcode_printPreviewDialog.Name = "barcode_printPreviewDialog";
            this.barcode_printPreviewDialog.Visible = false;
            // 
            // CreateProductForm
            // 
            this.ClientSize = new System.Drawing.Size(365, 319);
            this.Controls.Add(this.addProduct_button);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CreateProductForm";
            this.Text = "ÜRÜN OLUŞTUR";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        public CreateProductForm()
        {
            InitializeComponent();
        }

        private void createProduct_button_Click(object sender, EventArgs e)
        {
            urunlerMapping = new UrunlerMapping();
            Barcode barcodeLib = new Barcode();
            try
            {
                urunlerMapping.fiyat = float.Parse(price_textBox.Text.Replace(',', '.')).ToString(); ;
                urunlerMapping.stok = float.Parse(inventory_textBox.Text.Replace(',', '.')).ToString();
                urunlerMapping.kdv = int.Parse(addProductsKDV_textBox.Text).ToString();
                dbConnection = new Database();
                dbConnection.Baglan();
                //encode yaptıktan sonra check digit rawData'ya ekleniyor
                barcodeLib.Encode(TYPE.EAN13, "9799753" + (10001 + Int32.Parse(dbConnection.GetBarcodeCode("select id from urunler order by id desc limit 1"))));
                urunlerMapping.barcode = barcodeLib.RawData;
                urunlerMapping.isim = productName_textBox.Text;
                urunlerMapping.shortName = shortName_textBox.Text;
                dbConnection.AddProduct(urunlerMapping);
                dbConnection.BaglantiyiKes();
                barcode_printDocument.Print();
                productName_textBox.Text = price_textBox.Text = inventory_textBox.Text = shortName_textBox.Text = addProductsKDV_textBox.Text = String.Empty;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Geçerli Bir Değer Girin");
            }
        }

        private void barcode_printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrintingExample printingExample = new PrintingExample();
            printingExample.PrintBarcode(sender,e,urunlerMapping);
        }
    }
}
