using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Result
{
    public partial class SecureForm : Form
    {
        public SecureForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SecureForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kinoDataSet.Пользователь". При необходимости она может быть перемещена или удалена.
           // this.пользовательTableAdapter.Fill(this.kinoDataSet.Пользователь);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
          if (PasswordTextBox.Text != "")
            {
                //if (PasswordTextBox.Text == ((DataRowView)пользовательBindingSource.Current).Row["Пароль"].ToString())
                //{
                    if (UserChooseComboBox.Text == "Администратор")
                    {
                    if(PasswordTextBox.Text =="Администратор")
                    {
                        Result.Menu Рабочее_пространство = new Result.Menu();
                        Рабочее_пространство.ShowDialog();
                    }
                      else
                    {
                        СообщениеПароль.Show("Пароль введен неверно", PasswordTextBox, 10000);
                    }
                   
                    }
                    else 
                    {
                        //Form26 x = new Form26();
                        //x.ShowDialog();
                    }
               // }
                //else
                //{
                //    MessageBox.Show("Пароль неверный");
                //}
            }
            else
            {
                СообщениеПароль.Show("Поле ввода пароля не может быть пустым", PasswordTextBox, 10000);
            } 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void пользовательBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


    }
}
