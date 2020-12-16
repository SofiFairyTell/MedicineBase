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
                //Chairman = ChairmanTextBox.Text
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
            /*Добавление статичных данных в ComboBox*/
            List<string> Category_List = new List<string>();//категория освидетельствуемого
            Category_List.AddRange(new string[]
            {
                "01 - Граждане, поступающие на военную службу по контракту",
                "02 - Граждане, поступающие в образовательные организации",
                "03 - Граждане, призываемые на военные сборы",
                "04 - Военнослужащие, проходящие военную службу по контракту",
                "05 - Военнослужащие, проходящие военную службу по призыву",
                "06 - Слушатели, курсанты образовательных организаций до заключения первого контракта о прохождении военной службы",
                "07 - Граждане, пребывающие в запасе ФСБ России",
                "08 - Граждане, проходящие военные сборы",
                "09 - Граждане, прошедшие военную службу",
                "10 - Члены семей военнослужащих",
                "11 - Прочие"
            });
            foreach (var str in Category_List)
            {
                category_person.Items.Add(str);
            }
            List<string> Godnost_List = new List<string>();
            Godnost_List.AddRange(new string[]
            {
                "А - годен к военной службе",
                "Б - годен к военной службе с незначительными ограничениями",
                "В - ограниченно годен к военной службе",
                "Г - временно не годен к военной службе",
                "Д - не годен к военной службе",
            });
            foreach (var str in Godnost_List)
            {
                category_godnost.Items.Add(str);
            }

            List<string> Arm_status = new List<string>();//воинское звание
            Arm_status.AddRange(new string[]
            {
                "звание не указано",
                "Рядовой",  "Ефрейтор",
                "Младший сержант", "Сержант", "Старший сержант", "Старшина",
                "Прапорщик","Старший прапорщик",
                "Младший лейтенант","Лейтенант","Старший лейтенант",
                "Капитан", "Майор",
                "Подполковник", "Полковник",
                "Генерал-майор","Генерал-лейтенант",
                "Генерал-полковник", "Генерал армии",
                "Маршал Российской Федераци"
            });
            foreach (var str in Arm_status)
            {
               arm_status.Items.Add(str);
            }
        }

        private void category_person_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
