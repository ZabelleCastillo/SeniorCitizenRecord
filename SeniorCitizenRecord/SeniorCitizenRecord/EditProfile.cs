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
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // Add Profile User or client button
        {
            AddProfile form = new AddProfile();
            form.Show(this);
            this.Hide(); 
        }

        private void button1_Click(object sender, EventArgs e) // Back to Home Button
        {
            Form2 form = new Form2();
            form.Show(this);
            this.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e) // go to show table button
        {
            ShowTable form = new ShowTable();
            form.Show(this);
            this.Hide();
        }
    }
}
