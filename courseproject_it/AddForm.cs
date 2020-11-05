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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            /*Здесь загрузка БД также есть, потому что форма может быть вызвана из Рабочего Пространства*/
            ResultMedContext db;
            db = new ResultMedContext();
            db.Persons.Load();
            Person person = new Person();
            person.Surname = SurnameTextBox.Text;
            person.Name = NamTextBox.Text;
            person.Middlename = MiddNamTextBox.Text;
            db.Persons.Add(person);
            db.SaveChanges();
            MessageBox.Show("Новый объект добавлен");
            
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void armStatusBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
