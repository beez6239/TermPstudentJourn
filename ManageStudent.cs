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
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                StudentVariables obj2 = new StudentVariables();
                obj2.FullName = textFullName.Text;
                obj2.Email = textEmail.Text;
                obj2.Phone = textPhone.Text;
                obj2.IDNO = textIDNO.Text;
                getstudentsfromsql getdatafromsql2 = new getstudentsfromsql();
                getdatafromsql2.deletedb(obj2);
                MessageBox.Show("Student deleted successfully");
            }
            catch (Exception M)
            {
                MessageBox.Show(M.ToString());
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                StudentVariables obj1 = new StudentVariables();
                obj1.FullName = textFullName.Text;
                obj1.Email = textEmail.Text;
                obj1.Phone = textPhone.Text;
                obj1.IDNO = textIDNO.Text;
                getstudentsfromsql getdatafromsql1 = new getstudentsfromsql();
                getdatafromsql1.updatedb(obj1);
                MessageBox.Show("Updated successfully");
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }
        public void clear()
        {
            textFullName.Clear();
            textEmail.Clear();
            textPhone.Clear();
            textIDNO.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
