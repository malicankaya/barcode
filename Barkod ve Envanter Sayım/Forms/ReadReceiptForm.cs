using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barkod_ve_Envanter_Sayım.Forms
{
    class ReadReceiptForm : Form
    {
        private DataGridViewTextBoxColumn readReceiptDataGridView_productName_Column;
        private DataGridViewTextBoxColumn readReceiptDataGridView_KDV_Column;
        private DataGridViewTextBoxColumn readReceiptDataGridView_unitPrice_Column;
        private DataGridViewTextBoxColumn readReceiptDataGridView_piece_Column;
        private DataGridViewTextBoxColumn readReceiptDataGridView_totalPrice_Column;
        private DataGridView readReceipt_dataGridView;
        private TableLayoutPanel tableLayoutPanel1;
        private Label barcode_label;
        private Button getReceipt_button;
        private TextBox barcode_textBox;
        Database dbConnection;
        List<UrunlerMapping> urunlerMappingList;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.readReceipt_dataGridView = new System.Windows.Forms.DataGridView();
            this.readReceiptDataGridView_productName_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readReceiptDataGridView_KDV_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readReceiptDataGridView_unitPrice_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readReceiptDataGridView_piece_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readReceiptDataGridView_totalPrice_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.barcode_label = new System.Windows.Forms.Label();
            this.getReceipt_button = new System.Windows.Forms.Button();
            this.barcode_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.readReceipt_dataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // readReceipt_dataGridView
            // 
            this.readReceipt_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readReceipt_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.readReceiptDataGridView_productName_Column,
            this.readReceiptDataGridView_KDV_Column,
            this.readReceiptDataGridView_unitPrice_Column,
            this.readReceiptDataGridView_piece_Column,
            this.readReceiptDataGridView_totalPrice_Column});
            this.readReceipt_dataGridView.Location = new System.Drawing.Point(12, 59);
            this.readReceipt_dataGridView.Name = "readReceipt_dataGridView";
            this.readReceipt_dataGridView.Size = new System.Drawing.Size(951, 395);
            this.readReceipt_dataGridView.TabIndex = 0;
            // 
            // readReceiptDataGridView_productName_Column
            // 
            this.readReceiptDataGridView_productName_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readReceiptDataGridView_productName_Column.DefaultCellStyle = dataGridViewCellStyle1;
            this.readReceiptDataGridView_productName_Column.HeaderText = "Ürün Adı";
            this.readReceiptDataGridView_productName_Column.Name = "readReceiptDataGridView_productName_Column";
            // 
            // readReceiptDataGridView_KDV_Column
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readReceiptDataGridView_KDV_Column.DefaultCellStyle = dataGridViewCellStyle2;
            this.readReceiptDataGridView_KDV_Column.HeaderText = "KDV";
            this.readReceiptDataGridView_KDV_Column.Name = "readReceiptDataGridView_KDV_Column";
            // 
            // readReceiptDataGridView_unitPrice_Column
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readReceiptDataGridView_unitPrice_Column.DefaultCellStyle = dataGridViewCellStyle3;
            this.readReceiptDataGridView_unitPrice_Column.HeaderText = "Birim Fiyat";
            this.readReceiptDataGridView_unitPrice_Column.Name = "readReceiptDataGridView_unitPrice_Column";
            // 
            // readReceiptDataGridView_piece_Column
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readReceiptDataGridView_piece_Column.DefaultCellStyle = dataGridViewCellStyle4;
            this.readReceiptDataGridView_piece_Column.HeaderText = "Adet";
            this.readReceiptDataGridView_piece_Column.Name = "readReceiptDataGridView_piece_Column";
            // 
            // readReceiptDataGridView_totalPrice_Column
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readReceiptDataGridView_totalPrice_Column.DefaultCellStyle = dataGridViewCellStyle5;
            this.readReceiptDataGridView_totalPrice_Column.HeaderText = "Fiyat";
            this.readReceiptDataGridView_totalPrice_Column.Name = "readReceiptDataGridView_totalPrice_Column";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Controls.Add(this.barcode_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.getReceipt_button, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.barcode_textBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(410, 41);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // barcode_label
            // 
            this.barcode_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.barcode_label.AutoSize = true;
            this.barcode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode_label.Location = new System.Drawing.Point(3, 11);
            this.barcode_label.Name = "barcode_label";
            this.barcode_label.Size = new System.Drawing.Size(92, 18);
            this.barcode_label.TabIndex = 0;
            this.barcode_label.Text = "BARKOD";
            this.barcode_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getReceipt_button
            // 
            this.getReceipt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getReceipt_button.Location = new System.Drawing.Point(325, 3);
            this.getReceipt_button.Name = "getReceipt_button";
            this.getReceipt_button.Size = new System.Drawing.Size(82, 35);
            this.getReceipt_button.TabIndex = 2;
            this.getReceipt_button.Text = "GETİR";
            this.getReceipt_button.UseVisualStyleBackColor = true;
            this.getReceipt_button.Click += new System.EventHandler(this.getReceipt_button_Click);
            // 
            // barcode_textBox
            // 
            this.barcode_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.barcode_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode_textBox.Location = new System.Drawing.Point(101, 8);
            this.barcode_textBox.Name = "barcode_textBox";
            this.barcode_textBox.Size = new System.Drawing.Size(218, 24);
            this.barcode_textBox.TabIndex = 1;
            this.barcode_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcode_textBox_KeyDown);
            // 
            // ReadReceiptForm
            // 
            this.ClientSize = new System.Drawing.Size(975, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.readReceipt_dataGridView);
            this.Name = "ReadReceiptForm";
            this.Text = "FİŞ GÖRÜNTÜLE";
            ((System.ComponentModel.ISupportInitialize)(this.readReceipt_dataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        public ReadReceiptForm () 
        {
            InitializeComponent();
            dbConnection = new Database();
        }

        private void barcode_textBox_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    //enter basıldığında hata sesini engellemek için
                    e.SuppressKeyPress = true;
                    if (barcode_textBox.Text != string.Empty) 
                    {
                        getReceipt_button_Click(sender, e);
                    }
                }
        }

        private void getReceipt_button_Click(object sender, EventArgs e)
        {
            dbConnection.Baglan();
            if (dbConnection.getID("select id from alisverisler where barcode = '" + barcode_textBox.Text + "'") != string.Empty)
            {
                urunlerMappingList = new List<UrunlerMapping>();

                urunlerMappingList = dbConnection.readReceipt(barcode_textBox.Text);

                foreach (UrunlerMapping item in urunlerMappingList)
                {
                    string[] row = new string[] { item.isim, item.kdv, item.fiyat, item.adet, (float.Parse(item.fiyat) * float.Parse(item.adet)).ToString("0.00") };
                    readReceipt_dataGridView.Rows.Add(row);
                }
            }
            else 
            {
                MessageBox.Show("Fiş bulunamamıştır.","UYARI");
            }

            
        }
    }
}
