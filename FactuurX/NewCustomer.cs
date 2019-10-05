using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactuurX
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {

        }

        public EventHandler<CustomEventArgs> AddedCustomer;
        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.name = TXT_Name.Text;
            customer.street = TXT_Street.Text;
            customer.municipality = TXT_Municipality.Text;
            customer.BTWnumber = TXT_btwNumber.Text;

            if (AddedCustomer != null)
                AddedCustomer(this, new CustomEventArgs() { customer = customer });
            this.Close();
        }
    }
}
