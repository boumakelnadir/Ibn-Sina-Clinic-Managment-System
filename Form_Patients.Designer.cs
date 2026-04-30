namespace Ibn_Sina_Clinic_Managment_System
{
    partial class Form_Patients
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
            this.pnl_input = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.cbox_bloodgroup2 = new System.Windows.Forms.ComboBox();
            this.cbox_bloodgroup1 = new System.Windows.Forms.ComboBox();
            this.cbox_gender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.lbl_bloodgroup = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.tb_phonenumber = new System.Windows.Forms.TextBox();
            this.lbl_phonenumber = new System.Windows.Forms.Label();
            this.tb_fullname = new System.Windows.Forms.TextBox();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.lbl_patient_details = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_new_patient = new System.Windows.Forms.Label();
            this.pbox_person = new System.Windows.Forms.PictureBox();
            this.pnl_display = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.tb_search_patients = new System.Windows.Forms.TextBox();
            this.lbl_patient_list = new System.Windows.Forms.Label();
            this.dataGridView_patient_list = new System.Windows.Forms.DataGridView();
            this.pnl_input.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_person)).BeginInit();
            this.pnl_display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patient_list)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_input
            // 
            this.pnl_input.BackColor = System.Drawing.Color.SeaShell;
            this.pnl_input.Controls.Add(this.btn_delete);
            this.pnl_input.Controls.Add(this.btn_clear);
            this.pnl_input.Controls.Add(this.btn_save);
            this.pnl_input.Controls.Add(this.cbox_bloodgroup2);
            this.pnl_input.Controls.Add(this.cbox_bloodgroup1);
            this.pnl_input.Controls.Add(this.cbox_gender);
            this.pnl_input.Controls.Add(this.dateTimePicker_birthday);
            this.pnl_input.Controls.Add(this.lbl_bloodgroup);
            this.pnl_input.Controls.Add(this.lbl_gender);
            this.pnl_input.Controls.Add(this.lbl_birthday);
            this.pnl_input.Controls.Add(this.tb_address);
            this.pnl_input.Controls.Add(this.lbl_address);
            this.pnl_input.Controls.Add(this.tb_phonenumber);
            this.pnl_input.Controls.Add(this.lbl_phonenumber);
            this.pnl_input.Controls.Add(this.tb_fullname);
            this.pnl_input.Controls.Add(this.lbl_fullname);
            this.pnl_input.Controls.Add(this.lbl_patient_details);
            this.pnl_input.Controls.Add(this.panel1);
            this.pnl_input.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_input.Location = new System.Drawing.Point(0, 0);
            this.pnl_input.Name = "pnl_input";
            this.pnl_input.Size = new System.Drawing.Size(407, 612);
            this.pnl_input.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Crimson;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.Location = new System.Drawing.Point(274, 534);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(101, 43);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clear.Location = new System.Drawing.Point(159, 534);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(101, 43);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_save.Location = new System.Drawing.Point(44, 534);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 43);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cbox_bloodgroup2
            // 
            this.cbox_bloodgroup2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_bloodgroup2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_bloodgroup2.FormattingEnabled = true;
            this.cbox_bloodgroup2.Items.AddRange(new object[] {
            "Positive",
            "Negative"});
            this.cbox_bloodgroup2.Location = new System.Drawing.Point(239, 482);
            this.cbox_bloodgroup2.Name = "cbox_bloodgroup2";
            this.cbox_bloodgroup2.Size = new System.Drawing.Size(136, 27);
            this.cbox_bloodgroup2.TabIndex = 14;
            // 
            // cbox_bloodgroup1
            // 
            this.cbox_bloodgroup1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_bloodgroup1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_bloodgroup1.FormattingEnabled = true;
            this.cbox_bloodgroup1.Items.AddRange(new object[] {
            "A",
            "B",
            "O",
            "AB"});
            this.cbox_bloodgroup1.Location = new System.Drawing.Point(150, 483);
            this.cbox_bloodgroup1.Name = "cbox_bloodgroup1";
            this.cbox_bloodgroup1.Size = new System.Drawing.Size(83, 27);
            this.cbox_bloodgroup1.TabIndex = 13;
            // 
            // cbox_gender
            // 
            this.cbox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_gender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_gender.FormattingEnabled = true;
            this.cbox_gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cbox_gender.Location = new System.Drawing.Point(150, 438);
            this.cbox_gender.Name = "cbox_gender";
            this.cbox_gender.Size = new System.Drawing.Size(225, 27);
            this.cbox_gender.Sorted = true;
            this.cbox_gender.TabIndex = 12;
            // 
            // dateTimePicker_birthday
            // 
            this.dateTimePicker_birthday.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_birthday.Location = new System.Drawing.Point(150, 395);
            this.dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            this.dateTimePicker_birthday.Size = new System.Drawing.Size(225, 27);
            this.dateTimePicker_birthday.TabIndex = 11;
            // 
            // lbl_bloodgroup
            // 
            this.lbl_bloodgroup.AutoSize = true;
            this.lbl_bloodgroup.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bloodgroup.Location = new System.Drawing.Point(25, 482);
            this.lbl_bloodgroup.Name = "lbl_bloodgroup";
            this.lbl_bloodgroup.Size = new System.Drawing.Size(119, 25);
            this.lbl_bloodgroup.TabIndex = 10;
            this.lbl_bloodgroup.Text = "Blood Group";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(25, 437);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(74, 25);
            this.lbl_gender.TabIndex = 9;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthday.Location = new System.Drawing.Point(25, 396);
            this.lbl_birthday.Name = "lbl_birthday";
            this.lbl_birthday.Size = new System.Drawing.Size(84, 25);
            this.lbl_birthday.TabIndex = 8;
            this.lbl_birthday.Text = "BirthDay";
            // 
            // tb_address
            // 
            this.tb_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_address.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address.Location = new System.Drawing.Point(22, 311);
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(353, 69);
            this.tb_address.TabIndex = 7;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(25, 279);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(79, 25);
            this.lbl_address.TabIndex = 6;
            this.lbl_address.Text = "Address";
            // 
            // tb_phonenumber
            // 
            this.tb_phonenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_phonenumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phonenumber.Location = new System.Drawing.Point(22, 245);
            this.tb_phonenumber.Name = "tb_phonenumber";
            this.tb_phonenumber.Size = new System.Drawing.Size(353, 27);
            this.tb_phonenumber.TabIndex = 5;
            // 
            // lbl_phonenumber
            // 
            this.lbl_phonenumber.AutoSize = true;
            this.lbl_phonenumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phonenumber.Location = new System.Drawing.Point(25, 213);
            this.lbl_phonenumber.Name = "lbl_phonenumber";
            this.lbl_phonenumber.Size = new System.Drawing.Size(140, 25);
            this.lbl_phonenumber.TabIndex = 4;
            this.lbl_phonenumber.Text = "Phone Number";
            // 
            // tb_fullname
            // 
            this.tb_fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_fullname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fullname.Location = new System.Drawing.Point(22, 179);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(353, 27);
            this.tb_fullname.TabIndex = 3;
            
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullname.Location = new System.Drawing.Point(25, 147);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(97, 25);
            this.lbl_fullname.TabIndex = 2;
            this.lbl_fullname.Text = "Full Name";
            // 
            // lbl_patient_details
            // 
            this.lbl_patient_details.AutoSize = true;
            this.lbl_patient_details.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_details.Location = new System.Drawing.Point(21, 112);
            this.lbl_patient_details.Name = "lbl_patient_details";
            this.lbl_patient_details.Size = new System.Drawing.Size(139, 25);
            this.lbl_patient_details.TabIndex = 1;
            this.lbl_patient_details.Text = "Patient Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_new_patient);
            this.panel1.Controls.Add(this.pbox_person);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbl_new_patient
            // 
            this.lbl_new_patient.AutoSize = true;
            this.lbl_new_patient.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_patient.Location = new System.Drawing.Point(154, 41);
            this.lbl_new_patient.Name = "lbl_new_patient";
            this.lbl_new_patient.Size = new System.Drawing.Size(134, 25);
            this.lbl_new_patient.TabIndex = 1;
            this.lbl_new_patient.Text = "New Patients";
            // 
            // pbox_person
            // 
            this.pbox_person.Image = global::Ibn_Sina_Clinic_Managment_System.Properties.Resources.man_user_circle_icon;
            this.pbox_person.Location = new System.Drawing.Point(22, 12);
            this.pbox_person.Name = "pbox_person";
            this.pbox_person.Size = new System.Drawing.Size(100, 79);
            this.pbox_person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_person.TabIndex = 0;
            this.pbox_person.TabStop = false;
            // 
            // pnl_display
            // 
            this.pnl_display.Controls.Add(this.btn_refresh);
            this.pnl_display.Controls.Add(this.tb_search_patients);
            this.pnl_display.Controls.Add(this.lbl_patient_list);
            this.pnl_display.Controls.Add(this.dataGridView_patient_list);
            this.pnl_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_display.Location = new System.Drawing.Point(407, 0);
            this.pnl_display.Name = "pnl_display";
            this.pnl_display.Size = new System.Drawing.Size(626, 612);
            this.pnl_display.TabIndex = 1;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_refresh.Location = new System.Drawing.Point(478, 527);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(123, 40);
            this.btn_refresh.TabIndex = 18;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            // 
            // tb_search_patients
            // 
            this.tb_search_patients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_search_patients.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search_patients.Location = new System.Drawing.Point(21, 534);
            this.tb_search_patients.Name = "tb_search_patients";
            this.tb_search_patients.Size = new System.Drawing.Size(439, 30);
            this.tb_search_patients.TabIndex = 18;
            this.tb_search_patients.Text = "Search Patients....";
            this.tb_search_patients.TextChanged += new System.EventHandler(this.tb_search_patients_TextChanged);
            // 
            // lbl_patient_list
            // 
            this.lbl_patient_list.AutoSize = true;
            this.lbl_patient_list.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient_list.Location = new System.Drawing.Point(16, 66);
            this.lbl_patient_list.Name = "lbl_patient_list";
            this.lbl_patient_list.Size = new System.Drawing.Size(110, 25);
            this.lbl_patient_list.TabIndex = 18;
            this.lbl_patient_list.Text = "Patient List";
            // 
            // dataGridView_patient_list
            // 
            this.dataGridView_patient_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_patient_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_patient_list.Location = new System.Drawing.Point(21, 103);
            this.dataGridView_patient_list.Name = "dataGridView_patient_list";
            this.dataGridView_patient_list.Size = new System.Drawing.Size(580, 404);
            this.dataGridView_patient_list.TabIndex = 0;
            this.dataGridView_patient_list.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_patient_list_CellDoubleClick);
            // 
            // Form_Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1033, 612);
            this.Controls.Add(this.pnl_display);
            this.Controls.Add(this.pnl_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Patients";
            this.Text = "Form_Patients";
            this.pnl_input.ResumeLayout(false);
            this.pnl_input.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_person)).EndInit();
            this.pnl_display.ResumeLayout(false);
            this.pnl_display.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patient_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_input;
        private System.Windows.Forms.Panel pnl_display;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbox_person;
        private System.Windows.Forms.Label lbl_new_patient;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_phonenumber;
        private System.Windows.Forms.TextBox tb_fullname;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.Label lbl_patient_details;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthday;
        private System.Windows.Forms.Label lbl_bloodgroup;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_birthday;
        private System.Windows.Forms.TextBox tb_phonenumber;
        private System.Windows.Forms.ComboBox cbox_gender;
        private System.Windows.Forms.ComboBox cbox_bloodgroup1;
        private System.Windows.Forms.ComboBox cbox_bloodgroup2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox tb_search_patients;
        private System.Windows.Forms.Label lbl_patient_list;
        private System.Windows.Forms.DataGridView dataGridView_patient_list;
    }
}