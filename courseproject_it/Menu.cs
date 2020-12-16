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

        private void Menu_Load(object sender, EventArgs e)
        {

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
