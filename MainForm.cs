using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermPP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           
        }

        private void pictureboxLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {

            showmenu(editstudentpanel);
        }
     
        public void hidemune()
        {
            if (editstudentpanel.Visible = true)
                editstudentpanel.Visible = false;
        }
        public void showmenu(Panel menu)
        {
            if(menu.Visible == false)
            {
                hidemune();
                menu.Visible = true;
            }else
            {
                menu.Visible = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
        }

        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            ManageStudent ms = new ManageStudent();
            ms.ShowDialog(this);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManagegroup_Click(object sender, EventArgs e)
        {
            GroupsVar gpv = new GroupsVar();
            gpv.StartPosition = FormStartPosition.CenterParent;

            gpv.ShowDialog(this);
        }

        private void MangeSubject_Click(object sender, EventArgs e)
        {
            SubjectForm Sj = new SubjectForm();
            Sj.StartPosition = FormStartPosition.CenterParent;
            Sj.ShowDialog(this);
        }

        private void StudentList_Click(object sender, EventArgs e)
        {
            Viewallstudents vall = new Viewallstudents();
            vall.StartPosition = FormStartPosition.CenterParent;
            vall.ShowDialog(this);
        }

        private void StudentList_Click_1(object sender, EventArgs e)
        {
            Viewallstudents vall = new Viewallstudents();
            vall.StartPosition = FormStartPosition.CenterParent;
            vall.ShowDialog(this);
        }

        private void Viewallgroups_Click(object sender, EventArgs e)
        {
            viewallgroups groupall = new viewallgroups();
            groupall.StartPosition = FormStartPosition.CenterParent;
            groupall.ShowDialog(this);


        }
    }
}
