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

        //fired when we make a new profile
        public void OnCreatedProfile(object source, CustomEventArgs customEventArgs)
        {
            Profile newProfile = new Profile();
            newProfile.name = customEventArgs.text;

            //temporary until there is a save system
            Form1.selectedProfile = newProfile;
        }

        //when a new customer is created
        public void OnCreatedCustomer(object source, CustomEventArgs customEventArgs)
        {
            Customer customer = new Customer();
            customer = customEventArgs.customer;

            Form1.selectedProfile.customers.Add(customer);

        }
    }
}
