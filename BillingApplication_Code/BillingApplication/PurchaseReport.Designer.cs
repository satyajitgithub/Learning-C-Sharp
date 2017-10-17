namespace BillingApplication
{
    partial class PurchaseReport
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
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnView = new System.Windows.Forms.Button();
            this.dataGridViewPurchaseReport = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPurchaseItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVendor = new System.Windows.Forms.ComboBox();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnVendor = new System.Windows.Forms.Button();
            this.lblQtyLabel = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblVATLabel = new System.Windows.Forms.Label();
            this.lblSubtotalLabel = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.btnBillWise = new System.Windows.Forms.Button();
            this.btnDatewise = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Report From:";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Checked = false;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(142, 23);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Checked = false;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(142, 54);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 3;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(577, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(106, 27);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "General View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dataGridViewPurchaseReport
            // 
            this.dataGridViewPurchaseReport.AllowUserToAddRows = false;
            this.dataGridViewPurchaseReport.AllowUserToDeleteRows = false;
            this.dataGridViewPurchaseReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPurchaseReport.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewPurchaseReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchaseReport.Location = new System.Drawing.Point(28, 98);
            this.dataGridViewPurchaseReport.Name = "dataGridViewPurchaseReport";
            this.dataGridViewPurchaseReport.ReadOnly = true;
            this.dataGridViewPurchaseReport.Size = new System.Drawing.Size(801, 277);
            this.dataGridViewPurchaseReport.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "For Item:";
            // 
            // cmbPurchaseItem
            // 
            this.cmbPurchaseItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPurchaseItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPurchaseItem.ForeColor = System.Drawing.Color.Navy;
            this.cmbPurchaseItem.FormattingEnabled = true;
            this.cmbPurchaseItem.Location = new System.Drawing.Point(422, 22);
            this.cmbPurchaseItem.Name = "cmbPurchaseItem";
            this.cmbPurchaseItem.Size = new System.Drawing.Size(135, 21);
            this.cmbPurchaseItem.TabIndex = 7;
            this.cmbPurchaseItem.Text = "ALL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "From Vendor:";
            // 
            // cmbVendor
            // 
            this.cmbVendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbVendor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVendor.ForeColor = System.Drawing.Color.Navy;
            this.cmbVendor.FormattingEnabled = true;
            this.cmbVendor.Location = new System.Drawing.Point(422, 55);
            this.cmbVendor.Name = "cmbVendor";
            this.cmbVendor.Size = new System.Drawing.Size(135, 21);
            this.cmbVendor.TabIndex = 9;
            this.cmbVendor.Text = "ALL";
            // 
            // lbldisplay
            // 
            this.lbldisplay.AutoSize = true;
            this.lbldisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplay.Location = new System.Drawing.Point(478, 388);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(106, 15);
            this.lbldisplay.TabIndex = 10;
            this.lbldisplay.Text = "Total Amount:  Rs.";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(583, 387);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 15);
            this.lblAmount.TabIndex = 11;
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(577, 34);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(106, 27);
            this.btnItem.TabIndex = 2;
            this.btnItem.Text = "View Item-Wise";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnVendor
            // 
            this.btnVendor.Location = new System.Drawing.Point(577, 64);
            this.btnVendor.Name = "btnVendor";
            this.btnVendor.Size = new System.Drawing.Size(106, 28);
            this.btnVendor.TabIndex = 3;
            this.btnVendor.Text = "View Vendor-Wise";
            this.btnVendor.UseVisualStyleBackColor = true;
            this.btnVendor.Click += new System.EventHandler(this.btnVendor_Click);
            // 
            // lblQtyLabel
            // 
            this.lblQtyLabel.AutoSize = true;
            this.lblQtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyLabel.Location = new System.Drawing.Point(712, 387);
            this.lblQtyLabel.Name = "lblQtyLabel";
            this.lblQtyLabel.Size = new System.Drawing.Size(54, 15);
            this.lblQtyLabel.TabIndex = 14;
            this.lblQtyLabel.Text = "Quantity:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(763, 387);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(0, 15);
            this.lblQty.TabIndex = 15;
            // 
            // lblVATLabel
            // 
            this.lblVATLabel.AutoSize = true;
            this.lblVATLabel.Location = new System.Drawing.Point(272, 388);
            this.lblVATLabel.Name = "lblVATLabel";
            this.lblVATLabel.Size = new System.Drawing.Size(53, 13);
            this.lblVATLabel.TabIndex = 16;
            this.lblVATLabel.Text = "VAT:  Rs.";
            // 
            // lblSubtotalLabel
            // 
            this.lblSubtotalLabel.AutoSize = true;
            this.lblSubtotalLabel.Location = new System.Drawing.Point(28, 388);
            this.lblSubtotalLabel.Name = "lblSubtotalLabel";
            this.lblSubtotalLabel.Size = new System.Drawing.Size(78, 13);
            this.lblSubtotalLabel.TabIndex = 17;
            this.lblSubtotalLabel.Text = "Sub Total:  Rs.";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(101, 388);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(0, 13);
            this.lblSubTotal.TabIndex = 18;
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(323, 388);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(0, 13);
            this.lblVAT.TabIndex = 19;
            // 
            // btnBillWise
            // 
            this.btnBillWise.Location = new System.Drawing.Point(698, 5);
            this.btnBillWise.Name = "btnBillWise";
            this.btnBillWise.Size = new System.Drawing.Size(106, 25);
            this.btnBillWise.TabIndex = 20;
            this.btnBillWise.Text = "View Billwise";
            this.btnBillWise.UseVisualStyleBackColor = true;
            this.btnBillWise.Click += new System.EventHandler(this.btnBillWise_Click);
            // 
            // btnDatewise
            // 
            this.btnDatewise.Location = new System.Drawing.Point(698, 34);
            this.btnDatewise.Name = "btnDatewise";
            this.btnDatewise.Size = new System.Drawing.Size(106, 25);
            this.btnDatewise.TabIndex = 21;
            this.btnDatewise.Text = "View Datewise";
            this.btnDatewise.UseVisualStyleBackColor = true;
            this.btnDatewise.Click += new System.EventHandler(this.btnDatewise_Click);
            // 
            // PurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(859, 427);
            this.Controls.Add(this.btnDatewise);
            this.Controls.Add(this.btnBillWise);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblSubtotalLabel);
            this.Controls.Add(this.lblVATLabel);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblQtyLabel);
            this.Controls.Add(this.btnVendor);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.cmbVendor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPurchaseItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewPurchaseReport);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PurchaseReport";
            this.Text = "PurchaseReport";
            this.Load += new System.EventHandler(this.PurchaseReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dataGridViewPurchaseReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPurchaseItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVendor;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnVendor;
        private System.Windows.Forms.Label lblQtyLabel;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblVATLabel;
        private System.Windows.Forms.Label lblSubtotalLabel;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Button btnBillWise;
        private System.Windows.Forms.Button btnDatewise;
    }
}