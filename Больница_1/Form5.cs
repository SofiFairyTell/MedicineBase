using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Больница
{
    public partial class Form5 : Form
    {
        private Microsoft.Office.Interop.Excel.Application ObjExcel;
        private Microsoft.Office.Interop.Excel.Workbook ObjWorkBook;
        private Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
        private string fileName;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.dBDataSet.Patient);
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fileName = System.Windows.Forms.Application.StartupPath + "\\" + textBox1.Text + ".xlsx";
            try
            {

                ObjExcel = new Microsoft.Office.Interop.Excel.Application();
                //Книга.
                ObjWorkBook = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);
                //Таблица.
                ObjExcel.Columns.ColumnWidth = 15;


                ObjExcel.Cells[1, 1] = "Фамилия";
               ObjExcel.Cells[1, 2] = "Имя";
               ObjExcel.Cells[1, 3] = "Отчество";
               ObjExcel.Cells[1, 4] = "Дата р-ния";
               ObjExcel.Cells[1, 5] = "Адрес";
               ObjExcel.Cells[1, 6] = "Диагноз";
               ObjExcel.Cells[1, 7] = "Дата поступления";
               ObjExcel.Cells[1, 8] = "Дата выписки";

                ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];

                for (int i = 1; i <= view2DataGridView.Rows.Count; i++)
                {
                    DataGridViewRow row = view2DataGridView.Rows[i-1]; // строки

                    for (int j = 0; j < row.Cells.Count; j++) //цикл по ячейкам строки
                    {
                        ObjExcel.Cells[i + 1, j + 1] = row.Cells[j].Value;
                    }
                }
              
                ObjWorkBook.SaveAs(fileName);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
            finally
            {
                {
                   
           
                    ObjWorkBook.Close();
                    // Закрытие приложения Excel.
                    ObjExcel.Quit();
                    ObjWorkBook = null;
                    ObjWorkSheet = null;
                    ObjExcel = null;
                    GC.Collect();
                }
            }
           

            this.Text = this.Text + " - " + textBox1.Text + ".xlsx";
            
        }

       
    }
}
