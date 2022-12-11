using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace Lab_4._2
{
    public partial class MainForm : Form
    {
        public DataTable table = new DataTable();
        public List<Club> allData = new List<Club>();
        public MainForm()
        {
            InitializeComponent();            
            table.Columns.Add("Назва гуртка", typeof(string));
            table.Columns.Add("Факультет", typeof(string));
            table.Columns.Add("Кафедра", typeof(string));
            table.Columns.Add("День", typeof(string));
            table.Columns.Add("Час проведення", typeof(string));
            table.Columns.Add("Староста", typeof(string));
            table.Columns.Add("Орієнтація", typeof(string));
            table.Columns.Add("П.І.Б. керівника", typeof(string));
            dataGridView1.DataSource = table;

            OpenFromJson();
        }

        public void AddRow(Club club)
        {
            allData.Add(club);
            table.Rows.Add(club.ClubName, club.FacultyName, club.CathedraName, club.Day, club.Time, club.Chief, club.Orientation, club.HeadFullName);
        }

        private void button1_Click(object sender, EventArgs e)  //Add
        {
            AddForm form2 = new AddForm(this);
            form2.ShowDialog();          
        }

        private void button2_Click(object sender, EventArgs e)  //Edit
        {

            try
            {
                int position = dataGridView1.CurrentRow.Index;
                EditForm form5 = new EditForm(this, position);
                form5.ShowDialog();

            }
            catch(Exception)
            {
                MessageBox.Show("Неможливо редагувати!");
            }
                   
        }

        private void button3_Click(object sender, EventArgs e)  //Remove
        {

            try
            {
                int position = dataGridView1.CurrentRow.Index;
                allData.RemoveAt(position);
                table.Rows.RemoveAt(position);
            }
            catch(Exception)
            {
                MessageBox.Show("Неможливо видалити!");
            }                         
        }

        private void button4_Click(object sender, EventArgs e) //Save file
        {
            SaveToJson();
        }

        private void button5_Click(object sender, EventArgs e)  //Open file
        {
            OpenFromJson();
        }

        private void button6_Click(object sender, EventArgs e) //About program
        {
            InformationForm form4 = new InformationForm();
            form4.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string option = Convert.ToString(comboBox1.Items[comboBox1.SelectedIndex]);

            SearchForm form3 = new SearchForm(option, allData);
            form3.ShowDialog();
        }

        public void OpenFromJson()
        {
            table.Rows.Clear();
            allData.Clear();

            string jsonString = File.ReadAllText("DataBase.json");
            List<Club> getValue =
                JsonSerializer.Deserialize<List<Club>>(jsonString);

            allData = getValue;

            foreach (Club club in allData)
            {
                table.Rows.Add(club.ClubName, club.FacultyName, club.CathedraName, club.Day, club.Time, club.Chief, club.Orientation, club.HeadFullName);
            }
        }

        public void SaveToJson()
        {
            string jsonInformation = JsonSerializer.Serialize(allData);
            File.WriteAllText("DataBase.json", jsonInformation);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}


