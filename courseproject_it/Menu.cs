using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Result
{
    //Работа с главным меню, которое состоит из 3-х основных действий: 
    // 1. Окрыть базу данных - OpenAllPersonForm_Click
    // 2. Добавить данные о новом пациенте - OpenAddForm_Click
    // 3. Получить данные о пациентах - OpenAnalizForm_Click
    
    public partial class Menu : Form
    {
        public Menu()
        {
            try
            {
                InitializeComponent();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка при щелчке по узлу!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void OpenAllPersonForm_Click(object sender, EventArgs e)
        {
            AllPerson БазаДанных = new AllPerson();
            БазаДанных.Show();
        }

        private void OpenAddForm_Click(object sender, EventArgs e)
        {
            AddForm Добавить = new AddForm();
            Добавить.Show();
        }

        private void OpenAnalizForm_Click(object sender, EventArgs e)
        {
            PersonsTreeView Аналитика = new PersonsTreeView();
            Аналитика.Show();
        }
    }
}
