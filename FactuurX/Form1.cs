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
    public partial class Form1 : Form
    {
        public static Profile selectedProfile;
        public static Customer selectedCustomer = new Customer();

        // here we put al our events.
        EventManager eventManager = new EventManager();

        public Form1()
        {
            InitializeComponent();
            EventManager eventManager = new EventManager();
            eventManager.Setup();
        }

        private void bestandToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NieuwToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProfileCreator profileCreator = new ProfileCreator();
            profileCreator.Show();

         

            profileCreator.CreationCompleted += eventManager.OnCreatedProfile;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            newCustomer.Show();


            newCustomer.AddedCustomer += eventManager.OnCreatedCustomer;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open customer select screen
            CustomerSelect customerSelect = new CustomerSelect();

            //add all customers to the list
            foreach(Customer customer in selectedProfile.customers)
            {
                customerSelect.LB_Customers.Items.Add(customer.name);
            }

            customerSelect.Show();

            //bind event
            customerSelect.Selected += OnSelectedCustomer;
        }

        //when customer is selected
        public void OnSelectedCustomer(object source, CustomEventArgs customEventArgs)
        {
            selectedCustomer.name = customEventArgs.text;

            TXT_CustomerName.Text = selectedCustomer.name;
        }

        private void TXT_CustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewItem newItem = new NewItem();
            newItem.Show();
            newItem.AddedItem += this.OnCreatedItem;
        }

        private void OnCreatedItem(object source, CustomEventArgs customEventArgs)
        {
            Item item = new Item();
            item.name = customEventArgs.texts[0];
            item.price =customEventArgs.texts[1];
            item.referenceNumber = customEventArgs.texts[2];

            selectedProfile.Items.Add(item);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Items itemsPage = new Items();
            //add all customers to the list
            foreach (Item customer in selectedProfile.Items)
            {
                itemsPage.LB_Items.Items.Add(customer.name);
            }

            itemsPage.Show();
        }
    }
}
