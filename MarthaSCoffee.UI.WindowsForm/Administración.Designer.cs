namespace MarthaSCoffee.UI.WindowsForm
{
    partial class Administracion
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
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnMostrarProveedores = new System.Windows.Forms.Button();
            this.txtFK_IdProduct = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.lblIdproducto = new System.Windows.Forms.Label();
            this.btnGuardarProveedor = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.tbcAdministracion = new System.Windows.Forms.TabControl();
            this.Empleados = new System.Windows.Forms.TabPage();
            this.btnCancelarEM = new System.Windows.Forms.Button();
            this.btnShowEmpleados = new System.Windows.Forms.Button();
            this.btnSaveEmpleado = new System.Windows.Forms.Button();
            this.cmbAreas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Areas = new System.Windows.Forms.TabPage();
            this.CancelarArea = new System.Windows.Forms.Button();
            this.MostrarAreas = new System.Windows.Forms.Button();
            this.SaveAreas = new System.Windows.Forms.Button();
            this.txtNombreArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDAreas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Productos = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Proveedores.SuspendLayout();
            this.tbcAdministracion.SuspendLayout();
            this.Empleados.SuspendLayout();
            this.Areas.SuspendLayout();
            this.Productos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Proveedores
            // 
            this.Proveedores.Controls.Add(this.cmbProductos);
            this.Proveedores.Controls.Add(this.btnCancelar);
            this.Proveedores.Controls.Add(this.btnMostrarProveedores);
            this.Proveedores.Controls.Add(this.txtFK_IdProduct);
            this.Proveedores.Controls.Add(this.txtNombreProveedor);
            this.Proveedores.Controls.Add(this.label24);
            this.Proveedores.Controls.Add(this.lblIdproducto);
            this.Proveedores.Controls.Add(this.btnGuardarProveedor);
            this.Proveedores.Controls.Add(this.label26);
            this.Proveedores.Location = new System.Drawing.Point(4, 22);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Padding = new System.Windows.Forms.Padding(3);
            this.Proveedores.Size = new System.Drawing.Size(639, 379);
            this.Proveedores.TabIndex = 3;
            this.Proveedores.Text = "Proveedores";
            this.Proveedores.UseVisualStyleBackColor = true;
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(201, 202);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(173, 21);
            this.cmbProductos.TabIndex = 77;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::MarthaSCoffee.UI.WindowsForm.Properties.Resources._9004781_file_document_paper_page_icon;
            this.btnCancelar.Location = new System.Drawing.Point(210, 268);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(164, 70);
            this.btnCancelar.TabIndex = 76;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnMostrarProveedores
            // 
            this.btnMostrarProveedores.Image = global::MarthaSCoffee.UI.WindowsForm.Properties.Resources._2742782_archive_document_documents_file_files_icon;
            this.btnMostrarProveedores.Location = new System.Drawing.Point(429, 48);
            this.btnMostrarProveedores.Name = "btnMostrarProveedores";
            this.btnMostrarProveedores.Size = new System.Drawing.Size(164, 70);
            this.btnMostrarProveedores.TabIndex = 64;
            this.btnMostrarProveedores.Text = "Mostrar datos guardados";
            this.btnMostrarProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostrarProveedores.UseVisualStyleBackColor = true;
            // 
            // txtFK_IdProduct
            // 
            this.txtFK_IdProduct.Enabled = false;
            this.txtFK_IdProduct.Location = new System.Drawing.Point(201, 48);
            this.txtFK_IdProduct.Name = "txtFK_IdProduct";
            this.txtFK_IdProduct.Size = new System.Drawing.Size(173, 20);
            this.txtFK_IdProduct.TabIndex = 57;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(201, 125);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(173, 20);
            this.txtNombreProveedor.TabIndex = 54;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(29, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 13);
            this.label24.TabIndex = 58;
            this.label24.Text = "Id Proveedor";
            // 
            // lblIdproducto
            // 
            this.lblIdproducto.AutoSize = true;
            this.lblIdproducto.Location = new System.Drawing.Point(29, 205);
            this.lblIdproducto.Name = "lblIdproducto";
            this.lblIdproducto.Size = new System.Drawing.Size(65, 13);
            this.lblIdproducto.TabIndex = 56;
            this.lblIdproducto.Text = "Id_Producto";
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.Image = global::MarthaSCoffee.UI.WindowsForm.Properties.Resources._3669255_ic_save_floppy_icon__1_;
            this.btnGuardarProveedor.Location = new System.Drawing.Point(32, 268);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(164, 70);
            this.btnGuardarProveedor.TabIndex = 55;
            this.btnGuardarProveedor.Text = "Guardar datos";
            this.btnGuardarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarProveedor.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(29, 128);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(112, 13);
            this.label26.TabIndex = 53;
            this.label26.Text = "Nombre del proveedor";
            // 
            // tbcAdministracion
            // 
            this.tbcAdministracion.Controls.Add(this.Proveedores);
            this.tbcAdministracion.Controls.Add(this.Empleados);
            this.tbcAdministracion.Controls.Add(this.Areas);
            this.tbcAdministracion.Controls.Add(this.Productos);
            this.tbcAdministracion.Location = new System.Drawing.Point(23, 29);
            this.tbcAdministracion.Name = "tbcAdministracion";
            this.tbcAdministracion.SelectedIndex = 0;
            this.tbcAdministracion.Size = new System.Drawing.Size(647, 405);
            this.tbcAdministracion.TabIndex = 0;
            // 
            // Empleados
            // 
            this.Empleados.Controls.Add(this.btnCancelarEM);
            this.Empleados.Controls.Add(this.btnShowEmpleados);
            this.Empleados.Controls.Add(this.btnSaveEmpleado);
            this.Empleados.Controls.Add(this.cmbAreas);
            this.Empleados.Controls.Add(this.label2);
            this.Empleados.Controls.Add(this.txtNombre);
            this.Empleados.Controls.Add(this.c);
            this.Empleados.Controls.Add(this.txtIdEmpleado);
            this.Empleados.Controls.Add(this.label1);
            this.Empleados.Location = new System.Drawing.Point(4, 22);
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(639, 379);
            this.Empleados.TabIndex = 4;
            this.Empleados.Text = "Empleados";
            this.Empleados.UseVisualStyleBackColor = true;
            // 
            // btnCancelarEM
            // 
            this.btnCancelarEM.Image = global::MarthaSCoffee.UI.WindowsForm.Properties.Resources._9004781_file_document_paper_page_icon;
            this.btnCancelarEM.Location = new System.Drawing.Point(198, 239);
            this.btnCancelarEM.Name = "btnCancelarEM";
            this.btnCancelarEM.Size = new System.Drawing.Size(164, 70);
            this.btnCancelarEM.TabIndex = 75;
            this.btnCancelarEM.Text = "Cancelar";
            this.btnCancelarEM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarEM.UseVisualStyleBackColor = true;
            this.btnCancelarEM.Click += new System.EventHandler(this.btnCancelarEM_Click);
            // 
            // btnShowEmpleados
            // 
            this.btnShowEmpleados.Image = global::MarthaSCoffee.UI.WindowsForm.Properties.Resources._2742782_archive_document_documents_file_files_icon;
            this.btnShowEmpleados.Location = new System.Drawing.Point(420, 50);
            this.btnShowEmpleados.Name = "btnShowEmpleados";
            this.btnShowEmpleados.Size = new System.Drawing.Size(164, 70);
            this.btnShowEmpleados.TabIndex = 67;
            this.btnShowEmpleados.Text = "Mostrar datos guardados";
            this.btnShowEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowEmpleados.UseVisualStyleBackColor = true;
            this.btnShowEmpleados.Click += new System.EventHandler(this.btnShowEmpleados_Click);
            // 
            // btnSaveEmpleado
            // 
            this.btnSaveEmpleado.Image = global::MarthaSCoffee.UI.WindowsForm.Properties.Resources._3669255_ic_save_floppy_icon__1_;
            this.btnSaveEmpleado.Location = new System.Drawing.Point(28, 239);
            this.btnSaveEmpleado.Name = "btnSaveEmpleado";
            this.btnSaveEmpleado.Size = new System.Drawing.Size(164, 70);
            this.btnSaveEmpleado.TabIndex = 66;
            this.btnSaveEmpleado.Text = "Guardar datos";
            this.btnSaveEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveEmpleado.UseVisualStyleBackColor = true;
            this.btnSaveEmpleado.Click += new System.EventHandler(this.btnSaveEmpleado_Click);
            // 
            // cmbAreas
            // 
            this.cmbAreas.DisplayMember = "IDAREA";
            this.cmbAreas.FormattingEnabled = true;
            this.cmbAreas.Location = new System.Drawing.Point(190, 154);
            this.cmbAreas.Name = "cmbAreas";
            this.cmbAreas.Size = new System.Drawing.Size(172, 21);
            this.cmbAreas.TabIndex = 65;
            this.cmbAreas.ValueMember = "IDAREA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Área";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(190, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 20);
            this.txtNombre.TabIndex = 61;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(25, 100);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(49, 13);
            this.c.TabIndex = 62;
            this.c.Text = "Nombres";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Enabled = false;
            this.txtIdEmpleado.Location = new System.Drawing.Point(190, 52);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(172, 20);
            this.txtIdEmpleado.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "ID Empleado";
            // 
            // Areas
            // 
            this.Areas.Controls.Add(this.CancelarArea);
            this.Areas.Controls.Add(this.MostrarAreas);
            this.Areas.Controls.Add(this.SaveAreas);
            this.Areas.Controls.Add(this.txtNombreArea);
            this.Areas.Controls.Add(this.label3);
            this.Areas.Controls.Add(this.txtIDAreas);
            this.Areas.Controls.Add(this.label4);
            this.Areas.Location = new System.Drawing.Point(4, 22);
            this.Areas.Name = "Areas";
            this.Areas.Size = new System.Drawing.Size(639, 379);
            this.Areas.TabIndex = 5;
            this.Areas.Text = "Áreas";
            this.Areas.UseVisualStyleBackColor = true;
            // 
            // CancelarArea
            // 
            this.CancelarArea.Image = global::MarthaSCoffee.UI.WindowsForm.Properties.Resources._9004781_file_document_paper_page_icon;
            this.CancelarArea.Location = new System.Drawing.Point(198, 240);
            this.CancelarArea.Name = "CancelarArea";
            this.CancelarArea.Size = new System.Drawing.Size(164, 70);
            this.CancelarArea.TabIndex = 74;
            this.CancelarArea.Text = "Cancelar";
            this.CancelarArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarArea.UseVisualStyleBackColor = true;
            this.CancelarArea.Click += new System.EventHandler(this.CancelarArea_Click);
            // 
            // MostrarAreas
            // 
            this.MostrarAreas.Image = global::MarthaSCoffee.UI.WindowsForm.Properties.Resources._2742782_archive_document_documents_file_files_icon;
            this.MostrarAreas.Location = new System.Drawing.Point(434, 63);
            this.MostrarAreas.Name = "MostrarAreas";
            this.MostrarAreas.Size = new System.Drawing.Size(164, 70);
            this.MostrarAreas.TabIndex = 73;
            this.MostrarAreas.Text = "Mostrar datos guardados";
            this.MostrarAreas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MostrarAreas.UseVisualStyleBackColor = true;
            this.MostrarAreas.Click += new System.EventHandler(this.MostrarAreas_Click);
            // 
            // SaveAreas
            // 
            this.SaveAreas.Image = global::MarthaSCoffee.UI.WindowsForm.Properties.Resources._3669255_ic_save_floppy_icon__1_;
            this.SaveAreas.Location = new System.Drawing.Point(28, 240);
            this.SaveAreas.Name = "SaveAreas";
            this.SaveAreas.Size = new System.Drawing.Size(164, 70);
            this.SaveAreas.TabIndex = 72;
            this.SaveAreas.Text = "Guardar datos";
            this.SaveAreas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveAreas.UseVisualStyleBackColor = true;
            this.SaveAreas.Click += new System.EventHandler(this.SaveAreas_Click);
            // 
            // txtNombreArea
            // 
            this.txtNombreArea.Location = new System.Drawing.Point(189, 126);
            this.txtNombreArea.Name = "txtNombreArea";
            this.txtNombreArea.Size = new System.Drawing.Size(173, 20);
            this.txtNombreArea.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Nombre Área";
            // 
            // txtIDAreas
            // 
            this.txtIDAreas.Enabled = false;
            this.txtIDAreas.Location = new System.Drawing.Point(189, 63);
            this.txtIDAreas.Name = "txtIDAreas";
            this.txtIDAreas.Size = new System.Drawing.Size(173, 20);
            this.txtIDAreas.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "ID área";
            // 
            // Productos
            // 
            this.Productos.Controls.Add(this.comboBox1);
            this.Productos.Controls.Add(this.button1);
            this.Productos.Controls.Add(this.button2);
            this.Productos.Controls.Add(this.textBox1);
            this.Productos.Controls.Add(this.textBox2);
            this.Productos.Controls.Add(this.label5);
            this.Productos.Controls.Add(this.label6);
            this.Productos.Controls.Add(this.button3);
            this.Productos.Controls.Add(this.label7);
            this.Productos.Location = new System.Drawing.Point(4, 22);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(639, 379);
            this.Productos.TabIndex = 6;
            this.Productos.Text = "Productos";
            this.Productos.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(209, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 86;
            // 
            // button1
            // 
            this.button1.Image = global::MarthaSCoffee.UI.WindowsForm.Properties.Resources._9004781_file_document_paper_page_icon;
            this.button1.Location = new System.Drawing.Point(218, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 70);
            this.button1.TabIndex = 85;
            this.button1.Text = "Cancelar producto";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::MarthaSCoffee.UI.WindowsForm.Properties.Resources._2742782_archive_document_documents_file_files_icon;
            this.button2.Location = new System.Drawing.Point(437, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 70);
            this.button2.TabIndex = 84;
            this.button2.Text = "Mostrar Productos";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(209, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 82;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(209, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 83;
            this.label5.Text = "Id Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "Costo x unidad";
            // 
            // button3
            // 
            this.button3.Image = global::MarthaSCoffee.UI.WindowsForm.Properties.Resources._3669255_ic_save_floppy_icon__1_;
            this.button3.Location = new System.Drawing.Point(40, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 70);
            this.button3.TabIndex = 80;
            this.button3.Text = "Guardar Producto";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Nombre del producto";
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 485);
            this.Controls.Add(this.tbcAdministracion);
            this.Name = "Administracion";
            this.Text = "Administración";
            this.Load += new System.EventHandler(this.Administración_Load);
            this.Proveedores.ResumeLayout(false);
            this.Proveedores.PerformLayout();
            this.tbcAdministracion.ResumeLayout(false);
            this.Empleados.ResumeLayout(false);
            this.Empleados.PerformLayout();
            this.Areas.ResumeLayout(false);
            this.Areas.PerformLayout();
            this.Productos.ResumeLayout(false);
            this.Productos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Proveedores;
        private System.Windows.Forms.Button btnMostrarProveedores;
        private System.Windows.Forms.TextBox txtFK_IdProduct;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblIdproducto;
        private System.Windows.Forms.Button btnGuardarProveedor;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TabControl tbcAdministracion;
        private System.Windows.Forms.TabPage Empleados;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAreas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Button btnShowEmpleados;
        private System.Windows.Forms.Button btnSaveEmpleado;
        private System.Windows.Forms.TabPage Areas;
        private System.Windows.Forms.Button MostrarAreas;
        private System.Windows.Forms.Button SaveAreas;
        private System.Windows.Forms.TextBox txtNombreArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDAreas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelarArea;
        private System.Windows.Forms.Button btnCancelarEM;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.TabPage Productos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
    }
}