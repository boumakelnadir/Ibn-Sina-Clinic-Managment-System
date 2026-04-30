using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Ibn_Sina_Clinic_Managment_System
{
    public partial class Form_Patients : Form
    {
        
        public List<Patient> patientsList = new List<Patient>();

       
        Patient selectedPatientForEdit = null;


        public Form_Patients()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            tb_fullname.Clear();
            tb_phonenumber.Clear();
            tb_address.Clear();
            dateTimePicker_birthday.Value = DateTime.Now;

            
            if (cbox_gender.Items.Count > 0) cbox_gender.SelectedIndex = -1;
            if (cbox_bloodgroup1.Items.Count > 0) cbox_bloodgroup1.SelectedIndex = -1;
            if (cbox_bloodgroup2.Items.Count > 0) cbox_bloodgroup2.SelectedIndex = -1;

            
            btn_save.Text = "Save Patient";
            btn_save.BackColor = System.Drawing.Color.SeaGreen; 
            selectedPatientForEdit = null;
        }
        private void RefreshGrid()
        {
            
            dataGridView_patient_list.DataSource = null;

            
            dataGridView_patient_list.DataSource = patientsList;

           
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_fullname.Text))
            {
                MessageBox.Show("خطأ: يرجى كتابة اسم المريض أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tb_phonenumber.Text.Any(c => !char.IsDigit(c)))
            {
                MessageBox.Show("خطأ: رقم الهاتف يجب أن يحتوي على أرقام فقط", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedPatientForEdit == null)
            {
                
                Patient newPatient = new Patient()
                {
                    FullName = tb_fullname.Text,
                    Phone = tb_phonenumber.Text,
                    Address = tb_address.Text,
                    BirthDate = dateTimePicker_birthday.Value,
                    Gender = cbox_gender.SelectedItem?.ToString(),
                    BloodGroup = cbox_bloodgroup1.SelectedItem?.ToString() + " " + cbox_bloodgroup2.SelectedItem?.ToString()
                };
                patientsList.Add(newPatient);
                Form_Main.CentralPatientsList.Add(newPatient);
                MessageBox.Show("تم إضافة المريض بنجاح.");
            }
            else
            {
                
                selectedPatientForEdit.FullName = tb_fullname.Text;
                selectedPatientForEdit.Phone = tb_phonenumber.Text;
                selectedPatientForEdit.Address = tb_address.Text;
                selectedPatientForEdit.BirthDate = dateTimePicker_birthday.Value;
                selectedPatientForEdit.Gender = cbox_gender.SelectedItem?.ToString();
                selectedPatientForEdit.BloodGroup = cbox_bloodgroup1.SelectedItem?.ToString() + " " + cbox_bloodgroup2.SelectedItem?.ToString();

                
                selectedPatientForEdit = null;
                btn_save.Text = "Save Patient";
                btn_save.BackColor = Color.SeaGreen; 
                MessageBox.Show("تم تحديث بيانات المريض بنجاح.");
            }

           
            RefreshGrid();
            ClearFields();


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            
            tb_fullname.Clear();
            tb_phonenumber.Clear();
            tb_address.Clear();

            
            dateTimePicker_birthday.Value = DateTime.Now;

            
            cbox_gender.SelectedIndex = -1;
            cbox_bloodgroup1.SelectedIndex = -1;

            
            tb_fullname.Focus();

        }

        private void tb_search_patients_TextChanged(object sender, EventArgs e)
        {
            string searchText = tb_search_patients.Text.ToLower();

            
            var filteredList = patientsList.Where(p =>
                p.FullName.ToLower().Contains(searchText) ||
                p.Phone.Contains(searchText)
            ).ToList();

            
            dataGridView_patient_list.DataSource = null;
            dataGridView_patient_list.DataSource = filteredList;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

           
            if (dataGridView_patient_list.SelectedRows.Count > 0)
            {
                
                DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذا المريض؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    
                    Patient selectedPatient = (Patient)dataGridView_patient_list.SelectedRows[0].DataBoundItem;

                   
                    patientsList.Remove(selectedPatient);

                    
                    dataGridView_patient_list.DataSource = null;
                    dataGridView_patient_list.DataSource = patientsList;

                    MessageBox.Show("تم حذف المريض بنجاح.");
                }
            }
            else
            {
                MessageBox.Show("يرجى اختيار مريض من الجدول أولاً!");
            }

        }

        private void dataGridView_patient_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dataGridView_patient_list.SelectedRows.Count > 0)
            {
                
                selectedPatientForEdit = (Patient)dataGridView_patient_list.SelectedRows[0].DataBoundItem;

                
                tb_fullname.Text = selectedPatientForEdit.FullName;
                tb_phonenumber.Text = selectedPatientForEdit.Phone;
                tb_address.Text = selectedPatientForEdit.Address;
                dateTimePicker_birthday.Value = selectedPatientForEdit.BirthDate;
                cbox_gender.SelectedItem = selectedPatientForEdit.Gender;

                
                btn_save.Text = "Update Patient";
                btn_save.BackColor = Color.Orange;
            }



        }


    }

}
