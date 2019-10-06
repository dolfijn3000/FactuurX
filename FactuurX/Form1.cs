using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using HtmlAgilityPack;
using FactuurX.Handlers;
using PdfSharp.Pdf;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using PdfSharp;
using IronPdf;
using PuppeteerSharp;

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
                customerSelect.LB_Customers.Items.Add(customer);
            }

            customerSelect.Show();

            //bind event
            customerSelect.Selected += OnSelectedCustomer;
        }

        //when customer is selected
        public void OnSelectedCustomer(object source, CustomEventArgs customEventArgs)
        {
            selectedCustomer = customEventArgs.customer;

            TXT_CustomerName.Text = selectedCustomer.name;
            TXT_Street.Text = selectedCustomer.street;
            TXT_Municipality.Text = selectedCustomer.municipality;
            TXT_btwNumber.Text = selectedCustomer.BTWnumber.ToString();
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
            item = customEventArgs.item;

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

            double totalPrice = 0;

            if (item.price != null && item.price != "")
            {
                totalPrice = double.Parse(customEventArgs.amount) * double.Parse(item.price);
            }

            dataTable.Rows.Add(item.name, item.referenceNumber,customEventArgs.amount, item.price + item.unit, totalPrice);

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
                        LoadHandler loadHandler = new LoadHandler();
                        loadHandler.LoadProfile(filePath);
                        CheckForProfile();
                    }
                }
            }

           

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
                        LoadHandler loadHandler = new LoadHandler();
                        loadHandler.LoadInvoice(filePath);
                    }
                }
            }


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
            string path = "";
            if (CB_Language.Text == "nederlands" || CB_Language.Text == "")
            {
               path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Assets\standart.html");
            }

            if (CB_Language.Text == "frans")
            {
                path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Assets\standartfrans.html");
            }

            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(path);

            var table = doc.GetElementbyId("items");

            double totalPrice = 0;
            int counter = 1;

            HtmlNodeCollection rows = table.SelectNodes("//tr");

            for (int r = 0; r < DGV_Items.Rows.Count -1; r++)
            {
                    DataGridViewRow dgv_row = DGV_Items.Rows[r];
                    table.InsertAfter(HtmlNode.CreateNode("<tr id=" + counter.ToString() + "></tr>"), doc.GetElementbyId("0") );
                    var row = doc.GetElementbyId(counter.ToString());

                    //row.AppendChild(HtmlNode.CreateNode("<th>"+ dgv_row.Cells["naam"].Value + "</th>"));

                    //artikel
                    row.AppendChild(HtmlNode.CreateNode("<td>" + dgv_row.Cells["referentie nummer"].Value + "</td>"));

                    //beschijving
                    row.AppendChild(HtmlNode.CreateNode("<td>" + dgv_row.Cells["naam"].Value + "</td>"));
                    //aantal
                    row.AppendChild(HtmlNode.CreateNode("<td>" + dgv_row.Cells["aantal"].Value + "</td>"));
                    //eenheidprijs
                    row.AppendChild(HtmlNode.CreateNode("<td>" + dgv_row.Cells["eenheidprijs"].Value + "</td>"));
                    //bedrag
                    row.AppendChild(HtmlNode.CreateNode("<td>" + dgv_row.Cells["prijs"].Value + "</td>"));

                    string price = dgv_row.Cells["prijs"].Value.ToString();
                    if (price != "")
                    {
                        totalPrice += double.Parse(price);
                    }
                
                counter++;
            }
            //add customer data
            var customerTable = doc.GetElementbyId("customer");
            customerTable.AppendChild(HtmlNode.CreateNode("<p>" + selectedCustomer.name + "</p>"));
            customerTable.AppendChild(HtmlNode.CreateNode("<p>" + selectedCustomer.street + "</p>"));
            customerTable.AppendChild(HtmlNode.CreateNode("<p>" + selectedCustomer.municipality + "</p>"));
            customerTable.AppendChild(HtmlNode.CreateNode("<p>" + selectedCustomer.BTWnumber + "</p>"));

            //total price calculations
            var TotalExcl = doc.GetElementbyId("total-priceExcl");
            var ParentNode = TotalExcl.ParentNode;
            ParentNode.ReplaceChild(HtmlNode.CreateNode("<td>" + totalPrice + "</td>"),TotalExcl);

            //btw calculation
            var btw = doc.GetElementbyId("BTW");
            ParentNode = btw.ParentNode;
            ParentNode.ReplaceChild(HtmlNode.CreateNode("<td>" + (totalPrice / 100) * 21 + "</td>"), btw);

            //total calculation
            var total = doc.GetElementbyId("total-priceIncl");
            ParentNode = total.ParentNode;
            ParentNode.ReplaceChild(HtmlNode.CreateNode("<td>" + (((totalPrice / 100) * 21) + totalPrice) + "</td>"), total);

            //date and invoice number
            var invoiceNumber = doc.GetElementbyId("invoicenumber");
            ParentNode = invoiceNumber.ParentNode;
            ParentNode.ReplaceChild(HtmlNode.CreateNode("<td> Factuur nr:" + TXT_InvoiceNumber.Text + "</td>"), invoiceNumber);

            var date = doc.GetElementbyId("date");
            ParentNode = date.ParentNode;
            ParentNode.ReplaceChild(HtmlNode.CreateNode("<td> Datum:" + TXT_Date.Text + "</td>"), date);

            WB_Preview.DocumentText = doc.DocumentNode.OuterHtml;
           
        }

        public void GenerateInvoiceHtml(string template)
        {

        }

        //export invoice to odf
        private void exporteerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            BTN_Generate.PerformClick();
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "PDF (*.pdf)|*.pdf";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    var fileStream = myStream as FileStream;

                    Console.WriteLine(fileStream.Name + "path");

                    string path = fileStream.Name;

                    fileStream.Close();
                    myStream.Close();

                    Renderer.RenderHtmlAsPdf(WB_Preview.DocumentText).SaveAs(path);               
                }
            }
        }

        private void BTN_Extra_Click(object sender, EventArgs e)
        {
            Extra extra = new Extra();
            extra.Show();
            extra.AddedExtra += this.OnCreatedExtra;
        }

        public void OnCreatedExtra(object source, CustomEventArgs customEventArgs)
        {
            dataTable.Rows.Add(customEventArgs.text, string.Empty, string.Empty, string.Empty, null);
            DGV_Items.DataSource = dataTable;
        }

        private void klantenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            UpdateHandler updateHandler = new UpdateHandler();
            if(updateHandler.CheckForUpdate())
            {

            }

            EventManager eventManager = new EventManager();
            StartupHandler startupHandler = new StartupHandler();
            startupHandler.Startup();

            dataTable.Columns.Add("naam", typeof(string));
            dataTable.Columns.Add("referentie nummer", typeof(string));
            dataTable.Columns.Add("aantal", typeof(string));
            dataTable.Columns.Add("eenheidprijs", typeof(string));
            dataTable.Columns.Add("prijs", typeof(double));
            eventManager.Setup();
            CheckForProfile();
        }

        public void CheckForProfile()
        {
            if(selectedProfile != null)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                BTN_Extra.Enabled = true;
                BTN_Generate.Enabled = true;
            }
        }
    }
}
