using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Numerics;
using System.Windows.Forms;

namespace WinFormsApp11
{
    public partial class MainForm : Form
    {
        private ProductsContext? dbContext;

        int id = 2;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new ProductsContext();

            // Uncomment the line below to start fresh with a new database.
            //this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Categories.Load();

            this.categoryBindingSource.DataSource = dbContext.Categories.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                //int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Category student = dbContext.Categories.Find(id);
                dbContext.Categories.Remove(student);
                dbContext.SaveChanges();

                MessageBox.Show("Объект удален");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            id += 1;
            Category student = new Category();
            //student.Id = id;
            student.Name = textBox1.Text;
            student.Number = int.Parse(textBox2.Text);
            student.DR = dateTimePicker1.Value;
            student.DP = dateTimePicker2.Value;


            dbContext.Categories.Add(student);
            dbContext.SaveChanges();

            MessageBox.Show("Новый студент добавлен!");
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            var filter = dbContext.Categories
                .Where(r => (r.DP >= dateTimePicker3.Value && r.DP <= dateTimePicker4.Value) && (Calculat(textBox3.Text) >= r.DR.Year && Calculat(textBox4.Text) <= r.DR.Year))
                .Select(r => new { r.Id, r.Name, r.Number, r.DR, r.DP })
                .ToList();

            dataGridView1.DataSource = filter;

            dataGridView1.AutoGenerateColumns = true;

            /*dataGridView1.Columns["Id"].Visible = true;
            dataGridView1.Columns["Name"].Visible = true;
            dataGridView1.Columns["Number"].Visible = true;
            dataGridView1.Columns["DR"].Visible = true;
            dataGridView1.Columns["DP"].Visible = true;*/

            MessageBox.Show("Фильтрация прошла успешно!");
        }

        public int Calculat(string x)
        {
            DateTime dateTime = DateTime.Today;
            int b = Convert.ToInt32(x);
            int age = dateTime.Year - b;

            return age;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = dbContext.Categories.ToList();
            dataGridView1.DataSource = f;

            dataGridView1.AutoGenerateColumns = true;
        }
    }
}
