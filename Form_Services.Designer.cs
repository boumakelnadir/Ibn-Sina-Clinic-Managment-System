namespace Ibn_Sina_Clinic_Managment_System
{
    partial class Form_Services
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
            this.tb_service_description = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.numericUpDown1_service_price = new System.Windows.Forms.NumericUpDown();
            this.lbl_price = new System.Windows.Forms.Label();
            this.tb_service_name = new System.Windows.Forms.TextBox();
            this.lbl_service_name = new System.Windows.Forms.Label();
            this.tb_service_id = new System.Windows.Forms.TextBox();
            this.lbl_service_id = new System.Windows.Forms.Label();
            this.lbl_add_edit_service = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_clear_fields = new System.Windows.Forms.Button();
            this.btn_delete_service = new System.Windows.Forms.Button();
            this.btn_update_selected = new System.Windows.Forms.Button();
            this.btn_add_new_service = new System.Windows.Forms.Button();
            this.lbl_available_service_list = new System.Windows.Forms.Label();
            this.dataGridView1_table_service = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_service_price)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_table_service)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.tb_service_description);
            this.panel1.Controls.Add(this.lbl_description);
            this.panel1.Controls.Add(this.numericUpDown1_service_price);
            this.panel1.Controls.Add(this.lbl_price);
            this.panel1.Controls.Add(this.tb_service_name);
            this.panel1.Controls.Add(this.lbl_service_name);
            this.panel1.Controls.Add(this.tb_service_id);
            this.panel1.Controls.Add(this.lbl_service_id);
            this.panel1.Controls.Add(this.lbl_add_edit_service);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 612);
            this.panel1.TabIndex = 0;
            // 
            // tb_service_description
            // 
            this.tb_service_description.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_service_description.Location = new System.Drawing.Point(172, 320);
            this.tb_service_description.Multiline = true;
            this.tb_service_description.Name = "tb_service_description";
            this.tb_service_description.Size = new System.Drawing.Size(231, 182);
            this.tb_service_description.TabIndex = 8;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(23, 318);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(117, 25);
            this.lbl_description.TabIndex = 7;
            this.lbl_description.Text = "Description :";
            // 
            // numericUpDown1_service_price
            // 
            this.numericUpDown1_service_price.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1_service_price.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1_service_price.Location = new System.Drawing.Point(172, 254);
            this.numericUpDown1_service_price.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1_service_price.Name = "numericUpDown1_service_price";
            this.numericUpDown1_service_price.Size = new System.Drawing.Size(231, 30);
            this.numericUpDown1_service_price.TabIndex = 6;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(23, 252);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(127, 25);
            this.lbl_price.TabIndex = 5;
            this.lbl_price.Text = "Price ( DZD ) :";
            // 
            // tb_service_name
            // 
            this.tb_service_name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_service_name.Location = new System.Drawing.Point(172, 185);
            this.tb_service_name.Name = "tb_service_name";
            this.tb_service_name.Size = new System.Drawing.Size(231, 33);
            this.tb_service_name.TabIndex = 4;
            // 
            // lbl_service_name
            // 
            this.lbl_service_name.AutoSize = true;
            this.lbl_service_name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_service_name.Location = new System.Drawing.Point(23, 186);
            this.lbl_service_name.Name = "lbl_service_name";
            this.lbl_service_name.Size = new System.Drawing.Size(136, 25);
            this.lbl_service_name.TabIndex = 3;
            this.lbl_service_name.Text = "Service Name :";
            // 
            // tb_service_id
            // 
            this.tb_service_id.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_service_id.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_service_id.Location = new System.Drawing.Point(172, 116);
            this.tb_service_id.Name = "tb_service_id";
            this.tb_service_id.ReadOnly = true;
            this.tb_service_id.Size = new System.Drawing.Size(231, 33);
            this.tb_service_id.TabIndex = 2;
            // 
            // lbl_service_id
            // 
            this.lbl_service_id.AutoSize = true;
            this.lbl_service_id.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_service_id.Location = new System.Drawing.Point(23, 120);
            this.lbl_service_id.Name = "lbl_service_id";
            this.lbl_service_id.Size = new System.Drawing.Size(104, 25);
            this.lbl_service_id.TabIndex = 1;
            this.lbl_service_id.Text = "Service ID :";
            // 
            // lbl_add_edit_service
            // 
            this.lbl_add_edit_service.AutoSize = true;
            this.lbl_add_edit_service.BackColor = System.Drawing.Color.Transparent;
            this.lbl_add_edit_service.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_edit_service.Location = new System.Drawing.Point(21, 51);
            this.lbl_add_edit_service.Name = "lbl_add_edit_service";
            this.lbl_add_edit_service.Size = new System.Drawing.Size(178, 25);
            this.lbl_add_edit_service.TabIndex = 0;
            this.lbl_add_edit_service.Text = "Add / Edit Services";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_clear_fields);
            this.panel2.Controls.Add(this.btn_delete_service);
            this.panel2.Controls.Add(this.btn_update_selected);
            this.panel2.Controls.Add(this.btn_add_new_service);
            this.panel2.Controls.Add(this.lbl_available_service_list);
            this.panel2.Controls.Add(this.dataGridView1_table_service);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(438, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 612);
            this.panel2.TabIndex = 1;
            // 
            // btn_clear_fields
            // 
            this.btn_clear_fields.BackColor = System.Drawing.Color.Gold;
            this.btn_clear_fields.FlatAppearance.BorderSize = 0;
            this.btn_clear_fields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_fields.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_fields.Location = new System.Drawing.Point(460, 492);
            this.btn_clear_fields.Name = "btn_clear_fields";
            this.btn_clear_fields.Size = new System.Drawing.Size(107, 66);
            this.btn_clear_fields.TabIndex = 13;
            this.btn_clear_fields.Text = "Clear Fields";
            this.btn_clear_fields.UseVisualStyleBackColor = false;
            this.btn_clear_fields.Click += new System.EventHandler(this.btn_clear_fields_Click);
            // 
            // btn_delete_service
            // 
            this.btn_delete_service.BackColor = System.Drawing.Color.Crimson;
            this.btn_delete_service.FlatAppearance.BorderSize = 0;
            this.btn_delete_service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_service.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_service.Location = new System.Drawing.Point(316, 492);
            this.btn_delete_service.Name = "btn_delete_service";
            this.btn_delete_service.Size = new System.Drawing.Size(107, 66);
            this.btn_delete_service.TabIndex = 12;
            this.btn_delete_service.Text = "Delete Service";
            this.btn_delete_service.UseVisualStyleBackColor = false;
            this.btn_delete_service.Click += new System.EventHandler(this.btn_delete_service_Click);
            // 
            // btn_update_selected
            // 
            this.btn_update_selected.BackColor = System.Drawing.Color.Cyan;
            this.btn_update_selected.FlatAppearance.BorderSize = 0;
            this.btn_update_selected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_selected.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_selected.Location = new System.Drawing.Point(172, 492);
            this.btn_update_selected.Name = "btn_update_selected";
            this.btn_update_selected.Size = new System.Drawing.Size(107, 66);
            this.btn_update_selected.TabIndex = 11;
            this.btn_update_selected.Text = "Update Selected";
            this.btn_update_selected.UseVisualStyleBackColor = false;
            this.btn_update_selected.Click += new System.EventHandler(this.btn_update_selected_Click);
            // 
            // btn_add_new_service
            // 
            this.btn_add_new_service.BackColor = System.Drawing.Color.Turquoise;
            this.btn_add_new_service.FlatAppearance.BorderSize = 0;
            this.btn_add_new_service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_new_service.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_new_service.Location = new System.Drawing.Point(28, 492);
            this.btn_add_new_service.Name = "btn_add_new_service";
            this.btn_add_new_service.Size = new System.Drawing.Size(107, 66);
            this.btn_add_new_service.TabIndex = 10;
            this.btn_add_new_service.Text = "Add New Service";
            this.btn_add_new_service.UseVisualStyleBackColor = false;
            this.btn_add_new_service.Click += new System.EventHandler(this.btn_add_new_service_Click);
            // 
            // lbl_available_service_list
            // 
            this.lbl_available_service_list.AutoSize = true;
            this.lbl_available_service_list.BackColor = System.Drawing.Color.Transparent;
            this.lbl_available_service_list.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_available_service_list.Location = new System.Drawing.Point(24, 51);
            this.lbl_available_service_list.Name = "lbl_available_service_list";
            this.lbl_available_service_list.Size = new System.Drawing.Size(206, 25);
            this.lbl_available_service_list.TabIndex = 9;
            this.lbl_available_service_list.Text = "Available Service List :";
            // 
            // dataGridView1_table_service
            // 
            this.dataGridView1_table_service.AllowUserToAddRows = false;
            this.dataGridView1_table_service.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_table_service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_table_service.Location = new System.Drawing.Point(29, 120);
            this.dataGridView1_table_service.Name = "dataGridView1_table_service";
            this.dataGridView1_table_service.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_table_service.Size = new System.Drawing.Size(538, 357);
            this.dataGridView1_table_service.TabIndex = 0;
            this.dataGridView1_table_service.SelectionChanged += new System.EventHandler(this.dataGridView1_table_service_SelectionChanged);
            // 
            // Form_Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1033, 612);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Services";
            this.ShowIcon = false;
            this.Text = "Services";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_service_price)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_table_service)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_add_edit_service;
        private System.Windows.Forms.Label lbl_service_id;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.NumericUpDown numericUpDown1_service_price;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox tb_service_name;
        private System.Windows.Forms.Label lbl_service_name;
        private System.Windows.Forms.TextBox tb_service_id;
        private System.Windows.Forms.TextBox tb_service_description;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1_table_service;
        private System.Windows.Forms.Button btn_clear_fields;
        private System.Windows.Forms.Button btn_delete_service;
        private System.Windows.Forms.Button btn_update_selected;
        private System.Windows.Forms.Button btn_add_new_service;
        private System.Windows.Forms.Label lbl_available_service_list;
    }
}