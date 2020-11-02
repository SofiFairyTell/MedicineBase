using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Больница
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.dBDataSet.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.dBDataSet.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.dBDataSet.Department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.dBDataSet.Patient);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form2();
            ifrm.Show(); // отображаем Form2
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form3();
            ifrm.Show(); // отображаем Form3
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form4();
            ifrm.Show(); // отображаем Form4
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form5();
            ifrm.Show(); // отображаем Form5


         
        }
    }
}
