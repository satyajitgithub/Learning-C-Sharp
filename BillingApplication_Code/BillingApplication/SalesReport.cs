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
    public partial class SalesReport : Form
    {
        BillingSystemEntities db = new BillingSystemEntities();
        int sum = 0;
        int qtysum = 0;
        public SalesReport()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(dateTimePickerStartDate.Value.Date);
            DateTime endDate = Convert.ToDateTime(dateTimePickerEndDate.Value);
            var saltype = cmbSalesType.Text;
            var salitem = cmbSalesItem.Text;
            var salcust = cmbCustomer.Text;
            lblQty.Show(); lblQtyInfo.Show();
            lblInfo.Show(); lblAmount.Show();
            lblSubTotalLabel.Show(); lblSubTotal.Show();
            lblVATLabel.Show(); lblVAT.Show();
            if(saltype=="ALL")
            {
                if(salitem=="ALL")
                {
                    if(salcust=="ALL")
                    {
                        //All S,I,C
                        var filteredData = db.Sale_Details.Where(t => t.SaleDate >= startDate
                                                       && t.SaleDate <= endDate);
                        dataGridViewSalesReport_View(filteredData);
                    }
                    else //cust
                    {
                        //All S,I take C
                        var filteredData = db.Sale_Details.Where(t => t.SaleDate >= startDate
                                                       && t.SaleDate <= endDate
                                                       && t.Cust_Name.Equals(cmbCustomer.Text));
                        dataGridViewSalesReport_View(filteredData);
                    }
                }
                else
                {
                    if(salcust=="ALL")
                    {
                        //All S,C take I
                        var filteredData = db.Sale_Details.Where(t => t.SaleDate >= startDate
                                                       && t.SaleDate <= endDate
                                                       && t.Item_Name.Equals(cmbSalesItem.Text));
                        dataGridViewSalesReport_View(filteredData);
                    }
                    else
                    {
                        //All S take I and C
                        var filteredData = db.Sale_Details.Where(t => t.SaleDate >= startDate
                                                       && t.SaleDate <= endDate
                                                       && t.Item_Name.Equals(cmbSalesItem.Text)
                                                       && t.Cust_Name.Equals(cmbCustomer.Text));
                        dataGridViewSalesReport_View(filteredData);
                    }
                }
            }
            else
            {
                if(salitem=="ALL")
                {
                    if(salcust=="ALL")
                    {
                        //All I, C take s
                        var filteredData = db.Sale_Details.Where(t => t.SaleDate >= startDate
                                                       && t.SaleDate <= endDate
                                                       && t.SaleType.Equals(cmbSalesType.Text));
                        dataGridViewSalesReport_View(filteredData);
                    }
                    else
                    {
                        //All I, take s and c
                        var filteredData = db.Sale_Details.Where(t => t.SaleDate >= startDate
                                                       && t.SaleDate <= endDate
                                                       && t.SaleType.Equals(cmbSalesType.Text)
                                                       && t.Cust_Name.Equals(cmbCustomer.Text));
                        dataGridViewSalesReport_View(filteredData);
                    }
                }
                else
                {
                    if(salcust=="ALL")
                    {
                        //All C, take s, i
                        var filteredData = db.Sale_Details.Where(t => t.SaleDate >= startDate
                                                       && t.SaleDate <= endDate
                                                       && t.SaleType.Equals(cmbSalesType.Text)
                                                       && t.Item_Name.Equals(cmbSalesItem.Text));
                        dataGridViewSalesReport_View(filteredData);
                    }
                    else
                    {
                        //All none, take all three
                        var filteredData = db.Sale_Details.Where(t => t.SaleDate >= startDate
                                                       && t.SaleDate <= endDate
                                                       && t.SaleType.Equals(cmbSalesType.Text)
                                                       && t.Item_Name.Equals(cmbSalesItem.Text)
                                                       && t.Cust_Name.Equals(cmbCustomer.Text));
                        dataGridViewSalesReport_View(filteredData);
                    }
                }
            }
            
        }

        private void dataGridViewSalesReport_View(IQueryable<Sale_Details> filteredData)
        {
            dataGridViewSalesReport.DataSource = filteredData.Select(o => new
            {
                Item = o.Item_Name,
                Quantity = o.Qty,
                Rate = o.Rate,
                SaleAmount = o.SaleAmount,
                SalesType = o.SaleType,
                Customer = o.Cust_Name,
                SaleDate = o.SaleDate
            }).ToList();
            //Populate total amount from grid data
            for (int i = 0; i < dataGridViewSalesReport.Rows.Count; ++i)
            {

                sum += Convert.ToInt32(dataGridViewSalesReport.Rows[i].Cells[3].Value);
                qtysum += Convert.ToInt32(dataGridViewSalesReport.Rows[i].Cells[1].Value);

            }
            BottomLabel_Calc();
        }

        private void BottomLabel_Calc()
        {
            lblAmount.Text = Utility.convertDecimal(sum);
            lblVAT.Text = Utility.convertDecimal((decimal)(sum - (sum / 1.13)));
            lblSubTotal.Text = Utility.convertDecimal((decimal)(sum / 1.13));
            lblQty.Text = qtysum.ToString();
            sum = 0;
            qtysum = 0;
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("1", "ALL");
            comboSource.Add("2", "Wholesale");
            comboSource.Add("3", "Retail");

            cmbSalesType.DataSource = new BindingSource(comboSource, null);
            cmbSalesType.DisplayMember = "Value";
            cmbSalesType.ValueMember = "Key";

            List<Customer> cus = (from c in db.Customers
                                  select c).ToList();
            cus.Insert(0, new Customer { Name = "ALL" });
            cmbCustomer.DataSource = cus.ToList();
            cmbCustomer.ValueMember = "Name";
            cmbCustomer.DisplayMember = "Name";

            List<Item> it = (from i in db.Items
                             select i).ToList();
            it.Insert(0, new Item { ItemName = "ALL" });
            cmbSalesItem.DataSource = it.ToList();
            cmbSalesItem.ValueMember = "ItemName";
            cmbSalesItem.DisplayMember = "ItemName";

            lblQty.Hide(); lblQtyInfo.Hide();
            lblInfo.Hide(); lblAmount.Hide();
            lblSubTotalLabel.Hide(); lblSubTotal.Hide();
            lblVATLabel.Hide(); lblVAT.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(dateTimePickerStartDate.Value.Date);
            DateTime endDate = Convert.ToDateTime(dateTimePickerEndDate.Value);
            var saltype = cmbSalesType.Text;
            var salitem = cmbSalesItem.Text;
            var salcust = cmbCustomer.Text;
            lblQty.Show(); lblQtyInfo.Show();
            lblInfo.Show(); lblAmount.Show();
            lblSubTotalLabel.Show(); lblSubTotal.Show();
            lblVATLabel.Show(); lblVAT.Show();
            if (saltype == "ALL")
            {
                if (salitem == "ALL")
                {
                    if (salcust == "ALL")
                    {
                        //All S,I,C
                        var filteredDataCustomer = from m in db.Sale_Details
                                           where m.SaleDate >= startDate && m.SaleDate <= endDate
                                           group m by m.Cust_Name into g
                                           let itemcount = g.Sum(m => m.Qty)
                                           let amount = g.Sum(m => m.SaleAmount)
                                           orderby itemcount descending
                                           select new { ItemName = g.Key, itemcount, amount };

                        dataGridViewSalesReport.DataSource = filteredDataCustomer.Select(o => new
                        {
                            Customer = o.ItemName,
                            Quantity = o.itemcount,
                            SubAmount = (decimal)o.amount / (decimal)1.13,
                            VAT = (decimal)o.amount - (decimal)o.amount / (decimal)1.13,
                            Amount=o.amount
                        }).ToList();
                        display_amount_in_Customer();
                    }
                    else //cust
                    {
                        //All S,I take C
                        var filteredDataCustomer = from m in db.Sale_Details
                                           where m.SaleDate >= startDate && m.SaleDate <= endDate
                                           && m.Cust_Name.Equals(cmbCustomer.Text)
                                           group m by m.Cust_Name into g
                                           let itemcount = g.Sum(m => m.Qty)
                                           let amount = g.Sum(m => m.SaleAmount)
                                           orderby itemcount descending
                                           select new { ItemName = g.Key, itemcount, amount };

                        dataGridViewSalesReport.DataSource = filteredDataCustomer.Select(o => new
                        {
                            Customer = o.ItemName,
                            Quantity = o.itemcount,
                            SubAmount = (decimal)o.amount / (decimal)1.13,
                            VAT = (decimal)o.amount - (decimal)o.amount / (decimal)1.13,
                            Amount = o.amount
                        }).ToList();
                    }
                }
                else
                {
                    if (salcust == "ALL")
                    {
                        //All S,C take I
                        var filteredDataCustomer = from m in db.Sale_Details
                                           where m.SaleDate >= startDate && m.SaleDate <= endDate
                                           && m.Item_Name.Equals(cmbSalesItem.Text)
                                           group m by m.Cust_Name into g
                                           let itemcount = g.Sum(m => m.Qty)
                                           let amount = g.Sum(m => m.SaleAmount)
                                           orderby itemcount descending
                                           select new { ItemName = g.Key, itemcount, amount };

                        dataGridViewSalesReport.DataSource = filteredDataCustomer.Select(o => new
                        {
                            Customer = o.ItemName,
                            Quantity = o.itemcount,
                            SubAmount = (decimal)o.amount / (decimal)1.13,
                            VAT = (decimal)o.amount - (decimal)o.amount / (decimal)1.13,
                            Amount = o.amount
                        }).ToList();
                        display_amount_in_Customer();
                    }
                    else
                    {
                        //All S take I and C
                        var filteredDataCustomer = from m in db.Sale_Details
                                           where m.SaleDate >= startDate && m.SaleDate <= endDate
                                           && m.Item_Name.Equals(cmbSalesItem.Text)
                                           && m.Cust_Name.Equals(cmbCustomer.Text)
                                           group m by m.Cust_Name into g
                                           let itemcount = g.Sum(m => m.Qty)
                                           let amount = g.Sum(m => m.SaleAmount)
                                           orderby itemcount descending
                                           select new { ItemName = g.Key, itemcount, amount };

                        dataGridViewSalesReport.DataSource = filteredDataCustomer.Select(o => new
                        {
                            Customer = o.ItemName,
                            Quantity = o.itemcount,
                            SubAmount = (decimal)o.amount / (decimal)1.13,
                            VAT = (decimal)o.amount - (decimal)o.amount / (decimal)1.13,
                            Amount = o.amount
                        }).ToList();
                        display_amount_in_Customer();
                    }
                }
            }
            else
            {
                if (salitem == "ALL")
                {
                    if (salcust == "ALL")
                    {
                        //All I, C take s
                        var filteredDataCustomer = from m in db.Sale_Details
                                           where m.SaleDate >= startDate && m.SaleDate <= endDate
                                           && m.SaleType.Equals(cmbSalesType.Text)
                                           group m by m.Cust_Name into g
                                           let itemcount = g.Sum(m => m.Qty)
                                           let amount = g.Sum(m => m.SaleAmount)
                                           orderby itemcount descending
                                           select new { ItemName = g.Key, itemcount, amount };

                        dataGridViewSalesReport.DataSource = filteredDataCustomer.Select(o => new
                        {
                            Customer = o.ItemName,
                            Quantity = o.itemcount,
                            SubAmount = (decimal)o.amount / (decimal)1.13,
                            VAT = (decimal)o.amount - (decimal)o.amount / (decimal)1.13,
                            Amount = o.amount
                        }).ToList();
                        display_amount_in_Customer();
                    }
                    else
                    {
                        //All I, take s and c
                        var filteredDataCustomer = from m in db.Sale_Details
                                           where m.SaleDate >= startDate && m.SaleDate <= endDate
                                           && m.SaleType.Equals(cmbSalesType.Text)
                                           && m.Cust_Name.Equals(cmbCustomer.Text)
                                           group m by m.Cust_Name into g
                                           let itemcount = g.Sum(m => m.Qty)
                                           let amount = g.Sum(m => m.SaleAmount)
                                           orderby itemcount descending
                                           select new { ItemName = g.Key, itemcount, amount };

                        dataGridViewSalesReport.DataSource = filteredDataCustomer.Select(o => new
                        {
                            Customer = o.ItemName,
                            Quantity = o.itemcount,
                            SubAmount = (decimal)o.amount / (decimal)1.13,
                            VAT = (decimal)o.amount - (decimal)o.amount / (decimal)1.13,
                            Amount = o.amount
                        }).ToList();
                        display_amount_in_Customer();
                    }
                }
                else
                {
                    if (salcust == "ALL")
                    {
                        //All C, take s, i
                        var filteredDataCustomer = from m in db.Sale_Details
                                           where m.SaleDate >= startDate && m.SaleDate <= endDate
                                           && m.SaleType.Equals(cmbSalesType.Text)
                                           && m.Item_Name.Equals(cmbSalesItem.Text)
                                           group m by m.Cust_Name into g
                                           let itemcount = g.Sum(m => m.Qty)
                                           let amount = g.Sum(m => m.SaleAmount)
                                           orderby itemcount descending
                                           select new { ItemName = g.Key, itemcount, amount };

                        dataGridViewSalesReport.DataSource = filteredDataCustomer.Select(o => new
                        {
                            Customer = o.ItemName,
                            Quantity = o.itemcount,
                            SubAmount = (decimal)o.amount / (decimal)1.13,
                            VAT = (decimal)o.amount - (decimal)o.amount / (decimal)1.13,
                            Amount = o.amount
                        }).ToList();
                        display_amount_in_Customer();
                    }
                    else
                    {
                        //All none, take all three
                        var filteredDataCustomer = from m in db.Sale_Details
                                           where m.SaleDate >= startDate && m.SaleDate <= endDate
                                           && m.SaleType.Equals(cmbSalesType.Text)
                                           && m.Item_Name.Equals(cmbSalesItem.Text)
                                           && m.Cust_Name.Equals(cmbCustomer.Text)
                                           group m by m.Cust_Name into g
                                           let itemcount = g.Sum(m => m.Qty)
                                           let amount = g.Sum(m => m.SaleAmount)
                                           orderby itemcount descending
                                           select new { ItemName = g.Key, itemcount, amount };

                        dataGridViewSalesReport.DataSource = filteredDataCustomer.Select(o => new
                        {
                            Customer = o.ItemName,
                            Quantity = o.itemcount,
                            SubAmount = (decimal)o.amount / (decimal)1.13,
                            VAT = (decimal)o.amount - (decimal)o.amount / (decimal)1.13,
                            Amount = o.amount
                        }).ToList();
                        display_amount_in_Customer();
                    }
                }
            }
        }

        private void display_amount_in_Customer()
        {
            for (int i = 0; i < dataGridViewSalesReport.Rows.Count; ++i)
            {

                sum += Convert.ToInt32(dataGridViewSalesReport.Rows[i].Cells[4].Value);
                qtysum += Convert.ToInt32(dataGridViewSalesReport.Rows[i].Cells[1].Value);

            }
            BottomLabel_Calc();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(dateTimePickerStartDate.Value.Date);
            DateTime endDate = Convert.ToDateTime(dateTimePickerEndDate.Value);
            var saltype = cmbSalesType.Text;
            var salitem = cmbSalesItem.Text;
            var salcust = cmbCustomer.Text;
            lblQty.Show(); lblQtyInfo.Show();
            lblInfo.Show(); lblAmount.Show();
            lblSubTotalLabel.Show(); lblSubTotal.Show();
            lblVATLabel.Show(); lblVAT.Show();
            if (saltype == "ALL")
            {
                if (salitem == "ALL")
                {
                    if (salcust == "ALL")
                    {
                        //All S,I,C
                        var filteredData = from m in db.Sale_Details
                                               where m.SaleDate >= startDate && m.SaleDate <= endDate
                                               group m by m.Item_Name into g
                                               let itemcount = g.Sum(m => m.Qty)
                                               let amount = g.Sum(m => m.SaleAmount)
                                               orderby itemcount descending
                                               select new { ItemName = g.Key, itemcount, amount };

                        dataGridViewSalesReport.DataSource = filteredData.Select(o => new
                        {
                            Item = o.ItemName,
                            Quantity = o.itemcount,
                            Amount = o.amount
                        }).ToList();
                        //Populate total amount from grid data
                        display_amount_in_Item();
                    }
                    else //cust
                    {
                        //All S,I take C
                        var filteredData = from m in db.Sale_Details
                                           where m.SaleDate >= startDate && m.SaleDate <= endDate
                                           && m.Cust_Name.Equals(cmbCustomer.Text)
                                           group m by m.Item_Name into g
                                           let itemcount = g.Sum(m => m.Qty)
                                           let amount = g.Sum(m => m.SaleAmount)
                                           orderby itemcount descending
                                           select new { ItemName = g.Key, itemcount, amount };

                        dataGridViewSalesReport.DataSource = filteredData.Select(o => new
                        {
                            Item = o.ItemName,
                            Quantity = o.itemcount,
                            Amount = o.amount
                        }).ToList();
                        display_amount_in_Item();
                    }
                }
                else
                {
                    if (salcust == "ALL")
                    {
                        //All S,C take I
                        var filteredData = from m in db.Sale_Details
                                           where m.SaleDate >= startDate && m.SaleDate <= endDate
                                           && m.Item_Name.Equals(cmbSalesItem.Text)
                                           group m by m.Item_Name into g
                                           let itemcount = g.Sum(m => m.Qty)
                                           let amount = g.Sum(m => m.SaleAmount)
                                           orderby itemcount descending
                                           select new { ItemName = g.Key, itemcount, amount };

                        dataGridViewSalesReport.DataSource = filteredData.Select(o => new
                        {
                            Item = o.ItemName,
                            Quantity = o.itemcount,
                            Amount = o.amount
                        }).ToList();
                        display_amount_in_Item();
                    }
                    else
                    {
                        //All S take I and C
                        var filteredData = from m in db.Sale_Details
                                           where m.SaleDate >= startDate && m.SaleDate <= endDate
                                           && m.Item_Name.Equals(cmbSalesItem.Text)
                                           && m.Cust_Name.Equals(cmbCustomer.Text)
                                           group m by m.Item_Name into g
                                           let itemcount = g.Sum(m => m.Qty)
                                           let amount = g.Sum(m => m.SaleAmount)
                                           orderby itemcount descending
                                           select new { ItemName = g.Key, itemcount, amount };

                        dataGridViewSalesReport.DataSource = filteredData.Select(o => new
                        {
                            Item = o.ItemName,
                            Quantity = o.itemcount,
                            Amount = o.amount
                        }).ToList();
                        display_amount_in_Item();
                    }
                }
            }
            else
            {
                if (salitem == "ALL")
                {
                    if (salcust == "ALL")
                    {
                        //All I, C take s
                        var filteredData = from m in db.Sale_Details
                                           where m.SaleDate >= startDate && m.SaleDate <= endDate
                                           && m.SaleType.Equals(cmbSalesType.Text)
                                           group m by m.Item_Name into g
                                           let itemcount = g.Sum(m => m.Qty)
                                           let amount = g.Sum(m => m.SaleAmount)
                                           orderby itemcount descending
                                           select new { ItemName = g.Key, itemcount, amount };

                        dataGridViewSalesReport.DataSource = filteredData.Select(o => new
                        {
                            Item = o.ItemName,
                            Quantity = o.itemcount,
                            Amount = o.amount
                        }).ToList();
                        display_amount_in_Item();
                    }
                    else
                    {
                        //All I, take s and c
                        var filteredData = from m in db.Sale_Details
                                           where m.SaleDate >= startDate && m.SaleDate <= endDate
                                           && m.SaleType.Equals(cmbSalesType.Text)
                                           && m.Cust_Name.Equals(cmbCustomer.Text)
                                           group m by m.Item_Name into g
                                           let itemcount = g.Sum(m => m.Qty)
                                           let amount = g.Sum(m => m.SaleAmount)
                                           orderby itemcount descending
                                           select new { ItemName = g.Key, itemcount, amount };

                        dataGridViewSalesReport.DataSource = filteredData.Select(o => new
                        {
                            Item = o.ItemName,
                            Quantity = o.itemcount,
                            Amount = o.amount
                        }).ToList();
                        display_amount_in_Item();
                    }
                }
                else
                {
                    if (salcust == "ALL")
                    {
                        //All C, take s, i
                        var filteredData = from m in db.Sale_Details
                                           where m.SaleDate >= startDate && m.SaleDate <= endDate
                                           && m.SaleType.Equals(cmbSalesType.Text)
                                           && m.Item_Name.Equals(cmbSalesItem.Text)
                                           group m by m.Item_Name into g
                                           let itemcount = g.Sum(m => m.Qty)
                                           let amount = g.Sum(m => m.SaleAmount)
                                           orderby itemcount descending
                                           select new { ItemName = g.Key, itemcount, amount };

                        dataGridViewSalesReport.DataSource = filteredData.Select(o => new
                        {
                            Item = o.ItemName,
                            Quantity = o.itemcount,
                            Amount = o.amount
                        }).ToList();
                        display_amount_in_Item();
                    }
                    else
                    {
                        //All none, take all three
                        var filteredData = from m in db.Sale_Details
                                           where m.SaleDate >= startDate && m.SaleDate <= endDate
                                           && m.SaleType.Equals(cmbSalesType.Text)
                                           && m.Item_Name.Equals(cmbSalesItem.Text)
                                           && m.Cust_Name.Equals(cmbCustomer.Text)
                                           group m by m.Item_Name into g
                                           let itemcount = g.Sum(m => m.Qty)
                                           let amount = g.Sum(m => m.SaleAmount)
                                           orderby itemcount descending
                                           select new { ItemName = g.Key, itemcount, amount };

                        dataGridViewSalesReport.DataSource = filteredData.Select(o => new
                        {
                            Item = o.ItemName,
                            Quantity = o.itemcount,
                            Amount = o.amount
                        }).ToList();
                        display_amount_in_Item();
                    }
                }
            }
        }

        private void display_amount_in_Item()
        {
            for (int i = 0; i < dataGridViewSalesReport.Rows.Count; ++i)
            {

                sum += Convert.ToInt32(dataGridViewSalesReport.Rows[i].Cells[2].Value);
                qtysum += Convert.ToInt32(dataGridViewSalesReport.Rows[i].Cells[1].Value);

            }
            BottomLabel_Calc();
        }

        private void btnBillWise_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(dateTimePickerStartDate.Value.Date);
            DateTime endDate = Convert.ToDateTime(dateTimePickerEndDate.Value);
            var saltype = cmbSalesType.Text;
            var salcust = cmbCustomer.Text;
            lblQty.Hide(); lblQtyInfo.Hide();
            lblInfo.Show(); lblAmount.Show();
            lblSubTotalLabel.Show(); lblSubTotal.Show();
            lblVATLabel.Show(); lblVAT.Show();
            if (saltype == "ALL")
            {
                if(salcust=="ALL") //ALL S, C
                {
                    var filteredData = db.Sales.Where(t => t.SaleDate >= startDate
                                                    && t.SaleDate <= endDate);
                    GridView_Billwise(filteredData);
                }
                else // All S No C
                {
                    var filteredData = db.Sales.Where(t => t.SaleDate >= startDate
                                                    && t.SaleDate <= endDate
                                                    && t.Cust_Name==cmbCustomer.Text);
                    GridView_Billwise(filteredData);
                }
            }
            else 
            {
                if (salcust == "ALL")// All C No S
                {
                    var filteredData = db.Sales.Where(t => t.SaleDate >= startDate
                                                    && t.SaleDate <= endDate
                                                    && t.SaleType==cmbSalesType.Text);
                    GridView_Billwise(filteredData);
                }
                else //No S and C
                {
                    var filteredData = db.Sales.Where(t => t.SaleDate >= startDate
                                                    && t.SaleDate <= endDate
                                                    && t.Cust_Name == cmbCustomer.Text
                                                    && t.SaleType == cmbSalesType.Text);
                    GridView_Billwise(filteredData);
                }
            }
        }

        private void GridView_Billwise(IQueryable<Sale> filteredData)
        {
            dataGridViewSalesReport.DataSource = filteredData.Select(o => new
            {
                Bill_No = o.SaleID,
                SubAmount = o.SubAmount,
                VAT = o.VAT,
                Sale_Amount = o.SaleAmount,
                Sale_Type = o.SaleType,
                Customer = o.Cust_Name,
                Sale_Date = o.SaleDate
            }).ToList();
            //Populate total amount from grid data
            for (int i = 0; i < dataGridViewSalesReport.Rows.Count; ++i)
            {

                sum += Convert.ToInt32(dataGridViewSalesReport.Rows[i].Cells[3].Value);
            }
            BottomLabel_Calc();
        }

        private void btnDateWise_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(dateTimePickerStartDate.Value.Date);
            DateTime endDate = Convert.ToDateTime(dateTimePickerEndDate.Value);
            var saltype = cmbSalesType.Text;
            var salcust = cmbCustomer.Text;
            lblQty.Hide(); lblQtyInfo.Hide();
            lblInfo.Show(); lblAmount.Show();
            lblSubTotalLabel.Show(); lblSubTotal.Show();
            lblVATLabel.Show(); lblVAT.Show();
            if (saltype == "ALL")
            {
                if (salcust == "ALL") //ALL S, C
                {
                    //var filteredDataDateWise = from m in db.Sale_Details
                    //                   where m.SaleDate >= startDate && m.SaleDate <= endDate
                    //                   group m by m.SaleDate into g
                    //                   let Sale_Amount = g.Sum(m => m.SaleAmount)
                    //                   select new { Sale_Date = g.Key, Sale_Amount };

                    var filteredDataDatewise = from m in db.Sales
                                               where m.SaleDate >= startDate && m.SaleDate <= endDate
                                               group m by m.SaleDate into g
                                               let SubAmount = g.Sum(m => m.SubAmount)
                                               let VAT = g.Sum(m => m.VAT)
                                               let Amount = g.Sum(m => m.SaleAmount)
                                               select new { Sale_Date = g.Key, SubAmount, VAT, Amount };

                    dataGridViewSalesReport.DataSource = filteredDataDatewise.Select(o => new
                    {
                        Sale_Date = o.Sale_Date,
                        SubAmount = o.SubAmount,
                        VAT = o.VAT,
                        Amount = o.Amount
                    }).ToList();
                    display_amount_in_Datewise();
                }
                else // All S No C
                {
                    var filteredDataDatewise = from m in db.Sales
                                       where m.SaleDate >= startDate && m.SaleDate <= endDate
                                                                     && m.Cust_Name==cmbCustomer.Text
                                               group m by m.SaleDate into g
                                               let SubAmount = g.Sum(m => m.SubAmount)
                                               let VAT = g.Sum(m => m.VAT)
                                               let Amount = g.Sum(m => m.SaleAmount)
                                               select new { Sale_Date = g.Key, SubAmount, VAT, Amount };

                    dataGridViewSalesReport.DataSource = filteredDataDatewise.Select(o => new
                    {
                        Sale_Date = o.Sale_Date,
                        SubAmount = o.SubAmount,
                        VAT = o.VAT,
                        Amount = o.Amount
                    }).ToList();
                    display_amount_in_Datewise();
                }
            }
            else
            {
                if (salcust == "ALL")// All C No S
                {
                    var filteredDataDatewise = from m in db.Sales
                                       where m.SaleDate >= startDate && m.SaleDate <= endDate
                                                                     && m.SaleType==cmbSalesType.Text
                                               group m by m.SaleDate into g
                                               let SubAmount = g.Sum(m => m.SubAmount)
                                               let VAT = g.Sum(m => m.VAT)
                                               let Amount = g.Sum(m => m.SaleAmount)
                                               select new { Sale_Date = g.Key, SubAmount, VAT, Amount };

                    dataGridViewSalesReport.DataSource = filteredDataDatewise.Select(o => new
                    {
                        Sale_Date = o.Sale_Date,
                        SubAmount = o.SubAmount,
                        VAT = o.VAT,
                        Amount = o.Amount
                    }).ToList();
                    display_amount_in_Datewise();
                }
                else //No S and C
                {
                    var filteredDataDatewise = from m in db.Sales
                                       where m.SaleDate >= startDate && m.SaleDate <= endDate
                                                                     && m.Cust_Name == cmbCustomer.Text
                                                                     && m.SaleType == cmbSalesType.Text
                                               group m by m.SaleDate into g
                                               let SubAmount = g.Sum(m => m.SubAmount)
                                               let VAT = g.Sum(m => m.VAT)
                                               let Amount = g.Sum(m => m.SaleAmount)
                                               select new { Sale_Date = g.Key, SubAmount, VAT, Amount };

                    dataGridViewSalesReport.DataSource = filteredDataDatewise.Select(o => new
                    {
                        Sale_Date = o.Sale_Date,
                        SubAmount = o.SubAmount,
                        VAT = o.VAT,
                        Amount = o.Amount
                    }).ToList();
                    display_amount_in_Datewise();
                }
            }
        }

        private void display_amount_in_Datewise()
        {
            for (int i = 0; i < dataGridViewSalesReport.Rows.Count; ++i)
            {

                sum += Convert.ToInt32(dataGridViewSalesReport.Rows[i].Cells[3].Value);
            }
            BottomLabel_Calc();
        }
    }
}
