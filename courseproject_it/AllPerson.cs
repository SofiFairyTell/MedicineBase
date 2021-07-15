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
    
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm AddForm = new AddForm();
            DialogResult result = AddForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            //Person person = new Person
            //{
            //    Surname = AddForm.SurnameTextBox.Text,
            //    Name = AddForm.NamTextBox.Text,
            //    Middlename = AddForm.MiddNamTextBox.Text
            //};         
            //db.Persons.Add(person);
            //db.SaveChanges();
            //MessageBox.Show("Новый объект добавлен");
        }

        private void DelButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                var del_person = db.Persons.Find(id);
                
                db.Persons.Remove(del_person);
                db.SaveChanges();

                MessageBox.Show("Объект удален", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            MessageBox.Show("Изменения сохранены", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
