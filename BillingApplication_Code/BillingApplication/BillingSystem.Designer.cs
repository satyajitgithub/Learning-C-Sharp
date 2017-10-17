namespace BillingApplication
{
    partial class frmBilling
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
            this.label1 = new System.Windows.Forms.Label();
            this.SalesTypeGrp = new System.Windows.Forms.GroupBox();
            this.radioWholeSale = new System.Windows.Forms.RadioButton();
            this.radioRetail = new System.Windows.Forms.RadioButton();
            this.dateTimePickerSale = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnSaveBill = new System.Windows.Forms.Button();
            this.btnCancelBill = new System.Windows.Forms.Button();
            this.lblTotalAmtField = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCustomerSales = new System.Windows.Forms.ComboBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchBill = new System.Windows.Forms.TextBox();
            this.btnSearchBill = new System.Windows.Forms.Button();
            this.lblSaleTypeValue = new System.Windows.Forms.Label();
            this.lblCustomerValue = new System.Windows.Forms.Label();
            this.lblSaleDateValue = new System.Windows.Forms.Label();
            this.btnSearchPurchaseBill = new System.Windows.Forms.Button();
            this.lblSubAmountLabel = new System.Windows.Forms.Label();
            this.lblSubAmount = new System.Windows.Forms.Label();
            this.lblVATLabel = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.SalesTypeGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Customer Billing";
            // 
            // SalesTypeGrp
            // 
            this.SalesTypeGrp.Controls.Add(this.radioWholeSale);
            this.SalesTypeGrp.Controls.Add(this.radioRetail);
            this.SalesTypeGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTypeGrp.Location = new System.Drawing.Point(23, 67);
            this.SalesTypeGrp.Name = "SalesTypeGrp";
            this.SalesTypeGrp.Size = new System.Drawing.Size(195, 61);
            this.SalesTypeGrp.TabIndex = 1;
            this.SalesTypeGrp.TabStop = false;
            this.SalesTypeGrp.Text = "Sales Type";
            // 
            // radioWholeSale
            // 
            this.radioWholeSale.AutoSize = true;
            this.radioWholeSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioWholeSale.Location = new System.Drawing.Point(89, 24);
            this.radioWholeSale.Name = "radioWholeSale";
            this.radioWholeSale.Size = new System.Drawing.Size(94, 19);
            this.radioWholeSale.TabIndex = 1;
            this.radioWholeSale.TabStop = true;
            this.radioWholeSale.Text = "WholeSale";
            this.radioWholeSale.UseVisualStyleBackColor = true;
            // 
            // radioRetail
            // 
            this.radioRetail.AutoSize = true;
            this.radioRetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRetail.Location = new System.Drawing.Point(7, 24);
            this.radioRetail.Name = "radioRetail";
            this.radioRetail.Size = new System.Drawing.Size(63, 19);
            this.radioRetail.TabIndex = 0;
            this.radioRetail.TabStop = true;
            this.radioRetail.Text = "Retail";
            this.radioRetail.UseVisualStyleBackColor = true;
            this.radioRetail.CheckedChanged += new System.EventHandler(this.radioRetail_CheckedChanged);
            // 
            // dateTimePickerSale
            // 
            this.dateTimePickerSale.CalendarForeColor = System.Drawing.Color.Teal;
            this.dateTimePickerSale.CalendarTitleForeColor = System.Drawing.Color.Blue;
            this.dateTimePickerSale.Location = new System.Drawing.Point(542, 34);
            this.dateTimePickerSale.Name = "dateTimePickerSale";
            this.dateTimePickerSale.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSale.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rate:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(438, 150);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.ForeColor = System.Drawing.Color.Navy;
            this.txtQty.Location = new System.Drawing.Point(371, 152);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(56, 20);
            this.txtQty.TabIndex = 4;
            // 
            // txtRate
            // 
            this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRate.ForeColor = System.Drawing.Color.Navy;
            this.txtRate.Location = new System.Drawing.Point(248, 153);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(69, 20);
            this.txtRate.TabIndex = 3;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(29, 195);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(717, 207);
            this.dataGrid.TabIndex = 11;
            // 
            // btnSaveBill
            // 
            this.btnSaveBill.Location = new System.Drawing.Point(256, 444);
            this.btnSaveBill.Name = "btnSaveBill";
            this.btnSaveBill.Size = new System.Drawing.Size(97, 23);
            this.btnSaveBill.TabIndex = 12;
            this.btnSaveBill.Text = "Save Bill";
            this.btnSaveBill.UseVisualStyleBackColor = true;
            this.btnSaveBill.Click += new System.EventHandler(this.btnSaveBill_Click);
            // 
            // btnCancelBill
            // 
            this.btnCancelBill.Location = new System.Drawing.Point(388, 444);
            this.btnCancelBill.Name = "btnCancelBill";
            this.btnCancelBill.Size = new System.Drawing.Size(110, 23);
            this.btnCancelBill.TabIndex = 13;
            this.btnCancelBill.Text = "Clear and Refresh";
            this.btnCancelBill.UseVisualStyleBackColor = true;
            this.btnCancelBill.Click += new System.EventHandler(this.btnCancelBill_Click);
            // 
            // lblTotalAmtField
            // 
            this.lblTotalAmtField.AutoSize = true;
            this.lblTotalAmtField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmtField.Location = new System.Drawing.Point(516, 404);
            this.lblTotalAmtField.Name = "lblTotalAmtField";
            this.lblTotalAmtField.Size = new System.Drawing.Size(153, 17);
            this.lblTotalAmtField.TabIndex = 16;
            this.lblTotalAmtField.Text = "Total Sale Amount: Rs.";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(665, 404);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 17);
            this.lblTotalAmount.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageInventoryToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageInventoryToolStripMenuItem
            // 
            this.manageInventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.updateItemToolStripMenuItem,
            this.saleItemToolStripMenuItem});
            this.manageInventoryToolStripMenuItem.Name = "manageInventoryToolStripMenuItem";
            this.manageInventoryToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.manageInventoryToolStripMenuItem.Text = "Manage Inventory";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.purchaseToolStripMenuItem.Text = "Purchase Item";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // updateItemToolStripMenuItem
            // 
            this.updateItemToolStripMenuItem.Name = "updateItemToolStripMenuItem";
            this.updateItemToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.updateItemToolStripMenuItem.Text = "Update Item";
            this.updateItemToolStripMenuItem.Click += new System.EventHandler(this.updateItemToolStripMenuItem_Click);
            // 
            // saleItemToolStripMenuItem
            // 
            this.saleItemToolStripMenuItem.Name = "saleItemToolStripMenuItem";
            this.saleItemToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saleItemToolStripMenuItem.Text = "Update Customer";
            this.saleItemToolStripMenuItem.Click += new System.EventHandler(this.saleItemToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseReportToolStripMenuItem,
            this.salesReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // purchaseReportToolStripMenuItem
            // 
            this.purchaseReportToolStripMenuItem.Name = "purchaseReportToolStripMenuItem";
            this.purchaseReportToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.purchaseReportToolStripMenuItem.Text = "Purchase Report";
            this.purchaseReportToolStripMenuItem.Click += new System.EventHandler(this.purchaseReportToolStripMenuItem_Click);
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.salesReportToolStripMenuItem.Text = "Sales Report";
            this.salesReportToolStripMenuItem.Click += new System.EventHandler(this.salesReportToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Customer:";
            // 
            // cmbCustomerSales
            // 
            this.cmbCustomerSales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCustomerSales.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomerSales.ForeColor = System.Drawing.Color.Navy;
            this.cmbCustomerSales.FormattingEnabled = true;
            this.cmbCustomerSales.Location = new System.Drawing.Point(285, 92);
            this.cmbCustomerSales.Name = "cmbCustomerSales";
            this.cmbCustomerSales.Size = new System.Drawing.Size(149, 21);
            this.cmbCustomerSales.TabIndex = 20;
            // 
            // cmbItem
            // 
            this.cmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItem.ForeColor = System.Drawing.Color.Navy;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(55, 152);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(153, 21);
            this.cmbItem.TabIndex = 2;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "View Bill:";
            // 
            // txtSearchBill
            // 
            this.txtSearchBill.ForeColor = System.Drawing.Color.Navy;
            this.txtSearchBill.Location = new System.Drawing.Point(557, 89);
            this.txtSearchBill.Name = "txtSearchBill";
            this.txtSearchBill.Size = new System.Drawing.Size(47, 20);
            this.txtSearchBill.TabIndex = 23;
            this.txtSearchBill.TextChanged += new System.EventHandler(this.txtSearchBill_TextChanged);
            // 
            // btnSearchBill
            // 
            this.btnSearchBill.Location = new System.Drawing.Point(607, 87);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(67, 23);
            this.btnSearchBill.TabIndex = 24;
            this.btnSearchBill.Text = "Sell";
            this.btnSearchBill.UseVisualStyleBackColor = true;
            this.btnSearchBill.Click += new System.EventHandler(this.btnSearchBill_Click);
            // 
            // lblSaleTypeValue
            // 
            this.lblSaleTypeValue.AutoSize = true;
            this.lblSaleTypeValue.Location = new System.Drawing.Point(559, 121);
            this.lblSaleTypeValue.Name = "lblSaleTypeValue";
            this.lblSaleTypeValue.Size = new System.Drawing.Size(0, 13);
            this.lblSaleTypeValue.TabIndex = 28;
            // 
            // lblCustomerValue
            // 
            this.lblCustomerValue.AutoSize = true;
            this.lblCustomerValue.Location = new System.Drawing.Point(559, 144);
            this.lblCustomerValue.Name = "lblCustomerValue";
            this.lblCustomerValue.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerValue.TabIndex = 29;
            // 
            // lblSaleDateValue
            // 
            this.lblSaleDateValue.AutoSize = true;
            this.lblSaleDateValue.Location = new System.Drawing.Point(559, 167);
            this.lblSaleDateValue.Name = "lblSaleDateValue";
            this.lblSaleDateValue.Size = new System.Drawing.Size(0, 13);
            this.lblSaleDateValue.TabIndex = 30;
            // 
            // btnSearchPurchaseBill
            // 
            this.btnSearchPurchaseBill.Location = new System.Drawing.Point(675, 87);
            this.btnSearchPurchaseBill.Name = "btnSearchPurchaseBill";
            this.btnSearchPurchaseBill.Size = new System.Drawing.Size(67, 23);
            this.btnSearchPurchaseBill.TabIndex = 31;
            this.btnSearchPurchaseBill.Text = "Purchase";
            this.btnSearchPurchaseBill.UseVisualStyleBackColor = true;
            this.btnSearchPurchaseBill.Click += new System.EventHandler(this.btnSearchPurchaseBill_Click);
            // 
            // lblSubAmountLabel
            // 
            this.lblSubAmountLabel.AutoSize = true;
            this.lblSubAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubAmountLabel.Location = new System.Drawing.Point(28, 405);
            this.lblSubAmountLabel.Name = "lblSubAmountLabel";
            this.lblSubAmountLabel.Size = new System.Drawing.Size(118, 17);
            this.lblSubAmountLabel.TabIndex = 32;
            this.lblSubAmountLabel.Text = "Sub Amount:  Rs.";
            // 
            // lblSubAmount
            // 
            this.lblSubAmount.AutoSize = true;
            this.lblSubAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubAmount.Location = new System.Drawing.Point(144, 405);
            this.lblSubAmount.Name = "lblSubAmount";
            this.lblSubAmount.Size = new System.Drawing.Size(0, 17);
            this.lblSubAmount.TabIndex = 33;
            // 
            // lblVATLabel
            // 
            this.lblVATLabel.AutoSize = true;
            this.lblVATLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVATLabel.Location = new System.Drawing.Point(284, 405);
            this.lblVATLabel.Name = "lblVATLabel";
            this.lblVATLabel.Size = new System.Drawing.Size(68, 17);
            this.lblVATLabel.TabIndex = 34;
            this.lblVATLabel.Text = "VAT:  Rs.";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVAT.Location = new System.Drawing.Point(350, 405);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(0, 17);
            this.lblVAT.TabIndex = 35;
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(560, 131);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(0, 13);
            this.lblVendor.TabIndex = 37;
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(560, 159);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(0, 13);
            this.lblPurchaseDate.TabIndex = 38;
            // 
            // frmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(771, 484);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblVATLabel);
            this.Controls.Add(this.lblSubAmount);
            this.Controls.Add(this.lblSubAmountLabel);
            this.Controls.Add(this.btnSearchPurchaseBill);
            this.Controls.Add(this.lblSaleDateValue);
            this.Controls.Add(this.lblCustomerValue);
            this.Controls.Add(this.lblSaleTypeValue);
            this.Controls.Add(this.btnSearchBill);
            this.Controls.Add(this.txtSearchBill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.cmbCustomerSales);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotalAmtField);
            this.Controls.Add(this.btnCancelBill);
            this.Controls.Add(this.btnSaveBill);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerSale);
            this.Controls.Add(this.SalesTypeGrp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBilling";
            this.Text = "Billing System";
            this.Load += new System.EventHandler(this.frmBilling_Load);
            this.SalesTypeGrp.ResumeLayout(false);
            this.SalesTypeGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SalesTypeGrp;
        private System.Windows.Forms.RadioButton radioWholeSale;
        private System.Windows.Forms.RadioButton radioRetail;
        private System.Windows.Forms.DateTimePicker dateTimePickerSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnSaveBill;
        private System.Windows.Forms.Button btnCancelBill;
        private System.Windows.Forms.Label lblTotalAmtField;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCustomerSales;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchBill;
        private System.Windows.Forms.Button btnSearchBill;
        private System.Windows.Forms.Label lblSaleTypeValue;
        private System.Windows.Forms.Label lblCustomerValue;
        private System.Windows.Forms.Label lblSaleDateValue;
        private System.Windows.Forms.Button btnSearchPurchaseBill;
        private System.Windows.Forms.Label lblSubAmountLabel;
        private System.Windows.Forms.Label lblSubAmount;
        private System.Windows.Forms.Label lblVATLabel;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblPurchaseDate;
    }
}

