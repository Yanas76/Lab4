using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4._2
{
    public partial class EditForm : Form
    {
        private MainForm form1;
        private int position;
        public EditForm(MainForm form1, int pos)
        {

            InitializeComponent();
            this.form1 = form1;
            this.position = pos;

            textBox1.Text = form1.allData[position].ClubName;
            textBox2.Text = form1.allData[position].FacultyName;
            textBox3.Text = form1.allData[position].CathedraName;
            textBox4.Text = form1.allData[position].Day;
            textBox5.Text = form1.allData[position].Time; 
            textBox6.Text = form1.allData[position].Chief;
            textBox7.Text = form1.allData[position].Orientation;
            textBox8.Text = form1.allData[position].HeadFullName;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

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

                Club row = new Club();
                row.ClubName = textBox1.Text;
                row.FacultyName = textBox2.Text;
                row.CathedraName = textBox3.Text;
                row.Day = textBox4.Text;
                row.Time = textBox5.Text;                           
                row.Chief = textBox6.Text;
                row.Orientation = textBox7.Text;             
                row.HeadFullName = textBox8.Text;

                form1.allData[position] = row;
                Helper.DisplayResult(form1.allData, form1.table);
               
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Усі поля мають бути заповнені!");             
            }
        }
    }
}
