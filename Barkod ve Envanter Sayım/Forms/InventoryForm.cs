using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Barkod_ve_Envanter_Sayım
{
    class InventoryForm : Form
    {
        private DataGridViewTextBoxColumn inventoryProductColumn_dataGridView;
        private DataGridViewTextBoxColumn inventoryPiece_dataGridView;
        private DataGridView showInventory_dataGridView;
        private Database dbConnection;
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.showInventory_dataGridView = new System.Windows.Forms.DataGridView();
            this.inventoryProductColumn_dataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryPiece_dataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.showInventory_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showInventory_dataGridView
            // 
            this.showInventory_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showInventory_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryProductColumn_dataGridView,
            this.inventoryPiece_dataGridView});
            this.showInventory_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.showInventory_dataGridView.Name = "showInventory_dataGridView";
            this.showInventory_dataGridView.Size = new System.Drawing.Size(690, 448);
            this.showInventory_dataGridView.TabIndex = 0;
            // 
            // inventoryProductColumn_dataGridView
            // 
            this.inventoryProductColumn_dataGridView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryProductColumn_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.inventoryProductColumn_dataGridView.HeaderText = "Ürün";
            this.inventoryProductColumn_dataGridView.Name = "inventoryProductColumn_dataGridView";
            this.inventoryProductColumn_dataGridView.ReadOnly = true;
            // 
            // inventoryPiece_dataGridView
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryPiece_dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.inventoryPiece_dataGridView.HeaderText = "Stok Adedi";
            this.inventoryPiece_dataGridView.Name = "inventoryPiece_dataGridView";
            this.inventoryPiece_dataGridView.ReadOnly = true;
            // 
            // InventoryForm
            // 
            this.ClientSize = new System.Drawing.Size(714, 472);
            this.Controls.Add(this.showInventory_dataGridView);
            this.Name = "InventoryForm";
            this.Text = "STOK DURUMU";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showInventory_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        public InventoryForm() 
        {
            InitializeComponent();
            dbConnection = new Database();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            List<UrunlerMapping> urunlerMappingList;
            dbConnection.Baglan();
            urunlerMappingList = dbConnection.ShowInventory();

            for (int i = 0; i < urunlerMappingList.Count; i++)
            {
                string[] row = new string[] { urunlerMappingList[i].isim, urunlerMappingList[i].stok };
                showInventory_dataGridView.Rows.Add(row);
            }
            showInventory_dataGridView.Rows.Add(new string[] {"TOPLAM ÜRÜN MİKTARI: "+urunlerMappingList.Count.ToString(), String.Empty});

        }
    }
}
