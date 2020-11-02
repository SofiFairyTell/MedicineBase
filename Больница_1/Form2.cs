using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Больница
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);

        }

        private void patientBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);
            Application.Restart();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.dBDataSet.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.dBDataSet.Department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.dBDataSet.Patient);

        }



        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                фамилияTextBox.Clear();
                имяTextBox.Clear();
                отчествоTextBox.Clear();
                адрес_пропискиTextBox.Clear();
                диагнозTextBox.Clear();
                if (фамилияTextBox.TextLength == 0 & имяTextBox.TextLength == 0 & адрес_пропискиTextBox.TextLength == 0 & диагнозTextBox.TextLength == 0)
                {
                    MessageBox.Show("Для добовления нового поциента заполните все поля!", $"{Text}");
                }
                else
                {
                    this.Validate();
                    this.patientBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dBDataSet);
                    Application.Restart();
                }

            }
            catch
            {
                MessageBox.Show("Ошибка при добовленний пациента!", $"{Text}");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void фамилияTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
