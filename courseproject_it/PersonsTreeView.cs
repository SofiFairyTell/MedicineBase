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

namespace Result
{
    public partial class PersonsTreeView : Form
    {
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

                   // node.Text = item;
                    PersonsTreView.Nodes[0].Nodes[0].Nodes.Add("Категория", item);
                       
                }
                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
          

        private void PersonsTreView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void PersonsTreView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {

                TreeNode node = PersonsTreView.SelectedNode;// Получение выбранного двойным щелчком узла дерева.

                MessageBox.Show(string.Format("You selected: {0}", node.Text)); // Вывод окна с текстом данного узла.
                /*
                DataDescriptionGrid.Rows.Clear();
                DataDescriptionGrid.Columns.Clear();
                DataGridInit();
                DataDescriptionGrid.ReadOnly = true;
                DataDescriptionGrid.Visible = true;
                AddButton.BringToFront();*/
                /*
                                MinimButton.Visible = true;//для закрытия информации об узле
                                EditButton.Visible = true;//для изменения данных в содержимом узла
                                AddButton.Visible = true;
                                DelButton.Visible = true;
                                */
                using (var context = new Result_models.ResultMedContext())
                {
                    var Data = context.Persons.Where(x => x.Category_Person == node.Text).FirstOrDefault();//найдет только первый элемент, беда, что записано TreView
                    //var Data = context.Persons.Find(node.Text);
                    //foreach(IGrouping<int, Result_models.Person> group in Dt)
                    //{
                    //    foreach (Person person in group)
                    //    {
                    //        DataDescriptionGrid.Columns.Add("Surname", "Фамилия");
                    //        DataDescriptionGrid.Columns.Add("Name", "Имя");
                    //        DataDescriptionGrid.Columns.Add("MiddleName", "Отчество");
                    //        DataDescriptionGrid.Columns.Add("Diagnos", "Диагноз");
                    //        DataDescriptionGrid.Columns.Add("Result", "Результат");


                    //        DataDescriptionGrid.Rows.Add(1);
                    //        DataDescriptionGrid.Rows[0].Cells[0].Value = person.Surname.ToString();//записываем в таблицу или выводим таблицу
                    //        DataDescriptionGrid.Rows[0].Cells[1].Value = person.Name.ToString();//записываем в таблицу или выводим таблицу
                    //        DataDescriptionGrid.Rows[0].Cells[2].Value = person.Middlename.ToString();//записываем в таблицу или выводим таблицу
                    //        DataDescriptionGrid.Rows[0].Cells[3].Value = person.Diagnos.ToString();//записываем в таблицу или выводим таблицу
                    //        DataDescriptionGrid.Rows[0].Cells[4].Value = person.Result.ToString();//записываем в таблицу или выводим таблицу

                    //    }
                    //}
                    DataDescriptionGrid.Columns.Add("Surname", "Фамилия");
                    DataDescriptionGrid.Columns.Add("Name", "Имя");
                    DataDescriptionGrid.Columns.Add("MiddleName", "Отчество");
                    DataDescriptionGrid.Columns.Add("Diagnos", "Диагноз");
                    DataDescriptionGrid.Columns.Add("Result", "Результат");


                    DataDescriptionGrid.Rows.Add(1);
                    DataDescriptionGrid.Rows[0].Cells[0].Value = Data.Surname.ToString();//записываем в таблицу или выводим таблицу
                    DataDescriptionGrid.Rows[0].Cells[1].Value = Data.Name.ToString();//записываем в таблицу или выводим таблицу
                    DataDescriptionGrid.Rows[0].Cells[2].Value = Data.Middlename.ToString();//записываем в таблицу или выводим таблицу
                    DataDescriptionGrid.Rows[0].Cells[3].Value = Data.Diagnos.ToString();//записываем в таблицу или выводим таблицу
                    DataDescriptionGrid.Rows[0].Cells[4].Value = Data.Result.ToString();//записываем в таблицу или выводим таблицу

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при щелчке по узлу!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PersonsTreView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void PersonsTreView_Click(object sender, EventArgs e)
        {
          


        }
    }
}
