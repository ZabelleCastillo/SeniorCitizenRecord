using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SeniorCitizenRecord
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongDateString(); //date
            label2.Text = DateTime.Now.ToLongTimeString(); //time
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString(); //time
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e) // Back to Home
        {
        }

        private void button2_Click(object sender, EventArgs e) // Go to add profile button
        {
            AddProfile form = new AddProfile();
            form.Show(this);
            this.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e) // Go to edit profile button
        {
            EditProfile form = new EditProfile();
            form.Show(this);
            this.Hide(); 
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) // go to show table
        {
            ShowTable form = new ShowTable();
            form.Show(this);
            this.Hide();
        }

      //  private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
     //   {
         //   DateTime from = dateTimePicker1.Value;
        //    DateTime to = DateTime.Now;
         //   TimeSpan TSpan = to - from;
         //   double days = TSpan.TotalDays;
          //  textBox3.Text = (days / 365).ToString("0");
        }
    }

