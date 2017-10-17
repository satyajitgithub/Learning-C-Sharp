namespace BillingApplication
{
    partial class SalesReport
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
            this.dataGridViewSalesReport = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSalesType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSalesItem = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.lblQtyInfo = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.btnBillWise = new System.Windows.Forms.Button();
            this.btnDateWise = new System.Windows.Forms.Button();
            this.lblSubTotalLabel = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblVATLabel = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Report From:";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dateTimePickerStartDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dateTimePickerStartDate.Checked = false;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(126, 20);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dateTimePickerEndDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dateTimePickerEndDate.Checked = false;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(126, 50);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 3;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(565, 11);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(114, 27);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "General View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dataGridViewSalesReport
            // 
            this.dataGridViewSalesReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSalesReport.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesReport.Location = new System.Drawing.Point(25, 106);
            this.dataGridViewSalesReport.Name = "dataGridViewSalesReport";
            this.dataGridViewSalesReport.Size = new System.Drawing.Size(771, 293);
            this.dataGridViewSalesReport.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sales Type:";
            // 
            // cmbSalesType
            // 
            this.cmbSalesType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSalesType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSalesType.ForeColor = System.Drawing.Color.Navy;
            this.cmbSalesType.FormattingEnabled = true;
            this.cmbSalesType.Location = new System.Drawing.Point(408, 15);
            this.cmbSalesType.Name = "cmbSalesType";
            this.cmbSalesType.Size = new System.Drawing.Size(143, 21);
            this.cmbSalesType.TabIndex = 7;
            this.cmbSalesType.Text = "ALL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Customer:";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomer.ForeColor = System.Drawing.Color.Navy;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(408, 44);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(143, 21);
            this.cmbCustomer.TabIndex = 9;
            this.cmbCustomer.Text = "ALL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Item:";
            // 
            // cmbSalesItem
            // 
            this.cmbSalesItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSalesItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSalesItem.ForeColor = System.Drawing.Color.Navy;
            this.cmbSalesItem.FormattingEnabled = true;
            this.cmbSalesItem.Location = new System.Drawing.Point(408, 73);
            this.cmbSalesItem.Name = "cmbSalesItem";
            this.cmbSalesItem.Size = new System.Drawing.Size(143, 21);
            this.cmbSalesItem.TabIndex = 11;
            this.cmbSalesItem.Text = "ALL";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(416, 406);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(121, 13);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "Total Sales Amount: Rs.";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(533, 406);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 13);
            this.lblAmount.TabIndex = 13;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(565, 44);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(114, 26);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "View Customer-Wise";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(565, 74);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(114, 23);
            this.btnItem.TabIndex = 3;
            this.btnItem.Text = "View Item-Wise";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // lblQtyInfo
            // 
            this.lblQtyInfo.AutoSize = true;
            this.lblQtyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyInfo.Location = new System.Drawing.Point(656, 406);
            this.lblQtyInfo.Name = "lblQtyInfo";
            this.lblQtyInfo.Size = new System.Drawing.Size(100, 13);
            this.lblQtyInfo.TabIndex = 16;
            this.lblQtyInfo.Text = "Total Sold Quantity:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(754, 407);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(0, 13);
            this.lblQty.TabIndex = 17;
            // 
            // btnBillWise
            // 
            this.btnBillWise.Location = new System.Drawing.Point(688, 11);
            this.btnBillWise.Name = "btnBillWise";
            this.btnBillWise.Size = new System.Drawing.Size(108, 27);
            this.btnBillWise.TabIndex = 18;
            this.btnBillWise.Text = "View Bill-Wise";
            this.btnBillWise.UseVisualStyleBackColor = true;
            this.btnBillWise.Click += new System.EventHandler(this.btnBillWise_Click);
            // 
            // btnDateWise
            // 
            this.btnDateWise.Location = new System.Drawing.Point(688, 45);
            this.btnDateWise.Name = "btnDateWise";
            this.btnDateWise.Size = new System.Drawing.Size(108, 25);
            this.btnDateWise.TabIndex = 19;
            this.btnDateWise.Text = "View Date-Wise";
            this.btnDateWise.UseVisualStyleBackColor = true;
            this.btnDateWise.Click += new System.EventHandler(this.btnDateWise_Click);
            // 
            // lblSubTotalLabel
            // 
            this.lblSubTotalLabel.AutoSize = true;
            this.lblSubTotalLabel.Location = new System.Drawing.Point(25, 406);
            this.lblSubTotalLabel.Name = "lblSubTotalLabel";
            this.lblSubTotalLabel.Size = new System.Drawing.Size(78, 13);
            this.lblSubTotalLabel.TabIndex = 20;
            this.lblSubTotalLabel.Text = "Sub Total:  Rs.";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(105, 406);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(0, 13);
            this.lblSubTotal.TabIndex = 21;
            // 
            // lblVATLabel
            // 
            this.lblVATLabel.AutoSize = true;
            this.lblVATLabel.Location = new System.Drawing.Point(224, 406);
            this.lblVATLabel.Name = "lblVATLabel";
            this.lblVATLabel.Size = new System.Drawing.Size(53, 13);
            this.lblVATLabel.TabIndex = 22;
            this.lblVATLabel.Text = "VAT:  Rs.";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(277, 407);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(0, 13);
            this.lblVAT.TabIndex = 23;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(826, 441);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblVATLabel);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblSubTotalLabel);
            this.Controls.Add(this.btnDateWise);
            this.Controls.Add(this.btnBillWise);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblQtyInfo);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cmbSalesItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSalesType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewSalesReport);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dataGridViewSalesReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSalesType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSalesItem;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Label lblQtyInfo;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Button btnBillWise;
        private System.Windows.Forms.Button btnDateWise;
        private System.Windows.Forms.Label lblSubTotalLabel;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblVATLabel;
        private System.Windows.Forms.Label lblVAT;
    }
}