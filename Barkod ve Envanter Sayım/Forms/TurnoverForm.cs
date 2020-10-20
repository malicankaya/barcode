using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barkod_ve_Envanter_Sayım.Forms
{
    class TurnoverForm : Form
    {
        private TabControl turnover_tabControl;
        private TabPage dailyTurnover_tabPage;
        private TabPage monthlyTurnover_tabPage;
        private TabPage totalTurnover_tabPage;
        private DataGridView dailyTurnover_dataGridView;
        private TabPage weeklyTurnover_tabPage;
        Database dbConnection;
        private DataGridViewTextBoxColumn turnover_nameColumn;
        private DataGridViewTextBoxColumn turnover_pieceColumn;
        private DataGridViewTextBoxColumn turnover_priceColumn;
        private DataGridViewTextBoxColumn turnover_totalPriceColumn;
        private DataGridView weeklyTurnover_dataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridView monthlyTurnover_dataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridView totalTurnover_dataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        List<UrunlerMapping> urunlerMappingList;

        private void InitializeComponent()
        {
            this.turnover_tabControl = new System.Windows.Forms.TabControl();
            this.dailyTurnover_tabPage = new System.Windows.Forms.TabPage();
            this.dailyTurnover_dataGridView = new System.Windows.Forms.DataGridView();
            this.turnover_nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnover_pieceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnover_priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnover_totalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weeklyTurnover_tabPage = new System.Windows.Forms.TabPage();
            this.monthlyTurnover_tabPage = new System.Windows.Forms.TabPage();
            this.totalTurnover_tabPage = new System.Windows.Forms.TabPage();
            this.weeklyTurnover_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyTurnover_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTurnover_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnover_tabControl.SuspendLayout();
            this.dailyTurnover_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyTurnover_dataGridView)).BeginInit();
            this.weeklyTurnover_tabPage.SuspendLayout();
            this.monthlyTurnover_tabPage.SuspendLayout();
            this.totalTurnover_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyTurnover_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyTurnover_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTurnover_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // turnover_tabControl
            // 
            this.turnover_tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.turnover_tabControl.Controls.Add(this.dailyTurnover_tabPage);
            this.turnover_tabControl.Controls.Add(this.weeklyTurnover_tabPage);
            this.turnover_tabControl.Controls.Add(this.monthlyTurnover_tabPage);
            this.turnover_tabControl.Controls.Add(this.totalTurnover_tabPage);
            this.turnover_tabControl.Location = new System.Drawing.Point(12, 12);
            this.turnover_tabControl.Name = "turnover_tabControl";
            this.turnover_tabControl.SelectedIndex = 0;
            this.turnover_tabControl.Size = new System.Drawing.Size(597, 524);
            this.turnover_tabControl.TabIndex = 0;
            this.turnover_tabControl.SelectedIndexChanged += new System.EventHandler(this.turnover_tabControl_SelectedIndexChanged);
            // 
            // dailyTurnover_tabPage
            // 
            this.dailyTurnover_tabPage.Controls.Add(this.dailyTurnover_dataGridView);
            this.dailyTurnover_tabPage.Location = new System.Drawing.Point(4, 22);
            this.dailyTurnover_tabPage.Name = "dailyTurnover_tabPage";
            this.dailyTurnover_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dailyTurnover_tabPage.Size = new System.Drawing.Size(589, 498);
            this.dailyTurnover_tabPage.TabIndex = 0;
            this.dailyTurnover_tabPage.Text = "Günlük Ciro";
            this.dailyTurnover_tabPage.UseVisualStyleBackColor = true;
            // 
            // dailyTurnover_dataGridView
            // 
            this.dailyTurnover_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dailyTurnover_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyTurnover_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turnover_nameColumn,
            this.turnover_pieceColumn,
            this.turnover_priceColumn,
            this.turnover_totalPriceColumn});
            this.dailyTurnover_dataGridView.Location = new System.Drawing.Point(6, 6);
            this.dailyTurnover_dataGridView.Name = "dailyTurnover_dataGridView";
            this.dailyTurnover_dataGridView.Size = new System.Drawing.Size(577, 486);
            this.dailyTurnover_dataGridView.TabIndex = 0;
            // 
            // turnover_nameColumn
            // 
            this.turnover_nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.turnover_nameColumn.HeaderText = "İsim";
            this.turnover_nameColumn.Name = "turnover_nameColumn";
            // 
            // turnover_pieceColumn
            // 
            this.turnover_pieceColumn.HeaderText = "Adet";
            this.turnover_pieceColumn.Name = "turnover_pieceColumn";
            // 
            // turnover_priceColumn
            // 
            this.turnover_priceColumn.HeaderText = "Fiyat";
            this.turnover_priceColumn.Name = "turnover_priceColumn";
            // 
            // turnover_totalPriceColumn
            // 
            this.turnover_totalPriceColumn.HeaderText = "Toplam Fiyat";
            this.turnover_totalPriceColumn.Name = "turnover_totalPriceColumn";
            // 
            // weeklyTurnover_tabPage
            // 
            this.weeklyTurnover_tabPage.Controls.Add(this.weeklyTurnover_dataGridView);
            this.weeklyTurnover_tabPage.Location = new System.Drawing.Point(4, 22);
            this.weeklyTurnover_tabPage.Name = "weeklyTurnover_tabPage";
            this.weeklyTurnover_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.weeklyTurnover_tabPage.Size = new System.Drawing.Size(589, 498);
            this.weeklyTurnover_tabPage.TabIndex = 1;
            this.weeklyTurnover_tabPage.Text = "Haftalık Ciro";
            this.weeklyTurnover_tabPage.UseVisualStyleBackColor = true;
            // 
            // monthlyTurnover_tabPage
            // 
            this.monthlyTurnover_tabPage.Controls.Add(this.monthlyTurnover_dataGridView);
            this.monthlyTurnover_tabPage.Location = new System.Drawing.Point(4, 22);
            this.monthlyTurnover_tabPage.Name = "monthlyTurnover_tabPage";
            this.monthlyTurnover_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.monthlyTurnover_tabPage.Size = new System.Drawing.Size(589, 498);
            this.monthlyTurnover_tabPage.TabIndex = 2;
            this.monthlyTurnover_tabPage.Text = "Aylık Ciro";
            this.monthlyTurnover_tabPage.UseVisualStyleBackColor = true;
            // 
            // totalTurnover_tabPage
            // 
            this.totalTurnover_tabPage.Controls.Add(this.totalTurnover_dataGridView);
            this.totalTurnover_tabPage.Location = new System.Drawing.Point(4, 22);
            this.totalTurnover_tabPage.Name = "totalTurnover_tabPage";
            this.totalTurnover_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.totalTurnover_tabPage.Size = new System.Drawing.Size(589, 498);
            this.totalTurnover_tabPage.TabIndex = 3;
            this.totalTurnover_tabPage.Text = "Toplam Ciro";
            this.totalTurnover_tabPage.UseVisualStyleBackColor = true;
            // 
            // weeklyTurnover_dataGridView
            // 
            this.weeklyTurnover_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weeklyTurnover_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklyTurnover_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.weeklyTurnover_dataGridView.Location = new System.Drawing.Point(6, 6);
            this.weeklyTurnover_dataGridView.Name = "weeklyTurnover_dataGridView";
            this.weeklyTurnover_dataGridView.Size = new System.Drawing.Size(577, 486);
            this.weeklyTurnover_dataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "İsim";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Adet";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fiyat";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Toplam Fiyat";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // monthlyTurnover_dataGridView
            // 
            this.monthlyTurnover_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthlyTurnover_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthlyTurnover_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.monthlyTurnover_dataGridView.Location = new System.Drawing.Point(6, 6);
            this.monthlyTurnover_dataGridView.Name = "monthlyTurnover_dataGridView";
            this.monthlyTurnover_dataGridView.Size = new System.Drawing.Size(577, 486);
            this.monthlyTurnover_dataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "İsim";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Adet";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Fiyat";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Toplam Fiyat";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // totalTurnover_dataGridView
            // 
            this.totalTurnover_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTurnover_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalTurnover_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.totalTurnover_dataGridView.Location = new System.Drawing.Point(6, 6);
            this.totalTurnover_dataGridView.Name = "totalTurnover_dataGridView";
            this.totalTurnover_dataGridView.Size = new System.Drawing.Size(577, 486);
            this.totalTurnover_dataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.HeaderText = "İsim";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Adet";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Fiyat";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Toplam Fiyat";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // TurnoverForm
            // 
            this.ClientSize = new System.Drawing.Size(616, 544);
            this.Controls.Add(this.turnover_tabControl);
            this.Name = "TurnoverForm";
            this.Text = "CİRO";
            this.Load += new System.EventHandler(this.TurnoverForm_Load);
            this.turnover_tabControl.ResumeLayout(false);
            this.dailyTurnover_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dailyTurnover_dataGridView)).EndInit();
            this.weeklyTurnover_tabPage.ResumeLayout(false);
            this.monthlyTurnover_tabPage.ResumeLayout(false);
            this.totalTurnover_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weeklyTurnover_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyTurnover_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTurnover_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        public TurnoverForm() 
        {
            InitializeComponent();
            turnover_tabControl.SelectedIndex = 1;
        }
        private void TurnoverForm_Load(object sender, EventArgs e)
        {
            turnover_tabControl.SelectedIndex = 0;
        }

        private void turnover_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTabName = turnover_tabControl.SelectedTab.Name;
            List<UrunlerMapping> urunlerMappingList = new List<UrunlerMapping>();
            dailyTurnover_dataGridView.Rows.Clear();
            weeklyTurnover_dataGridView.Rows.Clear();
            monthlyTurnover_dataGridView.Rows.Clear();
            totalTurnover_dataGridView.Rows.Clear();
            switch (selectedTabName)
            {
                case "dailyTurnover_tabPage":
                    urunlerMappingList = new List<UrunlerMapping>();
                    dbConnection = new Database();
                    dbConnection.Baglan();
                    urunlerMappingList = dbConnection.GetTurnoverbyDay(1);
                    foreach (UrunlerMapping item in urunlerMappingList)
                    {
                        string[] row = new string[] {item.isim,item.adet,item.fiyat,(float.Parse(item.adet)*float.Parse(item.fiyat)).ToString("0.00")};
                        dailyTurnover_dataGridView.Rows.Add(row);
                    }
                    break;
                case "weeklyTurnover_tabPage":
                    urunlerMappingList = new List<UrunlerMapping>();
                    dbConnection = new Database();
                    dbConnection.Baglan();
                    urunlerMappingList = dbConnection.GetTurnoverbyDay(7);
                    foreach (UrunlerMapping item in urunlerMappingList)
                    {
                        string[] row = new string[] { item.isim, item.adet, item.fiyat, (float.Parse(item.adet) * float.Parse(item.fiyat)).ToString("0.00") };
                        weeklyTurnover_dataGridView.Rows.Add(row);
                    }
                    break;
                case "monthlyTurnover_tabPage":
                    urunlerMappingList = new List<UrunlerMapping>();
                    dbConnection = new Database();
                    dbConnection.Baglan();
                    urunlerMappingList = dbConnection.GetTurnoverbyDay(30);
                    foreach (UrunlerMapping item in urunlerMappingList)
                    {
                        string[] row = new string[] { item.isim, item.adet, item.fiyat, (float.Parse(item.adet) * float.Parse(item.fiyat)).ToString("0.00") };
                        monthlyTurnover_dataGridView.Rows.Add(row);
                    }
                    break;
                case "totalTurnover_tabPage":
                    urunlerMappingList = new List<UrunlerMapping>();
                    dbConnection = new Database();
                    dbConnection.Baglan();
                    urunlerMappingList = dbConnection.GetTurnoverbyDay(999999);
                    foreach (UrunlerMapping item in urunlerMappingList)
                    {
                        string[] row = new string[] { item.isim, item.adet, item.fiyat, (float.Parse(item.adet) * float.Parse(item.fiyat)).ToString("0.00") };
                        totalTurnover_dataGridView.Rows.Add(row);
                    }
                    break;
                default:
                    break;
                    
            }
            
        }
    }
}
