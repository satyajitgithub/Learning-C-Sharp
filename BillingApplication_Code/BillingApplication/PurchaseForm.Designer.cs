namespace BillingApplication
{
    partial class PurchaseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerPurchase = new System.Windows.Forms.DateTimePicker();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtVendorRate = new System.Windows.Forms.TextBox();
            this.txtLotNo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbItemP = new System.Windows.Forms.ComboBox();
            this.cmbVendorP = new System.Windows.Forms.ComboBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.dataGridPurchase = new System.Windows.Forms.DataGridView();
            this.btnPurchaseSubmit = new System.Windows.Forms.Button();
            this.lblTotalPurchaseLabel = new System.Windows.Forms.Label();
            this.lblTotalPurchaseAmount = new System.Windows.Forms.Label();
            this.lblSubAmount = new System.Windows.Forms.Label();
            this.lblSubAmountLabel = new System.Windows.Forms.Label();
            this.lblVATAmount = new System.Windows.Forms.Label();
            this.lblVATLabel = new System.Windows.Forms.Label();
            this.lblAdjLabel = new System.Windows.Forms.Label();
            this.txtAdj = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vendor Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lot No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vendor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date:";
            // 
            // dateTimePickerPurchase
            // 
            this.dateTimePickerPurchase.Location = new System.Drawing.Point(510, 17);
            this.dateTimePickerPurchase.Name = "dateTimePickerPurchase";
            this.dateTimePickerPurchase.Size = new System.Drawing.Size(199, 20);
            this.dateTimePickerPurchase.TabIndex = 8;
            // 
            // txtQty
            // 
            this.txtQty.ForeColor = System.Drawing.Color.Navy;
            this.txtQty.Location = new System.Drawing.Point(88, 96);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(68, 20);
            this.txtQty.TabIndex = 2;
            // 
            // txtVendorRate
            // 
            this.txtVendorRate.ForeColor = System.Drawing.Color.Navy;
            this.txtVendorRate.Location = new System.Drawing.Point(243, 96);
            this.txtVendorRate.Name = "txtVendorRate";
            this.txtVendorRate.Size = new System.Drawing.Size(75, 20);
            this.txtVendorRate.TabIndex = 3;
            // 
            // txtLotNo
            // 
            this.txtLotNo.ForeColor = System.Drawing.Color.Navy;
            this.txtLotNo.Location = new System.Drawing.Point(521, 61);
            this.txtLotNo.Name = "txtLotNo";
            this.txtLotNo.Size = new System.Drawing.Size(137, 20);
            this.txtLotNo.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(244, 408);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(413, 408);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel or Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(36, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "New Purchase Form";
            // 
            // cmbItemP
            // 
            this.cmbItemP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbItemP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItemP.ForeColor = System.Drawing.Color.Navy;
            this.cmbItemP.FormattingEnabled = true;
            this.cmbItemP.Location = new System.Drawing.Point(88, 57);
            this.cmbItemP.Name = "cmbItemP";
            this.cmbItemP.Size = new System.Drawing.Size(175, 21);
            this.cmbItemP.TabIndex = 1;
            this.cmbItemP.SelectedIndexChanged += new System.EventHandler(this.cmbItemP_SelectedIndexChanged);
            // 
            // cmbVendorP
            // 
            this.cmbVendorP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbVendorP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVendorP.ForeColor = System.Drawing.Color.Navy;
            this.cmbVendorP.FormattingEnabled = true;
            this.cmbVendorP.Location = new System.Drawing.Point(521, 88);
            this.cmbVendorP.Name = "cmbVendorP";
            this.cmbVendorP.Size = new System.Drawing.Size(175, 21);
            this.cmbVendorP.TabIndex = 6;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.ForeColor = System.Drawing.Color.Yellow;
            this.lblQty.Location = new System.Drawing.Point(87, 84);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(69, 13);
            this.lblQty.TabIndex = 15;
            this.lblQty.Text = "Re-Order Qty";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.ForeColor = System.Drawing.Color.Yellow;
            this.lblRate.Location = new System.Drawing.Point(241, 84);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(53, 13);
            this.lblRate.TabIndex = 16;
            this.lblRate.Text = "Last Rate";
            // 
            // dataGridPurchase
            // 
            this.dataGridPurchase.AllowUserToAddRows = false;
            this.dataGridPurchase.AllowUserToOrderColumns = true;
            this.dataGridPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPurchase.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPurchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPurchase.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPurchase.Location = new System.Drawing.Point(40, 130);
            this.dataGridPurchase.Name = "dataGridPurchase";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPurchase.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridPurchase.Size = new System.Drawing.Size(669, 244);
            this.dataGridPurchase.TabIndex = 23;
            // 
            // btnPurchaseSubmit
            // 
            this.btnPurchaseSubmit.Location = new System.Drawing.Point(339, 94);
            this.btnPurchaseSubmit.Name = "btnPurchaseSubmit";
            this.btnPurchaseSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnPurchaseSubmit.TabIndex = 4;
            this.btnPurchaseSubmit.Text = "Submit";
            this.btnPurchaseSubmit.UseVisualStyleBackColor = true;
            this.btnPurchaseSubmit.Click += new System.EventHandler(this.btnPurchaseSubmit_Click);
            // 
            // lblTotalPurchaseLabel
            // 
            this.lblTotalPurchaseLabel.AutoSize = true;
            this.lblTotalPurchaseLabel.Location = new System.Drawing.Point(507, 382);
            this.lblTotalPurchaseLabel.Name = "lblTotalPurchaseLabel";
            this.lblTotalPurchaseLabel.Size = new System.Drawing.Size(95, 13);
            this.lblTotalPurchaseLabel.TabIndex = 25;
            this.lblTotalPurchaseLabel.Text = "Total Amount:  Rs.";
            // 
            // lblTotalPurchaseAmount
            // 
            this.lblTotalPurchaseAmount.AutoSize = true;
            this.lblTotalPurchaseAmount.Location = new System.Drawing.Point(601, 382);
            this.lblTotalPurchaseAmount.Name = "lblTotalPurchaseAmount";
            this.lblTotalPurchaseAmount.Size = new System.Drawing.Size(0, 13);
            this.lblTotalPurchaseAmount.TabIndex = 26;
            // 
            // lblSubAmount
            // 
            this.lblSubAmount.AutoSize = true;
            this.lblSubAmount.Location = new System.Drawing.Point(124, 382);
            this.lblSubAmount.Name = "lblSubAmount";
            this.lblSubAmount.Size = new System.Drawing.Size(0, 13);
            this.lblSubAmount.TabIndex = 28;
            // 
            // lblSubAmountLabel
            // 
            this.lblSubAmountLabel.AutoSize = true;
            this.lblSubAmountLabel.Location = new System.Drawing.Point(37, 382);
            this.lblSubAmountLabel.Name = "lblSubAmountLabel";
            this.lblSubAmountLabel.Size = new System.Drawing.Size(90, 13);
            this.lblSubAmountLabel.TabIndex = 27;
            this.lblSubAmountLabel.Text = "Sub Amount:  Rs.";
            // 
            // lblVATAmount
            // 
            this.lblVATAmount.AutoSize = true;
            this.lblVATAmount.Location = new System.Drawing.Point(269, 382);
            this.lblVATAmount.Name = "lblVATAmount";
            this.lblVATAmount.Size = new System.Drawing.Size(0, 13);
            this.lblVATAmount.TabIndex = 30;
            // 
            // lblVATLabel
            // 
            this.lblVATLabel.AutoSize = true;
            this.lblVATLabel.Location = new System.Drawing.Point(217, 382);
            this.lblVATLabel.Name = "lblVATLabel";
            this.lblVATLabel.Size = new System.Drawing.Size(53, 13);
            this.lblVATLabel.TabIndex = 29;
            this.lblVATLabel.Text = "VAT:  Rs.";
            // 
            // lblAdjLabel
            // 
            this.lblAdjLabel.AutoSize = true;
            this.lblAdjLabel.Location = new System.Drawing.Point(398, 381);
            this.lblAdjLabel.Name = "lblAdjLabel";
            this.lblAdjLabel.Size = new System.Drawing.Size(25, 13);
            this.lblAdjLabel.TabIndex = 31;
            this.lblAdjLabel.Text = "Adj:";
            // 
            // txtAdj
            // 
            this.txtAdj.Location = new System.Drawing.Point(423, 378);
            this.txtAdj.Name = "txtAdj";
            this.txtAdj.Size = new System.Drawing.Size(54, 20);
            this.txtAdj.TabIndex = 32;
            this.txtAdj.TextChanged += new System.EventHandler(this.txtAdj_TextChanged);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(746, 443);
            this.Controls.Add(this.txtAdj);
            this.Controls.Add(this.lblAdjLabel);
            this.Controls.Add(this.lblVATAmount);
            this.Controls.Add(this.lblVATLabel);
            this.Controls.Add(this.lblSubAmount);
            this.Controls.Add(this.lblSubAmountLabel);
            this.Controls.Add(this.lblTotalPurchaseAmount);
            this.Controls.Add(this.lblTotalPurchaseLabel);
            this.Controls.Add(this.btnPurchaseSubmit);
            this.Controls.Add(this.dataGridPurchase);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.cmbVendorP);
            this.Controls.Add(this.cmbItemP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLotNo);
            this.Controls.Add(this.txtVendorRate);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.dateTimePickerPurchase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PurchaseForm";
            this.Text = "Purchase Form";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchase;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtVendorRate;
        private System.Windows.Forms.TextBox txtLotNo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbItemP;
        private System.Windows.Forms.ComboBox cmbVendorP;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.DataGridView dataGridPurchase;
        private System.Windows.Forms.Button btnPurchaseSubmit;
        private System.Windows.Forms.Label lblTotalPurchaseLabel;
        private System.Windows.Forms.Label lblTotalPurchaseAmount;
        private System.Windows.Forms.Label lblSubAmount;
        private System.Windows.Forms.Label lblSubAmountLabel;
        private System.Windows.Forms.Label lblVATAmount;
        private System.Windows.Forms.Label lblVATLabel;
        private System.Windows.Forms.Label lblAdjLabel;
        private System.Windows.Forms.TextBox txtAdj;
    }
}