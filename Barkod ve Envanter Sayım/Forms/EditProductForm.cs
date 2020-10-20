using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barkod_ve_Envanter_Sayım.Forms
{
    class EditProductForm : Form
    {
        private TableLayoutPanel tableLayoutPanel1;
        private Label editProductBarcode_label;
        private TextBox editProductBarcode_textBox;
        private TextBox editProductName_textBox;
        private TextBox editProductPrice_textBox;
        private TextBox editProductPiece_textBox;
        private Label editProductName_label;
        private Label editProductPrice_label;
        private Label editProductPiece_label;
        private Button editProductApply_button;
        private Button editProductFind_button;
        private Label editProdusctKDV_label;
        private TextBox editProductKDV_textBox;
        private UrunlerMapping urunlerMapping;
        private Database dbConnection;
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.editProductBarcode_label = new System.Windows.Forms.Label();
            this.editProductName_textBox = new System.Windows.Forms.TextBox();
            this.editProductPrice_textBox = new System.Windows.Forms.TextBox();
            this.editProductPiece_textBox = new System.Windows.Forms.TextBox();
            this.editProductName_label = new System.Windows.Forms.Label();
            this.editProductPrice_label = new System.Windows.Forms.Label();
            this.editProductPiece_label = new System.Windows.Forms.Label();
            this.editProductFind_button = new System.Windows.Forms.Button();
            this.editProductBarcode_textBox = new System.Windows.Forms.TextBox();
            this.editProductApply_button = new System.Windows.Forms.Button();
            this.editProdusctKDV_label = new System.Windows.Forms.Label();
            this.editProductKDV_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.06877F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.93123F));
            this.tableLayoutPanel1.Controls.Add(this.editProductBarcode_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.editProductName_textBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.editProductPrice_textBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.editProductPiece_textBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.editProductName_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.editProductPrice_label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.editProductPiece_label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.editProductFind_button, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.editProductBarcode_textBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.editProductApply_button, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.editProdusctKDV_label, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.editProductKDV_textBox, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 333);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // editProductBarcode_label
            // 
            this.editProductBarcode_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editProductBarcode_label.AutoSize = true;
            this.editProductBarcode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductBarcode_label.Location = new System.Drawing.Point(3, 14);
            this.editProductBarcode_label.Name = "editProductBarcode_label";
            this.editProductBarcode_label.Size = new System.Drawing.Size(77, 18);
            this.editProductBarcode_label.TabIndex = 0;
            this.editProductBarcode_label.Text = "BARKOD";
            this.editProductBarcode_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editProductName_textBox
            // 
            this.editProductName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editProductName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductName_textBox.Location = new System.Drawing.Point(86, 105);
            this.editProductName_textBox.Name = "editProductName_textBox";
            this.editProductName_textBox.Size = new System.Drawing.Size(260, 24);
            this.editProductName_textBox.TabIndex = 3;
            // 
            // editProductPrice_textBox
            // 
            this.editProductPrice_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editProductPrice_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductPrice_textBox.Location = new System.Drawing.Point(86, 152);
            this.editProductPrice_textBox.Name = "editProductPrice_textBox";
            this.editProductPrice_textBox.Size = new System.Drawing.Size(260, 24);
            this.editProductPrice_textBox.TabIndex = 4;
            // 
            // editProductPiece_textBox
            // 
            this.editProductPiece_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editProductPiece_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductPiece_textBox.Location = new System.Drawing.Point(86, 199);
            this.editProductPiece_textBox.Name = "editProductPiece_textBox";
            this.editProductPiece_textBox.Size = new System.Drawing.Size(260, 24);
            this.editProductPiece_textBox.TabIndex = 5;
            // 
            // editProductName_label
            // 
            this.editProductName_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editProductName_label.AutoSize = true;
            this.editProductName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductName_label.Location = new System.Drawing.Point(3, 99);
            this.editProductName_label.Name = "editProductName_label";
            this.editProductName_label.Size = new System.Drawing.Size(77, 36);
            this.editProductName_label.TabIndex = 5;
            this.editProductName_label.Text = "ÜRÜN İSMİ";
            this.editProductName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editProductPrice_label
            // 
            this.editProductPrice_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editProductPrice_label.AutoSize = true;
            this.editProductPrice_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductPrice_label.Location = new System.Drawing.Point(3, 155);
            this.editProductPrice_label.Name = "editProductPrice_label";
            this.editProductPrice_label.Size = new System.Drawing.Size(77, 18);
            this.editProductPrice_label.TabIndex = 6;
            this.editProductPrice_label.Text = "FİYAT";
            this.editProductPrice_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editProductPiece_label
            // 
            this.editProductPiece_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editProductPiece_label.AutoSize = true;
            this.editProductPiece_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductPiece_label.Location = new System.Drawing.Point(3, 202);
            this.editProductPiece_label.Name = "editProductPiece_label";
            this.editProductPiece_label.Size = new System.Drawing.Size(77, 18);
            this.editProductPiece_label.TabIndex = 7;
            this.editProductPiece_label.Text = "STOK";
            this.editProductPiece_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editProductFind_button
            // 
            this.editProductFind_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editProductFind_button.Location = new System.Drawing.Point(208, 52);
            this.editProductFind_button.Name = "editProductFind_button";
            this.editProductFind_button.Size = new System.Drawing.Size(138, 36);
            this.editProductFind_button.TabIndex = 2;
            this.editProductFind_button.Text = "ÜRÜNÜ GETİR";
            this.editProductFind_button.UseVisualStyleBackColor = true;
            this.editProductFind_button.Click += new System.EventHandler(this.editProductFind_button_Click);
            // 
            // editProductBarcode_textBox
            // 
            this.editProductBarcode_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editProductBarcode_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductBarcode_textBox.Location = new System.Drawing.Point(86, 11);
            this.editProductBarcode_textBox.Name = "editProductBarcode_textBox";
            this.editProductBarcode_textBox.Size = new System.Drawing.Size(260, 24);
            this.editProductBarcode_textBox.TabIndex = 1;
            // 
            // editProductApply_button
            // 
            this.editProductApply_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editProductApply_button.Location = new System.Drawing.Point(208, 290);
            this.editProductApply_button.Name = "editProductApply_button";
            this.editProductApply_button.Size = new System.Drawing.Size(138, 34);
            this.editProductApply_button.TabIndex = 7;
            this.editProductApply_button.Text = "ONAYLA";
            this.editProductApply_button.UseVisualStyleBackColor = true;
            this.editProductApply_button.Click += new System.EventHandler(this.editProductApply_button_Click);
            // 
            // editProdusctKDV_label
            // 
            this.editProdusctKDV_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editProdusctKDV_label.AutoSize = true;
            this.editProdusctKDV_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProdusctKDV_label.Location = new System.Drawing.Point(3, 249);
            this.editProdusctKDV_label.Name = "editProdusctKDV_label";
            this.editProdusctKDV_label.Size = new System.Drawing.Size(77, 18);
            this.editProdusctKDV_label.TabIndex = 10;
            this.editProdusctKDV_label.Text = "KDV";
            this.editProdusctKDV_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editProductKDV_textBox
            // 
            this.editProductKDV_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editProductKDV_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductKDV_textBox.Location = new System.Drawing.Point(86, 246);
            this.editProductKDV_textBox.MaxLength = 2;
            this.editProductKDV_textBox.Name = "editProductKDV_textBox";
            this.editProductKDV_textBox.Size = new System.Drawing.Size(260, 24);
            this.editProductKDV_textBox.TabIndex = 6;
            // 
            // EditProductForm
            // 
            this.ClientSize = new System.Drawing.Size(373, 357);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditProductForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        public EditProductForm() 
        {
            InitializeComponent();
        }

        private void editProductFind_button_Click(object sender, EventArgs e)
        {
            dbConnection = new Database();
            dbConnection.Baglan();
            urunlerMapping = dbConnection.ReturnProduct(editProductBarcode_textBox.Text);
            editProductPiece_textBox.Text = urunlerMapping.stok;
            editProductPrice_textBox.Text = urunlerMapping.fiyat;
            editProductName_textBox.Text = urunlerMapping.isim;
            editProductKDV_textBox.Text = urunlerMapping.kdv;
            dbConnection.BaglantiyiKes();
        }

        private void editProductApply_button_Click(object sender, EventArgs e)
        {
            dbConnection = new Database();
            dbConnection.Baglan();
            urunlerMapping.barcode = editProductBarcode_textBox.Text;
            urunlerMapping.isim = editProductName_textBox.Text;
            urunlerMapping.fiyat = float.Parse(editProductPrice_textBox.Text.Replace(',', '.')).ToString();
            urunlerMapping.stok = float.Parse(editProductPiece_textBox.Text.Replace(',', '.')).ToString();
            urunlerMapping.kdv = int.Parse(editProductKDV_textBox.Text).ToString();
            dbConnection.EditProduct(urunlerMapping);
            dbConnection.BaglantiyiKes();
        }
    }
}
