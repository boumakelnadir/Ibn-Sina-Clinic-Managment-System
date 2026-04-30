namespace Ibn_Sina_Clinic_Managment_System
{
    partial class Form_Appointments
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_appointment_details = new System.Windows.Forms.GroupBox();
            this.tb_notes = new System.Windows.Forms.TextBox();
            this.lbl_notes = new System.Windows.Forms.Label();
            this.pnl_date_and_time = new System.Windows.Forms.Panel();
            this.dateTimePicker2_time = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_date_and_time = new System.Windows.Forms.Label();
            this.lbl_message_linked_to = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.cbox_select_service = new System.Windows.Forms.ComboBox();
            this.lbl_select_service = new System.Windows.Forms.Label();
            this.cbox_select_patients = new System.Windows.Forms.ComboBox();
            this.lbl_select_patients = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gb_confirm_booking = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.lbl_choice_service = new System.Windows.Forms.Label();
            this.lbl_summary = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gb_appointment_details.SuspendLayout();
            this.pnl_date_and_time.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gb_confirm_booking.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.gb_appointment_details);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 573);
            this.panel1.TabIndex = 0;
            // 
            // gb_appointment_details
            // 
            this.gb_appointment_details.Controls.Add(this.tb_notes);
            this.gb_appointment_details.Controls.Add(this.lbl_notes);
            this.gb_appointment_details.Controls.Add(this.pnl_date_and_time);
            this.gb_appointment_details.Controls.Add(this.lbl_date_and_time);
            this.gb_appointment_details.Controls.Add(this.lbl_message_linked_to);
            this.gb_appointment_details.Controls.Add(this.tb_price);
            this.gb_appointment_details.Controls.Add(this.lbl_price);
            this.gb_appointment_details.Controls.Add(this.cbox_select_service);
            this.gb_appointment_details.Controls.Add(this.lbl_select_service);
            this.gb_appointment_details.Controls.Add(this.cbox_select_patients);
            this.gb_appointment_details.Controls.Add(this.lbl_select_patients);
            this.gb_appointment_details.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_appointment_details.Location = new System.Drawing.Point(21, 42);
            this.gb_appointment_details.Name = "gb_appointment_details";
            this.gb_appointment_details.Size = new System.Drawing.Size(526, 508);
            this.gb_appointment_details.TabIndex = 0;
            this.gb_appointment_details.TabStop = false;
            this.gb_appointment_details.Text = "Appointment Details";
            // 
            // tb_notes
            // 
            this.tb_notes.Location = new System.Drawing.Point(174, 343);
            this.tb_notes.Multiline = true;
            this.tb_notes.Name = "tb_notes";
            this.tb_notes.Size = new System.Drawing.Size(330, 148);
            this.tb_notes.TabIndex = 10;
            // 
            // lbl_notes
            // 
            this.lbl_notes.AutoSize = true;
            this.lbl_notes.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notes.Location = new System.Drawing.Point(14, 365);
            this.lbl_notes.Name = "lbl_notes";
            this.lbl_notes.Size = new System.Drawing.Size(57, 23);
            this.lbl_notes.TabIndex = 9;
            this.lbl_notes.Text = "Notes";
            // 
            // pnl_date_and_time
            // 
            this.pnl_date_and_time.BackColor = System.Drawing.Color.Aquamarine;
            this.pnl_date_and_time.Controls.Add(this.dateTimePicker2_time);
            this.pnl_date_and_time.Controls.Add(this.dateTimePicker1_date);
            this.pnl_date_and_time.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_date_and_time.Location = new System.Drawing.Point(174, 237);
            this.pnl_date_and_time.Name = "pnl_date_and_time";
            this.pnl_date_and_time.Size = new System.Drawing.Size(330, 82);
            this.pnl_date_and_time.TabIndex = 8;
            // 
            // dateTimePicker2_time
            // 
            this.dateTimePicker2_time.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2_time.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2_time.Location = new System.Drawing.Point(169, 30);
            this.dateTimePicker2_time.Name = "dateTimePicker2_time";
            this.dateTimePicker2_time.Size = new System.Drawing.Size(135, 27);
            this.dateTimePicker2_time.TabIndex = 1;
            // 
            // dateTimePicker1_date
            // 
            this.dateTimePicker1_date.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1_date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1_date.Location = new System.Drawing.Point(15, 30);
            this.dateTimePicker1_date.Name = "dateTimePicker1_date";
            this.dateTimePicker1_date.Size = new System.Drawing.Size(135, 27);
            this.dateTimePicker1_date.TabIndex = 0;
            // 
            // lbl_date_and_time
            // 
            this.lbl_date_and_time.AutoSize = true;
            this.lbl_date_and_time.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_and_time.Location = new System.Drawing.Point(14, 267);
            this.lbl_date_and_time.Name = "lbl_date_and_time";
            this.lbl_date_and_time.Size = new System.Drawing.Size(134, 23);
            this.lbl_date_and_time.TabIndex = 7;
            this.lbl_date_and_time.Text = "Date and Time";
            // 
            // lbl_message_linked_to
            // 
            this.lbl_message_linked_to.AutoSize = true;
            this.lbl_message_linked_to.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message_linked_to.Location = new System.Drawing.Point(196, 194);
            this.lbl_message_linked_to.Name = "lbl_message_linked_to";
            this.lbl_message_linked_to.Size = new System.Drawing.Size(250, 19);
            this.lbl_message_linked_to.TabIndex = 6;
            this.lbl_message_linked_to.Text = "(Linked to \"Consultation General\")";
            // 
            // tb_price
            // 
            this.tb_price.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_price.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.ForeColor = System.Drawing.Color.SeaGreen;
            this.tb_price.Location = new System.Drawing.Point(185, 146);
            this.tb_price.Name = "tb_price";
            this.tb_price.ReadOnly = true;
            this.tb_price.Size = new System.Drawing.Size(261, 30);
            this.tb_price.TabIndex = 5;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(14, 146);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(107, 23);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price (DZD)";
            // 
            // cbox_select_service
            // 
            this.cbox_select_service.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_select_service.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_select_service.FormattingEnabled = true;
            this.cbox_select_service.Location = new System.Drawing.Point(185, 95);
            this.cbox_select_service.Name = "cbox_select_service";
            this.cbox_select_service.Size = new System.Drawing.Size(261, 31);
            this.cbox_select_service.TabIndex = 3;
            this.cbox_select_service.SelectedIndexChanged += new System.EventHandler(this.cbox_select_service_SelectedIndexChanged);
            // 
            // lbl_select_service
            // 
            this.lbl_select_service.AutoSize = true;
            this.lbl_select_service.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_select_service.Location = new System.Drawing.Point(14, 98);
            this.lbl_select_service.Name = "lbl_select_service";
            this.lbl_select_service.Size = new System.Drawing.Size(126, 23);
            this.lbl_select_service.TabIndex = 2;
            this.lbl_select_service.Text = "Select Service";
            // 
            // cbox_select_patients
            // 
            this.cbox_select_patients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_select_patients.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_select_patients.FormattingEnabled = true;
            this.cbox_select_patients.Location = new System.Drawing.Point(185, 49);
            this.cbox_select_patients.Name = "cbox_select_patients";
            this.cbox_select_patients.Size = new System.Drawing.Size(261, 31);
            this.cbox_select_patients.TabIndex = 1;
            // 
            // lbl_select_patients
            // 
            this.lbl_select_patients.AutoSize = true;
            this.lbl_select_patients.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_select_patients.Location = new System.Drawing.Point(14, 52);
            this.lbl_select_patients.Name = "lbl_select_patients";
            this.lbl_select_patients.Size = new System.Drawing.Size(131, 23);
            this.lbl_select_patients.TabIndex = 0;
            this.lbl_select_patients.Text = "Select Patients";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.gb_confirm_booking);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(567, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 573);
            this.panel3.TabIndex = 1;
            // 
            // gb_confirm_booking
            // 
            this.gb_confirm_booking.Controls.Add(this.btn_cancel);
            this.gb_confirm_booking.Controls.Add(this.btn_confirm);
            this.gb_confirm_booking.Controls.Add(this.lbl_choice_service);
            this.gb_confirm_booking.Controls.Add(this.lbl_summary);
            this.gb_confirm_booking.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_confirm_booking.Location = new System.Drawing.Point(18, 42);
            this.gb_confirm_booking.Name = "gb_confirm_booking";
            this.gb_confirm_booking.Size = new System.Drawing.Size(420, 508);
            this.gb_confirm_booking.TabIndex = 0;
            this.gb_confirm_booking.TabStop = false;
            this.gb_confirm_booking.Text = "Confirm Booking";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.Location = new System.Drawing.Point(38, 325);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(359, 117);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel Appointment";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_confirm.Location = new System.Drawing.Point(38, 153);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(359, 117);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "Confirm Appointment";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_Confirm_appointment_Click);
            // 
            // lbl_choice_service
            // 
            this.lbl_choice_service.AutoSize = true;
            this.lbl_choice_service.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choice_service.Location = new System.Drawing.Point(136, 95);
            this.lbl_choice_service.Name = "lbl_choice_service";
            this.lbl_choice_service.Size = new System.Drawing.Size(193, 23);
            this.lbl_choice_service.TabIndex = 1;
            this.lbl_choice_service.Text = "Consulatation General";
            // 
            // lbl_summary
            // 
            this.lbl_summary.AutoSize = true;
            this.lbl_summary.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_summary.Location = new System.Drawing.Point(21, 72);
            this.lbl_summary.Name = "lbl_summary";
            this.lbl_summary.Size = new System.Drawing.Size(109, 23);
            this.lbl_summary.TabIndex = 0;
            this.lbl_summary.Text = "Summary : ";
            // 
            // Form_Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 573);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Appointments";
            this.Text = "Form_Appointments";
            this.panel1.ResumeLayout(false);
            this.gb_appointment_details.ResumeLayout(false);
            this.gb_appointment_details.PerformLayout();
            this.pnl_date_and_time.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gb_confirm_booking.ResumeLayout(false);
            this.gb_confirm_booking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb_appointment_details;
        private System.Windows.Forms.Label lbl_select_patients;
        private System.Windows.Forms.ComboBox cbox_select_service;
        private System.Windows.Forms.Label lbl_select_service;
        private System.Windows.Forms.ComboBox cbox_select_patients;
        private System.Windows.Forms.Panel pnl_date_and_time;
        private System.Windows.Forms.Label lbl_date_and_time;
        private System.Windows.Forms.Label lbl_message_linked_to;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox tb_notes;
        private System.Windows.Forms.Label lbl_notes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker2_time;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gb_confirm_booking;
        private System.Windows.Forms.Label lbl_choice_service;
        private System.Windows.Forms.Label lbl_summary;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
    }
}