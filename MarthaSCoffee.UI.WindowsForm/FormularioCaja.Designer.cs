namespace MarthaSCoffee.UI.WindowsForm
{
    partial class frmCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaja));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.combxTipoOrden = new System.Windows.Forms.ComboBox();
            this.lblTipoOrden = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.Empleado = new System.Windows.Forms.Label();
            this.lblNomC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.comboPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnventas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(534, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 36);
            this.button1.TabIndex = 87;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(529, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 81;
            this.label2.Text = "Pago";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(534, 327);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(260, 36);
            this.btnCalcular.TabIndex = 80;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // combxTipoOrden
            // 
            this.combxTipoOrden.FormattingEnabled = true;
            this.combxTipoOrden.Items.AddRange(new object[] {
            "LLEVAR",
            "RESTAURANTE"});
            this.combxTipoOrden.Location = new System.Drawing.Point(677, 183);
            this.combxTipoOrden.Name = "combxTipoOrden";
            this.combxTipoOrden.Size = new System.Drawing.Size(98, 21);
            this.combxTipoOrden.TabIndex = 79;
            // 
            // lblTipoOrden
            // 
            this.lblTipoOrden.AutoSize = true;
            this.lblTipoOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoOrden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTipoOrden.Location = new System.Drawing.Point(531, 188);
            this.lblTipoOrden.Name = "lblTipoOrden";
            this.lblTipoOrden.Size = new System.Drawing.Size(95, 16);
            this.lblTipoOrden.TabIndex = 77;
            this.lblTipoOrden.Text = "Tipo de orden:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Pedido";
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(210, 217);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(122, 20);
            this.txtNomCliente.TabIndex = 67;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCantidad.Location = new System.Drawing.Point(14, 487);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 16);
            this.lblCantidad.TabIndex = 63;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // Empleado
            // 
            this.Empleado.AutoSize = true;
            this.Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Empleado.Location = new System.Drawing.Point(14, 534);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(157, 16);
            this.Empleado.TabIndex = 62;
            this.Empleado.Text = "Seleccione el empleado:";
            // 
            // lblNomC
            // 
            this.lblNomC.AutoSize = true;
            this.lblNomC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomC.Location = new System.Drawing.Point(14, 218);
            this.lblNomC.Name = "lblNomC";
            this.lblNomC.Size = new System.Drawing.Size(182, 16);
            this.lblNomC.TabIndex = 58;
            this.lblNomC.Text = "Ingrese el nombre del cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 90;
            this.label6.Text = "Seleccione el producto:";
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(210, 534);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(122, 21);
            this.cmbEmpleados.TabIndex = 92;
            // 
            // comboPago
            // 
            this.comboPago.FormattingEnabled = true;
            this.comboPago.Location = new System.Drawing.Point(699, 291);
            this.comboPago.Name = "comboPago";
            this.comboPago.Size = new System.Drawing.Size(93, 21);
            this.comboPago.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Seleccione un tipo de pago:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(534, 410);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(260, 36);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Realizar transacción";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(585, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Total:";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(752, 377);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(13, 13);
            this.lblMontoTotal.TabIndex = 37;
            this.lblMontoTotal.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(156)))), ((int)(((byte)(116)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 29);
            this.label8.TabIndex = 99;
            this.label8.Text = "Caja";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(210, 483);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(122, 20);
            this.txtCantidad.TabIndex = 101;
            // 
            // dgvProductos
            // 
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(13, 284);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(460, 181);
            this.dgvProductos.TabIndex = 104;
            // 
            // btnventas
            // 
            this.btnventas.BackColor = System.Drawing.Color.Transparent;
            this.btnventas.ForeColor = System.Drawing.Color.Black;
            this.btnventas.Location = new System.Drawing.Point(534, 463);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(260, 36);
            this.btnventas.TabIndex = 105;
            this.btnventas.Text = "Mostrar registros";
            this.btnventas.UseVisualStyleBackColor = false;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            // 
            // frmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(821, 573);
            this.Controls.Add(this.btnventas);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboPago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.combxTipoOrden);
            this.Controls.Add(this.lblTipoOrden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomCliente);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.Empleado);
            this.Controls.Add(this.lblNomC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCaja";
            this.Load += new System.EventHandler(this.frmCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox combxTipoOrden;
        private System.Windows.Forms.Label lblTipoOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label Empleado;
        private System.Windows.Forms.Label lblNomC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.ComboBox comboPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnventas;
    }
}