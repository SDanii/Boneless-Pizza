
﻿using System;
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
    public partial class Parts : Form
    {
        public Parts()
        {
            InitializeComponent();
        }

        private void homeButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            tempListBox.Items.Add(txtBoxRecent.Text);
            txtBoxRecent.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBoxPartAva.Items.Add(txtBoxAvaliable.Text);
            txtBoxAvaliable.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtBoxSearch.Text;
            foreach(var item in listBoxPartAva.Items)
            {
                if (item.ToString() == search)
                {
                    MessageBox.Show("Item is avaliable.");
                }
                else 
                {
                    
                }
            }
        }
    }
}
 master
