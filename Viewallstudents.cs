using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BAL;

namespace TermPP
{
    public partial class Viewallstudents : Form
    {
        public Viewallstudents()
        {
            InitializeComponent();
        }

        private void btnAllstudents_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            getstudentsfromsql getstudent = new getstudentsfromsql();
            StudentVariables students = new StudentVariables();
            getstudent.viewallstudent(table, students);
            allstudentsgrid.DataSource = table;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
