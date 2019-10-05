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
    public partial class CustomerSelect : Form
    {
        public CustomerSelect()
        {
            InitializeComponent();
        }

        public EventHandler<CustomEventArgs> Selected;
        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            if (Selected != null)
                Selected(this, new CustomEventArgs() { customer = Form1.selectedProfile.customers.Find(x => x.name == LB_Customers.SelectedItem.ToString()) });
            this.Close();
        }
    }
}
