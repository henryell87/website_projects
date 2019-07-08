using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDSystem.Entities;


namespace CRUDSystem.Migrations
{
    public partial class Form1 : Form
    {
        Detail MyDetail = new Detail();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PopGridview();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopGridview();
        }


        private void PopGridview()
        {
            using (var MyModelEntites = new MyModel())
            {
                dataGridView1.DataSource = MyModelEntites.Details.ToList<Detail>();
            }
        }
    }
}
