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
    public partial class viewallgroups : Form
    {
        public viewallgroups()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAllgroups_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                GroupVariables group = new GroupVariables();
                Getgroupfromdb getgroup = new Getgroupfromdb();
                getgroup.viewallgroups(table, group);
                allgroupgrid.DataSource = table;
            }
            catch (Exception T)
            {
                MessageBox.Show(T.Message);
            }
            
        }
    }
}
