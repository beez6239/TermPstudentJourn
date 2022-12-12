
namespace TermPP
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MangeSubject = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnManagegroup = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.piclogopanel = new System.Windows.Forms.Panel();
            this.editstudentpanel = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnManageStudent = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentList = new System.Windows.Forms.Button();
            this.Viewallgroups = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.piclogopanel.SuspendLayout();
            this.editstudentpanel.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.Color.Navy;
            this.MainPanel.Controls.Add(this.Viewallgroups);
            this.MainPanel.Controls.Add(this.StudentList);
            this.MainPanel.Controls.Add(this.btnManagegroup);
            this.MainPanel.Controls.Add(this.MangeSubject);
            this.MainPanel.Controls.Add(this.btnSubject);
            this.MainPanel.Controls.Add(this.btnGroup);
            this.MainPanel.Controls.Add(this.piclogopanel);
            this.MainPanel.Controls.Add(this.editstudentpanel);
            this.MainPanel.Controls.Add(this.btnStudent);
            this.MainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(233, 335);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // MangeSubject
            // 
            this.MangeSubject.BackColor = System.Drawing.Color.Blue;
            this.MangeSubject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.MangeSubject.FlatAppearance.BorderSize = 0;
            this.MangeSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MangeSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MangeSubject.ForeColor = System.Drawing.Color.White;
            this.MangeSubject.Location = new System.Drawing.Point(0, 478);
            this.MangeSubject.Name = "MangeSubject";
            this.MangeSubject.Size = new System.Drawing.Size(216, 41);
            this.MangeSubject.TabIndex = 11;
            this.MangeSubject.Text = "Manage Subject";
            this.MangeSubject.UseVisualStyleBackColor = false;
            this.MangeSubject.Click += new System.EventHandler(this.MangeSubject_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSubject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.btnSubject.FlatAppearance.BorderSize = 0;
            this.btnSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubject.ForeColor = System.Drawing.Color.White;
            this.btnSubject.Location = new System.Drawing.Point(0, 445);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSubject.Size = new System.Drawing.Size(216, 39);
            this.btnSubject.TabIndex = 5;
            this.btnSubject.Text = "Subject";
            this.btnSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubject.UseVisualStyleBackColor = false;
            // 
            // btnManagegroup
            // 
            this.btnManagegroup.BackColor = System.Drawing.Color.Blue;
            this.btnManagegroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.btnManagegroup.FlatAppearance.BorderSize = 0;
            this.btnManagegroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagegroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagegroup.ForeColor = System.Drawing.Color.White;
            this.btnManagegroup.Location = new System.Drawing.Point(0, 371);
            this.btnManagegroup.Name = "btnManagegroup";
            this.btnManagegroup.Size = new System.Drawing.Size(216, 44);
            this.btnManagegroup.TabIndex = 10;
            this.btnManagegroup.Text = "Manage group";
            this.btnManagegroup.UseVisualStyleBackColor = false;
            this.btnManagegroup.Click += new System.EventHandler(this.btnManagegroup_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.MediumBlue;
            this.btnGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.btnGroup.FlatAppearance.BorderSize = 0;
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroup.ForeColor = System.Drawing.Color.White;
            this.btnGroup.Location = new System.Drawing.Point(0, 337);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnGroup.Size = new System.Drawing.Size(216, 39);
            this.btnGroup.TabIndex = 3;
            this.btnGroup.Text = "Group";
            this.btnGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroup.UseVisualStyleBackColor = false;
            // 
            // piclogopanel
            // 
            this.piclogopanel.BackColor = System.Drawing.Color.White;
            this.piclogopanel.Controls.Add(this.pictureBox2);
            this.piclogopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.piclogopanel.Location = new System.Drawing.Point(0, 0);
            this.piclogopanel.Name = "piclogopanel";
            this.piclogopanel.Size = new System.Drawing.Size(216, 179);
            this.piclogopanel.TabIndex = 2;
            // 
            // editstudentpanel
            // 
            this.editstudentpanel.Controls.Add(this.btnRegister);
            this.editstudentpanel.Controls.Add(this.btnManageStudent);
            this.editstudentpanel.Location = new System.Drawing.Point(1, 218);
            this.editstudentpanel.Name = "editstudentpanel";
            this.editstudentpanel.Size = new System.Drawing.Size(215, 81);
            this.editstudentpanel.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Blue;
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(0, 0);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(215, 42);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Registration";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnManageStudent
            // 
            this.btnManageStudent.BackColor = System.Drawing.Color.Blue;
            this.btnManageStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnManageStudent.FlatAppearance.BorderSize = 0;
            this.btnManageStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStudent.ForeColor = System.Drawing.Color.White;
            this.btnManageStudent.Location = new System.Drawing.Point(0, 42);
            this.btnManageStudent.Name = "btnManageStudent";
            this.btnManageStudent.Size = new System.Drawing.Size(215, 39);
            this.btnManageStudent.TabIndex = 1;
            this.btnManageStudent.Text = "Manage student";
            this.btnManageStudent.UseVisualStyleBackColor = false;
            this.btnManageStudent.Click += new System.EventHandler(this.btnManageStudent_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.MediumBlue;
            this.btnStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Location = new System.Drawing.Point(0, 182);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(216, 39);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Student";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.panelHeader.Location = new System.Drawing.Point(239, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(750, 38);
            this.panelHeader.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "National Aviation University Students Journal";
            // 
            // StudentList
            // 
            this.StudentList.BackColor = System.Drawing.Color.Blue;
            this.StudentList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.StudentList.FlatAppearance.BorderSize = 0;
            this.StudentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentList.ForeColor = System.Drawing.Color.White;
            this.StudentList.Location = new System.Drawing.Point(0, 296);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(216, 44);
            this.StudentList.TabIndex = 12;
            this.StudentList.Text = "View students";
            this.StudentList.UseVisualStyleBackColor = false;
            this.StudentList.Click += new System.EventHandler(this.StudentList_Click_1);
            // 
            // Viewallgroups
            // 
            this.Viewallgroups.BackColor = System.Drawing.Color.Blue;
            this.Viewallgroups.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.Viewallgroups.FlatAppearance.BorderSize = 0;
            this.Viewallgroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Viewallgroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewallgroups.ForeColor = System.Drawing.Color.White;
            this.Viewallgroups.Location = new System.Drawing.Point(1, 406);
            this.Viewallgroups.Name = "Viewallgroups";
            this.Viewallgroups.Size = new System.Drawing.Size(215, 44);
            this.Viewallgroups.TabIndex = 13;
            this.Viewallgroups.Text = "See all groups";
            this.Viewallgroups.UseVisualStyleBackColor = false;
            this.Viewallgroups.Click += new System.EventHandler(this.Viewallgroups_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TermPP.Properties.Resources.studypic;
            this.pictureBox1.Location = new System.Drawing.Point(239, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 310);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TermPP.Properties.Resources.nau;
            this.pictureBox2.Location = new System.Drawing.Point(18, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(215, 176);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(989, 344);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management Admin";
            this.MainPanel.ResumeLayout(false);
            this.piclogopanel.ResumeLayout(false);
            this.editstudentpanel.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnManageStudent;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel piclogopanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnManagegroup;
        private System.Windows.Forms.Button MangeSubject;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Panel editstudentpanel;
        private System.Windows.Forms.Button Viewallgroups;
        private System.Windows.Forms.Button StudentList;
    }
}