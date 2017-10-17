using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApplication
{
    public partial class PurchaseForm : Form
    {
        BillingSystemEntities db = new BillingSystemEntities();
        DataTable dt = new DataTable();
        decimal sum = 0, sum1 = 0, sum2 = 0;
        public PurchaseForm()
        {
            InitializeComponent();
            dt.Columns.Add("Item");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Vendor Rate");
            dt.Columns.Add("Sub Amount");
            dt.Columns.Add("VAT");
            dt.Columns.Add("Amount");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            using (var dbcxtransaction = db.Database.BeginTransaction())
            {
                try
                {
                    try
                    {
                        //Insert into Purchase Table
                        Purchase pur = new Purchase();
                        pur.SubAmount = Convert.ToDecimal(lblSubAmount.Text);
                        pur.TotalVAT = Convert.ToDecimal(lblVATAmount.Text);
                        pur.TotalAmount = Convert.ToDecimal(lblTotalPurchaseAmount.Text);
                        pur.Lot_No1 = txtLotNo.Text;
                        pur.Vendor = cmbVendorP.Text;
                        pur.PurchaseDate = dateTimePickerPurchase.Value.Date;

                        db.Purchases.Add(pur);
                        db.SaveChanges();
                        int maxid = db.Purchases.Max(p => p.Purchase_ID);

                        //Insert into Purchase_Details table for each grid value
                        foreach (DataGridViewRow dr in dataGridPurchase.Rows)
                        {
                            Purchase_Details p1 = new Purchase_Details();
                            p1.ItemName = Convert.ToString(dr.Cells["Item"].Value);
                            p1.Qty = Convert.ToInt32(dr.Cells["Quantity"].Value);
                            p1.VendorRate = Convert.ToDecimal(dr.Cells["Vendor Rate"].Value);
                            p1.VAT = Convert.ToDecimal(dr.Cells["VAT"].Value);
                            p1.FinalRate = Convert.ToDecimal(dr.Cells["Vendor Rate"].Value) + (Convert.ToDecimal(dr.Cells["Vendor Rate"].Value) * Convert.ToDecimal(0.13));
                            p1.SubAmount = Convert.ToDecimal(dr.Cells["Vendor Rate"].Value) * Convert.ToInt32(dr.Cells["Quantity"].Value);
                            p1.Amount = Convert.ToDecimal(dr.Cells["Vendor Rate"].Value) * Convert.ToDecimal(1.13) * Convert.ToInt32(dr.Cells["Quantity"].Value);
                            p1.Vendor = cmbVendorP.Text;
                            p1.PurchaseDate = dateTimePickerPurchase.Value.Date;
                            p1.Purchase_ID = maxid;

                            db.Purchase_Details.Add(p1);
                            db.SaveChanges();

                            //Select latest ItemName
                            var qry = db.Items.Where(i => i.ItemName == p1.ItemName).FirstOrDefault();
                            if (qry != null)
                            {
                                //update Item table (Qty_In_Hand, Vendor_Price and Last_Purchased_Price) fileds
                                var itm = (from i in db.Items
                                           where i.ItemName == p1.ItemName
                                           select i).FirstOrDefault();

                                itm.Qty_In_Hand = itm.Qty_In_Hand + p1.Qty;
                                itm.Vendor_Price = p1.VendorRate;
                                itm.Last_Purchased_Price = p1.FinalRate;

                                int num = db.SaveChanges();

                                cmbItemP.SelectedIndex = 0;
                                txtQty.Clear();
                                txtVendorRate.Clear();
                            }
                            else
                            {
                                //Insert into Item table for new Item entry (ItemName, Qty_In_Hand and Last_Purchased_Price)
                                Item i1 = new Item();
                                i1.ItemName = p1.ItemName;
                                i1.Qty_In_Hand = p1.Qty;
                                i1.Last_Purchased_Price = p1.FinalRate;
                                i1.Vendor_Price = p1.VendorRate;
                                i1.Qty_Sold = 0;
                                i1.ItemRetailPrice = 0;
                                i1.ItemWholeSalePrice = 0;
                                i1.ReOrderLevel = 0;
                                i1.ReOrderQty = 0;
                                i1.PriceLastUpdated = dateTimePickerPurchase.Value.Date;

                                db.Items.Add(i1);
                                db.SaveChanges();

                                cmbItemP.SelectedIndex = 0;
                                txtQty.Clear();
                                txtVendorRate.Clear();
                            }
                        }

                        List<Item> itm1 = (from i in db.Items
                                           select i).ToList();

                        itm1.Insert(0, new Item { ItemName = "Non Item Selected" });

                        cmbItemP.DataSource = itm1.ToList();
                        cmbItemP.ValueMember = "ItemName";
                        cmbItemP.DisplayMember = "ItemName";

                        List<string> ven = db.Purchases.Select(m => m.Vendor).Distinct().ToList();
                        ven.Insert(0, "Non Vendor Selected");
                        cmbVendorP.DataSource = ven.ToList();
                        cmbVendorP.DisplayMember = "Vendor".Trim();

                        lblQty.Hide();
                        lblRate.Hide();
                        dt.Clear();
                        dataGridPurchase.DataSource = null;
                        lblSubAmount.Hide(); lblSubAmountLabel.Hide();
                        lblTotalPurchaseAmount.Hide(); lblTotalPurchaseLabel.Hide();
                        lblVATAmount.Hide(); lblVATLabel.Hide();
                        lblAdjLabel.Hide(); txtAdj.Hide();

                        txtLotNo.Clear();
                        cmbVendorP.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dbcxtransaction.Commit();
                }
                catch
                {
                    dbcxtransaction.Rollback();
                }
            }
            dt.Clear();
            dataGridPurchase.DataSource = null;
            btnSave.Enabled = true;
            lblQty.Hide();
            lblRate.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dateTimePickerPurchase.Value = DateTime.Now;
            dt.Clear();
            dataGridPurchase.DataSource = null;

            lblQty.Hide();
            lblRate.Hide();
            btnSave.Enabled = false;

            txtLotNo.Clear();
            cmbVendorP.SelectedIndex = 0;

            lblSubAmount.Hide(); lblSubAmountLabel.Hide();
            lblTotalPurchaseAmount.Hide(); lblTotalPurchaseLabel.Hide();
            lblVATAmount.Hide(); lblVATLabel.Hide();
            lblAdjLabel.Hide(); txtAdj.Hide();

            cmbItemP.SelectedIndex = 0;
            txtQty.Clear();
            txtVendorRate.Clear();

        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            List<Item> itm = (from i in db.Items
                              select i).ToList();

            itm.Insert(0, new Item { ItemName = "Non Item Selected" });

            cmbItemP.DataSource = itm.ToList();
            cmbItemP.ValueMember = "ItemName";
            cmbItemP.DisplayMember = "ItemName";

            List<string> ven = db.Purchases.Select(m => m.Vendor).Distinct().ToList();
            ven.Insert(0, "Non Vendor Selected");
            cmbVendorP.DataSource = ven.ToList();
            cmbVendorP.DisplayMember = "Vendor";

            lblQty.Hide();
            lblRate.Hide();
            btnSave.Enabled = false;

            lblSubAmount.Hide(); lblSubAmountLabel.Hide();
            lblTotalPurchaseAmount.Hide(); lblTotalPurchaseLabel.Hide();
            lblVATAmount.Hide(); lblVATLabel.Hide();
            lblAdjLabel.Hide(); txtAdj.Hide();
        }

        private void cmbItemP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbItemP.SelectedIndex > 0)
            {
                txtVendorRate.Text = Utility.convertDecimal(((decimal)(from i in db.Items
                                                                       where i.ItemName == cmbItemP.Text
                                                                       select i.Vendor_Price).FirstOrDefault()));

                txtQty.Text = (from i in db.Items
                               where i.ItemName == cmbItemP.Text
                               select i.ReOrderQty).FirstOrDefault().ToString();
                lblQty.Show();
                lblRate.Show();
            }

        }

        private void btnPurchaseSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dt.NewRow();
                decimal VatValue = Convert.ToDecimal(txtVendorRate.Text.Trim()) * Convert.ToDecimal(0.13);
                decimal Frate = Convert.ToDecimal(txtVendorRate.Text.Trim()) + Convert.ToDecimal(VatValue);
                decimal vatamt = Convert.ToDecimal(VatValue) * Convert.ToDecimal(txtQty.Text);
                decimal amt = Convert.ToDecimal(Frate) * Convert.ToDecimal(txtQty.Text);

                row["Item"] = Convert.ToString(cmbItemP.Text);
                row["Quantity"] = Convert.ToDecimal(txtQty.Text);
                row["Vendor Rate"] = Utility.convertDecimal(Convert.ToDecimal(txtVendorRate.Text));
                row["Sub Amount"] = Utility.convertDecimal(Convert.ToDecimal(txtQty.Text) * Convert.ToDecimal(txtVendorRate.Text));
                row["VAT"] = Utility.convertDecimal(Convert.ToDecimal(vatamt));
                row["Amount"] = Utility.convertDecimal(Convert.ToDecimal(amt));

                dt.Rows.Add(row);
                dataGridPurchase.DataSource = null;
                dataGridPurchase.DataSource = dt;

                for (int i = 0; i < dataGridPurchase.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridPurchase.Rows[i].Cells[5].Value);
                    sum1 += Convert.ToDecimal(dataGridPurchase.Rows[i].Cells[3].Value);
                    sum2 += Convert.ToDecimal(dataGridPurchase.Rows[i].Cells[4].Value);
                }
                lblTotalPurchaseAmount.Text = sum.ToString();
                lblVATAmount.Text = sum2.ToString();
                lblSubAmount.Text=sum1.ToString();
                sum = 0; sum1 = 0; sum2 = 0;
                cmbItemP.SelectedIndex = 0;
                txtQty.Clear();
                txtVendorRate.Clear();
                lblQty.Hide();
                lblRate.Hide();
                btnSave.Enabled = true;

                lblSubAmount.Show(); lblSubAmountLabel.Show();
                lblTotalPurchaseAmount.Show(); lblTotalPurchaseLabel.Show();
                lblVATAmount.Show(); lblVATLabel.Show();
                lblAdjLabel.Show(); txtAdj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private object GetNewValues()
        {
            throw new NotImplementedException();
        }

        private void txtAdj_TextChanged(object sender, EventArgs e)
        {
            if (txtAdj.Text != "")
            {
                decimal adjval = 0, purtot = 0;
                adjval = Convert.ToDecimal(txtAdj.Text);
                purtot = Convert.ToDecimal(lblTotalPurchaseAmount.Text);
                lblTotalPurchaseAmount.Text = Utility.convertDecimal(adjval + purtot);
                adjval = 0; purtot = 0;
            }
            
        }
    }
}
