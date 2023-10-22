namespace Final_Project_NIBM
{
    partial class StudentReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentReport));
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cMSreport = new Final_Project_NIBM.CMSreport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmd_fillstuid = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.studentsTableAdapter = new Final_Project_NIBM.CMSreportTableAdapters.studentsTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_dep = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_stu = new System.Windows.Forms.Button();
            this.btn_lec = new System.Windows.Forms.Button();
            this.btn_fees = new System.Windows.Forms.Button();
            this.picbox_nibm = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSreport)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_nibm)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.cMSreport;
            // 
            // cMSreport
            // 
            this.cMSreport.DataSetName = "CMSreport";
            this.cMSreport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.studentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Final_Project_NIBM.CMSreport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 301);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1235, 508);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmd_fillstuid
            // 
            this.cmd_fillstuid.FormattingEnabled = true;
            this.cmd_fillstuid.Location = new System.Drawing.Point(885, 159);
            this.cmd_fillstuid.Name = "cmd_fillstuid";
            this.cmd_fillstuid.Size = new System.Drawing.Size(327, 24);
            this.cmd_fillstuid.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(885, 201);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(327, 46);
            this.btn_search.TabIndex = 68;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(760, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 69;
            this.label4.Text = "Student ID";
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.btn_dep);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btn_stu);
            this.panel3.Controls.Add(this.btn_lec);
            this.panel3.Controls.Add(this.btn_fees);
            this.panel3.Location = new System.Drawing.Point(256, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1003, 119);
            this.panel3.TabIndex = 71;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(928, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btn_dep
            // 
            this.btn_dep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.btn_dep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dep.ForeColor = System.Drawing.Color.White;
            this.btn_dep.Location = new System.Drawing.Point(472, 24);
            this.btn_dep.Name = "btn_dep";
            this.btn_dep.Size = new System.Drawing.Size(202, 58);
            this.btn_dep.TabIndex = 10;
            this.btn_dep.Text = "Departments";
            this.btn_dep.UseVisualStyleBackColor = false;
            this.btn_dep.Click += new System.EventHandler(this.btn_dep_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(962, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_stu
            // 
            this.btn_stu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.btn_stu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_stu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stu.ForeColor = System.Drawing.Color.White;
            this.btn_stu.Location = new System.Drawing.Point(39, 24);
            this.btn_stu.Name = "btn_stu";
            this.btn_stu.Size = new System.Drawing.Size(193, 58);
            this.btn_stu.TabIndex = 8;
            this.btn_stu.Text = "Students";
            this.btn_stu.UseVisualStyleBackColor = false;
            this.btn_stu.Click += new System.EventHandler(this.btn_stu_Click);
            // 
            // btn_lec
            // 
            this.btn_lec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.btn_lec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lec.ForeColor = System.Drawing.Color.White;
            this.btn_lec.Location = new System.Drawing.Point(253, 24);
            this.btn_lec.Name = "btn_lec";
            this.btn_lec.Size = new System.Drawing.Size(199, 58);
            this.btn_lec.TabIndex = 9;
            this.btn_lec.Text = "Lecturers";
            this.btn_lec.UseVisualStyleBackColor = false;
            this.btn_lec.Click += new System.EventHandler(this.btn_lec_Click);
            // 
            // btn_fees
            // 
            this.btn_fees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.btn_fees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fees.ForeColor = System.Drawing.Color.White;
            this.btn_fees.Location = new System.Drawing.Point(695, 24);
            this.btn_fees.Name = "btn_fees";
            this.btn_fees.Size = new System.Drawing.Size(201, 58);
            this.btn_fees.TabIndex = 11;
            this.btn_fees.Text = "Payments";
            this.btn_fees.UseVisualStyleBackColor = false;
            this.btn_fees.Click += new System.EventHandler(this.btn_fees_Click);
            // 
            // picbox_nibm
            // 
            this.picbox_nibm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_nibm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox_nibm.Image = ((System.Drawing.Image)(resources.GetObject("picbox_nibm.Image")));
            this.picbox_nibm.Location = new System.Drawing.Point(38, 24);
            this.picbox_nibm.Name = "picbox_nibm";
            this.picbox_nibm.Size = new System.Drawing.Size(143, 76);
            this.picbox_nibm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_nibm.TabIndex = 70;
            this.picbox_nibm.TabStop = false;
            this.picbox_nibm.Click += new System.EventHandler(this.picbox_nibm_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 838);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1259, 10);
            this.panel2.TabIndex = 72;
            // 
            // StudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 848);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.picbox_nibm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cmd_fillstuid);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentReport";
            this.Load += new System.EventHandler(this.StudentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSreport)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_nibm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cmd_fillstuid;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private CMSreport cMSreport;
        private CMSreportTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_dep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_stu;
        private System.Windows.Forms.Button btn_lec;
        private System.Windows.Forms.Button btn_fees;
        private System.Windows.Forms.PictureBox picbox_nibm;
        private System.Windows.Forms.Panel panel2;
    }
}