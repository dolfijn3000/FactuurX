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
    public partial class Form1 : Form
    {
        public static Profile selectedProfile;
        EventManager eventManager = new EventManager();

        public Form1()
        {
            InitializeComponent();
            EventManager eventManager = new EventManager();
            eventManager.Setup();
        }

        private void bestandToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NieuwToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProfileCreator profileCreator = new ProfileCreator();
            profileCreator.Show();

         

            profileCreator.CreationCompleted += eventManager.OnCreatedProfile;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            newCustomer.Show();


            newCustomer.AddedCustomer += eventManager.OnCreatedCustomer;

        }
    }
}
