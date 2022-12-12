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
    public partial class SubjectForm : Form
    {
        public SubjectForm()
        {
            InitializeComponent();
        }

        private void Subjecttext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                SubjectVariables subobj = new SubjectVariables();
                subobj.SubjectName = Subjecttext.Text;
                subobj.SubjectID = IDText.Text;
                subobj.SubjectTime = TimeText.Text;
                subobj.Date = datetime.Value;

                getsubjectsfromsql getfromdal = new getsubjectsfromsql();
                getfromdal.subjectdata(subobj);
                MessageBox.Show("Success");
            }
            catch(Exception T)
            {
                MessageBox.Show(T.Message);
            }
           

        }

        private void Update_Click(object sender, EventArgs e)
        {

            try
            {

                SubjectVariables subobj = new SubjectVariables();
                subobj.SubjectName = Subjecttext.Text;
                subobj.SubjectID = IDText.Text;
                subobj.SubjectTime = TimeText.Text;
                subobj.Date = datetime.Value;
                getsubjectsfromsql getfromdal = new getsubjectsfromsql();
                getfromdal.updatestudent(subobj);
                MessageBox.Show("Updated sucessfully");
            }
            catch (Exception T)
            {
                MessageBox.Show(T.Message);
            }
           
        }

        private void Viewallsubjects_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                SubjectVariables subobj = new SubjectVariables();
                getsubjectsfromsql getsubsql = new getsubjectsfromsql();
                getsubsql.viewallsubjects(table, subobj);
                subjectsview.DataSource = table;
            }
            catch (Exception T)
            {
                MessageBox.Show(T.Message);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SubjectVariables subobj = new SubjectVariables();
                subobj.SubjectName = Subjecttext.Text;
                subobj.SubjectID = IDText.Text;
                subobj.SubjectTime = TimeText.Text;
                subobj.Date = datetime.Value;
                getsubjectsfromsql getfromdal = new getsubjectsfromsql();
                getfromdal.Deletedb(subobj);

                MessageBox.Show("Deleted Successfully");

            }
            catch (Exception T)
            {
                MessageBox.Show(T.Message);
            }
            
        }
    }
}
