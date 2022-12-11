using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Lab_4._2
{
    public partial class SearchForm : Form
    {
        private string option;
        private string text;
        private DataTable table = new DataTable();
        private List<Club> allDataNew;
        private IEnumerable<Club> result;
        public SearchForm(string opt, List<Club> allData)
        {
            InitializeComponent();
            this.allDataNew = allData;
            this.option = opt;

            table.Columns.Add("Назва гуртка", typeof(string));
            table.Columns.Add("Факультет", typeof(string));
            table.Columns.Add("Кафедра", typeof(string));
            table.Columns.Add("День", typeof(string));
            table.Columns.Add("Час проведення", typeof(string));
            table.Columns.Add("Староста", typeof(string));
            table.Columns.Add("Орієнтація", typeof(string));
            table.Columns.Add("П.І.Б. керівника", typeof(string));
            dataGridView1.DataSource = table;

            Helper.DisplayResult(this.allDataNew, table);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;

            if(text == "")
            {
                MessageBox.Show("Будь ласка, введіть критерії для пошуку");
            }
            else
            {

                if(option == "Назва гуртка"){
                  
                    result = from club in allDataNew where club.ClubName.Contains(text) select club;                   
                }
                else if(option == "Факультет")
                {
                    result = from club in allDataNew where club.FacultyName.Contains(text) select club;
                }
                else if(option == "Керівник")
                {
                    result = from club in allDataNew where club.HeadFullName.Contains(text) select club;
                }

                table.Clear();
                foreach (Club club in result)
                {
                    table.Rows.Add(club.ClubName, club.FacultyName, club.CathedraName, club.Day, club.Time, club.Chief, club.Orientation, club.HeadFullName);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
