using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ibn_Sina_Clinic_Managment_System
{
    public partial class Form_Services : Form
    {
       
       public List<ClinicService> servicesList = new List<ClinicService>();

        
        ClinicService selectedServiceForEdit = null;

        public Form_Services()
        {
            InitializeComponent();

            
            dataGridView1_table_service.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1_table_service.AllowUserToAddRows = false;
            dataGridView1_table_service.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

       
        private void btn_add_new_service_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tb_service_name.Text) || numericUpDown1_service_price.Value <= 0)
            {
                MessageBox.Show("الرجاء إدخال اسم الخدمة وسعر صحيح.");
                return;
            }

            
            ClinicService newService = new ClinicService();

            
            newService.ServiceID = servicesList.Count + 1;
            newService.ServiceName = tb_service_name.Text;
            newService.Price = (double)numericUpDown1_service_price.Value;
            newService.Description = tb_service_description.Text;

           
            servicesList.Add(newService);
            Form_Main.CentralServicesList.Add(newService);

           
            UpdateDataGridView();

            
            ClearFields();
        }

        
        private void dataGridView1_table_service_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dataGridView1_table_service.SelectedRows.Count > 0)
            {
               
                int selectedId = (int)dataGridView1_table_service.SelectedRows[0].Cells["ServiceID"].Value;

                
                selectedServiceForEdit = servicesList.Find(s => s.ServiceID == selectedId);

                
                if (selectedServiceForEdit != null)
                {
                    tb_service_id.Text = selectedServiceForEdit.ServiceID.ToString();
                    tb_service_name.Text = selectedServiceForEdit.ServiceName;
                    numericUpDown1_service_price.Value = (decimal)selectedServiceForEdit.Price;
                    tb_service_description.Text = selectedServiceForEdit.Description;
                }
            }
        }

        
        private void UpdateDataGridView()
        {
            
            dataGridView1_table_service.DataSource = null;
            dataGridView1_table_service.DataSource = servicesList;
        }

        private void ClearFields()
        {
            tb_service_id.Clear();
            tb_service_name.Clear();
            numericUpDown1_service_price.Value = 0;
            tb_service_description.Clear();
            selectedServiceForEdit = null;
        }

        private void btn_clear_fields_Click(object sender, EventArgs e)
        {
            
            ClearFields();
        }

        private void btn_update_selected_Click(object sender, EventArgs e)
        {
            
            if (selectedServiceForEdit == null)
            {
                MessageBox.Show("الرجاء اختيار خدمة من الجدول أولاً لكي يتم تعديلها.");
                return;
            }

           
            if (string.IsNullOrEmpty(tb_service_name.Text) || numericUpDown1_service_price.Value <= 0)
            {
                MessageBox.Show("الرجاء التأكد من اسم الخدمة وسعر صحيح.");
                return;
            }

           
            selectedServiceForEdit.ServiceName = tb_service_name.Text;
            selectedServiceForEdit.Price = (double)numericUpDown1_service_price.Value;
            selectedServiceForEdit.Description = tb_service_description.Text;

            
            UpdateDataGridView();

           
            ClearFields();

            MessageBox.Show("تم تحديث الخدمة بنجاح.");
        }

        private void btn_delete_service_Click(object sender, EventArgs e)
        {
            
            if (selectedServiceForEdit == null)
            {
                MessageBox.Show("الرجاء اختيار خدمة من الجدول أولاً لكي يتم حذفها.");
                return;
            }

            
            DialogResult confirmResult = MessageBox.Show(
                $"هل أنت متأكد من حذف خدمة '{selectedServiceForEdit.ServiceName}'؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
              
                servicesList.Remove(selectedServiceForEdit);

                
                UpdateDataGridView();

               
                ClearFields();

                MessageBox.Show("تم حذف الخدمة.");
            }
        }



    }
}