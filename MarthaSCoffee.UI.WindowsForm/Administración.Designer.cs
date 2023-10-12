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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administracion));
            this.Proveedores = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuardarProveedor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnMostrarProveedores = new System.Windows.Forms.Button();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblIdproducto = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tbcAdministracion = new System.Windows.Forms.TabControl();
            this.Empleados = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelarEM = new System.Windows.Forms.Button();
            this.btnSaveEmpleado = new System.Windows.Forms.Button();
            this.btnShowEmpleados = new System.Windows.Forms.Button();
            this.cmbAreas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Areas = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CancelarArea = new System.Windows.Forms.Button();
            this.SaveAreas = new System.Windows.Forms.Button();
            this.MostrarAreas = new System.Windows.Forms.Button();
            this.txtNombreArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDAreas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Productos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.MostrarProduct = new System.Windows.Forms.Button();
            this.CancelarProduct = new System.Windows.Forms.Button();
            this.GuardarProduct = new System.Windows.Forms.Button();
            this.txtCostoXunidad = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtNombreproducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Proveedores.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbcAdministracion.SuspendLayout();
            this.Empleados.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Areas.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.Productos.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Proveedores
            // 
            this.Proveedores.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Proveedores.Controls.Add(this.tableLayoutPanel1);
            this.Proveedores.Controls.Add(this.cmbProductos);
            this.Proveedores.Controls.Add(this.txtNombreProveedor);
            this.Proveedores.Controls.Add(this.lblIdproducto);
            this.Proveedores.Controls.Add(this.label26);
            this.Proveedores.Location = new System.Drawing.Point(4, 25);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Padding = new System.Windows.Forms.Padding(3);
            this.Proveedores.Size = new System.Drawing.Size(639, 376);
            this.Proveedores.TabIndex = 3;
            this.Proveedores.Text = "Proveedores";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9985F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGuardarProveedor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMostrarProveedores, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 259);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(575, 79);
            this.tableLayoutPanel1.TabIndex = 78;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(463, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 73);
            this.button2.TabIndex = 80;
            this.button2.Text = "Cerrar sesión";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarProveedor.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(109, 73);
            this.btnGuardarProveedor.TabIndex = 55;
            this.btnGuardarProveedor.Text = "Guardar datos";
            this.btnGuardarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarProveedor.UseVisualStyleBackColor = true;
            this.btnGuardarProveedor.Click += new System.EventHandler(this.btnGuardarProveedor_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(348, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 73);
            this.button1.TabIndex = 79;
            this.button1.Text = "Caja";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(118, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 73);
            this.btnCancelar.TabIndex = 76;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnMostrarProveedores
            // 
            this.btnMostrarProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarProveedores.Location = new System.Drawing.Point(233, 3);
            this.btnMostrarProveedores.Name = "btnMostrarProveedores";
            this.btnMostrarProveedores.Size = new System.Drawing.Size(109, 73);
            this.btnMostrarProveedores.TabIndex = 64;
            this.btnMostrarProveedores.Text = "Mostrar datos guardados";
            this.btnMostrarProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostrarProveedores.UseVisualStyleBackColor = true;
            this.btnMostrarProveedores.Click += new System.EventHandler(this.btnMostrarProveedores_Click);
            // 
            // cmbProductos
            // 
            this.cmbProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(254, 163);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(350, 24);
            this.cmbProductos.TabIndex = 77;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(254, 86);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(350, 22);
            this.txtNombreProveedor.TabIndex = 54;
            // 
            // lblIdproducto
            // 
            this.lblIdproducto.AutoSize = true;
            this.lblIdproducto.Location = new System.Drawing.Point(26, 167);
            this.lblIdproducto.Name = "lblIdproducto";
            this.lblIdproducto.Size = new System.Drawing.Size(183, 16);
            this.lblIdproducto.TabIndex = 56;
            this.lblIdproducto.Text = "Seleccióne el ID del producto";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(26, 89);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(206, 16);
            this.label26.TabIndex = 53;
            this.label26.Text = "Ingrese el nombre del proveedor:";
            // 
            // tbcAdministracion
            // 
            this.tbcAdministracion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcAdministracion.Controls.Add(this.Proveedores);
            this.tbcAdministracion.Controls.Add(this.Empleados);
            this.tbcAdministracion.Controls.Add(this.Areas);
            this.tbcAdministracion.Controls.Add(this.Productos);
            this.tbcAdministracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcAdministracion.Location = new System.Drawing.Point(14, 130);
            this.tbcAdministracion.Name = "tbcAdministracion";
            this.tbcAdministracion.SelectedIndex = 0;
            this.tbcAdministracion.Size = new System.Drawing.Size(647, 405);
            this.tbcAdministracion.TabIndex = 0;
            // 
            // Empleados
            // 
            this.Empleados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Empleados.Controls.Add(this.tableLayoutPanel2);
            this.Empleados.Controls.Add(this.cmbAreas);
            this.Empleados.Controls.Add(this.label2);
            this.Empleados.Controls.Add(this.txtNombre);
            this.Empleados.Controls.Add(this.c);
            this.Empleados.Controls.Add(this.txtIdEmpleado);
            this.Empleados.Controls.Add(this.label1);
            this.Empleados.Location = new System.Drawing.Point(4, 25);
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(639, 376);
            this.Empleados.TabIndex = 4;
            this.Empleados.Text = "Empleados";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancelarEM, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSaveEmpleado, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnShowEmpleados, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(28, 275);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(588, 79);
            this.tableLayoutPanel2.TabIndex = 79;
            // 
            // btnCancelarEM
            // 
            this.btnCancelarEM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarEM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarEM.Location = new System.Drawing.Point(198, 3);
            this.btnCancelarEM.Name = "btnCancelarEM";
            this.btnCancelarEM.Size = new System.Drawing.Size(189, 73);
            this.btnCancelarEM.TabIndex = 75;
            this.btnCancelarEM.Text = "Cancelar";
            this.btnCancelarEM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarEM.UseVisualStyleBackColor = true;
            this.btnCancelarEM.Click += new System.EventHandler(this.btnCancelarEM_Click);
            // 
            // btnSaveEmpleado
            // 
            this.btnSaveEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEmpleado.Location = new System.Drawing.Point(3, 3);
            this.btnSaveEmpleado.Name = "btnSaveEmpleado";
            this.btnSaveEmpleado.Size = new System.Drawing.Size(189, 73);
            this.btnSaveEmpleado.TabIndex = 66;
            this.btnSaveEmpleado.Text = "Guardar datos";
            this.btnSaveEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveEmpleado.UseVisualStyleBackColor = true;
            this.btnSaveEmpleado.Click += new System.EventHandler(this.btnSaveEmpleado_Click);
            // 
            // btnShowEmpleados
            // 
            this.btnShowEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowEmpleados.Location = new System.Drawing.Point(393, 3);
            this.btnShowEmpleados.Name = "btnShowEmpleados";
            this.btnShowEmpleados.Size = new System.Drawing.Size(192, 73);
            this.btnShowEmpleados.TabIndex = 67;
            this.btnShowEmpleados.Text = "Mostrar datos guardados";
            this.btnShowEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowEmpleados.UseVisualStyleBackColor = true;
            this.btnShowEmpleados.Click += new System.EventHandler(this.btnShowEmpleados_Click);
            // 
            // cmbAreas
            // 
            this.cmbAreas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAreas.DisplayMember = "IDAREA";
            this.cmbAreas.FormattingEnabled = true;
            this.cmbAreas.Location = new System.Drawing.Point(261, 179);
            this.cmbAreas.Name = "cmbAreas";
            this.cmbAreas.Size = new System.Drawing.Size(355, 24);
            this.cmbAreas.TabIndex = 65;
            this.cmbAreas.ValueMember = "IDAREA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Seleccione el área del empleado:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(261, 116);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(355, 22);
            this.txtNombre.TabIndex = 61;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(25, 116);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(219, 16);
            this.c.TabIndex = 62;
            this.c.Text = "Ingrese los nombres del empleado:";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Enabled = false;
            this.txtIdEmpleado.Location = new System.Drawing.Point(261, 52);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(32, 22);
            this.txtIdEmpleado.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "ID del empleado:";
            // 
            // Areas
            // 
            this.Areas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Areas.Controls.Add(this.tableLayoutPanel3);
            this.Areas.Controls.Add(this.txtNombreArea);
            this.Areas.Controls.Add(this.label3);
            this.Areas.Controls.Add(this.txtIDAreas);
            this.Areas.Controls.Add(this.label4);
            this.Areas.Location = new System.Drawing.Point(4, 25);
            this.Areas.Name = "Areas";
            this.Areas.Size = new System.Drawing.Size(639, 376);
            this.Areas.TabIndex = 5;
            this.Areas.Text = "Áreas";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.CancelarArea, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.SaveAreas, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.MostrarAreas, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(28, 262);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(582, 82);
            this.tableLayoutPanel3.TabIndex = 79;
            // 
            // CancelarArea
            // 
            this.CancelarArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelarArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarArea.Location = new System.Drawing.Point(196, 3);
            this.CancelarArea.Name = "CancelarArea";
            this.CancelarArea.Size = new System.Drawing.Size(187, 76);
            this.CancelarArea.TabIndex = 74;
            this.CancelarArea.Text = "Cancelar";
            this.CancelarArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarArea.UseVisualStyleBackColor = true;
            this.CancelarArea.Click += new System.EventHandler(this.CancelarArea_Click);
            // 
            // SaveAreas
            // 
            this.SaveAreas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveAreas.Location = new System.Drawing.Point(3, 3);
            this.SaveAreas.Name = "SaveAreas";
            this.SaveAreas.Size = new System.Drawing.Size(187, 76);
            this.SaveAreas.TabIndex = 72;
            this.SaveAreas.Text = "Guardar datos";
            this.SaveAreas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveAreas.UseVisualStyleBackColor = true;
            this.SaveAreas.Click += new System.EventHandler(this.SaveAreas_Click);
            // 
            // MostrarAreas
            // 
            this.MostrarAreas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MostrarAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MostrarAreas.Location = new System.Drawing.Point(389, 3);
            this.MostrarAreas.Name = "MostrarAreas";
            this.MostrarAreas.Size = new System.Drawing.Size(190, 76);
            this.MostrarAreas.TabIndex = 73;
            this.MostrarAreas.Text = "Mostrar datos guardados";
            this.MostrarAreas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MostrarAreas.UseVisualStyleBackColor = true;
            this.MostrarAreas.Click += new System.EventHandler(this.MostrarAreas_Click);
            // 
            // txtNombreArea
            // 
            this.txtNombreArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreArea.Location = new System.Drawing.Point(211, 138);
            this.txtNombreArea.Name = "txtNombreArea";
            this.txtNombreArea.Size = new System.Drawing.Size(399, 22);
            this.txtNombreArea.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "Ingrese el nombre del área:";
            // 
            // txtIDAreas
            // 
            this.txtIDAreas.Enabled = false;
            this.txtIDAreas.Location = new System.Drawing.Point(211, 63);
            this.txtIDAreas.Name = "txtIDAreas";
            this.txtIDAreas.Size = new System.Drawing.Size(37, 22);
            this.txtIDAreas.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "ID del área:";
            // 
            // Productos
            // 
            this.Productos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Productos.Controls.Add(this.tableLayoutPanel4);
            this.Productos.Controls.Add(this.txtCostoXunidad);
            this.Productos.Controls.Add(this.txtIdProducto);
            this.Productos.Controls.Add(this.txtNombreproducto);
            this.Productos.Controls.Add(this.label5);
            this.Productos.Controls.Add(this.label6);
            this.Productos.Controls.Add(this.label7);
            this.Productos.Location = new System.Drawing.Point(4, 25);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(639, 376);
            this.Productos.TabIndex = 6;
            this.Productos.Text = "Productos";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.MostrarProduct, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.CancelarProduct, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.GuardarProduct, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(40, 267);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(568, 80);
            this.tableLayoutPanel4.TabIndex = 87;
            // 
            // MostrarProduct
            // 
            this.MostrarProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MostrarProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MostrarProduct.Location = new System.Drawing.Point(381, 3);
            this.MostrarProduct.Name = "MostrarProduct";
            this.MostrarProduct.Size = new System.Drawing.Size(184, 74);
            this.MostrarProduct.TabIndex = 84;
            this.MostrarProduct.Text = "Mostrar Productos";
            this.MostrarProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MostrarProduct.UseVisualStyleBackColor = true;
            this.MostrarProduct.Click += new System.EventHandler(this.MostrarProduct_Click);
            // 
            // CancelarProduct
            // 
            this.CancelarProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelarProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarProduct.Location = new System.Drawing.Point(192, 3);
            this.CancelarProduct.Name = "CancelarProduct";
            this.CancelarProduct.Size = new System.Drawing.Size(183, 74);
            this.CancelarProduct.TabIndex = 85;
            this.CancelarProduct.Text = "Cancelar producto";
            this.CancelarProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarProduct.UseVisualStyleBackColor = true;
            this.CancelarProduct.Click += new System.EventHandler(this.CancelarProduct_Click);
            // 
            // GuardarProduct
            // 
            this.GuardarProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GuardarProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarProduct.Location = new System.Drawing.Point(3, 3);
            this.GuardarProduct.Name = "GuardarProduct";
            this.GuardarProduct.Size = new System.Drawing.Size(183, 74);
            this.GuardarProduct.TabIndex = 80;
            this.GuardarProduct.Text = "Guardar Producto";
            this.GuardarProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarProduct.UseVisualStyleBackColor = true;
            this.GuardarProduct.Click += new System.EventHandler(this.GuardarProduct_Click);
            // 
            // txtCostoXunidad
            // 
            this.txtCostoXunidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostoXunidad.Location = new System.Drawing.Point(247, 198);
            this.txtCostoXunidad.Name = "txtCostoXunidad";
            this.txtCostoXunidad.Size = new System.Drawing.Size(361, 22);
            this.txtCostoXunidad.TabIndex = 86;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(247, 44);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(33, 22);
            this.txtIdProducto.TabIndex = 82;
            // 
            // txtNombreproducto
            // 
            this.txtNombreproducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreproducto.Location = new System.Drawing.Point(247, 124);
            this.txtNombreproducto.Name = "txtNombreproducto";
            this.txtNombreproducto.Size = new System.Drawing.Size(361, 22);
            this.txtNombreproducto.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 83;
            this.label5.Text = "ID del producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 16);
            this.label6.TabIndex = 81;
            this.label6.Text = "Ingrese el costo por unidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 16);
            this.label7.TabIndex = 78;
            this.label7.Text = "Ingrese el nombre del producto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(341, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Panel de control administrador";
            this.label8.UseMnemonic = false;
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(673, 553);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbcAdministracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Administracion";
            this.Load += new System.EventHandler(this.Administración_Load);
            this.Proveedores.ResumeLayout(false);
            this.Proveedores.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tbcAdministracion.ResumeLayout(false);
            this.Empleados.ResumeLayout(false);
            this.Empleados.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Areas.ResumeLayout(false);
            this.Areas.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.Productos.ResumeLayout(false);
            this.Productos.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage Proveedores;
        private System.Windows.Forms.Button btnMostrarProveedores;
        private System.Windows.Forms.TextBox txtNombreProveedor;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}