using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FactuurX.Handlers
{
    class UpdateHandler
    {
        public bool CheckForUpdate()
        {
            bool updateAvaible = false;

            using (var client = new WebClient())
            {
                client.DownloadFile("https://doc-0s-98-docs.googleusercontent.com/docs/securesc/8e7cpeoaf3qq62bubfuqrjiolrli9ekb/nc840g17aqod1vupa30mrnrsej7fei70/1570377600000/17710259923542319496/17710259923542319496/1yje9FP70_5DqY24q2vVgzh7DpBgzuEH5?e=download&nonce=3s58ktab4rfhm&user=17710259923542319496&hash=414et4sp9a2rj05pjosq851pe5fijbvl", "v.txt");
            }
            string[] lines = File.ReadAllLines("v.txt");
            if(lines[0] == Form1.settings.version)
            {
                updateAvaible = false;
            }
            else
            {
                updateAvaible = false;
            }

            return updateAvaible;
        }

        public void update()
        {

        }
    }
}
