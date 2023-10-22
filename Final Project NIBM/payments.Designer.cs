namespace Final_Project_NIBM
{
    partial class payments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picbox_nibm = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btnfees_pay = new System.Windows.Forms.Button();
            this.feestunam_txt = new System.Windows.Forms.TextBox();
            this.feesid_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.feestuid_combo = new System.Windows.Forms.ComboBox();
            this.feesamount_txt = new System.Windows.Forms.TextBox();
            this.feesdatetime_period = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_dep = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_stu = new System.Windows.Forms.Button();
            this.btn_lec = new System.Windows.Forms.Button();
            this.btn_fees = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_fees = new System.Windows.Forms.DataGridView();
            this.clear_btn = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_nibm)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fees)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_nibm
            // 
            this.picbox_nibm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_nibm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox_nibm.Image = ((System.Drawing.Image)(resources.GetObject("picbox_nibm.Image")));
            this.picbox_nibm.Location = new System.Drawing.Point(32, 24);
            this.picbox_nibm.Name = "picbox_nibm";
            this.picbox_nibm.Size = new System.Drawing.Size(143, 76);
            this.picbox_nibm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_nibm.TabIndex = 14;
            this.picbox_nibm.TabStop = false;
            this.picbox_nibm.Click += new System.EventHandler(this.picbox_nibm_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(45, 616);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(456, 46);
            this.btn_home.TabIndex = 69;
            this.btn_home.Text = "Dashboard";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btnfees_pay
            // 
            this.btnfees_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.btnfees_pay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfees_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfees_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfees_pay.ForeColor = System.Drawing.Color.White;
            this.btnfees_pay.Location = new System.Drawing.Point(45, 425);
            this.btnfees_pay.Name = "btnfees_pay";
            this.btnfees_pay.Size = new System.Drawing.Size(456, 46);
            this.btnfees_pay.TabIndex = 67;
            this.btnfees_pay.Text = "Pay";
            this.btnfees_pay.UseVisualStyleBackColor = false;
            this.btnfees_pay.Click += new System.EventHandler(this.btnfees_add_Click);
            // 
            // feestunam_txt
            // 
            this.feestunam_txt.Location = new System.Drawing.Point(200, 266);
            this.feestunam_txt.Name = "feestunam_txt";
            this.feestunam_txt.Size = new System.Drawing.Size(301, 22);
            this.feestunam_txt.TabIndex = 59;
            // 
            // feesid_txt
            // 
            this.feesid_txt.Location = new System.Drawing.Point(200, 184);
            this.feesid_txt.Name = "feesid_txt";
            this.feesid_txt.Size = new System.Drawing.Size(301, 22);
            this.feesid_txt.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(40, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(40, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "Period";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(40, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Payments List";
            // 
            // feestuid_combo
            // 
            this.feestuid_combo.FormattingEnabled = true;
            this.feestuid_combo.Location = new System.Drawing.Point(200, 226);
            this.feestuid_combo.Name = "feestuid_combo";
            this.feestuid_combo.Size = new System.Drawing.Size(301, 24);
            this.feestuid_combo.TabIndex = 72;
            this.feestuid_combo.SelectedIndexChanged += new System.EventHandler(this.feestuid_combo_SelectedIndexChanged);
            this.feestuid_combo.SelectionChangeCommitted += new System.EventHandler(this.feestuid_combo_SelectionChangeCommitted);
            // 
            // feesamount_txt
            // 
            this.feesamount_txt.Location = new System.Drawing.Point(200, 351);
            this.feesamount_txt.Name = "feesamount_txt";
            this.feesamount_txt.Size = new System.Drawing.Size(301, 22);
            this.feesamount_txt.TabIndex = 73;
            // 
            // feesdatetime_period
            // 
            this.feesdatetime_period.Location = new System.Drawing.Point(200, 309);
            this.feesdatetime_period.Name = "feesdatetime_period";
            this.feesdatetime_period.Size = new System.Drawing.Size(301, 22);
            this.feesdatetime_period.TabIndex = 74;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.btn_dep);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btn_stu);
            this.panel3.Controls.Add(this.btn_lec);
            this.panel3.Controls.Add(this.btn_fees);
            this.panel3.Location = new System.Drawing.Point(256, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1003, 119);
            this.panel3.TabIndex = 75;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(928, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 77;
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
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(962, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
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
            this.btn_fees.ForeColor = System.Drawing.Color.Silver;
            this.btn_fees.Location = new System.Drawing.Point(695, 24);
            this.btn_fees.Name = "btn_fees";
            this.btn_fees.Size = new System.Drawing.Size(201, 58);
            this.btn_fees.TabIndex = 11;
            this.btn_fees.Text = "Payments";
            this.btn_fees.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 838);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1259, 10);
            this.panel2.TabIndex = 76;
            // 
            // dgv_fees
            // 
            this.dgv_fees.AllowUserToAddRows = false;
            this.dgv_fees.AllowUserToDeleteRows = false;
            this.dgv_fees.AllowUserToResizeColumns = false;
            this.dgv_fees.AllowUserToResizeRows = false;
            this.dgv_fees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_fees.BackgroundColor = System.Drawing.Color.White;
            this.dgv_fees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_fees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_fees.ColumnHeadersHeight = 30;
            this.dgv_fees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_fees.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_fees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_fees.EnableHeadersVisualStyles = false;
            this.dgv_fees.GridColor = System.Drawing.Color.White;
            this.dgv_fees.Location = new System.Drawing.Point(549, 184);
            this.dgv_fees.Name = "dgv_fees";
            this.dgv_fees.ReadOnly = true;
            this.dgv_fees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_fees.RowHeadersVisible = false;
            this.dgv_fees.RowHeadersWidth = 51;
            this.dgv_fees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_fees.RowTemplate.Height = 24;
            this.dgv_fees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fees.Size = new System.Drawing.Size(698, 543);
            this.dgv_fees.TabIndex = 92;
            this.dgv_fees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_fees_CellContentClick);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(45, 554);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(456, 46);
            this.clear_btn.TabIndex = 95;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(148)))));
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.Color.White;
            this.btn_del.Location = new System.Drawing.Point(45, 490);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(456, 46);
            this.btn_del.TabIndex = 96;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 848);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.dgv_fees);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.feesdatetime_period);
            this.Controls.Add(this.feesamount_txt);
            this.Controls.Add(this.feestuid_combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btnfees_pay);
            this.Controls.Add(this.feestunam_txt);
            this.Controls.Add(this.feesid_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picbox_nibm);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_nibm)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_nibm;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btnfees_pay;
        private System.Windows.Forms.TextBox feestunam_txt;
        private System.Windows.Forms.TextBox feesid_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox feestuid_combo;
        private System.Windows.Forms.TextBox feesamount_txt;
        private System.Windows.Forms.DateTimePicker feesdatetime_period;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_dep;
        private System.Windows.Forms.Button btn_stu;
        private System.Windows.Forms.Button btn_lec;
        private System.Windows.Forms.Button btn_fees;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_fees;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button btn_del;
    }
}