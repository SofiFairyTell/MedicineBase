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
                    var Data = context.Persons.Where(x => x.Surname == node.Text).FirstOrDefault();//ишем в базе то, что записано TreView
                    DataDescriptionGrid.Columns.Add("Name","");
                    DataDescriptionGrid.Rows.Add(1);
                    DataDescriptionGrid.Rows[0].Cells[0].Value = Data.Name.ToString();//записываем в таблицу или выводим таблицу
                }
                //    var index = MedList.FindIndex(x => x.MedicName.Contains(node.Text));
                //DataDescriptionGrid.Rows[0].Cells[1].Value = MedList[index].MedicName;
                //DataDescriptionGrid.Rows[1].Cells[1].Value = MedList[index].Index; //индекс это номер элемента в списке
                //DataDescriptionGrid.Rows[2].Cells[1].Value = MedList[index].Child; //индекс это номер элемента в списке
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при щелчке по узлу!\nДополнительные сведения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
