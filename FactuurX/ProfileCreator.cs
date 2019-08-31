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
    public partial class ProfileCreator : Form
    {
        public ProfileCreator()
        {
            InitializeComponent();
        }

        public EventHandler<CustomEventArgs> CreationCompleted;
        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            if (CreationCompleted != null)
                CreationCompleted(this, new CustomEventArgs() { text = TXT_Name.Text });
        }

        private void ProfileCreator_Load(object sender, EventArgs e)
        {

        }
    }
}
