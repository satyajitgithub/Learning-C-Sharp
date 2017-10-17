namespace BillingApplication
{
    partial class ItemForm
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
            this.dataGridViewItemDetail = new System.Windows.Forms.DataGridView();
            this.panelGridContainer = new System.Windows.Forms.Panel();
            this.btnItemView = new System.Windows.Forms.Button();
            this.btnNearingReOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReOrder = new System.Windows.Forms.Button();
            this.panelUpdateItem = new System.Windows.Forms.Panel();
            this.txtLastPurchasedPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSetReOrderQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSetReOrderLevel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtWholeSalePrice = new System.Windows.Forms.TextBox();
            this.txtRetailPrice = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemDetail)).BeginInit();
            this.panelGridContainer.SuspendLayout();
            this.panelUpdateItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewItemDetail
            // 
            this.dataGridViewItemDetail.AllowUserToOrderColumns = true;
            this.dataGridViewItemDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItemDetail.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewItemDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemDetail.Location = new System.Drawing.Point(21, 47);
            this.dataGridViewItemDetail.Name = "dataGridViewItemDetail";
            this.dataGridViewItemDetail.Size = new System.Drawing.Size(1031, 344);
            this.dataGridViewItemDetail.TabIndex = 1;
            this.dataGridViewItemDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItemDetail_CellDoubleClick);
            // 
            // panelGridContainer
            // 
            this.panelGridContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelGridContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGridContainer.Controls.Add(this.btnItemView);
            this.panelGridContainer.Controls.Add(this.btnNearingReOrder);
            this.panelGridContainer.Controls.Add(this.label5);
            this.panelGridContainer.Controls.Add(this.btnReOrder);
            this.panelGridContainer.Controls.Add(this.dataGridViewItemDetail);
            this.panelGridContainer.ForeColor = System.Drawing.Color.Navy;
            this.panelGridContainer.Location = new System.Drawing.Point(12, 15);
            this.panelGridContainer.Name = "panelGridContainer";
            this.panelGridContainer.Size = new System.Drawing.Size(1073, 410);
            this.panelGridContainer.TabIndex = 4;
            // 
            // btnItemView
            // 
            this.btnItemView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemView.Location = new System.Drawing.Point(875, 6);
            this.btnItemView.Name = "btnItemView";
            this.btnItemView.Size = new System.Drawing.Size(177, 31);
            this.btnItemView.TabIndex = 7;
            this.btnItemView.Text = "Back To Item View";
            this.btnItemView.UseVisualStyleBackColor = true;
            this.btnItemView.Click += new System.EventHandler(this.btnItemView_Click);
            // 
            // btnNearingReOrder
            // 
            this.btnNearingReOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNearingReOrder.Location = new System.Drawing.Point(668, 6);
            this.btnNearingReOrder.Name = "btnNearingReOrder";
            this.btnNearingReOrder.Size = new System.Drawing.Size(177, 33);
            this.btnNearingReOrder.TabIndex = 6;
            this.btnNearingReOrder.Text = "Items Nearing Re-Order";
            this.btnNearingReOrder.UseVisualStyleBackColor = true;
            this.btnNearingReOrder.Click += new System.EventHandler(this.btnNearingReOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(17, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Item Details";
            // 
            // btnReOrder
            // 
            this.btnReOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReOrder.Location = new System.Drawing.Point(455, 6);
            this.btnReOrder.Name = "btnReOrder";
            this.btnReOrder.Size = new System.Drawing.Size(177, 32);
            this.btnReOrder.TabIndex = 5;
            this.btnReOrder.Text = "Items To Re-Order";
            this.btnReOrder.UseVisualStyleBackColor = true;
            this.btnReOrder.Click += new System.EventHandler(this.btnReOrder_Click);
            // 
            // panelUpdateItem
            // 
            this.panelUpdateItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelUpdateItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelUpdateItem.Controls.Add(this.txtLastPurchasedPrice);
            this.panelUpdateItem.Controls.Add(this.label8);
            this.panelUpdateItem.Controls.Add(this.txtSetReOrderQty);
            this.panelUpdateItem.Controls.Add(this.label7);
            this.panelUpdateItem.Controls.Add(this.txtSetReOrderLevel);
            this.panelUpdateItem.Controls.Add(this.label6);
            this.panelUpdateItem.Controls.Add(this.lblItem);
            this.panelUpdateItem.Controls.Add(this.label4);
            this.panelUpdateItem.Controls.Add(this.btnCancel);
            this.panelUpdateItem.Controls.Add(this.btnUpdate);
            this.panelUpdateItem.Controls.Add(this.txtWholeSalePrice);
            this.panelUpdateItem.Controls.Add(this.txtRetailPrice);
            this.panelUpdateItem.Controls.Add(this.txtItemName);
            this.panelUpdateItem.Controls.Add(this.label3);
            this.panelUpdateItem.Controls.Add(this.label2);
            this.panelUpdateItem.Controls.Add(this.label1);
            this.panelUpdateItem.ForeColor = System.Drawing.Color.Navy;
            this.panelUpdateItem.Location = new System.Drawing.Point(33, 12);
            this.panelUpdateItem.Name = "panelUpdateItem";
            this.panelUpdateItem.Size = new System.Drawing.Size(383, 305);
            this.panelUpdateItem.TabIndex = 2;
            // 
            // txtLastPurchasedPrice
            // 
            this.txtLastPurchasedPrice.Enabled = false;
            this.txtLastPurchasedPrice.ForeColor = System.Drawing.Color.Navy;
            this.txtLastPurchasedPrice.Location = new System.Drawing.Point(135, 95);
            this.txtLastPurchasedPrice.Name = "txtLastPurchasedPrice";
            this.txtLastPurchasedPrice.Size = new System.Drawing.Size(94, 20);
            this.txtLastPurchasedPrice.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Last Purchased Price:";
            // 
            // txtSetReOrderQty
            // 
            this.txtSetReOrderQty.ForeColor = System.Drawing.Color.Navy;
            this.txtSetReOrderQty.Location = new System.Drawing.Point(136, 165);
            this.txtSetReOrderQty.Name = "txtSetReOrderQty";
            this.txtSetReOrderQty.Size = new System.Drawing.Size(93, 20);
            this.txtSetReOrderQty.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Set Re-Order Qty:";
            // 
            // txtSetReOrderLevel
            // 
            this.txtSetReOrderLevel.ForeColor = System.Drawing.Color.Navy;
            this.txtSetReOrderLevel.Location = new System.Drawing.Point(135, 132);
            this.txtSetReOrderLevel.Name = "txtSetReOrderLevel";
            this.txtSetReOrderLevel.Size = new System.Drawing.Size(94, 20);
            this.txtSetReOrderLevel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Set Re-Order Level:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(320, 27);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(0, 13);
            this.lblItem.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(19, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Update Item";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(266, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(265, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtWholeSalePrice
            // 
            this.txtWholeSalePrice.ForeColor = System.Drawing.Color.Navy;
            this.txtWholeSalePrice.Location = new System.Drawing.Point(135, 248);
            this.txtWholeSalePrice.Name = "txtWholeSalePrice";
            this.txtWholeSalePrice.Size = new System.Drawing.Size(94, 20);
            this.txtWholeSalePrice.TabIndex = 5;
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.ForeColor = System.Drawing.Color.Navy;
            this.txtRetailPrice.Location = new System.Drawing.Point(136, 206);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Size = new System.Drawing.Size(93, 20);
            this.txtRetailPrice.TabIndex = 4;
            // 
            // txtItemName
            // 
            this.txtItemName.Enabled = false;
            this.txtItemName.ForeColor = System.Drawing.Color.Navy;
            this.txtItemName.Location = new System.Drawing.Point(135, 56);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(198, 20);
            this.txtItemName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Set WholeSale Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set Retail Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name:";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 437);
            this.Controls.Add(this.panelUpdateItem);
            this.Controls.Add(this.panelGridContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemDetail)).EndInit();
            this.panelGridContainer.ResumeLayout(false);
            this.panelGridContainer.PerformLayout();
            this.panelUpdateItem.ResumeLayout(false);
            this.panelUpdateItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewItemDetail;
        private System.Windows.Forms.Panel panelGridContainer;
        private System.Windows.Forms.Panel panelUpdateItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtWholeSalePrice;
        private System.Windows.Forms.TextBox txtRetailPrice;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSetReOrderLevel;
        private System.Windows.Forms.TextBox txtSetReOrderQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReOrder;
        private System.Windows.Forms.Button btnNearingReOrder;
        private System.Windows.Forms.Button btnItemView;
        private System.Windows.Forms.TextBox txtLastPurchasedPrice;
        private System.Windows.Forms.Label label8;
    }
}