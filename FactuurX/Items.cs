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
                    SelectedItem(this, new CustomEventArgs() { item = item, amount = NUD_Amount.Value.ToString() });
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
                TXT_Unit.Text = item.unit;
            }

            if (LB_Items.SelectedItem != null)
            {
                BTN_Add.Enabled = true;
            }

        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            item = (Item)LB_Items.SelectedItem;
            Item item2 = Form1.selectedProfile.Items.Find(x => x.name == item.name);
            Form1.selectedProfile.Items.Remove(item2);
            LB_Items.Items.Remove(item);
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            NewItem newItem = new NewItem();
            newItem.TXT_Name.Text = TXT_Name.Text;
            newItem.TXT_referenceNumber.Text = TXT_referenceNumber.Text;
            newItem.TXT_Price.Text = TXT_Price.Text;
            newItem.TXT_Unit.Text = TXT_Unit.Text;
            newItem.editMode = true;
            newItem.EditedItem += Refresh;

            newItem.Show();
        }

        public void Refresh(object sender, CustomEventArgs e)
        {
            int index;
            index = Form1.selectedProfile.Items.FindIndex(x => x.name == LB_Items.SelectedItem.ToString());
            LB_Items.Items.Clear();

            Form1.selectedProfile.Items[index] = e.item;

            foreach (Item item in Form1.selectedProfile.Items)
            {
                LB_Items.Items.Add(item);
            }
            if (LB_Items.SelectedItem == null)
            {
                BTN_Add.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LB_Items.Items.Clear();

            foreach (Item item in Form1.selectedProfile.Items)
            {
                if (item.name.StartsWith(textBox1.Text, StringComparison.CurrentCultureIgnoreCase) || item.referenceNumber.StartsWith(textBox1.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    LB_Items.Items.Add(item);
                }
            }
        }
    }
}
