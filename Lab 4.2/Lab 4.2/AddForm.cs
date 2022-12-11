using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_4._2
{
    public partial class AddForm : Form
    {
        private MainForm form1;
        public AddForm(MainForm form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.Validator(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,
                    textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);

                Club club = new Club();
                club.ClubName = textBox1.Text;
                club.FacultyName = textBox2.Text;
                club.CathedraName = textBox3.Text;
                club.Day = textBox4.Text;
                club.Time = textBox5.Text;
                club.Chief = textBox6.Text;
                club.Orientation = textBox7.Text;               
                club.HeadFullName = textBox8.Text;

                form1.AddRow(club);
                this.Close();
  
            }
            catch(Exception ex)
            {
                MessageBox.Show("Усі поля мають бути заповнені!");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
