
namespace PruebaTecnica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.btnBorrarEmployee = new System.Windows.Forms.Button();
            this.btnExportExcelData = new System.Windows.Forms.Button();
            this.btnDetalleEmpleado = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(597, 172);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(12, 12);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(140, 23);
            this.AddEmployee.TabIndex = 1;
            this.AddEmployee.Text = "Agregar Empleado";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // btnBorrarEmployee
            // 
            this.btnBorrarEmployee.Location = new System.Drawing.Point(12, 41);
            this.btnBorrarEmployee.Name = "btnBorrarEmployee";
            this.btnBorrarEmployee.Size = new System.Drawing.Size(140, 23);
            this.btnBorrarEmployee.TabIndex = 2;
            this.btnBorrarEmployee.Text = "Eliminar Empleado";
            this.btnBorrarEmployee.UseVisualStyleBackColor = true;
            this.btnBorrarEmployee.Click += new System.EventHandler(this.btnBorrarEmployee_Click);
            // 
            // btnExportExcelData
            // 
            this.btnExportExcelData.Location = new System.Drawing.Point(459, 12);
            this.btnExportExcelData.Name = "btnExportExcelData";
            this.btnExportExcelData.Size = new System.Drawing.Size(150, 23);
            this.btnExportExcelData.TabIndex = 3;
            this.btnExportExcelData.Text = "Exportar Empleados";
            this.btnExportExcelData.UseVisualStyleBackColor = true;
            this.btnExportExcelData.Click += new System.EventHandler(this.btnExportExcelData_Click);
            // 
            // btnDetalleEmpleado
            // 
            this.btnDetalleEmpleado.Location = new System.Drawing.Point(459, 41);
            this.btnDetalleEmpleado.Name = "btnDetalleEmpleado";
            this.btnDetalleEmpleado.Size = new System.Drawing.Size(150, 23);
            this.btnDetalleEmpleado.TabIndex = 4;
            this.btnDetalleEmpleado.Text = "Detalle del Empleado";
            this.btnDetalleEmpleado.UseVisualStyleBackColor = true;
            this.btnDetalleEmpleado.Click += new System.EventHandler(this.btnDetalleEmpleado_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(269, 41);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 254);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDetalleEmpleado);
            this.Controls.Add(this.btnExportExcelData);
            this.Controls.Add(this.btnBorrarEmployee);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button btnBorrarEmployee;
        private System.Windows.Forms.Button btnExportExcelData;
        private System.Windows.Forms.Button btnDetalleEmpleado;
        private System.Windows.Forms.Button btnRefresh;
    }
}

