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
    public partial class Items : Form
    {
        Item item = new Item();

        public Items()
        {
            InitializeComponent();
        }
        public EventHandler<CustomEventArgs> SelectedItem;

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if (item != null)
            {
                if (SelectedItem != null)
                    SelectedItem(this, new CustomEventArgs() { item = item});
                this.Close();
            }
        }

        private void Items_Load(object sender, EventArgs e)
        {

        }

        private void LB_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            item = (Item)LB_Items.SelectedItem;
            if (item != null)
            {
                TXT_Name.Text = item.name;
                TXT_Price.Text = item.price;
                TXT_referenceNumber.Text = item.referenceNumber;
            }

        }
    }
}
