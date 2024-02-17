using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SeniorCitizenRecord
{
    public partial class AddProfile : Form
    {
        public AddProfile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Back to Home
        {
            Form2 form = new Form2();
            form.Show(this);
            this.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e) // go to edit profile button
        {
            EditProfile form = new EditProfile();
            form.Show(this);
            this.Hide(); 
        }

        private void button9_Click(object sender, EventArgs e) // go to show table button
        {
            ShowTable form = new ShowTable();
            form.Show(this);
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
