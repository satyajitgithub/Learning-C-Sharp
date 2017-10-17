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
    public partial class ItemForm : Form
    {
        BillingSystemEntities db = new BillingSystemEntities();
        public ItemForm()
        {
            InitializeComponent();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            panelUpdateItem.Hide();
            //Populate Item grid
            var qry = from i in db.Items 
                      select new {i.ItemID, 
                                  i.ItemName,
                                  i.Qty_In_Hand,
                                  i.Qty_Sold,
                                  i.Last_Purchased_Price,
                                  i.ItemRetailPrice, 
                                  i.ItemWholeSalePrice, 
                                  i.ReOrderLevel,
                                  i.ReOrderQty,
                                  i.PriceLastUpdated};
            
            dataGridViewItemDetail.DataSource = qry.Select(o => new
            {
                SN = o.ItemID,
                Item = o.ItemName,
                Quantity_In_Hand= o.Qty_In_Hand,
                Quantity_Sold = o.Qty_Sold,
                Last_Purchased_Price = o.Last_Purchased_Price,
                Retail_Price = o.ItemRetailPrice,
                WholeSale_Price = o.ItemWholeSalePrice,
                ReOrder_Level = o.ReOrderLevel,
                ReOrder_Quantity = o.ReOrderQty,
                Price_Last_Updated = o.PriceLastUpdated
            }).OrderBy(o => o.SN).ToList();
        }
        //Need to solve for blank value in database error
        private void dataGridViewItemDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelGridContainer.Hide();
            lblItem.Text = dataGridViewItemDetail[0, e.RowIndex].Value.ToString();
            txtItemName.Text = dataGridViewItemDetail[1, e.RowIndex].Value.ToString();
            txtLastPurchasedPrice.Text = dataGridViewItemDetail[4, e.RowIndex].Value.ToString();
            txtRetailPrice.Text = dataGridViewItemDetail[5, e.RowIndex].Value.ToString();
            txtWholeSalePrice.Text = dataGridViewItemDetail[6, e.RowIndex].Value.ToString();
            txtSetReOrderLevel.Text = dataGridViewItemDetail[7, e.RowIndex].Value.ToString();
            txtSetReOrderQty.Text = dataGridViewItemDetail[8, e.RowIndex].Value.ToString();
            lblItem.Hide();
            panelUpdateItem.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelUpdateItem.Hide();
            panelGridContainer.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Item i1 = db.Items.Find(Convert.ToInt32(lblItem.Text)); 
            i1.ItemName = Convert.ToString(txtItemName.Text);
            i1.ReOrderLevel = Convert.ToInt32(txtSetReOrderLevel.Text);
            i1.ReOrderQty = Convert.ToInt32(txtSetReOrderQty.Text);
            i1.ItemRetailPrice = Convert.ToDecimal(txtRetailPrice.Text);
            i1.ItemWholeSalePrice = Convert.ToDecimal(txtWholeSalePrice.Text);
            i1.PriceLastUpdated = DateTime.Now;
            
            db.Entry(i1).State = System.Data.Entity.EntityState.Modified;    
            //db.Items.Attach(i1);
            //db.Items.Add(i1);
            db.SaveChanges();

            panelUpdateItem.Hide();
            //Populate Item grid
            var qry = from i in db.Items
                      select new
                      {
                          i.ItemID,
                          i.ItemName,
                          i.Qty_In_Hand,
                          i.Qty_Sold,
                          i.Last_Purchased_Price,
                          i.ItemRetailPrice,
                          i.ItemWholeSalePrice,
                          i.ReOrderLevel,
                          i.ReOrderQty,
                          i.PriceLastUpdated
                      };

            dataGridViewItemDetail.DataSource = qry.Select(o => new
            {
                SN = o.ItemID,
                Item = o.ItemName,
                Quantity_In_Hand = o.Qty_In_Hand,
                Quantity_Sold = o.Qty_Sold,
                Last_Purchased_Price = o.Last_Purchased_Price,
                Retail_Price = o.ItemRetailPrice,
                WholeSale_Price = o.ItemWholeSalePrice,
                ReOrder_Level = o.ReOrderLevel,
                ReOrder_Quantity = o.ReOrderQty,
                Price_Last_Updated = o.PriceLastUpdated
            }).OrderBy(o => o.SN).ToList();
            panelGridContainer.Show();
        }

        private void btnReOrder_Click(object sender, EventArgs e)
        {
            panelUpdateItem.Hide();
            var filteredData = db.Items.Where(t => t.Qty_In_Hand <= t.ReOrderLevel);

            dataGridViewItemDetail.DataSource = filteredData.Select(o => new
                {
                    Item = o.ItemName,
                    Quantity_In_Hand = o.Qty_In_Hand,
                    Re_Order_Level = o.ReOrderLevel,
                    Re_Order_Quantity = o.ReOrderQty,
                    Last_Purchased_Price = o.Last_Purchased_Price
                }).OrderBy(o => o.Item).ToList();
         }

        private void btnItemView_Click(object sender, EventArgs e)
        {
            panelUpdateItem.Hide();
            //Populate Item grid
            var qry = from i in db.Items
                      select new
                      {
                          i.ItemID,
                          i.ItemName,
                          i.Qty_In_Hand,
                          i.Qty_Sold,
                          i.Last_Purchased_Price,
                          i.ItemRetailPrice,
                          i.ItemWholeSalePrice,
                          i.ReOrderLevel,
                          i.ReOrderQty,
                          i.PriceLastUpdated
                      };

            dataGridViewItemDetail.DataSource = qry.Select(o => new
            {
                SN = o.ItemID,
                Item = o.ItemName,
                Quantity_In_Hand = o.Qty_In_Hand,
                Quantity_Sold = o.Qty_Sold,
                Last_Purchased_Price = o.Last_Purchased_Price,
                Retail_Price = o.ItemRetailPrice,
                WholeSale_Price = o.ItemWholeSalePrice,
                ReOrder_Level = o.ReOrderLevel,
                ReOrder_Quantity = o.ReOrderQty,
                Price_Last_Updated = o.PriceLastUpdated
            }).OrderBy(o => o.SN).ToList();
        }

        private void btnNearingReOrder_Click(object sender, EventArgs e)
        {
            panelUpdateItem.Hide();
            var filteredData = db.Items.Where(t => t.Qty_In_Hand > t.ReOrderLevel
                                                   && t.Qty_In_Hand <= (t.ReOrderLevel*0.25 + t.ReOrderLevel)
                                                   );

            dataGridViewItemDetail.DataSource = filteredData.Select(o => new
            {
                Item = o.ItemName,
                Quantity_In_Hand = o.Qty_In_Hand,
                Re_Order_Level = o.ReOrderLevel,
                Re_Order_Quantity = o.ReOrderQty,
                Last_Purchased_Price = o.Last_Purchased_Price
            }).OrderBy(o => o.Item).ToList();
        }

    }
}
