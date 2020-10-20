using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barkod_ve_Envanter_Sayım.Forms
{
    class DeleteProductForm : Form
    {
        private TableLayoutPanel tableLayoutPanel1;
        private Label deleteProductbarcode_label;
        private Button deleteProduct_button;
        private TextBox deleteProductbarcode_textBox;
        private Database dbConnection;
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteProductbarcode_label = new System.Windows.Forms.Label();
            this.deleteProduct_button = new System.Windows.Forms.Button();
            this.deleteProductbarcode_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.63343F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.36657F));
            this.tableLayoutPanel1.Controls.Add(this.deleteProductbarcode_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteProduct_button, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.deleteProductbarcode_textBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 109);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // deleteProductbarcode_label
            // 
            this.deleteProductbarcode_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProductbarcode_label.AutoSize = true;
            this.deleteProductbarcode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProductbarcode_label.Location = new System.Drawing.Point(3, 19);
            this.deleteProductbarcode_label.Name = "deleteProductbarcode_label";
            this.deleteProductbarcode_label.Size = new System.Drawing.Size(77, 16);
            this.deleteProductbarcode_label.TabIndex = 0;
            this.deleteProductbarcode_label.Text = "BARKOD";
            this.deleteProductbarcode_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteProduct_button
            // 
            this.deleteProduct_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteProduct_button.Location = new System.Drawing.Point(187, 62);
            this.deleteProduct_button.Name = "deleteProduct_button";
            this.deleteProduct_button.Size = new System.Drawing.Size(151, 39);
            this.deleteProduct_button.TabIndex = 1;
            this.deleteProduct_button.Text = "ÜRÜNÜ SİL";
            this.deleteProduct_button.UseVisualStyleBackColor = true;
            this.deleteProduct_button.Click += new System.EventHandler(this.deleteProduct_button_Click);
            this.deleteProduct_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.deleteProduct_button_KeyDown);
            // 
            // deleteProductbarcode_textBox
            // 
            this.deleteProductbarcode_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProductbarcode_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProductbarcode_textBox.Location = new System.Drawing.Point(86, 15);
            this.deleteProductbarcode_textBox.Name = "deleteProductbarcode_textBox";
            this.deleteProductbarcode_textBox.Size = new System.Drawing.Size(252, 24);
            this.deleteProductbarcode_textBox.TabIndex = 2;
            // 
            // DeleteProductForm
            // 
            this.ClientSize = new System.Drawing.Size(365, 183);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DeleteProductForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        public DeleteProductForm() 
        {
            InitializeComponent();

            dbConnection = new Database();
        }

        private void deleteProduct_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Ürünü silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) 
            {
                dbConnection.Baglan();
                dbConnection.DeleteProduct(deleteProductbarcode_textBox.Text);
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi.","UYARI");
            }

        }

        private void deleteProduct_button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter basıldığında hata sesini engellemek için
                e.SuppressKeyPress = true;
            }
        }
    }
}
