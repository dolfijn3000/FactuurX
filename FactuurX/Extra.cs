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
    public partial class Extra : Form
    {
        public Extra()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public EventHandler<CustomEventArgs> AddedExtra;

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            int counter= 0;
            string[] lines = textBox1.Lines;
            foreach (string line in lines)
            {
                lines[counter] = line + "<br>";
                counter++;
            }
            textBox1.Lines = lines;

            if (AddedExtra != null)
                AddedExtra(this, new CustomEventArgs() { text = textBox1.Text });
            this.Close();
        }

        private void Extra_Load(object sender, EventArgs e)
        {

        }
    }
}
