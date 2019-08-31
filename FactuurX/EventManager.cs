using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactuurX
{
    class EventManager
    {
        public void Setup()
        {
         
        }

        public void OnCreatedProfile(object source, CustomEventArgs customEventArgs)
        {
            Profile newProfile = new Profile();
            newProfile.name = customEventArgs.text;

            //temporary until there is a save system
            Form1.selectedProfile = newProfile;
        }
    }
}
