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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }


        private void textFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    StudentVariables obj1 = new StudentVariables();
            //    obj1.FullName = textFullName.Text;
            //    obj1.Email = textEmail.Text;
            //    obj1.Phone = textPhone.Text;
            //    obj1.IDNO = textIDNO.Text;
            //    getstudentsfromsql getdatafromsql1 = new getstudentsfromsql();
            //    getdatafromsql1.updatedb(obj1);
            //    MessageBox.Show("Updated successfully");
            //}
            //catch (Exception c)
            //{
            //    MessageBox.Show(c.ToString());
            //}




        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    StudentVariables obj2 = new StudentVariables();
            //    obj2.FullName = textFullName.Text;
            //    obj2.Email = textEmail.Text;
            //    obj2.Phone = textPhone.Text;
            //    obj2.IDNO = textIDNO.Text;
            //    getstudentsfromsql getdatafromsql2 = new getstudentsfromsql();
            //    getdatafromsql2.deletedb(obj2);
            //    MessageBox.Show("Student deleted successfully");
            //}
            //catch (Exception M)
            //{
            //    MessageBox.Show(M.ToString());
            //}

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {

               
                StudentVariables obj = new StudentVariables();
              
                obj.FullName = textFullName.Text;
                obj.Email = textEmail.Text;
                obj.Phone = textPhone.Text;
                obj.IDNO = textIDNO.Text;
                getstudentsfromsql getdatafromsql = new getstudentsfromsql();
                getdatafromsql.Getdata(obj);
                MessageBox.Show("Details saved successfully");


            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
        public void clear()
        {
            textFullName.Clear();
            textEmail.Clear();
            textPhone.Clear();
            textIDNO.Clear();
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                StudentVariables obj3 = new StudentVariables();
                obj3.FullName = textFullName.Text;
                if(textFullName.Text == string.Empty)
                {
                    MessageBox.Show("Enter a student name to search","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                getstudentsfromsql getdatafromsql3 = new getstudentsfromsql();
                DataTable table = new DataTable();
                getdatafromsql3.searchdb(table, obj3);
                studentdataview.DataSource = table;
            }
            catch (Exception K)
            {
                MessageBox.Show(K.ToString());
            }
        }

        private void Displaystudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
