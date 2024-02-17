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
    public partial class ShowTable : Form
    {
        public ShowTable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Back to Home button
        {
            Form2 form = new Form2();
            form.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) // Go to add profile button
        {
            AddProfile form = new AddProfile();
            form.Show(this);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) // go to edit or update button
        {
            EditProfile form = new EditProfile();
            form.Show(this);
            this.Hide();
        }
    }
}
