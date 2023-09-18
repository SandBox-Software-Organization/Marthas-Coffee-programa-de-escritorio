namespace MarthaSCoffee.UI.WindowsForm
{
    partial class Administración
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
            this.Proveedores = new System.Windows.Forms.TabPage();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.txtId_Proveedor = new System.Windows.Forms.TextBox();
            this.txtFK_IdProduct = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.lblIdproducto = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.tbcAdministracion = new System.Windows.Forms.TabControl();
            this.Empleados = new System.Windows.Forms.TabPage();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAreas = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Proveedores.SuspendLayout();
            this.tbcAdministracion.SuspendLayout();
            this.Empleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // Proveedores
            // 
            this.Proveedores.Controls.Add(this.btnMostrarDatos);
            this.Proveedores.Controls.Add(this.txtId_Proveedor);
            this.Proveedores.Controls.Add(this.txtFK_IdProduct);
            this.Proveedores.Controls.Add(this.txtNombreProveedor);
            this.Proveedores.Controls.Add(this.label24);
            this.Proveedores.Controls.Add(this.lblIdproducto);
            this.Proveedores.Controls.Add(this.btnGuardar);
            this.Proveedores.Controls.Add(this.label26);
            this.Proveedores.Location = new System.Drawing.Point(4, 22);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Padding = new System.Windows.Forms.Padding(3);
            this.Proveedores.Size = new System.Drawing.Size(682, 373);
            this.Proveedores.TabIndex = 3;
            this.Proveedores.Text = "Proveedores";
            this.Proveedores.UseVisualStyleBackColor = true;
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(447, 168);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(197, 57);
            this.btnMostrarDatos.TabIndex = 64;
            this.btnMostrarDatos.Text = "Mostrar datos guardados";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            // 
            // txtId_Proveedor
            // 
            this.txtId_Proveedor.Location = new System.Drawing.Point(233, 205);
            this.txtId_Proveedor.Name = "txtId_Proveedor";
            this.txtId_Proveedor.Size = new System.Drawing.Size(173, 20);
            this.txtId_Proveedor.TabIndex = 59;
            // 
            // txtFK_IdProduct
            // 
            this.txtFK_IdProduct.Location = new System.Drawing.Point(233, 48);
            this.txtFK_IdProduct.Name = "txtFK_IdProduct";
            this.txtFK_IdProduct.Size = new System.Drawing.Size(173, 20);
            this.txtFK_IdProduct.TabIndex = 57;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(233, 125);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(173, 20);
            this.txtNombreProveedor.TabIndex = 54;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(62, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 13);
            this.label24.TabIndex = 58;
            this.label24.Text = "Id Proveedor";
            // 
            // lblIdproducto
            // 
            this.lblIdproducto.AutoSize = true;
            this.lblIdproducto.Location = new System.Drawing.Point(65, 212);
            this.lblIdproducto.Name = "lblIdproducto";
            this.lblIdproducto.Size = new System.Drawing.Size(65, 13);
            this.lblIdproducto.TabIndex = 56;
            this.lblIdproducto.Text = "Id_Producto";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(447, 88);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(197, 57);
            this.btnGuardar.TabIndex = 55;
            this.btnGuardar.Text = "Guardar datos";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(62, 132);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(112, 13);
            this.label26.TabIndex = 53;
            this.label26.Text = "Nombre del proveedor";
            // 
            // tbcAdministracion
            // 
            this.tbcAdministracion.Controls.Add(this.Proveedores);
            this.tbcAdministracion.Controls.Add(this.Empleados);
            this.tbcAdministracion.Location = new System.Drawing.Point(23, 29);
            this.tbcAdministracion.Name = "tbcAdministracion";
            this.tbcAdministracion.SelectedIndex = 0;
            this.tbcAdministracion.Size = new System.Drawing.Size(690, 399);
            this.tbcAdministracion.TabIndex = 0;
            // 
            // Empleados
            // 
            this.Empleados.Controls.Add(this.btnShow);
            this.Empleados.Controls.Add(this.btnSave);
            this.Empleados.Controls.Add(this.cmbAreas);
            this.Empleados.Controls.Add(this.label2);
            this.Empleados.Controls.Add(this.txtNombre);
            this.Empleados.Controls.Add(this.c);
            this.Empleados.Controls.Add(this.txtIdEmpleado);
            this.Empleados.Controls.Add(this.label1);
            this.Empleados.Location = new System.Drawing.Point(4, 22);
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(682, 373);
            this.Empleados.TabIndex = 4;
            this.Empleados.Text = "Empleados";
            this.Empleados.UseVisualStyleBackColor = true;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(265, 52);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(173, 20);
            this.txtIdEmpleado.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "ID Empleado";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(265, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 20);
            this.txtNombre.TabIndex = 61;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(94, 100);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(49, 13);
            this.c.TabIndex = 62;
            this.c.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Área";
            // 
            // cmbAreas
            // 
            this.cmbAreas.FormattingEnabled = true;
            this.cmbAreas.Location = new System.Drawing.Point(265, 162);
            this.cmbAreas.Name = "cmbAreas";
            this.cmbAreas.Size = new System.Drawing.Size(172, 21);
            this.cmbAreas.TabIndex = 65;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(241, 292);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(197, 57);
            this.btnShow.TabIndex = 67;
            this.btnShow.Text = "Mostrar datos guardados";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(241, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 57);
            this.btnSave.TabIndex = 66;
            this.btnSave.Text = "Guardar datos";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Administración
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.tbcAdministracion);
            this.Name = "Administración";
            this.Text = "Administración";
            this.Proveedores.ResumeLayout(false);
            this.Proveedores.PerformLayout();
            this.tbcAdministracion.ResumeLayout(false);
            this.Empleados.ResumeLayout(false);
            this.Empleados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Proveedores;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.TextBox txtId_Proveedor;
        private System.Windows.Forms.TextBox txtFK_IdProduct;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblIdproducto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TabControl tbcAdministracion;
        private System.Windows.Forms.TabPage Empleados;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAreas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSave;
    }
}