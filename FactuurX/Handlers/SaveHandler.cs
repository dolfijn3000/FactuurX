using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FactuurX
{
    class SaveHandler
    {
        public void SaveProfile(Profile profile)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Profile));

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "factuur x bestand (*.FACTX)|*.FACTX";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {

                    ser.Serialize(myStream,profile);

                    myStream.Close();
                }
            }
        }

        public void SaveInvoice(DataGridView dataGrid)
        {
            //create invoice to save and assign data to it
            Invoice invoice = new Invoice();
            invoice.customer = Form1.selectedCustomer;

            List<Item> items = new List<Item>();
            //load all items in data gridd into a list
            foreach(DataGridViewRow row in dataGrid.Rows)
            {
                Item item = new Item();
                item.name = (string)row.Cells["naam"].Value;
                item.referenceNumber = (string)row.Cells["referentie nummer"].Value;
                item.price = (string)row.Cells["prijs"].Value;

                items.Add(item);
            }

            invoice.items = items;

            //serilize the data
            XmlSerializer ser = new XmlSerializer(typeof(Invoice));

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "factuur x bestand (*.FACTX)|*.FACTX";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {

                    ser.Serialize(myStream, invoice);

                    myStream.Close();
                }
            }
        }

        public void SaveSettings()
        {
            string AppdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            XmlSerializer ser = new XmlSerializer(typeof(Settings));
            TextWriter textWriter = new StreamWriter(AppdataPath + "\\FactuurX\\settings.FACTXS");

            ser.Serialize(textWriter, Form1.settings);

            textWriter.Close();
        }
    }
}
