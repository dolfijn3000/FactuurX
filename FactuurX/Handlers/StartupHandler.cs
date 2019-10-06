using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FactuurX.Handlers
{
    class StartupHandler
    {
        public void Startup()
        {
            string AppdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            if (!Directory.Exists(AppdataPath + "\\FactuurX"))
            {
                Directory.CreateDirectory(AppdataPath + "\\FactuurX");
            }

            //if we dont have a settings file create one
            if(!File.Exists(AppdataPath + "\\FactuurX\\settings.FACTXS"))
            {              
                Settings settings = new Settings();

                XmlSerializer ser = new XmlSerializer(typeof(Settings));
                TextWriter textWriter = new StreamWriter(AppdataPath + "\\FactuurX\\settings.FACTXS");

                ser.Serialize(textWriter, settings);

                textWriter.Close();
            }

            LoadHandler loadHandler = new LoadHandler();
            loadHandler.LoadSettings();
            if (Form1.settings.LastProfilePath != null)
            {
                if (Form1.settings.LastProfilePath != "")
                {
                    loadHandler.LoadProfile(Form1.settings.LastProfilePath);
                }
            }


        }
    }
}
