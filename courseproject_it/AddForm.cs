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
            Person person = new Person
            {
                /*Общие сведения об освидетельствуемом*/
                Surname = SurnameTextBox.Text,
                Name = NamTextBox.Text,
                Middlename = MiddNamTextBox.Text,
                Birthday = dateTimePicker1.Text,
                /*Категории*/
                Category_Person = category_person.Text,//категория
                Arm_Status = arm_status.Text,//воинское звание
                /*Все что связано с диагонозом*/
                Article_Raspisanie = article_raspisanie.Text,
                Article_Trebovanie = article_trebovanie.Text,
                Diagnos = Diagnos.Text,
                Category_Godnost = category_godnost.Text,
                Result = result.Text
            };

            //person.Result_Id =
            //person.Result_Date = 
            //person.Result_Prichina =
            /*
            if (Other.Text == "")
            {
                person.Other = Other.Text;
            }*/
            db.Persons.Add(person);
            db.SaveChanges();
            MessageBox.Show("Новый объект добавлен");
            
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
