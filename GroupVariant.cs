using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DAL;

namespace TermPP
{
    public partial class GroupsVar : Form
    {
        public GroupsVar()
        {
            InitializeComponent();
                    
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
        public void linkvarandsql()
        {
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try {

                GroupVariables obj1 = new GroupVariables();
                obj1.GroupName = groupname.Text;
                obj1.GroupNumber = groupnumber.Text;

                Getgroupfromdb getgroupfromdb = new Getgroupfromdb();

                getgroupfromdb.getgroupdata(obj1);
                MessageBox.Show("Successful");

            }
            catch(Exception r)
            {
                MessageBox.Show(r.Message);
            }
            
            
        }
      

        private void GroupVariant_Load(object sender, EventArgs e)
        {

        }

        private void groupnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                GroupVariables groupVariables = new GroupVariables();
                groupVariables.GroupName = groupname.Text;
                groupVariables.GroupNumber = groupnumber.Text;
                Getgroupfromdb getgroupfromdb = new Getgroupfromdb();
                getgroupfromdb.deletegroup(groupVariables);
                MessageBox.Show("Deleted Sucessfully");

            }
            catch(Exception t)
            {
                MessageBox.Show(t.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                GroupVariables groupVariables = new GroupVariables();
                groupVariables.GroupName = groupname.Text;
                groupVariables.GroupNumber = groupnumber.Text;
                Getgroupfromdb getgroupfromdb = new Getgroupfromdb();
                getgroupfromdb.updategroup(groupVariables);
                MessageBox.Show("Update Success");
            }
            catch (Exception T)
            {
                MessageBox.Show(T.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            if(Search.Text == string.Empty)
            {
                MessageBox.Show("Enter Group Number to Search","Unable to Search",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                      
            GroupVariables groupVariables = new GroupVariables();
            groupVariables.GroupNumber = Search.Text;
            Getgroupfromdb getgroupfromdb = new Getgroupfromdb();
            getgroupfromdb.searchgroup(data, groupVariables);

            Datagridview.DataSource = data;
        }
       
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
