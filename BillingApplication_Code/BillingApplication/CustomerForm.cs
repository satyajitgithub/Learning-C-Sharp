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
    public partial class CustomerForm : Form
    {
        BillingSystemEntities db = new BillingSystemEntities();
        public CustomerForm()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            if(cmbExistingCustomer.SelectedIndex == 0)
            {
                txtName.Clear();
                txtAddress.Clear();
                txtPhone.Clear();
                btnUpdate.Enabled = false;
            }
            else
            {
                List<Customer> cust = (from c in db.Customers
                                       select c).ToList();

                cust.Insert(0, new Customer { Name = "View Existing Customer or Select to Edit" });

                cmbExistingCustomer.DataSource = cust.ToList();
                cmbExistingCustomer.ValueMember = "Name";
                btnUpdate.Enabled = true;
                btnSave.Enabled = false;
            }
            btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;

            try
            {
                //Insert into Customer table
                Customer c1 = new Customer();
                c1.Name = Convert.ToString(txtName.Text);
                c1.PhoneNo = Convert.ToString(txtPhone.Text);
                c1.Address = Convert.ToString(txtAddress.Text);
                db.Customers.Add(c1);
                db.SaveChanges();

                txtName.Clear();
                txtPhone.Clear();
                txtAddress.Clear();
                // Load newly added Customer in Cust Combo
                List<Customer> cust = (from c in db.Customers
                                       select c).ToList();

                cust.Insert(0, new Customer { Name = "View Existing Customer or Select to Edit" });

                cmbExistingCustomer.DataSource = cust.ToList();
                cmbExistingCustomer.ValueMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
            cmbExistingCustomer.SelectedIndex = 0;
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }

        private void cmbExistingCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExistingCustomer.SelectedIndex == 0)
            {
                txtName.Clear();
                txtAddress.Clear();
                txtPhone.Clear();
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                if (cmbExistingCustomer.SelectedIndex > 0)
                {
                    txtName.Text = (from c in db.Customers
                                    where c.Name == cmbExistingCustomer.Text
                                    select c.Name).FirstOrDefault().ToString();

                    txtAddress.Text = (from c in db.Customers
                                       where c.Name == cmbExistingCustomer.Text
                                       select c.Address).FirstOrDefault().ToString();
                    txtPhone.Text = (from c in db.Customers
                                     where c.Name == cmbExistingCustomer.Text
                                     select c.PhoneNo).FirstOrDefault().ToString();
                    btnUpdate.Enabled = true;
                    btnSave.Enabled = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {   //Update column field of Customer Table
            var cust = (from c in db.Customers
                        where c.Name == cmbExistingCustomer.Text
                        select c).FirstOrDefault();
            cust.Name = txtName.Text;
            cust.Address = txtAddress.Text;
            cust.PhoneNo = txtPhone.Text;

            int num1 = db.SaveChanges();

            //Update column field of Sale_Details Table
            var salcust = (from sc in db.Sale_Details
                           where sc.Cust_Name == cmbExistingCustomer.Text
                           select sc).ToList();
            for (int i = 0; i < salcust.Count; i++)
            {
                salcust[i].Cust_Name = txtName.Text;
                int num = db.SaveChanges();
            }

            //Update column field of Sale Table
            var saldetcust = (from sdc in db.Sales
                           where sdc.Cust_Name == cmbExistingCustomer.Text
                           select sdc).ToList();
            for (int i = 0; i < saldetcust.Count; i++)
            {
                saldetcust[i].Cust_Name = txtName.Text;
                int num2 = db.SaveChanges();
            }

            //Reload Customer combo with updated cust_info
            List<Customer> custo = (from c in db.Customers
                                   select c).ToList();

            custo.Insert(0, new Customer { Name = "View Existing Customer or Select to Edit" });

            cmbExistingCustomer.DataSource = custo.ToList();
            cmbExistingCustomer.ValueMember = "Name";
            
            cmbExistingCustomer.SelectedIndex = 0;
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            btnUpdate.Enabled = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (btnUpdate.Enabled == true)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }

        
    }
}
