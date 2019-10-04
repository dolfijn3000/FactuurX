using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using HtmlAgilityPack;
using FactuurX.Handlers;
namespace FactuurX
{
    public partial class Form1 : Form
    {
        public static Profile selectedProfile;
        public static Customer selectedCustomer = new Customer();
        public static Invoice invoice = new Invoice();
        public static Settings settings = new Settings();

        //all date for in the table
        DataTable dataTable = new DataTable();

        // here we put al our events.
        EventManager eventManager = new EventManager();

        public Form1()
        {
            InitializeComponent();
            EventManager eventManager = new EventManager();
            StartupHandler startupHandler = new StartupHandler();
            startupHandler.Startup();

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

        private void WB_Preview_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        //generate html code for invoice
        private void BTN_Generate_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Assets\standart.html");

            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(path);

            var table = doc.DocumentNode.SelectSingleNode("//table");

            int totalPrice = 0;
            int counter = 0;
            for (int r = 0; r < DGV_Items.Rows.Count - 1; r++)
            {
                DataGridViewRow dgv_row = DGV_Items.Rows[r];
                table.AppendChild(HtmlNode.CreateNode("<tr id="+counter.ToString()+"></tr>"));
                var row = doc.GetElementbyId(counter.ToString());

                //naam
                row.AppendChild(HtmlNode.CreateNode("<th>"+ dgv_row.Cells["naam"].Value + "</th>"));
                //refrentie nummer
                row.AppendChild(HtmlNode.CreateNode("<th>" + dgv_row.Cells["naam"].Value + "</th>"));
                //prijs
                row.AppendChild(HtmlNode.CreateNode("<th>" + dgv_row.Cells["prijs"].Value + "</th>"));

                string price = (string)dgv_row.Cells["prijs"].Value;
                totalPrice += Int32.Parse(price);

                counter++;
            }
            table.AppendChild(HtmlNode.CreateNode("<tr id='total price'></tr>"));
            var lastRow = doc.GetElementbyId("total price");
            lastRow.AppendChild(HtmlNode.CreateNode("<th></th>"));
            lastRow.AppendChild(HtmlNode.CreateNode("<th>Totaal:</th>"));
            lastRow.AppendChild(HtmlNode.CreateNode("<th>"+totalPrice+"</th>"));





            WB_Preview.DocumentText = doc.DocumentNode.OuterHtml;
        }

        public void GenerateInvoiceHtml(string template)
        {

        }
    }
}
