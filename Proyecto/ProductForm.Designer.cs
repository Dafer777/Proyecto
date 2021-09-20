
namespace Proyecto
{
    partial class ProductForm
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAgeEmp = new System.Windows.Forms.Label();
            this.lblbirthDate = new System.Windows.Forms.Label();
            this.lblDateEmp = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblnameEmp = new System.Windows.Forms.Label();
            this.lblCodEmp = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblNameEmployee = new System.Windows.Forms.Label();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblAge);
            this.grpDatos.Controls.Add(this.lblAgeEmp);
            this.grpDatos.Controls.Add(this.lblbirthDate);
            this.grpDatos.Controls.Add(this.lblDateEmp);
            this.grpDatos.Controls.Add(this.lblFullname);
            this.grpDatos.Controls.Add(this.lblnameEmp);
            this.grpDatos.Controls.Add(this.lblCodEmp);
            this.grpDatos.Controls.Add(this.lblCod);
            this.grpDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.Location = new System.Drawing.Point(29, 131);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(483, 426);
            this.grpDatos.TabIndex = 7;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Empleado";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(280, 228);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 20);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "label";
            // 
            // lblAgeEmp
            // 
            this.lblAgeEmp.AutoSize = true;
            this.lblAgeEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeEmp.Location = new System.Drawing.Point(43, 228);
            this.lblAgeEmp.Name = "lblAgeEmp";
            this.lblAgeEmp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAgeEmp.Size = new System.Drawing.Size(84, 20);
            this.lblAgeEmp.TabIndex = 8;
            this.lblAgeEmp.Text = "categoria";
            // 
            // lblbirthDate
            // 
            this.lblbirthDate.AutoSize = true;
            this.lblbirthDate.Location = new System.Drawing.Point(280, 168);
            this.lblbirthDate.Name = "lblbirthDate";
            this.lblbirthDate.Size = new System.Drawing.Size(42, 20);
            this.lblbirthDate.TabIndex = 7;
            this.lblbirthDate.Text = "label";
            // 
            // lblDateEmp
            // 
            this.lblDateEmp.AutoSize = true;
            this.lblDateEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEmp.Location = new System.Drawing.Point(39, 168);
            this.lblDateEmp.Name = "lblDateEmp";
            this.lblDateEmp.Size = new System.Drawing.Size(58, 20);
            this.lblDateEmp.TabIndex = 6;
            this.lblDateEmp.Text = "precio";
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(280, 108);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(42, 20);
            this.lblFullname.TabIndex = 3;
            this.lblFullname.Text = "label";
            // 
            // lblnameEmp
            // 
            this.lblnameEmp.AutoSize = true;
            this.lblnameEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameEmp.Location = new System.Drawing.Point(43, 108);
            this.lblnameEmp.Name = "lblnameEmp";
            this.lblnameEmp.Size = new System.Drawing.Size(147, 20);
            this.lblnameEmp.TabIndex = 2;
            this.lblnameEmp.Text = "Nombre producto";
            this.lblnameEmp.Click += new System.EventHandler(this.lblnameEmp_Click);
            // 
            // lblCodEmp
            // 
            this.lblCodEmp.AutoSize = true;
            this.lblCodEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEmp.Location = new System.Drawing.Point(43, 48);
            this.lblCodEmp.Name = "lblCodEmp";
            this.lblCodEmp.Size = new System.Drawing.Size(65, 20);
            this.lblCodEmp.TabIndex = 1;
            this.lblCodEmp.Text = "Codigo";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(280, 48);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(42, 20);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "label";
            // 
            // lblNameEmployee
            // 
            this.lblNameEmployee.AutoSize = true;
            this.lblNameEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.lblNameEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEmployee.ForeColor = System.Drawing.Color.Black;
            this.lblNameEmployee.Location = new System.Drawing.Point(29, 49);
            this.lblNameEmployee.Name = "lblNameEmployee";
            this.lblNameEmployee.Size = new System.Drawing.Size(70, 25);
            this.lblNameEmployee.TabIndex = 6;
            this.lblNameEmployee.Text = "label2";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 628);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.lblNameEmployee);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAgeEmp;
        private System.Windows.Forms.Label lblbirthDate;
        private System.Windows.Forms.Label lblDateEmp;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblnameEmp;
        private System.Windows.Forms.Label lblCodEmp;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblNameEmployee;
    }
}