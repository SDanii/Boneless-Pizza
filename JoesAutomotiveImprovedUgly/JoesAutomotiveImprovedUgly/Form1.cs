using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoesAutomotiveImprovedUgly
{
    public partial class joesAutomotiveMain : Form
    {
        public joesAutomotiveMain()
        {
            InitializeComponent();
        }

        private void joesAutomotiveMain_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vehicleButton_Click(object sender, EventArgs e)
        {
            Form Vehicle = new Vehicle();
            Vehicle.Show();
        }

        private void partsButton_Click(object sender, EventArgs e)
        {
            Form Parts = new Parts();
            Parts.Show();
        }

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            Form Invoice = new Invoice();
            Invoice.Show();
        }
    }
}
