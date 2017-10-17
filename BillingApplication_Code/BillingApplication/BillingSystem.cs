using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApplication
{
    public partial class frmBilling : Form
    {
        List<Sale> lst = new List<Sale>();
        BillingSystemEntities db = new BillingSystemEntities();
        DataTable dt = new DataTable();
        decimal sum = 0, vatamt = 0, subamt = 0;
        public frmBilling()
        {
            InitializeComponent();
            dt.Columns.Add("Item");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Rate");
            dt.Columns.Add("Amount");
            lblTotalAmtField.Visible = false;
            lblTotalAmount.Visible = false;
            lblSubAmountLabel.Visible = false;
            lblSubAmount.Visible = false;
            lblVATLabel.Visible = false;
            lblVAT.Visible = false;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dt.NewRow();
                row["Item"] = Convert.ToString(cmbItem.Text);
                row["Quantity"] = Convert.ToDecimal(txtQty.Text);
                row["Rate"] = Utility.convertDecimal(Convert.ToDecimal(txtRate.Text));
                row["Amount"] = Utility.convertDecimal(Convert.ToDecimal(txtQty.Text) * Convert.ToDecimal(txtRate.Text));

                dt.Rows.Add(row);
                
                dataGrid.DataSource = null;
                dataGrid.DataSource = dt;
                
                for (int i = 0; i < dataGrid.Rows.Count; ++i)
                {

                    sum += Convert.ToDecimal(dataGrid.Rows[i].Cells[3].Value);

                }
                lblTotalAmount.Text = Utility.convertDecimal(sum);
                var tempsubtotal = (decimal)sum / (decimal)1.13;
                var tempvat = (decimal)sum - (decimal)sum / (decimal)1.13;
                lblVAT.Text = Utility.convertDecimal(tempvat);
                lblSubAmount.Text = Utility.convertDecimal(tempsubtotal);
                sum = 0;
                lblTotalAmtField.Visible = true;
                lblTotalAmount.Visible = true;
                btnSaveBill.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            // txtItem.Clear();
            cmbItem.SelectedIndex = 0;
            txtQty.Clear();
            txtRate.Clear();
            // Clear & Hide Search related fields
            txtSearchBill.Clear();
            lblSaleTypeValue.Hide();
            lblCustomerValue.Hide();
            lblSaleDateValue.Hide();
            lblVendor.Hide();
            lblPurchaseDate.Hide();
            lblSubAmountLabel.Show();
            lblSubAmount.Show();
            lblVATLabel.Show();
            lblVAT.Show();
            btnSearchBill.Enabled = false;
            btnSearchPurchaseBill.Enabled = false;
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            using (var dbcxtransaction = db.Database.BeginTransaction())
            {
                try
                {
                    //SALEID, SALEAMOUNT, SALETYPE, Cust_Name and SALEDATE FIELDS OF SALE TABLE
                    string rb = null;
                    if (radioRetail.Checked == true)
                    {
                        rb = "Retail";
                    }
                    else
                    {
                        rb = "Wholesale";
                    }

                    Sale s = new Sale();

                    s.SaleType = rb;
                    s.SaleAmount = Convert.ToDecimal(lblTotalAmount.Text);
                    s.SubAmount = Convert.ToDecimal(lblTotalAmount.Text) / Convert.ToDecimal(1.13);
                    s.VAT = s.SaleAmount - s.SubAmount;
                    s.Cust_Name = cmbCustomerSales.Text;
                    s.SaleDate = dateTimePickerSale.Value.Date;

                    db.Sales.Add(s);
                    db.SaveChanges(); //Insert into Sale table

                    int maxID = db.Sales.Max(m => m.SaleID);
                    //SALEDETAILID, SALEID, ITEM_NAME, QTY, RATE, SALEAMOUNT, SALEDATE FIELDS OF SALE_DETAILS TABLE
                    Sale_Details s1;
                    foreach (DataGridViewRow dr in dataGrid.Rows) //Insert each rows of grid in Sale_Details table
                    {
                        s1 = new Sale_Details();
                        s1.Item_Name = Convert.ToString(dr.Cells["Item"].Value);
                        s1.Qty = Convert.ToUInt16(dr.Cells["Quantity"].Value);
                        s1.Rate = Convert.ToDecimal(dr.Cells["Rate"].Value);
                        s1.SaleAmount = Convert.ToDecimal(dr.Cells["Amount"].Value);
                        s1.VAT = Convert.ToDecimal(dr.Cells["Rate"].Value) * Convert.ToDecimal(0.13);
                        s1.Before_VAT = s1.Rate - s1.VAT;
                        s1.SaleDate = dateTimePickerSale.Value.Date;
                        s1.SaleType = rb;
                        s1.Cust_Name = cmbCustomerSales.Text;
                        s1.SaleID = maxID;

                        db.Sale_Details.Add(s1); //Insert each rows of grid in Sale_Details table

                        //update Item table (Qty_In_Hand and Qty_Sold) fileds
                        var itm = (from i in db.Items
                                   where i.ItemName == s1.Item_Name
                                   select i).FirstOrDefault();

                        itm.Qty_In_Hand = itm.Qty_In_Hand - Convert.ToUInt16(dr.Cells["Quantity"].Value);
                        itm.Qty_Sold = itm.Qty_Sold + Convert.ToUInt16(dr.Cells["Quantity"].Value);

                        db.SaveChanges(); //update Item table (Qty_In_Hand and Qty_Sold) fileds
                    }
                    dbcxtransaction.Commit();
                }
                catch
                {
                    dbcxtransaction.Rollback();
                }
            }
            dt.Clear();
            dataGrid.DataSource = null;
            lblTotalAmount.Hide(); lblTotalAmtField.Hide();
            lblSubAmount.Hide(); lblSubAmountLabel.Hide();
            lblVAT.Hide(); lblVATLabel.Hide();
            lblTotalAmount.Text = "0";
            radioRetail.Select();
            btnSaveBill.Enabled = false;
        }

        private void btnCancelBill_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGrid.DataSource = null;
            radioRetail.Select();
            txtSearchBill.Clear();
            lblTotalAmount.Hide();
            lblTotalAmtField.Hide();
            lblSubAmountLabel.Hide();
            lblSubAmount.Hide();
            lblVATLabel.Hide();
            lblVAT.Hide();
            btnSearchBill.Enabled = false;
            btnSaveBill.Enabled = false;
            btnSearchPurchaseBill.Enabled = false;

            lblSaleTypeValue.Hide();
            lblCustomerValue.Hide();
            lblSaleDateValue.Hide();
            lblVendor.Hide();
            lblPurchaseDate.Hide();

            List<Item> itm = (from i in db.Items
                              select i).ToList();

            itm.Insert(0, new Item { ItemName = "Select Item" });

            cmbItem.DataSource = itm.ToList();
            cmbItem.ValueMember = "ItemName";
            cmbItem.DisplayMember = "ItemName";

            dateTimePickerSale.Value = DateTime.Now;
            cmbItem.SelectedIndex = 0;
            txtQty.Clear();
            txtRate.Clear();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is PurchaseForm)
                {
                    isOpen = true;
                    break;
                }
            }
            if (!isOpen)
            {
                PurchaseForm ApplicationPreferences = new PurchaseForm();
                ApplicationPreferences.Show();
            }
            else
            {
                MessageBox.Show("Purchase Form is already open");
            }
        }

        private void updateItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is ItemForm)
                {
                    isOpen = true;
                    break;
                }
            }
            if (!isOpen)
            {
                ItemForm ApplicationPreferences = new ItemForm();
                ApplicationPreferences.Show();
            }
            else
            {
                MessageBox.Show("Item Form is already open");
            }
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is ItemForm)
                {
                    isOpen = true;
                    break;
                }
            }
            if (!isOpen)
            {
                PurchaseReport ApplicationPreferences = new PurchaseReport();
                ApplicationPreferences.Show();
            }
            else
            {
                MessageBox.Show("Purchase Report Form is already open");
            }
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is ItemForm)
                {
                    isOpen = true;
                    break;
                }
            }
            if (!isOpen)
            {
                SalesReport ApplicationPreferences = new SalesReport();
                ApplicationPreferences.Show();
            }
            else
            {
                MessageBox.Show("Sales Report Form is already open");
            }
        }

        private void radioRetail_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRetail.Checked == true)
            {
                cmbCustomerSales.Text = "General Customer";
                txtRate.Text = (from i in db.Items
                                where i.ItemName == cmbItem.Text
                                select i.ItemRetailPrice).FirstOrDefault().ToString();
            }
            else
            {
                List<Customer> cust = (from c in db.Customers
                                       select c).ToList();
                cmbCustomerSales.DataSource = cust.ToList();
                cmbCustomerSales.ValueMember = "Name";
                cmbCustomerSales.DisplayMember = "Name";
                txtRate.Text = (from i in db.Items
                                where i.ItemName == cmbItem.Text
                                select i.ItemWholeSalePrice).FirstOrDefault().ToString();
            }
                
        }

        private void saleItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is CustomerForm)
                {
                    isOpen = true;
                    break;
                }
            }
            if (!isOpen)
            {
                CustomerForm ApplicationPreferences = new CustomerForm();
                ApplicationPreferences.Show();
            }
            else
            {
                MessageBox.Show("Customer Update Form is already open");
            }
        }

        private void frmBilling_Load(object sender, EventArgs e)
        {   //Load Item in Item combo
            List<Item> itm = (from i in db.Items
                              select i).ToList();

            itm.Insert(0, new Item { ItemName = "Select Item" });
            
            cmbItem.DataSource = itm.ToList();
            cmbItem.ValueMember = "ItemName";
            cmbItem.DisplayMember = "ItemName";

            btnSaveBill.Enabled = false;
            btnSearchBill.Enabled = false;
            btnSearchPurchaseBill.Enabled = false;

            lblSaleTypeValue.Hide();
            lblCustomerValue.Hide();
            lblSaleDateValue.Hide();
            lblVendor.Hide();
            lblPurchaseDate.Hide();
        }
        
        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioRetail.Checked == true)
            {
                txtRate.Text = (from i in db.Items
                                where i.ItemName == cmbItem.Text
                                select i.ItemRetailPrice).FirstOrDefault().ToString();
            }
            else 
            {
                txtRate.Text = (from i in db.Items
                                where i.ItemName == cmbItem.Text
                                select i.ItemWholeSalePrice).FirstOrDefault().ToString();
            }
        }

        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            dt.Clear();
            int bill = 0;
            bill = Convert.ToInt32(txtSearchBill.Text);
            var filteredData = db.Sale_Details.Where(t => t.SaleID == bill);
            dataGrid.DataSource = filteredData.Select(o => new
            {
                Item = o.Item_Name,
                Quantity = o.Qty,
                Rate = o.Rate,
                SubAmount = o.Qty * o.Before_VAT,
                VAT = o.VAT * o.Qty,
                SaleAmount = o.SaleAmount
            }).ToList();
            for (int i = 0; i < dataGrid.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGrid.Rows[i].Cells[5].Value);
                vatamt += Convert.ToInt32(dataGrid.Rows[i].Cells[4].Value);
                subamt += Convert.ToInt32(dataGrid.Rows[i].Cells[3].Value);
            }
            lblVendor.Hide();
            lblPurchaseDate.Hide();
            lblSubAmountLabel.Show();
            lblSubAmount.Show();
            lblVATLabel.Show();
            lblVAT.Show();
            lblSaleTypeValue.Show(); lblSaleTypeValue.Text = Convert.ToString(filteredData.Select(v => new { Sale_Type = v.SaleType }).FirstOrDefault());
            lblCustomerValue.Show(); var te = Convert.ToString(filteredData.Select(v => new { Customer = v.Cust_Name }).FirstOrDefault());
            lblSaleDateValue.Show(); lblSaleDateValue.Text = Convert.ToString(filteredData.Select(v => new { Sales_Date = v.SaleDate }).FirstOrDefault());
            lblCustomerValue.Text = te.TrimEnd(' ');

            lblTotalAmtField.Show();
            lblTotalAmount.Show();
            lblTotalAmount.Text = Utility.convertDecimal(sum);
            lblVAT.Text = Utility.convertDecimal(vatamt);
            lblSubAmount.Text = Utility.convertDecimal(subamt);
            sum = 0; vatamt = 0; subamt = 0;
            btnSaveBill.Enabled = false;
        }

        private void txtSearchBill_TextChanged(object sender, EventArgs e)
        {
            btnSearchBill.Enabled = true;
            btnSearchPurchaseBill.Enabled = true;
        }

        private void btnSearchPurchaseBill_Click(object sender, EventArgs e)
        {
            dt.Clear();
            int bill = 0;
            bill = Convert.ToInt32(txtSearchBill.Text);
            var filteredData = db.Purchase_Details.Where(t => t.Purchase_ID == bill);
            dataGrid.DataSource = filteredData.Select(o => new
            {
                Item = o.ItemName,
                Quantity = o.Qty,
                Vendor_Rate = o.VendorRate,
                Final_Rate = o.FinalRate,
                VAT = o.VAT,
                Amount = o.Amount
            }).ToList();
            for (int i = 0; i < dataGrid.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGrid.Rows[i].Cells[5].Value);
                vatamt += Convert.ToInt32(dataGrid.Rows[i].Cells[4].Value);
            }
            lblSaleTypeValue.Hide();
            lblCustomerValue.Hide();
            lblSaleDateValue.Hide();
            lblVendor.Show(); lblVendor.Text = Convert.ToString(filteredData.Select(v => new { Vendor = v.Vendor }).FirstOrDefault());
            lblPurchaseDate.Show(); lblPurchaseDate.Text = Convert.ToString(filteredData.Select(v => new { P_Date = v.PurchaseDate }).FirstOrDefault());

            lblTotalAmtField.Show();
            lblTotalAmount.Show();
            lblSubAmountLabel.Show();
            lblSubAmount.Show();
            lblVATLabel.Show();
            lblVAT.Show();
            lblTotalAmount.Text = Utility.convertDecimal(sum);
            lblSubAmount.Text = Utility.convertDecimal(sum - vatamt);
            lblVAT.Text = Utility.convertDecimal(vatamt);
            sum = 0;
            vatamt = 0;
            btnSaveBill.Enabled = false;
        }

        


   }
}
