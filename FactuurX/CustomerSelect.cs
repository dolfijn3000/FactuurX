using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactuurX
{
    public partial class CustomerSelect : Form
    {
        public CustomerSelect()
        {
            InitializeComponent();
        }

        public EventHandler<CustomEventArgs> Selected;
        public Customer selectedCustomer;

        private void BTN_Ok_Click(object sender, EventArgs e)
        {          

            if (Selected != null)
                Selected(this, new CustomEventArgs() { customer = selectedCustomer });
            this.Close();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)LB_Customers.SelectedItem;
            Customer customer2 = Form1.selectedProfile.customers.Find(x => x.name == customer.name);
            Form1.selectedProfile.customers.Remove(customer2);
            LB_Customers.Items.Remove(customer);
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)LB_Customers.SelectedItem;

            NewCustomer newCustomer = new NewCustomer();
            newCustomer.TXT_Name.Text = customer.name;
            newCustomer.TXT_Street.Text = customer.street;
            newCustomer.TXT_Municipality.Text = customer.municipality;
            newCustomer.TXT_btwNumber.Text = customer.BTWnumber;

            newCustomer.editMode = true;
            newCustomer.EditedCustomer += Refresh;

            newCustomer.Show();
        }

        public void Refresh(object sender, CustomEventArgs e)
        {
            int index;
            index = Form1.selectedProfile.customers.FindIndex(x => x.name == LB_Customers.SelectedItem.ToString());
            LB_Customers.Items.Clear();

            Form1.selectedProfile.customers[index] = e.customer;

            foreach (Customer customer in Form1.selectedProfile.customers)
            {
                LB_Customers.Items.Add(customer);
            }

            if (LB_Customers.SelectedItem == null)
            {
                BTN_Ok.Enabled = false;
            }
        }

        private void LB_Customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_Customers.SelectedItem != null)
            {
                BTN_Ok.Enabled = true;
            }
            try
            {
                selectedCustomer = Form1.selectedProfile.customers.Find(x => x.name == LB_Customers.SelectedItem.ToString());
            }
            catch
            {

            }
           
        }

        private void TXT_Search_TextChanged(object sender, EventArgs e)
        {
            LB_Customers.Items.Clear();

            foreach (Customer customer in Form1.selectedProfile.customers)
            {
                if (customer.name.StartsWith(TXT_Search.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    LB_Customers.Items.Add(customer);
                }
            }
        }
    }
}
