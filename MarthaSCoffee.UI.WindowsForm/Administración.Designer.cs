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
            this.txt_IdProduct = new System.Windows.Forms.TextBox();
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
            this.txtCostoXunidad = new System.Windows.Forms.TextBox();
            this.CancelarProduct = new System.Windows.Forms.Button();
            this.MostrarProduct = new System.Windows.Forms.Button();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtNombreproducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GuardarProduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.Proveedores.Controls.Add(this.txt_IdProduct);
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
            this.Proveedores.UseWaitCursor = true;
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(201, 202);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(173, 21);
            this.cmbProductos.TabIndex = 77;
            this.cmbProductos.UseWaitCursor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(210, 268);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(164, 70);
            this.btnCancelar.TabIndex = 76;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.UseWaitCursor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnMostrarProveedores
            // 
            this.btnMostrarProveedores.Location = new System.Drawing.Point(429, 48);
            this.btnMostrarProveedores.Name = "btnMostrarProveedores";
            this.btnMostrarProveedores.Size = new System.Drawing.Size(164, 70);
            this.btnMostrarProveedores.TabIndex = 64;
            this.btnMostrarProveedores.Text = "Mostrar datos guardados";
            this.btnMostrarProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostrarProveedores.UseVisualStyleBackColor = true;
            this.btnMostrarProveedores.UseWaitCursor = true;
            this.btnMostrarProveedores.Click += new System.EventHandler(this.btnMostrarProveedores_Click);
            // 
            // txt_IdProduct
            // 
            this.txt_IdProduct.Enabled = false;
            this.txt_IdProduct.Location = new System.Drawing.Point(201, 48);
            this.txt_IdProduct.Name = "txt_IdProduct";
            this.txt_IdProduct.Size = new System.Drawing.Size(173, 20);
            this.txt_IdProduct.TabIndex = 57;
            this.txt_IdProduct.UseWaitCursor = true;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(201, 125);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(173, 20);
            this.txtNombreProveedor.TabIndex = 54;
            this.txtNombreProveedor.UseWaitCursor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(29, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 13);
            this.label24.TabIndex = 58;
            this.label24.Text = "Id Proveedor";
            this.label24.UseWaitCursor = true;
            // 
            // lblIdproducto
            // 
            this.lblIdproducto.AutoSize = true;
            this.lblIdproducto.Location = new System.Drawing.Point(29, 205);
            this.lblIdproducto.Name = "lblIdproducto";
            this.lblIdproducto.Size = new System.Drawing.Size(65, 13);
            this.lblIdproducto.TabIndex = 56;
            this.lblIdproducto.Text = "Id_Producto";
            this.lblIdproducto.UseWaitCursor = true;
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.Location = new System.Drawing.Point(32, 268);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(164, 70);
            this.btnGuardarProveedor.TabIndex = 55;
            this.btnGuardarProveedor.Text = "Guardar datos";
            this.btnGuardarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarProveedor.UseVisualStyleBackColor = true;
            this.btnGuardarProveedor.UseWaitCursor = true;
            this.btnGuardarProveedor.Click += new System.EventHandler(this.btnGuardarProveedor_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(29, 128);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(112, 13);
            this.label26.TabIndex = 53;
            this.label26.Text = "Nombre del proveedor";
            this.label26.UseWaitCursor = true;
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
            this.tbcAdministracion.UseWaitCursor = true;
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
            this.Empleados.UseWaitCursor = true;
            // 
            // btnCancelarEM
            // 
            this.btnCancelarEM.Location = new System.Drawing.Point(198, 239);
            this.btnCancelarEM.Name = "btnCancelarEM";
            this.btnCancelarEM.Size = new System.Drawing.Size(164, 70);
            this.btnCancelarEM.TabIndex = 75;
            this.btnCancelarEM.Text = "Cancelar";
            this.btnCancelarEM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarEM.UseVisualStyleBackColor = true;
            this.btnCancelarEM.UseWaitCursor = true;
            this.btnCancelarEM.Click += new System.EventHandler(this.btnCancelarEM_Click);
            // 
            // btnShowEmpleados
            // 
            this.btnShowEmpleados.Location = new System.Drawing.Point(420, 50);
            this.btnShowEmpleados.Name = "btnShowEmpleados";
            this.btnShowEmpleados.Size = new System.Drawing.Size(164, 70);
            this.btnShowEmpleados.TabIndex = 67;
            this.btnShowEmpleados.Text = "Mostrar datos guardados";
            this.btnShowEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowEmpleados.UseVisualStyleBackColor = true;
            this.btnShowEmpleados.UseWaitCursor = true;
            this.btnShowEmpleados.Click += new System.EventHandler(this.btnShowEmpleados_Click);
            // 
            // btnSaveEmpleado
            // 
            this.btnSaveEmpleado.Location = new System.Drawing.Point(28, 239);
            this.btnSaveEmpleado.Name = "btnSaveEmpleado";
            this.btnSaveEmpleado.Size = new System.Drawing.Size(164, 70);
            this.btnSaveEmpleado.TabIndex = 66;
            this.btnSaveEmpleado.Text = "Guardar datos";
            this.btnSaveEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveEmpleado.UseVisualStyleBackColor = true;
            this.btnSaveEmpleado.UseWaitCursor = true;
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
            this.cmbAreas.UseWaitCursor = true;
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
            this.label2.UseWaitCursor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(190, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 20);
            this.txtNombre.TabIndex = 61;
            this.txtNombre.UseWaitCursor = true;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(25, 100);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(49, 13);
            this.c.TabIndex = 62;
            this.c.Text = "Nombres";
            this.c.UseWaitCursor = true;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Enabled = false;
            this.txtIdEmpleado.Location = new System.Drawing.Point(190, 52);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(172, 20);
            this.txtIdEmpleado.TabIndex = 59;
            this.txtIdEmpleado.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "ID Empleado";
            this.label1.UseWaitCursor = true;
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
            this.Areas.UseWaitCursor = true;
            // 
            // CancelarArea
            // 
            this.CancelarArea.Location = new System.Drawing.Point(198, 240);
            this.CancelarArea.Name = "CancelarArea";
            this.CancelarArea.Size = new System.Drawing.Size(164, 70);
            this.CancelarArea.TabIndex = 74;
            this.CancelarArea.Text = "Cancelar";
            this.CancelarArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarArea.UseVisualStyleBackColor = true;
            this.CancelarArea.UseWaitCursor = true;
            this.CancelarArea.Click += new System.EventHandler(this.CancelarArea_Click);
            // 
            // MostrarAreas
            // 
            this.MostrarAreas.Location = new System.Drawing.Point(434, 63);
            this.MostrarAreas.Name = "MostrarAreas";
            this.MostrarAreas.Size = new System.Drawing.Size(164, 70);
            this.MostrarAreas.TabIndex = 73;
            this.MostrarAreas.Text = "Mostrar datos guardados";
            this.MostrarAreas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MostrarAreas.UseVisualStyleBackColor = true;
            this.MostrarAreas.UseWaitCursor = true;
            this.MostrarAreas.Click += new System.EventHandler(this.MostrarAreas_Click);
            // 
            // SaveAreas
            // 
            this.SaveAreas.Location = new System.Drawing.Point(28, 240);
            this.SaveAreas.Name = "SaveAreas";
            this.SaveAreas.Size = new System.Drawing.Size(164, 70);
            this.SaveAreas.TabIndex = 72;
            this.SaveAreas.Text = "Guardar datos";
            this.SaveAreas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveAreas.UseVisualStyleBackColor = true;
            this.SaveAreas.UseWaitCursor = true;
            this.SaveAreas.Click += new System.EventHandler(this.SaveAreas_Click);
            // 
            // txtNombreArea
            // 
            this.txtNombreArea.Location = new System.Drawing.Point(189, 126);
            this.txtNombreArea.Name = "txtNombreArea";
            this.txtNombreArea.Size = new System.Drawing.Size(173, 20);
            this.txtNombreArea.TabIndex = 70;
            this.txtNombreArea.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Nombre Área";
            this.label3.UseWaitCursor = true;
            // 
            // txtIDAreas
            // 
            this.txtIDAreas.Enabled = false;
            this.txtIDAreas.Location = new System.Drawing.Point(189, 63);
            this.txtIDAreas.Name = "txtIDAreas";
            this.txtIDAreas.Size = new System.Drawing.Size(173, 20);
            this.txtIDAreas.TabIndex = 68;
            this.txtIDAreas.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "ID área";
            this.label4.UseWaitCursor = true;
            // 
            // Productos
            // 
            this.Productos.Controls.Add(this.txtCostoXunidad);
            this.Productos.Controls.Add(this.CancelarProduct);
            this.Productos.Controls.Add(this.MostrarProduct);
            this.Productos.Controls.Add(this.txtIdProducto);
            this.Productos.Controls.Add(this.txtNombreproducto);
            this.Productos.Controls.Add(this.label5);
            this.Productos.Controls.Add(this.label6);
            this.Productos.Controls.Add(this.GuardarProduct);
            this.Productos.Controls.Add(this.label7);
            this.Productos.Location = new System.Drawing.Point(4, 22);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(639, 379);
            this.Productos.TabIndex = 6;
            this.Productos.Text = "Productos";
            this.Productos.UseVisualStyleBackColor = true;
            this.Productos.UseWaitCursor = true;
            // 
            // txtCostoXunidad
            // 
            this.txtCostoXunidad.Location = new System.Drawing.Point(209, 194);
            this.txtCostoXunidad.Name = "txtCostoXunidad";
            this.txtCostoXunidad.Size = new System.Drawing.Size(173, 20);
            this.txtCostoXunidad.TabIndex = 86;
            this.txtCostoXunidad.UseWaitCursor = true;
            // 
            // CancelarProduct
            // 
            this.CancelarProduct.Location = new System.Drawing.Point(218, 264);
            this.CancelarProduct.Name = "CancelarProduct";
            this.CancelarProduct.Size = new System.Drawing.Size(164, 70);
            this.CancelarProduct.TabIndex = 85;
            this.CancelarProduct.Text = "Cancelar producto";
            this.CancelarProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarProduct.UseVisualStyleBackColor = true;
            this.CancelarProduct.UseWaitCursor = true;
            this.CancelarProduct.Click += new System.EventHandler(this.CancelarProduct_Click);
            // 
            // MostrarProduct
            // 
            this.MostrarProduct.Location = new System.Drawing.Point(437, 44);
            this.MostrarProduct.Name = "MostrarProduct";
            this.MostrarProduct.Size = new System.Drawing.Size(164, 70);
            this.MostrarProduct.TabIndex = 84;
            this.MostrarProduct.Text = "Mostrar Productos";
            this.MostrarProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MostrarProduct.UseVisualStyleBackColor = true;
            this.MostrarProduct.UseWaitCursor = true;
            this.MostrarProduct.Click += new System.EventHandler(this.MostrarProduct_Click);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(209, 44);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(173, 20);
            this.txtIdProducto.TabIndex = 82;
            this.txtIdProducto.UseWaitCursor = true;
            // 
            // txtNombreproducto
            // 
            this.txtNombreproducto.Location = new System.Drawing.Point(209, 121);
            this.txtNombreproducto.Name = "txtNombreproducto";
            this.txtNombreproducto.Size = new System.Drawing.Size(173, 20);
            this.txtNombreproducto.TabIndex = 79;
            this.txtNombreproducto.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 83;
            this.label5.Text = "Id Producto";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "Costo x unidad";
            this.label6.UseWaitCursor = true;
            // 
            // GuardarProduct
            // 
            this.GuardarProduct.Location = new System.Drawing.Point(40, 264);
            this.GuardarProduct.Name = "GuardarProduct";
            this.GuardarProduct.Size = new System.Drawing.Size(164, 70);
            this.GuardarProduct.TabIndex = 80;
            this.GuardarProduct.Text = "Guardar Producto";
            this.GuardarProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarProduct.UseVisualStyleBackColor = true;
            this.GuardarProduct.UseWaitCursor = true;
            this.GuardarProduct.Click += new System.EventHandler(this.GuardarProduct_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Nombre del producto";
            this.label7.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar seción";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = " Caja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbcAdministracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Administracion";
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
        private System.Windows.Forms.TextBox txt_IdProduct;
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
        private System.Windows.Forms.Button CancelarProduct;
        private System.Windows.Forms.Button MostrarProduct;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtNombreproducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GuardarProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCostoXunidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}