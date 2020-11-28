using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Result_models;

namespace Result
{
    public partial class AllPerson : Form
    {
        ResultMedContext db;
        public AllPerson()
        {
            InitializeComponent();
            db = new ResultMedContext();
            db.Persons.Load();//опять не грузится. Почнму??
            //вывод на форме таблицы
            dataGridView1.DataSource = db.Persons.Local.ToBindingList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm AddForm = new AddForm();
            DialogResult result = AddForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Person person = new Person
            {
                Surname = AddForm.SurnameTextBox.Text,
                Name = AddForm.NamTextBox.Text,
                Middlename = AddForm.MiddNamTextBox.Text
            };         
            db.Persons.Add(person);
            db.SaveChanges();
            MessageBox.Show("Новый объект добавлен");
        }
    }
}
