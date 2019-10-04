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

            SaveHandler saveHandler = new SaveHandler();
            Form1.settings.LastProfilePath = filePath;
            saveHandler.SaveSettings();
        }
        public void LoadInvoice(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Invoice));

            StreamReader reader = new StreamReader(filePath);
            Form1.invoice = (Invoice)serializer.Deserialize(reader);
            reader.Close();
        }

        public void LoadSettings()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            string AppdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            StreamReader reader = new StreamReader(AppdataPath + "\\FactuurX\\settings.FACTXS");
            Form1.settings = (Settings)serializer.Deserialize(reader);
            reader.Close();
        }
    }
}
