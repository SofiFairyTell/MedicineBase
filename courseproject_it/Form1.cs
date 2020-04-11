using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using courseproject_it;
namespace courseproject_it
{
    public partial class Form1 : Form
    {
        ResultMedContext db;
        public Form1()
        {
            InitializeComponent();
            db = new ResultMedContext();
            db.Persons.Load();
            dataGridView1.DataSource = db.Persons.Local.ToBindingList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
