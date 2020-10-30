using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using courseproject_it_models;
namespace courseproject_it
{
    public partial class AddForm : Form
    {
       // ResultMedContext db;
        public AddForm()
        {
            InitializeComponent();
           // db = new ResultMedContext();
          // db.Persons.Load();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void armStatusBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
