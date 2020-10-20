namespace Barkod_ve_Envanter_Sayım
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.barcode_textbox = new System.Windows.Forms.TextBox();
            this.print_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel_top = new System.Windows.Forms.TableLayoutPanel();
            this.lastProductPrice_label = new System.Windows.Forms.Label();
            this.lastProduct_label = new System.Windows.Forms.Label();
            this.lastProductPiece_label = new System.Windows.Forms.Label();
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            this.dataGridView_productName_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewKdv_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_piece_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_price_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_barcode_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_unitPrice_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_shortName_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearProducts_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel_bottom = new System.Windows.Forms.TableLayoutPanel();
            this.completeShopping_button = new System.Windows.Forms.Button();
            this.decreaseInventory_button = new System.Windows.Forms.Button();
            this.startDay_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_total = new System.Windows.Forms.TableLayoutPanel();
            this.total_label = new System.Windows.Forms.Label();
            this.totalPrice_label = new System.Windows.Forms.Label();
            this.deleteProduct_button = new System.Windows.Forms.Button();
            this.addProduct_button = new System.Windows.Forms.Button();
            this.piece_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkInventory_button = new System.Windows.Forms.Button();
            this.piece_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.createProductBarcode_button = new System.Windows.Forms.Button();
            this.searchReceipt_button = new System.Windows.Forms.Button();
            this.dailyTurnover_button = new System.Windows.Forms.Button();
            this.receipt_printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cash_textBox = new System.Windows.Forms.TextBox();
            this.cash_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            this.tableLayoutPanel_bottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel_total.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piece_numericUpDown)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // barcode_textbox
            // 
            this.barcode_textbox.BackColor = System.Drawing.Color.DimGray;
            this.barcode_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.barcode_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode_textbox.Location = new System.Drawing.Point(3, 3);
            this.barcode_textbox.MaxLength = 128;
            this.barcode_textbox.Name = "barcode_textbox";
            this.barcode_textbox.Size = new System.Drawing.Size(289, 38);
            this.barcode_textbox.TabIndex = 1;
            this.barcode_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.check_Enter);
            // 
            // print_button
            // 
            this.print_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.print_button.Location = new System.Drawing.Point(1090, 3);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(115, 51);
            this.print_button.TabIndex = 4;
            this.print_button.Text = "Fiş Yazdır";
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.fisYazdir_button_Click);
            this.print_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.all_things_focusbarcode_KeyDown);
            // 
            // tableLayoutPanel_top
            // 
            this.tableLayoutPanel_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_top.BackColor = System.Drawing.Color.Tomato;
            this.tableLayoutPanel_top.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel_top.ColumnCount = 3;
            this.tableLayoutPanel_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.93174F));
            this.tableLayoutPanel_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.5802F));
            this.tableLayoutPanel_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.17065F));
            this.tableLayoutPanel_top.Controls.Add(this.lastProductPrice_label, 2, 0);
            this.tableLayoutPanel_top.Controls.Add(this.lastProduct_label, 0, 0);
            this.tableLayoutPanel_top.Controls.Add(this.lastProductPiece_label, 1, 0);
            this.tableLayoutPanel_top.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel_top.Name = "tableLayoutPanel_top";
            this.tableLayoutPanel_top.RowCount = 1;
            this.tableLayoutPanel_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_top.Size = new System.Drawing.Size(1208, 68);
            this.tableLayoutPanel_top.TabIndex = 5;
            this.tableLayoutPanel_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.all_things_focusbarcode_KeyDown);
            // 
            // lastProductPrice_label
            // 
            this.lastProductPrice_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lastProductPrice_label.AutoSize = true;
            this.lastProductPrice_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastProductPrice_label.ForeColor = System.Drawing.SystemColors.Window;
            this.lastProductPrice_label.Location = new System.Drawing.Point(1114, 15);
            this.lastProductPrice_label.Name = "lastProductPrice_label";
            this.lastProductPrice_label.Size = new System.Drawing.Size(88, 37);
            this.lastProductPrice_label.TabIndex = 2;
            this.lastProductPrice_label.Text = "0.00₺";
            // 
            // lastProduct_label
            // 
            this.lastProduct_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastProduct_label.AutoSize = true;
            this.lastProduct_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastProduct_label.ForeColor = System.Drawing.SystemColors.Window;
            this.lastProduct_label.Location = new System.Drawing.Point(6, 15);
            this.lastProduct_label.Name = "lastProduct_label";
            this.lastProduct_label.Size = new System.Drawing.Size(210, 37);
            this.lastProduct_label.TabIndex = 0;
            this.lastProduct_label.Text = "Ürün Okutunuz";
            // 
            // lastProductPiece_label
            // 
            this.lastProductPiece_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastProductPiece_label.AutoSize = true;
            this.lastProductPiece_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastProductPiece_label.ForeColor = System.Drawing.SystemColors.Window;
            this.lastProductPiece_label.Location = new System.Drawing.Point(800, 15);
            this.lastProductPiece_label.Name = "lastProductPiece_label";
            this.lastProductPiece_label.Size = new System.Drawing.Size(79, 37);
            this.lastProductPiece_label.TabIndex = 1;
            this.lastProductPiece_label.Text = "Adet";
            // 
            // dataGridView_products
            // 
            this.dataGridView_products.AllowUserToAddRows = false;
            this.dataGridView_products.AllowUserToDeleteRows = false;
            this.dataGridView_products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_products.BackgroundColor = System.Drawing.Color.Gold;
            this.dataGridView_products.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridView_productName_Column,
            this.dataGridViewKdv_Column,
            this.dataGridView_piece_Column,
            this.dataGridView_price_Column,
            this.dataGridView_barcode_Column,
            this.dataGridView_unitPrice_Column,
            this.dataGridView_shortName_Column});
            this.dataGridView_products.Location = new System.Drawing.Point(12, 163);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.ReadOnly = true;
            this.dataGridView_products.RowTemplate.Height = 30;
            this.dataGridView_products.Size = new System.Drawing.Size(910, 356);
            this.dataGridView_products.TabIndex = 6;
            this.dataGridView_products.MouseUp += new System.Windows.Forms.MouseEventHandler(this.all_things_focusbarcode_KeyDown);
            // 
            // dataGridView_productName_Column
            // 
            this.dataGridView_productName_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridView_productName_Column.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_productName_Column.HeaderText = "Ürün Adı";
            this.dataGridView_productName_Column.MinimumWidth = 10;
            this.dataGridView_productName_Column.Name = "dataGridView_productName_Column";
            this.dataGridView_productName_Column.ReadOnly = true;
            // 
            // dataGridViewKdv_Column
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewKdv_Column.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewKdv_Column.HeaderText = "KDV";
            this.dataGridViewKdv_Column.Name = "dataGridViewKdv_Column";
            this.dataGridViewKdv_Column.ReadOnly = true;
            // 
            // dataGridView_piece_Column
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridView_piece_Column.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_piece_Column.HeaderText = "Adet";
            this.dataGridView_piece_Column.Name = "dataGridView_piece_Column";
            this.dataGridView_piece_Column.ReadOnly = true;
            // 
            // dataGridView_price_Column
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridView_price_Column.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_price_Column.HeaderText = "Fiyat";
            this.dataGridView_price_Column.Name = "dataGridView_price_Column";
            this.dataGridView_price_Column.ReadOnly = true;
            this.dataGridView_price_Column.Width = 150;
            // 
            // dataGridView_barcode_Column
            // 
            this.dataGridView_barcode_Column.HeaderText = "barcode";
            this.dataGridView_barcode_Column.Name = "dataGridView_barcode_Column";
            this.dataGridView_barcode_Column.ReadOnly = true;
            this.dataGridView_barcode_Column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_barcode_Column.Visible = false;
            // 
            // dataGridView_unitPrice_Column
            // 
            this.dataGridView_unitPrice_Column.HeaderText = "Birim Fiyat";
            this.dataGridView_unitPrice_Column.Name = "dataGridView_unitPrice_Column";
            this.dataGridView_unitPrice_Column.ReadOnly = true;
            this.dataGridView_unitPrice_Column.Visible = false;
            // 
            // dataGridView_shortName_Column
            // 
            this.dataGridView_shortName_Column.HeaderText = "Short Name";
            this.dataGridView_shortName_Column.Name = "dataGridView_shortName_Column";
            this.dataGridView_shortName_Column.ReadOnly = true;
            this.dataGridView_shortName_Column.Visible = false;
            // 
            // clearProducts_button
            // 
            this.clearProducts_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clearProducts_button.Location = new System.Drawing.Point(770, 3);
            this.clearProducts_button.Name = "clearProducts_button";
            this.clearProducts_button.Size = new System.Drawing.Size(112, 51);
            this.clearProducts_button.TabIndex = 7;
            this.clearProducts_button.Text = "Temizle";
            this.clearProducts_button.UseVisualStyleBackColor = true;
            this.clearProducts_button.Click += new System.EventHandler(this.clearProducts_button_Click);
            this.clearProducts_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.all_things_focusbarcode_KeyDown);
            // 
            // settings_button
            // 
            this.settings_button.Location = new System.Drawing.Point(3, 3);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(145, 51);
            this.settings_button.TabIndex = 8;
            this.settings_button.Text = "AYARLAR";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            this.settings_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.all_things_focusbarcode_KeyDown);
            // 
            // tableLayoutPanel_bottom
            // 
            this.tableLayoutPanel_bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_bottom.ColumnCount = 6;
            this.tableLayoutPanel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.84766F));
            this.tableLayoutPanel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.15234F));
            this.tableLayoutPanel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tableLayoutPanel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel_bottom.Controls.Add(this.completeShopping_button, 4, 0);
            this.tableLayoutPanel_bottom.Controls.Add(this.settings_button, 0, 0);
            this.tableLayoutPanel_bottom.Controls.Add(this.clearProducts_button, 3, 0);
            this.tableLayoutPanel_bottom.Controls.Add(this.decreaseInventory_button, 2, 0);
            this.tableLayoutPanel_bottom.Controls.Add(this.startDay_button, 1, 0);
            this.tableLayoutPanel_bottom.Controls.Add(this.print_button, 5, 0);
            this.tableLayoutPanel_bottom.Location = new System.Drawing.Point(12, 522);
            this.tableLayoutPanel_bottom.Name = "tableLayoutPanel_bottom";
            this.tableLayoutPanel_bottom.RowCount = 1;
            this.tableLayoutPanel_bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_bottom.Size = new System.Drawing.Size(1208, 57);
            this.tableLayoutPanel_bottom.TabIndex = 9;
            // 
            // completeShopping_button
            // 
            this.completeShopping_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.completeShopping_button.Location = new System.Drawing.Point(974, 3);
            this.completeShopping_button.Name = "completeShopping_button";
            this.completeShopping_button.Size = new System.Drawing.Size(103, 51);
            this.completeShopping_button.TabIndex = 14;
            this.completeShopping_button.Text = "Alışverişi Tamamla";
            this.completeShopping_button.UseVisualStyleBackColor = true;
            this.completeShopping_button.Click += new System.EventHandler(this.completeShopping_button_Click);
            // 
            // decreaseInventory_button
            // 
            this.decreaseInventory_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.decreaseInventory_button.Location = new System.Drawing.Point(651, 3);
            this.decreaseInventory_button.Name = "decreaseInventory_button";
            this.decreaseInventory_button.Size = new System.Drawing.Size(112, 51);
            this.decreaseInventory_button.TabIndex = 13;
            this.decreaseInventory_button.Text = "Ürünleri Stoktan Azalt";
            this.decreaseInventory_button.UseVisualStyleBackColor = true;
            this.decreaseInventory_button.Click += new System.EventHandler(this.decreaseInventory_button_Click);
            this.decreaseInventory_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.all_things_focusbarcode_KeyDown);
            // 
            // startDay_button
            // 
            this.startDay_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.startDay_button.Location = new System.Drawing.Point(455, 3);
            this.startDay_button.Name = "startDay_button";
            this.startDay_button.Size = new System.Drawing.Size(122, 51);
            this.startDay_button.TabIndex = 14;
            this.startDay_button.Text = "Güne Başla";
            this.startDay_button.UseVisualStyleBackColor = true;
            this.startDay_button.Click += new System.EventHandler(this.startDay_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.barcode_textbox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(925, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 306F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(295, 43);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel_total
            // 
            this.tableLayoutPanel_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_total.BackColor = System.Drawing.Color.ForestGreen;
            this.tableLayoutPanel_total.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel_total.ColumnCount = 2;
            this.tableLayoutPanel_total.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.17489F));
            this.tableLayoutPanel_total.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.82511F));
            this.tableLayoutPanel_total.Controls.Add(this.total_label, 0, 0);
            this.tableLayoutPanel_total.Controls.Add(this.totalPrice_label, 1, 0);
            this.tableLayoutPanel_total.Location = new System.Drawing.Point(12, 89);
            this.tableLayoutPanel_total.Name = "tableLayoutPanel_total";
            this.tableLayoutPanel_total.RowCount = 1;
            this.tableLayoutPanel_total.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_total.Size = new System.Drawing.Size(910, 68);
            this.tableLayoutPanel_total.TabIndex = 11;
            this.tableLayoutPanel_total.MouseUp += new System.Windows.Forms.MouseEventHandler(this.all_things_focusbarcode_KeyDown);
            // 
            // total_label
            // 
            this.total_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.ForeColor = System.Drawing.SystemColors.Window;
            this.total_label.Location = new System.Drawing.Point(6, 15);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(104, 37);
            this.total_label.TabIndex = 0;
            this.total_label.Text = "TUTAR";
            // 
            // totalPrice_label
            // 
            this.totalPrice_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalPrice_label.AutoSize = true;
            this.totalPrice_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice_label.ForeColor = System.Drawing.SystemColors.Window;
            this.totalPrice_label.Location = new System.Drawing.Point(805, 15);
            this.totalPrice_label.Name = "totalPrice_label";
            this.totalPrice_label.Size = new System.Drawing.Size(88, 37);
            this.totalPrice_label.TabIndex = 1;
            this.totalPrice_label.Text = "0.00₺";
            // 
            // deleteProduct_button
            // 
            this.deleteProduct_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteProduct_button.BackColor = System.Drawing.Color.Red;
            this.deleteProduct_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProduct_button.ForeColor = System.Drawing.SystemColors.Window;
            this.deleteProduct_button.Location = new System.Drawing.Point(120, 42);
            this.deleteProduct_button.Name = "deleteProduct_button";
            this.deleteProduct_button.Size = new System.Drawing.Size(172, 66);
            this.deleteProduct_button.TabIndex = 3;
            this.deleteProduct_button.Text = "Ürün Sil";
            this.deleteProduct_button.UseVisualStyleBackColor = false;
            this.deleteProduct_button.Click += new System.EventHandler(this.deleteProduct_button_Click);
            this.deleteProduct_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.all_things_focusbarcode_KeyDown);
            // 
            // addProduct_button
            // 
            this.addProduct_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProduct_button.BackColor = System.Drawing.Color.Coral;
            this.addProduct_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_button.ForeColor = System.Drawing.SystemColors.Window;
            this.addProduct_button.Location = new System.Drawing.Point(3, 42);
            this.addProduct_button.Name = "addProduct_button";
            this.addProduct_button.Size = new System.Drawing.Size(111, 66);
            this.addProduct_button.TabIndex = 2;
            this.addProduct_button.Text = "Ürün Ekle";
            this.addProduct_button.UseVisualStyleBackColor = false;
            this.addProduct_button.Click += new System.EventHandler(this.urunEkle_button_Click);
            this.addProduct_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.all_things_focusbarcode_KeyDown);
            // 
            // piece_label
            // 
            this.piece_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.piece_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piece_label.Location = new System.Drawing.Point(3, 5);
            this.piece_label.Name = "piece_label";
            this.piece_label.Size = new System.Drawing.Size(111, 28);
            this.piece_label.TabIndex = 13;
            this.piece_label.Text = "ADET";
            this.piece_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.66102F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.33898F));
            this.tableLayoutPanel2.Controls.Add(this.checkInventory_button, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.piece_label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.addProduct_button, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.deleteProduct_button, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.piece_numericUpDown, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.createProductBarcode_button, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.searchReceipt_button, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.dailyTurnover_button, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(925, 135);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(295, 279);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // checkInventory_button
            // 
            this.checkInventory_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkInventory_button.Location = new System.Drawing.Point(177, 150);
            this.checkInventory_button.Name = "checkInventory_button";
            this.checkInventory_button.Size = new System.Drawing.Size(115, 55);
            this.checkInventory_button.TabIndex = 13;
            this.checkInventory_button.Text = "Stok Görüntüle";
            this.checkInventory_button.UseVisualStyleBackColor = true;
            this.checkInventory_button.Click += new System.EventHandler(this.checkInventory_button_Click);
            this.checkInventory_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.all_things_focusbarcode_KeyDown);
            // 
            // piece_numericUpDown
            // 
            this.piece_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.piece_numericUpDown.BackColor = System.Drawing.Color.DimGray;
            this.piece_numericUpDown.DecimalPlaces = 3;
            this.piece_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piece_numericUpDown.ForeColor = System.Drawing.SystemColors.Window;
            this.piece_numericUpDown.Location = new System.Drawing.Point(120, 5);
            this.piece_numericUpDown.Name = "piece_numericUpDown";
            this.piece_numericUpDown.Size = new System.Drawing.Size(172, 29);
            this.piece_numericUpDown.TabIndex = 14;
            // 
            // createProductBarcode_button
            // 
            this.createProductBarcode_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createProductBarcode_button.Location = new System.Drawing.Point(3, 150);
            this.createProductBarcode_button.Name = "createProductBarcode_button";
            this.createProductBarcode_button.Size = new System.Drawing.Size(111, 55);
            this.createProductBarcode_button.TabIndex = 15;
            this.createProductBarcode_button.Text = "Ürün Barkodu Oluştur";
            this.createProductBarcode_button.UseVisualStyleBackColor = true;
            this.createProductBarcode_button.Click += new System.EventHandler(this.createProductBarcode_button_Click);
            // 
            // searchReceipt_button
            // 
            this.searchReceipt_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchReceipt_button.Location = new System.Drawing.Point(3, 221);
            this.searchReceipt_button.Name = "searchReceipt_button";
            this.searchReceipt_button.Size = new System.Drawing.Size(111, 55);
            this.searchReceipt_button.TabIndex = 16;
            this.searchReceipt_button.Text = "Fiş Okut";
            this.searchReceipt_button.UseVisualStyleBackColor = true;
            this.searchReceipt_button.Click += new System.EventHandler(this.searchReceipt_button_Click);
            // 
            // dailyTurnover_button
            // 
            this.dailyTurnover_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dailyTurnover_button.Location = new System.Drawing.Point(177, 221);
            this.dailyTurnover_button.Name = "dailyTurnover_button";
            this.dailyTurnover_button.Size = new System.Drawing.Size(115, 55);
            this.dailyTurnover_button.TabIndex = 17;
            this.dailyTurnover_button.Text = "Ciro Görüntüle";
            this.dailyTurnover_button.UseVisualStyleBackColor = true;
            this.dailyTurnover_button.Click += new System.EventHandler(this.dailyTurnover_button_Click);
            // 
            // receipt_printDocument
            // 
            this.receipt_printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.receipt_printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog1";
            this.printPreviewDialog.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel3.Controls.Add(this.cash_textBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cash_label, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(928, 473);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(295, 43);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // cash_textBox
            // 
            this.cash_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cash_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_textBox.Location = new System.Drawing.Point(75, 9);
            this.cash_textBox.Name = "cash_textBox";
            this.cash_textBox.Size = new System.Drawing.Size(214, 24);
            this.cash_textBox.TabIndex = 1;
            // 
            // cash_label
            // 
            this.cash_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cash_label.AutoSize = true;
            this.cash_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_label.Location = new System.Drawing.Point(6, 11);
            this.cash_label.Name = "cash_label";
            this.cash_label.Size = new System.Drawing.Size(60, 20);
            this.cash_label.TabIndex = 0;
            this.cash_label.Text = "NAKİT";
            this.cash_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(1232, 591);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel_total);
            this.Controls.Add(this.dataGridView_products);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel_bottom);
            this.Controls.Add(this.tableLayoutPanel_top);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "mainForm";
            this.Text = "Barkod ve Envanter Sayım";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.all_things_focusbarcode_KeyDown);
            this.tableLayoutPanel_top.ResumeLayout(false);
            this.tableLayoutPanel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            this.tableLayoutPanel_bottom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel_total.ResumeLayout(false);
            this.tableLayoutPanel_total.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piece_numericUpDown)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox barcode_textbox;
        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_top;
        private System.Windows.Forms.Label lastProduct_label;
        private System.Windows.Forms.Label lastProductPiece_label;
        private System.Windows.Forms.Label lastProductPrice_label;
        private System.Windows.Forms.DataGridView dataGridView_products;
        private System.Windows.Forms.Button clearProducts_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_bottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_total;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label totalPrice_label;
        private System.Windows.Forms.Button deleteProduct_button;
        private System.Windows.Forms.Button addProduct_button;
        private System.Windows.Forms.Label piece_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown piece_numericUpDown;
        private System.Drawing.Printing.PrintDocument receipt_printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Button checkInventory_button;
        private System.Windows.Forms.Button decreaseInventory_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridView_productName_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewKdv_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridView_piece_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridView_price_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridView_barcode_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridView_unitPrice_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridView_shortName_Column;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label cash_label;
        private System.Windows.Forms.TextBox cash_textBox;
        private System.Windows.Forms.Button createProductBarcode_button;
        private System.Windows.Forms.Button searchReceipt_button;
        private System.Windows.Forms.Button dailyTurnover_button;
        private System.Windows.Forms.Button startDay_button;
        private System.Windows.Forms.Button completeShopping_button;
    }
}

