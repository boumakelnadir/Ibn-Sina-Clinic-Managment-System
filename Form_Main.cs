using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ibn_Sina_Clinic_Managment_System
{
    public partial class Form_Main : Form
    {
        public static List<Patient> CentralPatientsList = new List<Patient>();

        public static List<ClinicService> CentralServicesList = new List<ClinicService>();

        public static List<Appointment> CentralAppointmentsList = new List<Appointment>();

        public Form_Main()
        {
            InitializeComponent();

            this.IsMdiContainer = true;

            this.MdiChildActivate += (sender, e) =>
            {
                if (this.ActiveMdiChild != null)
                {
                   
                    this.Width = this.ActiveMdiChild.Width + pnl_left_parametre_section.Width + 50; 
                    this.Height = this.ActiveMdiChild.Height + pnl_top_title_section.Height + 50;
                }
            };
        }

        private void btn_patients_Click(object sender, EventArgs e)
        {
            
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            
            Form_Patients frm = new Form_Patients();

           
            frm.MdiParent = this;

            
            frm.Dock = DockStyle.Fill;

            
            frm.Show();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            Form_Services form_Services = new Form_Services();

            form_Services.MdiParent = this;

            form_Services.Dock = DockStyle.Fill;

            form_Services.Show();
        }

        private void btn_appointments_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            Form_Appointments form_appointment = new Form_Appointments();

            form_appointment.MdiParent = this;

            form_appointment.Dock = DockStyle.Fill;

            form_appointment.Show();
        }
    }
}
