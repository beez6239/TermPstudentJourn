
namespace TermPP
{
    partial class viewallgroups
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Back = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllgroups = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.allgroupgrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allgroupgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BorderColor = System.Drawing.Color.DarkGreen;
            this.Back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Back.FillColor = System.Drawing.Color.Maroon;
            this.Back.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(568, 331);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(89, 30);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // btnAllgroups
            // 
            this.btnAllgroups.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAllgroups.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllgroups.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllgroups.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllgroups.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllgroups.FillColor = System.Drawing.Color.DarkGreen;
            this.btnAllgroups.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllgroups.ForeColor = System.Drawing.Color.White;
            this.btnAllgroups.Location = new System.Drawing.Point(523, 6);
            this.btnAllgroups.Name = "btnAllgroups";
            this.btnAllgroups.Size = new System.Drawing.Size(134, 33);
            this.btnAllgroups.TabIndex = 4;
            this.btnAllgroups.Text = "View all groups";
            this.btnAllgroups.Click += new System.EventHandler(this.btnAllgroups_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.allgroupgrid);
            this.guna2Panel1.Location = new System.Drawing.Point(28, 42);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(629, 286);
            this.guna2Panel1.TabIndex = 3;
            // 
            // allgroupgrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.allgroupgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.allgroupgrid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allgroupgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.allgroupgrid.ColumnHeadersHeight = 4;
            this.allgroupgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allgroupgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.allgroupgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.allgroupgrid.Location = new System.Drawing.Point(3, 3);
            this.allgroupgrid.Name = "allgroupgrid";
            this.allgroupgrid.RowHeadersVisible = false;
            this.allgroupgrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.allgroupgrid.Size = new System.Drawing.Size(623, 280);
            this.allgroupgrid.TabIndex = 0;
            this.allgroupgrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.allgroupgrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.allgroupgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.allgroupgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.allgroupgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.allgroupgrid.ThemeStyle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.allgroupgrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.allgroupgrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.allgroupgrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.allgroupgrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allgroupgrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.allgroupgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.allgroupgrid.ThemeStyle.HeaderStyle.Height = 4;
            this.allgroupgrid.ThemeStyle.ReadOnly = false;
            this.allgroupgrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.allgroupgrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.allgroupgrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allgroupgrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.allgroupgrid.ThemeStyle.RowsStyle.Height = 22;
            this.allgroupgrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.allgroupgrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // viewallgroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(685, 366);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.btnAllgroups);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "viewallgroups";
            this.Text = "viewallgroup";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allgroupgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Back;
        private Guna.UI2.WinForms.Guna2Button btnAllgroups;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView allgroupgrid;
    }
}