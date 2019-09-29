using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FactuurX
{
    class LoadHandler
    {
        public void LoadProfile(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Profile));

            StreamReader reader = new StreamReader(filePath);
            Form1.selectedProfile = (Profile)serializer.Deserialize(reader);
            reader.Close();
        }
        public void LoadInvoice(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Invoice));

            StreamReader reader = new StreamReader(filePath);
            Form1.invoice = (Invoice)serializer.Deserialize(reader);
            reader.Close();
        }
    }
}
