using System;
using System.Linq;
using System.Windows.Forms;

namespace Ibn_Sina_Clinic_Managment_System
{
    public partial class Form_Appointments : Form
    {
        public Form_Appointments()
        {
            InitializeComponent();

            FillPatientsComboBox();
            FillServicesComboBox();
        }

        
        private void FillPatientsComboBox()
        {
            
            cbox_select_patients.Items.Clear();

            
            foreach (Patient patient in Form_Main.CentralPatientsList)
            {
                
                cbox_select_patients.Items.Add(patient.FullName);
            }
        }

        
        private void FillServicesComboBox()
        {
            
            cbox_select_service.Items.Clear();

           
            foreach (ClinicService service in Form_Main.CentralServicesList)
            {
                
                cbox_select_service.Items.Add(service.ServiceName);
            }
        }

        private void cbox_select_service_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
            if (cbox_select_service.SelectedIndex == -1) 
            {
                tb_price.Clear(); 
                return;
            }

           
            string selectedServiceName = cbox_select_service.SelectedItem.ToString();

           
            ClinicService selectedService = Form_Main.CentralServicesList
                                                     .FirstOrDefault(s => s.ServiceName == selectedServiceName);

            
            if (selectedService != null)
            {
                
                tb_price.Text = selectedService.Price.ToString();
            }
            else
            {
                
                tb_price.Clear();
            }
        }

        

        private void btn_Confirm_appointment_Click(object sender, EventArgs e)
        {
            
            if (cbox_select_patients.SelectedIndex == -1 || cbox_select_service.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء اختيار المريض والخدمة أولاً.");
                return;
            }

            
            Appointment newAppointment = new Appointment();

            
            newAppointment.PatientName = cbox_select_patients.SelectedItem.ToString();
            newAppointment.ServiceName = cbox_select_service.SelectedItem.ToString();
            
            newAppointment.Price = double.Parse(tb_price.Text);
            
            newAppointment.AppointmentDateTime = dateTimePicker1_date.Value;

           
            Form_Main.CentralAppointmentsList.Add(newAppointment);

           
            MessageBox.Show($"تم تأكيد الموعد للمريض '{newAppointment.PatientName}' بنجاح.");
            ClearFields();
        }

        private void ClearFields()
        {
           
            cbox_select_patients.SelectedIndex = -1;

            
            cbox_select_service.SelectedIndex = -1;

           
            tb_price.Clear();

            
            dateTimePicker1_date.Value = DateTime.Now;

            
            cbox_select_patients.Focus();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
