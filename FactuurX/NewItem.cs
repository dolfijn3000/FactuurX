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
        public NewItem()
        {
            InitializeComponent();
        }

        public EventHandler<CustomEventArgs> AddedItem;
        List<string> textList = new List<string>();

        //add al information into a list and send it to the caller
        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            textList.Add(TXT_Name.Text);
            textList.Add(TXT_Price.Text);
            textList.Add(TXT_referenceNumber.Text);
            if (AddedItem != null)
                AddedItem(this, new CustomEventArgs() { texts = textList });
            this.Close();
        }
    }
}
