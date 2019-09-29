using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public static Invoice invoice = new Invoice();

        //all date for in the table
        DataTable dataTable = new DataTable();

        // here we put al our events.
        EventManager eventManager = new EventManager();

        public Form1()
        {
            InitializeComponent();
            EventManager eventManager = new EventManager();

            dataTable.Columns.Add("naam", typeof(string));
            dataTable.Columns.Add("referentie nummer", typeof(string));
            dataTable.Columns.Add("prijs", typeof(string));
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
            itemsPage.SelectedItem += OnSelectedItem;
            //add all customers to the list
            foreach (Item item in selectedProfile.Items)
            {               
                itemsPage.LB_Items.Items.Add(item);
            }

            itemsPage.Show();
        }

        private void OnSelectedItem(object source, CustomEventArgs customEventArgs)
        {
            Item item = customEventArgs.item;

            dataTable.Rows.Add(item.name,item.referenceNumber,item.price);

            DGV_Items.DataSource = dataTable;
        }

        private void opslaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveHandler saveHandler = new SaveHandler();

            saveHandler.SaveInvoice(DGV_Items);
        }

        private void opslaanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveHandler saveHandler = new SaveHandler();

            saveHandler.SaveProfile(selectedProfile);
        }

        private void selecteerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "factuur x bestand (*.FACTX)|*.FACTX";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            LoadHandler loadHandler = new LoadHandler();
            loadHandler.LoadProfile(filePath);

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "factuur x bestand (*.FACTX)|*.FACTX";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            LoadHandler loadHandler = new LoadHandler();
            loadHandler.LoadInvoice(filePath);

            Refresh();
        }

        //refresh data
        public void Refresh()
        {
            //load data from invoice
            foreach(Item item in invoice.items)
            {
                dataTable.Rows.Add(item.name, item.referenceNumber, item.price);

                
            }
            DGV_Items.DataSource = dataTable;
        }
    }
}
