using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApplication
{
    public partial class PurchaseReport : Form
    {
        BillingSystemEntities db = new BillingSystemEntities();
        int sum = 0, subamt =0, VATamt = 0;
        int qtysum = 0;

        public PurchaseReport()
        {
            InitializeComponent();

        }
        
        private void PurchaseReport_Load(object sender, EventArgs e)
        {
            List<Item> itm = (from i in db.Items
                              select i).ToList();

            itm.Insert(0, new Item { ItemName = "ALL" });

            cmbPurchaseItem.DataSource = itm.ToList();
            cmbPurchaseItem.ValueMember = "ItemName";
            cmbPurchaseItem.DisplayMember = "ItemName";

            List<String> ven = db.Purchases.Select(m => m.Vendor).Distinct().ToList();
            ven.Insert(0, "ALL");
            cmbVendor.DataSource = ven.ToList();
            cmbVendor.DisplayMember = "Vendor";

            lblSubtotalLabel.Hide(); lblSubTotal.Hide();
            lblVATLabel.Hide(); lblVAT.Hide();
            lbldisplay.Hide(); lblAmount.Hide();
            lblQtyLabel.Hide(); lblQty.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(dateTimePickerStartDate.Value.Date);
            DateTime endDate = Convert.ToDateTime(dateTimePickerEndDate.Value);
            var cmbItem = cmbPurchaseItem.Text;
            var cmbVen = cmbVendor.Text;
            lblSubtotalLabel.Show(); lblSubTotal.Show();
            lblVATLabel.Show(); lblVAT.Show();
            lbldisplay.Show(); lblAmount.Show();
            lblQtyLabel.Show(); lblQty.Show();

            if (cmbItem == "ALL")
            {
                if (cmbVen == "ALL")
                {
                    var filteredData = db.Purchase_Details.Where(t => t.PurchaseDate >= startDate && t.PurchaseDate <= endDate);
                    dataGridViewPurchasedReport_Fields(filteredData);
                }
                else
                {
                    var filteredData = db.Purchase_Details.Where(t => t.PurchaseDate >= startDate && t.PurchaseDate <= endDate
                                                                && t.Vendor.Equals(cmbVendor.Text));
                    dataGridViewPurchasedReport_Fields(filteredData);
                }
            }
            else
            {
                if (cmbVen == "ALL")
                {
                    var filteredData = db.Purchase_Details.Where(t => t.PurchaseDate >= startDate && t.PurchaseDate <= endDate
                                                                && t.ItemName.Equals(cmbPurchaseItem.Text));
                    dataGridViewPurchasedReport_Fields(filteredData);
                }
                else
                {
                    var filteredData = db.Purchase_Details.Where(t => t.PurchaseDate >= startDate && t.PurchaseDate <= endDate
                                                        && t.ItemName.Equals(cmbPurchaseItem.Text)
                                                        && t.Vendor.Equals(cmbVendor.Text));
                    dataGridViewPurchasedReport_Fields(filteredData);
                }
            }
         }

        private void dataGridViewPurchasedReport_Fields(IQueryable<Purchase_Details> filteredData)
        {
            dataGridViewPurchaseReport.DataSource = filteredData.Select(p => new
            {
                Item = p.ItemName,
                Quantity = p.Qty,
                Vendor_Rate = p.VendorRate,
                Final_Rate = p.FinalRate,
                VAT = p.VAT,
                SubAmount = p.SubAmount,
                Amount = p.Amount,
                Vendor = p.Vendor,
                Date = p.PurchaseDate
            }).ToList();
            //Populate total amount from grid data
            for (int i = 0; i < dataGridViewPurchaseReport.Rows.Count; ++i)
            {

                sum += Convert.ToInt32(dataGridViewPurchaseReport.Rows[i].Cells[6].Value);
                qtysum += Convert.ToInt32(dataGridViewPurchaseReport.Rows[i].Cells[1].Value);
                VATamt += Convert.ToInt32(dataGridViewPurchaseReport.Rows[i].Cells[4].Value);

            }
            lblAmount.Text = Utility.convertDecimal(sum);
            lblQty.Text = Convert.ToDecimal(qtysum).ToString();
            lblVAT.Text = Utility.convertDecimal(VATamt);
            lblSubTotal.Text = Utility.convertDecimal(sum - VATamt);
            sum = 0;
            qtysum = 0;
            VATamt = 0;
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(dateTimePickerStartDate.Value.Date);
            DateTime endDate = Convert.ToDateTime(dateTimePickerEndDate.Value);
            var cmbItem = cmbPurchaseItem.Text;
            var cmbVen = cmbVendor.Text;
            lblSubtotalLabel.Show(); lblSubTotal.Show();
            lblVATLabel.Show(); lblVAT.Show();
            lbldisplay.Show(); lblAmount.Show();
            lblQtyLabel.Show(); lblQty.Show();
            if (cmbItem == "ALL")
            {
                if (cmbVen == "ALL")
                {
                    var filteredData = from m in db.Purchase_Details
                                       where m.PurchaseDate >= startDate && m.PurchaseDate <= endDate
                                       group m by m.ItemName into g
                                       let itemcount = g.Sum(m => m.Qty)
                                       let avgrate = g.Average(m => m.FinalRate)
                                       let vat = g.Sum(m => m.VAT)
                                       let subamount = g.Sum(m => m.SubAmount)
                                       let amount = g.Sum(m => m.Amount)
                                       orderby itemcount descending
                                       select new { ItemName = g.Key, itemcount, vat, avgrate, subamount, amount };

                    dataGridViewPurchaseReport.DataSource = filteredData.Select(o => new
                    {
                        Item = o.ItemName,
                        Quantity = o.itemcount,
                        Avg_Rate = o.avgrate,
                        VAT = o.vat,
                        SubAmount = o.subamount,
                        Amount = o.amount
                    }).ToList();
                    display_amount_in_Item();

                }
                else
                {
                    var filteredData = from m in db.Purchase_Details
                                       where m.PurchaseDate >= startDate && m.PurchaseDate <= endDate
                                       && m.Vendor.Equals(cmbVendor.Text)
                                       group m by m.ItemName into g
                                       let itemcount = g.Sum(m => m.Qty)
                                       let avgrate = g.Average(m => m.FinalRate)
                                       let vat = g.Sum(m => m.VAT)
                                       let subamount = g.Sum(m => m.SubAmount)
                                       let amount = g.Sum(m => m.Amount)
                                       orderby itemcount descending
                                       select new { ItemName = g.Key, itemcount, vat, avgrate, subamount, amount };

                    dataGridViewPurchaseReport.DataSource = filteredData.Select(o => new
                    {
                        Item = o.ItemName,
                        Quantity = o.itemcount,
                        Avg_Rate = o.avgrate,
                        VAT = o.vat,
                        SubAmount = o.subamount,
                        Amount = o.amount
                    }).ToList();
                    display_amount_in_Item();
                }
            }
            else
            {
                if (cmbVen == "ALL")
                {
                    var filteredData = from m in db.Purchase_Details
                                       where m.PurchaseDate >= startDate && m.PurchaseDate <= endDate
                                       && m.ItemName.Equals(cmbPurchaseItem.Text)
                                       group m by m.ItemName into g
                                       let itemcount = g.Sum(m => m.Qty)
                                       let avgrate = g.Average(m => m.FinalRate)
                                       let vat = g.Sum(m => m.VAT)
                                       let subamount = g.Sum(m => m.SubAmount)
                                       let amount = g.Sum(m => m.Amount)
                                       orderby itemcount descending
                                       select new { ItemName = g.Key, itemcount, vat, avgrate, subamount, amount };

                    dataGridViewPurchaseReport.DataSource = filteredData.Select(o => new
                    {
                        Item = o.ItemName,
                        Quantity = o.itemcount,
                        Avg_Rate = o.avgrate,
                        VAT = o.vat,
                        SubAmount = o.subamount,
                        Amount = o.amount
                    }).ToList();
                    display_amount_in_Item();
                }
                else
                {
                    var filteredData = from m in db.Purchase_Details
                                       where m.PurchaseDate >= startDate && m.PurchaseDate <= endDate
                                       && m.ItemName.Equals(cmbPurchaseItem.Text)
                                       && m.Vendor.Equals(cmbVendor.Text)
                                       group m by m.ItemName into g
                                       let itemcount = g.Sum(m => m.Qty)
                                       let avgrate = g.Average(m => m.FinalRate)
                                       let vat = g.Sum(m => m.VAT)
                                       let subamount = g.Sum(m => m.SubAmount)
                                       let amount = g.Sum(m => m.Amount)
                                       orderby itemcount descending
                                       select new { ItemName = g.Key, itemcount, vat, avgrate, subamount, amount };

                    dataGridViewPurchaseReport.DataSource = filteredData.Select(o => new
                    {
                        Item = o.ItemName,
                        Quantity = o.itemcount,
                        Avg_Rate = o.avgrate,
                        VAT = o.vat,
                        SubAmount = o.subamount,
                        Amount = o.amount
                    }).ToList();
                    display_amount_in_Item();
                }
            }
        }

        private void display_amount_in_Item()
        {
            for (int i = 0; i < dataGridViewPurchaseReport.Rows.Count; ++i)
            {

                sum += Convert.ToInt32(dataGridViewPurchaseReport.Rows[i].Cells[5].Value);
                qtysum += Convert.ToInt32(dataGridViewPurchaseReport.Rows[i].Cells[1].Value);
                VATamt += Convert.ToInt32(dataGridViewPurchaseReport.Rows[i].Cells[3].Value);

            }
            lblAmount.Text = Utility.convertDecimal(sum);
            lblQty.Text = Convert.ToDecimal(qtysum).ToString();
            lblVAT.Text = Utility.convertDecimal(VATamt);
            lblSubTotal.Text = Utility.convertDecimal(sum - VATamt);
            sum = 0;
            qtysum = 0;
            VATamt = 0;
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(dateTimePickerStartDate.Value.Date);
            DateTime endDate = Convert.ToDateTime(dateTimePickerEndDate.Value);
            var cmbItem = cmbPurchaseItem.Text;
            var cmbVen = cmbVendor.Text;
            lblSubtotalLabel.Show(); lblSubTotal.Show();
            lblVATLabel.Show(); lblVAT.Show();
            lbldisplay.Show(); lblAmount.Show();
            lblQtyLabel.Show(); lblQty.Show();
            if (cmbItem == "ALL")
            {
                if (cmbVen == "ALL")
                {
                    var filteredData = from m in db.Purchase_Details
                                       where m.PurchaseDate >= startDate && m.PurchaseDate <= endDate
                                       group m by m.Vendor into g
                                       let itemcount = g.Sum(m => m.Qty)
                                       let vat = g.Sum(m => m.VAT)
                                       let subamount = g.Sum(m => m.SubAmount)
                                       let amount = g.Sum(m => m.Amount)
                                       orderby itemcount descending
                                       select new { ItemName = g.Key, itemcount, vat, subamount, amount };

                    dataGridViewPurchaseReport.DataSource = filteredData.Select(o => new
                    {
                        Vendor = o.ItemName,
                        Quantity = o.itemcount,
                        VAT = o.vat,
                        SubAmount = o.subamount,
                        Amount = o.amount
                    }).ToList();
                    display_amount_in_Vendor();

                }
                else
                {
                    var filteredData = from m in db.Purchase_Details
                                       where m.PurchaseDate >= startDate && m.PurchaseDate <= endDate
                                       && m.Vendor.Equals(cmbVendor.Text)
                                       group m by m.Vendor into g
                                       let itemcount = g.Sum(m => m.Qty)
                                       let vat = g.Sum(m => m.VAT)
                                       let subamount = g.Sum(m => m.SubAmount)
                                       let amount = g.Sum(m => m.Amount)
                                       orderby itemcount descending
                                       select new { ItemName = g.Key, itemcount, vat, subamount, amount };

                    dataGridViewPurchaseReport.DataSource = filteredData.Select(o => new
                    {
                        Vendor = o.ItemName,
                        Quantity = o.itemcount,
                        VAT = o.vat,
                        SubAmount = o.subamount,
                        Amount = o.amount
                    }).ToList();
                    display_amount_in_Vendor();
                }
            }
            else
            {
                if (cmbVen == "ALL")
                {
                    var filteredData = from m in db.Purchase_Details
                                       where m.PurchaseDate >= startDate && m.PurchaseDate <= endDate
                                       && m.ItemName.Equals(cmbPurchaseItem.Text)
                                       group m by m.Vendor into g
                                       let itemcount = g.Sum(m => m.Qty)
                                       let vat = g.Sum(m => m.VAT)
                                       let subamount = g.Sum(m => m.SubAmount)
                                       let amount = g.Sum(m => m.Amount)
                                       orderby itemcount descending
                                       select new { ItemName = g.Key, itemcount, vat, subamount, amount };

                    dataGridViewPurchaseReport.DataSource = filteredData.Select(o => new
                    {
                        Vendor = o.ItemName,
                        Quantity = o.itemcount,
                        VAT = o.vat,
                        SubAmount = o.subamount,
                        Amount = o.amount
                    }).ToList();
                    display_amount_in_Vendor();
                }
                else
                {
                    var filteredData = from m in db.Purchase_Details
                                       where m.PurchaseDate >= startDate && m.PurchaseDate <= endDate
                                       && m.ItemName.Equals(cmbPurchaseItem.Text)
                                       && m.Vendor.Equals(cmbVendor.Text)
                                       group m by m.Vendor into g
                                       let itemcount = g.Sum(m => m.Qty)
                                       let vat = g.Sum(m => m.VAT)
                                       let subamount = g.Sum(m => m.SubAmount)
                                       let amount = g.Sum(m => m.Amount)
                                       orderby itemcount descending
                                       select new { ItemName = g.Key, itemcount, vat, subamount, amount };

                    dataGridViewPurchaseReport.DataSource = filteredData.Select(o => new
                    {
                        Vendor = o.ItemName,
                        Quantity = o.itemcount,
                        VAT = o.vat,
                        SubAmount = o.subamount,
                        Amount = o.amount
                    }).ToList();
                    display_amount_in_Vendor();
                }
            }
        }

        private void display_amount_in_Vendor()
        {
            for (int i = 0; i < dataGridViewPurchaseReport.Rows.Count; ++i)
            {

                sum += Convert.ToInt32(dataGridViewPurchaseReport.Rows[i].Cells[4].Value);
                qtysum += Convert.ToInt32(dataGridViewPurchaseReport.Rows[i].Cells[1].Value);
                VATamt += Convert.ToInt32(dataGridViewPurchaseReport.Rows[i].Cells[2].Value);

            }
            lblAmount.Text = Utility.convertDecimal(sum);
            lblQty.Text = Convert.ToDecimal(qtysum).ToString();
            lblVAT.Text = Utility.convertDecimal(VATamt);
            lblSubTotal.Text = Utility.convertDecimal(sum - VATamt);
            sum = 0;
            qtysum = 0;
            VATamt = 0;
        }

        private void btnBillWise_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(dateTimePickerStartDate.Value.Date);
            DateTime endDate = Convert.ToDateTime(dateTimePickerEndDate.Value);
            var cmbItem = cmbPurchaseItem.Text;
            var cmbVen = cmbVendor.Text;
            lblSubtotalLabel.Show(); lblSubTotal.Show();
            lblVATLabel.Show(); lblVAT.Show();
            lbldisplay.Show(); lblAmount.Show();
            lblQty.Hide(); lblQtyLabel.Hide();

            if (cmbVendor.Text == "ALL")
            {
                var filteredData = db.Purchases.Where(t => t.PurchaseDate >= startDate && t.PurchaseDate <= endDate);
                BillwiseGridView(filteredData);
            }
            else
            {
                var filteredData = db.Purchases.Where(t => t.PurchaseDate >= startDate 
                                                        && t.PurchaseDate <= endDate
                                                        && t.Vendor == cmbVendor.Text);
                BillwiseGridView(filteredData);
            }
        }

        private void BillwiseGridView(IQueryable<Purchase> filteredData)
        {
            dataGridViewPurchaseReport.DataSource = filteredData.Select(p => new
            {
                Purchase_ID = p.Purchase_ID,
                Sub_Amount = p.SubAmount,
                VAT = p.TotalVAT,
                Total_Amount = p.TotalAmount,
                Lot_No = p.Lot_No1,
                Vendor = p.Vendor,
                Purchase_Date = p.PurchaseDate
            }).ToList();
            //Populate total amount from grid data
            for (int i = 0; i < dataGridViewPurchaseReport.Rows.Count; ++i)
            {

                sum += Convert.ToInt32(dataGridViewPurchaseReport.Rows[i].Cells[3].Value);
                VATamt += Convert.ToInt32(dataGridViewPurchaseReport.Rows[i].Cells[2].Value);
                subamt += Convert.ToInt32(dataGridViewPurchaseReport.Rows[i].Cells[1].Value);

            }
            lblAmount.Text = Utility.convertDecimal(sum);
            lblVAT.Text = Utility.convertDecimal(VATamt);
            lblSubTotal.Text = Utility.convertDecimal(subamt);
            sum = 0;
            VATamt = 0;
            subamt = 0;
        }

        private void btnDatewise_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(dateTimePickerStartDate.Value.Date);
            DateTime endDate = Convert.ToDateTime(dateTimePickerEndDate.Value);
            var cmbItem = cmbPurchaseItem.Text;
            var cmbVen = cmbVendor.Text;
            lblSubtotalLabel.Show(); lblSubTotal.Show();
            lblVATLabel.Show(); lblVAT.Show();
            lbldisplay.Show(); lblAmount.Show();
            lblQty.Hide(); lblQtyLabel.Hide();

            if (cmbVendor.Text == "ALL")
            {
                var filteredDataPDateWise = from m in db.Purchases
                                           where m.PurchaseDate >= startDate && m.PurchaseDate <= endDate
                                           group m by m.PurchaseDate into g
                                           let Sub_Amount = g.Sum(m => m.SubAmount)
                                           let VAT = g.Sum(m => m.TotalVAT)
                                           let Total_Amount = g.Sum(m => m.TotalAmount)
                                           select new { Purchase_Date = g.Key, Sub_Amount, VAT, Total_Amount };

                dataGridViewPurchaseReport.DataSource = filteredDataPDateWise.Select(o => new
                {
                    Purchase_Date = o.Purchase_Date,
                    Sub_Amount = o.Sub_Amount,
                    VAT = o.VAT,
                    Total_Amount = o.Total_Amount
                }).ToList();

                DatewiseGridView();
            }
            else
            {
                var filteredDataPDateWise = from m in db.Purchases
                                             where m.PurchaseDate >= startDate && m.PurchaseDate <= endDate && m.Vendor==cmbVendor.Text
                                             group m by m.PurchaseDate into g
                                             let Sub_Amount = g.Sum(m => m.SubAmount)
                                             let VAT = g.Sum(m => m.TotalVAT)
                                             let Total_Amount = g.Sum(m => m.TotalAmount)
                                             select new { Purchase_Date = g.Key, Sub_Amount, VAT, Total_Amount };

                dataGridViewPurchaseReport.DataSource = filteredDataPDateWise.Select(o => new
                {
                    Purchase_Date = o.Purchase_Date,
                    Sub_Amount = o.Sub_Amount,
                    VAT = o.VAT,
                    Total_Amount = o.Total_Amount
                }).ToList();

                DatewiseGridView();
            }
        }

        private void DatewiseGridView()
        {
            for (int i = 0; i < dataGridViewPurchaseReport.Rows.Count; ++i)
            {

                sum += Convert.ToInt32(dataGridViewPurchaseReport.Rows[i].Cells[3].Value);
                VATamt += Convert.ToInt32(dataGridViewPurchaseReport.Rows[i].Cells[2].Value);
                subamt += Convert.ToInt32(dataGridViewPurchaseReport.Rows[i].Cells[1].Value);
            }
            lblAmount.Text = Utility.convertDecimal(sum);
            lblVAT.Text = Utility.convertDecimal(VATamt);
            lblSubTotal.Text = Utility.convertDecimal(subamt);
            sum = 0;
            VATamt = 0;
            subamt = 0;
        }
   }
}
