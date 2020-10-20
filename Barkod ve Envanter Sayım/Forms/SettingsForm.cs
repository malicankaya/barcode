using Barkod_ve_Envanter_Sayım.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barkod_ve_Envanter_Sayım
{
    class SettingsForm : Form
    {
        private TableLayoutPanel tableLayoutPanel1;
        private Button addProduct_settings_button;
        private Button deleteProduct_settings_button;
        private Button editProduct_settings_button;

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addProduct_settings_button = new System.Windows.Forms.Button();
            this.deleteProduct_settings_button = new System.Windows.Forms.Button();
            this.editProduct_settings_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.52853F));
            this.tableLayoutPanel1.Controls.Add(this.addProduct_settings_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteProduct_settings_button, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.editProduct_settings_button, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 296);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // addProduct_settings_button
            // 
            this.addProduct_settings_button.Location = new System.Drawing.Point(3, 3);
            this.addProduct_settings_button.Name = "addProduct_settings_button";
            this.addProduct_settings_button.Size = new System.Drawing.Size(327, 94);
            this.addProduct_settings_button.TabIndex = 0;
            this.addProduct_settings_button.Text = "Yeni Ürün(Barkod) Ekle";
            this.addProduct_settings_button.UseVisualStyleBackColor = true;
            this.addProduct_settings_button.Click += new System.EventHandler(this.addProduct_settings_button_Click);
            // 
            // deleteProduct_settings_button
            // 
            this.deleteProduct_settings_button.Location = new System.Drawing.Point(3, 103);
            this.deleteProduct_settings_button.Name = "deleteProduct_settings_button";
            this.deleteProduct_settings_button.Size = new System.Drawing.Size(327, 91);
            this.deleteProduct_settings_button.TabIndex = 1;
            this.deleteProduct_settings_button.Text = "Varolan Ürünü(Barkod) Sil";
            this.deleteProduct_settings_button.UseVisualStyleBackColor = true;
            this.deleteProduct_settings_button.Click += new System.EventHandler(this.deleteProduct_settings_button_Click);
            // 
            // editProduct_settings_button
            // 
            this.editProduct_settings_button.Location = new System.Drawing.Point(3, 200);
            this.editProduct_settings_button.Name = "editProduct_settings_button";
            this.editProduct_settings_button.Size = new System.Drawing.Size(327, 93);
            this.editProduct_settings_button.TabIndex = 2;
            this.editProduct_settings_button.Text = "Varolan Ürünü(Barkod) Düzenle";
            this.editProduct_settings_button.UseVisualStyleBackColor = true;
            this.editProduct_settings_button.Click += new System.EventHandler(this.editProduct_settings_button_Click);
            // 
            // SettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(357, 320);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SettingsForm";
            this.Text = "AYARLAR";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public SettingsForm() 
        {
            InitializeComponent();
        }

        private void addProduct_settings_button_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
        }

        private void deleteProduct_settings_button_Click(object sender, EventArgs e)
        {
            DeleteProductForm deleteProductForm = new DeleteProductForm();
            deleteProductForm.Show();
        }

        private void editProduct_settings_button_Click(object sender, EventArgs e)
        {
            EditProductForm editProductForm = new EditProductForm();
            editProductForm.Show();
        }
    }
}
