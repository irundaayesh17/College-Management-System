namespace Final_Project_NIBM
{
    partial class Lecturers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lecturers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picbox_nibm = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_dep = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_stu = new System.Windows.Forms.Button();
            this.btn_lec = new System.Windows.Forms.Button();
            this.btn_fees = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.lectel_txt = new System.Windows.Forms.TextBox();
            this.btnlec_del = new System.Windows.Forms.Button();
            this.btnlec_add = new System.Windows.Forms.Button();
            this.btnlec_edit = new System.Windows.Forms.Button();
            this.lecgender_combo = new System.Windows.Forms.ComboBox();
            this.lecdep_combo = new System.Windows.Forms.ComboBox();
            this.lecadd_richtxt = new System.Windows.Forms.RichTextBox();
            this.lecdob_datetime = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.lecage_txt = new System.Windows.Forms.TextBox();
            this.lecname_txt = new System.Windows.Forms.TextBox();
            this.lecid_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_dep = new System.Windows.Forms.DataGridView();
            this.clear_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_nibm)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dep)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_nibm
            // 
            this.picbox_nibm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_nibm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox_nibm.Image = ((System.Drawing.Image)(resources.GetObject("picbox_nibm.Image")));
            this.picbox_nibm.Location = new System.Drawing.Point(36, 24);
            this.picbox_nibm.Name = "picbox_nibm";
            this.picbox_nibm.Size = new System.Drawing.Size(143, 76);
            this.picbox_nibm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_nibm.TabIndex = 14;
            this.picbox_nibm.TabStop = false;
            this.picbox_nibm.Click += new System.EventHandler(this.picbox_nibm_Click);
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
            this.panel3.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(928, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 53;
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
            this.pictureBox1.TabIndex = 52;
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
            this.btn_lec.ForeColor = System.Drawing.Color.Silver;
            this.btn_lec.Location = new System.Drawing.Point(253, 24);
            this.btn_lec.Name = "btn_lec";
            this.btn_lec.Size = new System.Drawing.Size(199, 58);
            this.btn_lec.TabIndex = 9;
            this.btn_lec.Text = "Lecturers";
            this.btn_lec.UseVisualStyleBackColor = false;
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
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(49, 694);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(456, 46);
            this.btn_home.TabIndex = 49;
            this.btn_home.Text = "Dashboard";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // lectel_txt
            // 
            this.lectel_txt.Location = new System.Drawing.Point(204, 473);
            this.lectel_txt.Name = "lectel_txt";
            this.lectel_txt.Size = new System.Drawing.Size(301, 22);
            this.lectel_txt.TabIndex = 40;
            // 
            // btnlec_del
            // 
            this.btnlec_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.btnlec_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlec_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlec_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlec_del.ForeColor = System.Drawing.Color.White;
            this.btnlec_del.Location = new System.Drawing.Point(375, 571);
            this.btnlec_del.Margin = new System.Windows.Forms.Padding(0);
            this.btnlec_del.Name = "btnlec_del";
            this.btnlec_del.Size = new System.Drawing.Size(130, 46);
            this.btnlec_del.TabIndex = 48;
            this.btnlec_del.Text = "Delete";
            this.btnlec_del.UseVisualStyleBackColor = false;
            this.btnlec_del.Click += new System.EventHandler(this.btnlec_del_Click);
            // 
            // btnlec_add
            // 
            this.btnlec_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.btnlec_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlec_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlec_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlec_add.ForeColor = System.Drawing.Color.White;
            this.btnlec_add.Location = new System.Drawing.Point(213, 571);
            this.btnlec_add.Name = "btnlec_add";
            this.btnlec_add.Size = new System.Drawing.Size(130, 46);
            this.btnlec_add.TabIndex = 47;
            this.btnlec_add.Text = "Add";
            this.btnlec_add.UseVisualStyleBackColor = false;
            this.btnlec_add.Click += new System.EventHandler(this.btnlec_add_Click);
            // 
            // btnlec_edit
            // 
            this.btnlec_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.btnlec_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlec_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlec_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlec_edit.ForeColor = System.Drawing.Color.White;
            this.btnlec_edit.Location = new System.Drawing.Point(49, 571);
            this.btnlec_edit.Name = "btnlec_edit";
            this.btnlec_edit.Size = new System.Drawing.Size(130, 46);
            this.btnlec_edit.TabIndex = 46;
            this.btnlec_edit.Text = "Edit";
            this.btnlec_edit.UseVisualStyleBackColor = false;
            this.btnlec_edit.Click += new System.EventHandler(this.btnlec_edit_Click);
            // 
            // lecgender_combo
            // 
            this.lecgender_combo.FormattingEnabled = true;
            this.lecgender_combo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.lecgender_combo.Location = new System.Drawing.Point(204, 268);
            this.lecgender_combo.Name = "lecgender_combo";
            this.lecgender_combo.Size = new System.Drawing.Size(301, 24);
            this.lecgender_combo.TabIndex = 45;
            // 
            // lecdep_combo
            // 
            this.lecdep_combo.FormattingEnabled = true;
            this.lecdep_combo.Items.AddRange(new object[] {
            "uiui"});
            this.lecdep_combo.Location = new System.Drawing.Point(204, 513);
            this.lecdep_combo.Name = "lecdep_combo";
            this.lecdep_combo.Size = new System.Drawing.Size(301, 24);
            this.lecdep_combo.TabIndex = 44;
            // 
            // lecadd_richtxt
            // 
            this.lecadd_richtxt.Location = new System.Drawing.Point(204, 397);
            this.lecadd_richtxt.Name = "lecadd_richtxt";
            this.lecadd_richtxt.Size = new System.Drawing.Size(301, 62);
            this.lecadd_richtxt.TabIndex = 43;
            this.lecadd_richtxt.Text = "";
            // 
            // lecdob_datetime
            // 
            this.lecdob_datetime.CalendarForeColor = System.Drawing.Color.White;
            this.lecdob_datetime.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.lecdob_datetime.CalendarTitleForeColor = System.Drawing.Color.White;
            this.lecdob_datetime.Location = new System.Drawing.Point(204, 311);
            this.lecdob_datetime.Name = "lecdob_datetime";
            this.lecdob_datetime.Size = new System.Drawing.Size(301, 22);
            this.lecdob_datetime.TabIndex = 42;
            this.lecdob_datetime.ValueChanged += new System.EventHandler(this.lecdob_datetime_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(44, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 25);
            this.label11.TabIndex = 39;
            this.label11.Text = "Address";
            // 
            // lecage_txt
            // 
            this.lecage_txt.Location = new System.Drawing.Point(204, 353);
            this.lecage_txt.Name = "lecage_txt";
            this.lecage_txt.Size = new System.Drawing.Size(301, 22);
            this.lecage_txt.TabIndex = 38;
            this.lecage_txt.TextChanged += new System.EventHandler(this.lecage_txt_TextChanged);
            // 
            // lecname_txt
            // 
            this.lecname_txt.Location = new System.Drawing.Point(204, 227);
            this.lecname_txt.Name = "lecname_txt";
            this.lecname_txt.Size = new System.Drawing.Size(301, 22);
            this.lecname_txt.TabIndex = 37;
            // 
            // lecid_txt
            // 
            this.lecid_txt.Location = new System.Drawing.Point(204, 186);
            this.lecid_txt.Name = "lecid_txt";
            this.lecid_txt.Size = new System.Drawing.Size(301, 22);
            this.lecid_txt.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(44, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(44, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Telephone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(44, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(44, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(44, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(44, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(44, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Teachers List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 838);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1259, 10);
            this.panel2.TabIndex = 52;
            // 
            // dgv_dep
            // 
            this.dgv_dep.AllowUserToAddRows = false;
            this.dgv_dep.AllowUserToDeleteRows = false;
            this.dgv_dep.AllowUserToResizeColumns = false;
            this.dgv_dep.AllowUserToResizeRows = false;
            this.dgv_dep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dep.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_dep.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_dep.ColumnHeadersHeight = 30;
            this.dgv_dep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_dep.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_dep.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_dep.EnableHeadersVisualStyles = false;
            this.dgv_dep.GridColor = System.Drawing.Color.White;
            this.dgv_dep.Location = new System.Drawing.Point(549, 184);
            this.dgv_dep.Name = "dgv_dep";
            this.dgv_dep.ReadOnly = true;
            this.dgv_dep.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_dep.RowHeadersVisible = false;
            this.dgv_dep.RowHeadersWidth = 51;
            this.dgv_dep.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_dep.RowTemplate.Height = 24;
            this.dgv_dep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dep.Size = new System.Drawing.Size(698, 543);
            this.dgv_dep.TabIndex = 92;
            this.dgv_dep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dep_CellContentClick);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(49, 633);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(456, 46);
            this.clear_btn.TabIndex = 95;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Lecturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 848);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.dgv_dep);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.lectel_txt);
            this.Controls.Add(this.btnlec_del);
            this.Controls.Add(this.btnlec_add);
            this.Controls.Add(this.btnlec_edit);
            this.Controls.Add(this.lecgender_combo);
            this.Controls.Add(this.lecdep_combo);
            this.Controls.Add(this.lecadd_richtxt);
            this.Controls.Add(this.lecdob_datetime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lecage_txt);
            this.Controls.Add(this.lecname_txt);
            this.Controls.Add(this.lecid_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picbox_nibm);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lecturers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecturers";
            this.Load += new System.EventHandler(this.Lecturers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_nibm)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_nibm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_dep;
        private System.Windows.Forms.Button btn_stu;
        private System.Windows.Forms.Button btn_lec;
        private System.Windows.Forms.Button btn_fees;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.TextBox lectel_txt;
        private System.Windows.Forms.Button btnlec_del;
        private System.Windows.Forms.Button btnlec_add;
        private System.Windows.Forms.Button btnlec_edit;
        private System.Windows.Forms.ComboBox lecgender_combo;
        private System.Windows.Forms.ComboBox lecdep_combo;
        private System.Windows.Forms.RichTextBox lecadd_richtxt;
        private System.Windows.Forms.DateTimePicker lecdob_datetime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox lecage_txt;
        private System.Windows.Forms.TextBox lecname_txt;
        private System.Windows.Forms.TextBox lecid_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_dep;
        private System.Windows.Forms.Button clear_btn;
    }
}