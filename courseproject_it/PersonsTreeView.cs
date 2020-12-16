using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Result_models;

/*Для экпорта в Excel*/
using Microsoft.Office.Interop.Excel;


namespace Result
{
    
    public partial class PersonsTreeView : Form
    {
        string Name; //имя файла формируется из имени категории
        public PersonsTreeView()
        {
            InitializeComponent();
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
            try
            {
                /*Добавление данных о категории в список*/
                foreach (var item in Category_List)
                {
                    PersonsTreView.Nodes[0].Nodes[0].Nodes.Add("Категория", item);                      
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PersonsTreView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            /*После двойного нажатия но узлу из базы будет выведен список всех людей, у которых одно
             из полей совпадает с содержанием узла*/
            try
            {

                TreeNode node = PersonsTreView.SelectedNode;// Получение выбранного двойным щелчком узла дерева.

                MessageBox.Show(string.Format("You selected: {0}", node.Text)); // Вывод окна с текстом данного узла.

                Name = node.Text;

                using (var context = new Result_models.ResultMedContext())
                {
                    /*------------Удалим ранее введенные данные---------*/
                    DataDescriptionGrid.Rows.Clear();
                    DataDescriptionGrid.Columns.Clear();
                    /*-------------------------------------------------*/

                    /*------Наименования столбцов----------------------*/
                    DataDescriptionGrid.Columns.Add("Surname", "Фамилия");
                    DataDescriptionGrid.Columns.Add("Name", "Имя");
                    DataDescriptionGrid.Columns.Add("MiddleName", "Отчество");
                    DataDescriptionGrid.Columns.Add("Diagnos", "Диагноз");
                    DataDescriptionGrid.Columns.Add("Result", "Результат");
                    DataDescriptionGrid.Columns.Add("Date", "Дата");
                    DataDescriptionGrid.Columns.Add("Doctor", "Врач");
                    /*-------------------------------------------------*/

                    DataDescriptionGrid.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    DataDescriptionGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //автоматическое выравнивание текста в колонке
                    DataDescriptionGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                    /*--------Найдем в БД освидетельствуемого с нужной категорией--------------*/
                    var Person_tb = from u in context.Persons where u.Category_Person == node.Text select u;

                    if(Person_tb != null)
                    {
                     /*---Определим сколько необходимо создать строк для загрузки данных-------*/
                        int rows = Person_tb.Count();
                        DataDescriptionGrid.Rows.Add(rows);
                        int i = 0;
                    /*--------------------------Начало загрузки данных----------------------*/
                        foreach (var person in Person_tb)
                            {
                                DataDescriptionGrid.Rows[i].Cells[0].Value = person.Surname.ToString();
                                DataDescriptionGrid.Rows[i].Cells[1].Value = person.Name.ToString();//записываем в таблицу или выводим таблицу
                                DataDescriptionGrid.Rows[i].Cells[2].Value = person.Middlename.ToString();//записываем в таблицу или выводим таблицу
                                DataDescriptionGrid.Rows[i].Cells[3].Value = person.Diagnos.ToString();//записываем в таблицу или выводим таблицу
                                DataDescriptionGrid.Rows[i].Cells[4].Value = person.Result.ToString();//записываем в таблицу или выводим таблицу
                                DataDescriptionGrid.Rows[i].Cells[5].Value = person.Result_Date.ToString();//записываем в таблицу или выводим таблицу
                                DataDescriptionGrid.Rows[i].Cells[6].Value = person.Other.ToString();//записываем в таблицу или выводим таблицу
                            if (i!= rows) //увеличим счетчик для новой строки
                                    i++;
                            
                            }
                        DataDescriptionGrid.Rows[i].Cells[5].Value ="Итого по категории:";//записываем в таблицу или выводим таблицу
                        DataDescriptionGrid.Rows[i].Cells[6].Value = Person_tb.Count();//записываем в таблицу или выводим таблицу

                    }
                    else
                    {
                        MessageBox.Show($"По вашему запросу ничего не найдено!\n", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при щелчке по узлу!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToExcel(string Name)
        {
            try
            {

                Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
                exApp.Visible = true;
                exApp.Workbooks.Add();
                Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
                workSheet.Cells[1, 1] = "Фамилия";
                workSheet.Cells[1, 2] = "Имя";
                workSheet.Cells[1, 3] = "Отчество";
                workSheet.Cells[1, 4] = "Диагноз";
                workSheet.Cells[1, 5] = "Результат";
                workSheet.Cells[1, 6] = "Дата";
                workSheet.Cells[1, 7] = "Врач";
                int rowExcel = 2;
                for (int i = 0; i < DataDescriptionGrid.Rows.Count; i++)
                {
                    workSheet.Cells[rowExcel, "A"] = DataDescriptionGrid.Rows[i].Cells[0].Value;
                    workSheet.Cells[rowExcel, "B"] = DataDescriptionGrid.Rows[i].Cells[1].Value;
                    workSheet.Cells[rowExcel, "C"] = DataDescriptionGrid.Rows[i].Cells[2].Value;
                    workSheet.Cells[rowExcel, "D"] = DataDescriptionGrid.Rows[i].Cells[3].Value;
                    workSheet.Cells[rowExcel, "E"] = DataDescriptionGrid.Rows[i].Cells[4].Value;
                    workSheet.Cells[rowExcel, "F"] = DataDescriptionGrid.Rows[i].Cells[5].Value;
                    workSheet.Cells[rowExcel, "G"] = DataDescriptionGrid.Rows[i].Cells[6].Value;

                    ++rowExcel;
                }
                //На последней строке выведем итого по категории

                string directory = AppDomain.CurrentDomain.BaseDirectory;
                string path = (Name + ".xls");
                string path2 = directory + "\\";
                workSheet.SaveAs(directory + Name);
                exApp.Quit();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка при щелчке по узлу!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportExcellButton_DoubleClick(object sender, EventArgs e)
        {
            ExportToExcel(Name);
        }
    }
}
