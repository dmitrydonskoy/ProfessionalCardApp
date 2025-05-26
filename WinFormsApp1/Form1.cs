using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Person> people = new List<Person>();
        private const string FilePath = "data.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                people = JsonSerializer.Deserialize<List<Person>>(json) ?? new List<Person>();
            }
        }

        private void SaveData()
        {
            string json = JsonSerializer.Serialize(people);
            File.WriteAllText(FilePath, json);
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = people;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            people.Add(new Person
            {
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text),
                City = txtCity.Text
            });
            UpdateGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        // === LINQ ЗАПРОСЫ ===

        private void btnSortByAge_Click(object sender, EventArgs e)
        {
            var sorted = people.OrderBy(p => p.Age).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sorted;
        }

        private void btnFilterCity_Click(object sender, EventArgs e)
        {
            var filtered = people.Where(p => p.City == txtFilterCity.Text).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filtered;
        }

        private void btnAvgAge_Click(object sender, EventArgs e)
        {
            var avg = people.Select(p => p.Age).Average();
            MessageBox.Show($"Средний возраст: {avg:F1}");
        }

        private void btnSelectNames_Click(object sender, EventArgs e)
        {
            var names = people.Select(p => p.Name).ToList();
            MessageBox.Show("Имена: " + string.Join(", ", names));
        }
    }
}
