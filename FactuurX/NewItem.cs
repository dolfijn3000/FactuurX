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
    public partial class NewItem : Form
    {
        public bool editMode = false;

        public NewItem()
        {
            InitializeComponent();
        }

        public EventHandler<CustomEventArgs> AddedItem;
        public EventHandler<CustomEventArgs> EditedItem;
        List<string> textList = new List<string>();

        //add al information into a list and send it to the caller
        private void BTN_Ok_Click(object sender, EventArgs e)
        {
          
            if (editMode)
            {
                Item item = new Item();
                item.name = TXT_Name.Text;
                item.price = TXT_Price.Text;
                item.referenceNumber = TXT_referenceNumber.Text;
                item.unit = TXT_Unit.Text;

                if (EditedItem != null)
                    EditedItem(this, new CustomEventArgs() { item = item });
                Close();
            }
            else
            {
                Item item = new Item();
                item.name = TXT_Name.Text;
                item.price = TXT_Price.Text;
                item.referenceNumber = TXT_referenceNumber.Text;
                item.unit = TXT_Unit.Text;

                if (CheckName(item.name))
                {
                    if (AddedItem != null)
                        AddedItem(this, new CustomEventArgs() { item = item });
                    this.Close();
                }
            }
        }

        private void NewItem_Load(object sender, EventArgs e)
        {

        }

        public  bool CheckName(string name)
        {
            bool nameFree = true;
            bool containsItem =Form1.selectedProfile.Items.Any(item => item.name == name);

            if (containsItem)
            {
                string message = "Er bestaat al een item met deze naam.";
                string caption = "ERROR: naam al gebruikt";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    // Closes the parent form.
                    this.Close();
                }
                nameFree = false;
            }


            return nameFree;
        }
    }
}
