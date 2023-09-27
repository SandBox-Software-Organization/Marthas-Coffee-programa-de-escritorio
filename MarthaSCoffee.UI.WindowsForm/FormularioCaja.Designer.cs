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
            this.MostrarRegistros = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.combxTipoOrden = new System.Windows.Forms.ComboBox();
            this.lblTipoOrden = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumO = new System.Windows.Forms.Label();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.Empleado = new System.Windows.Forms.Label();
            this.lblNumO = new System.Windows.Forms.Label();
            this.lblNomC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProduc = new System.Windows.Forms.ComboBox();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.Realizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // MostrarRegistros
            // 
            this.MostrarRegistros.BackColor = System.Drawing.Color.Transparent;
            this.MostrarRegistros.ForeColor = System.Drawing.Color.Black;
            this.MostrarRegistros.Location = new System.Drawing.Point(374, 403);
            this.MostrarRegistros.Name = "MostrarRegistros";
            this.MostrarRegistros.Size = new System.Drawing.Size(192, 52);
            this.MostrarRegistros.TabIndex = 88;
            this.MostrarRegistros.Text = "Mostrar registro";
            this.MostrarRegistros.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(374, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 52);
            this.button1.TabIndex = 87;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(147, 374);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown1.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(369, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 81;
            this.label2.Text = "Pago";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(578, 32);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(57, 32);
            this.btnCalcular.TabIndex = 80;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // combxTipoOrden
            // 
            this.combxTipoOrden.FormattingEnabled = true;
            this.combxTipoOrden.Location = new System.Drawing.Point(477, 83);
            this.combxTipoOrden.Name = "combxTipoOrden";
            this.combxTipoOrden.Size = new System.Drawing.Size(89, 21);
            this.combxTipoOrden.TabIndex = 79;
            // 
            // lblTipoOrden
            // 
            this.lblTipoOrden.AutoSize = true;
            this.lblTipoOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoOrden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTipoOrden.Location = new System.Drawing.Point(371, 83);
            this.lblTipoOrden.Name = "lblTipoOrden";
            this.lblTipoOrden.Size = new System.Drawing.Size(92, 16);
            this.lblTipoOrden.TabIndex = 77;
            this.lblTipoOrden.Text = "Tipo de orden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Pedido";
            // 
            // txtNumO
            // 
            this.txtNumO.AutoSize = true;
            this.txtNumO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNumO.Location = new System.Drawing.Point(178, 83);
            this.txtNumO.Name = "txtNumO";
            this.txtNumO.Size = new System.Drawing.Size(14, 16);
            this.txtNumO.TabIndex = 68;
            this.txtNumO.Text = "0";
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(147, 143);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(88, 20);
            this.txtNomCliente.TabIndex = 67;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCantidad.Location = new System.Drawing.Point(11, 378);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 16);
            this.lblCantidad.TabIndex = 63;
            this.lblCantidad.Text = "Cantidad";
            // 
            // Empleado
            // 
            this.Empleado.AutoSize = true;
            this.Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Empleado.Location = new System.Drawing.Point(9, 197);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(70, 16);
            this.Empleado.TabIndex = 62;
            this.Empleado.Text = "Empleado";
            // 
            // lblNumO
            // 
            this.lblNumO.AutoSize = true;
            this.lblNumO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumO.Location = new System.Drawing.Point(9, 83);
            this.lblNumO.Name = "lblNumO";
            this.lblNumO.Size = new System.Drawing.Size(112, 16);
            this.lblNumO.TabIndex = 59;
            this.lblNumO.Text = "Número de orden";
            // 
            // lblNomC
            // 
            this.lblNomC.AutoSize = true;
            this.lblNomC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomC.Location = new System.Drawing.Point(9, 144);
            this.lblNomC.Name = "lblNomC";
            this.lblNomC.Size = new System.Drawing.Size(122, 16);
            this.lblNomC.TabIndex = 58;
            this.lblNomC.Text = "Nombre del Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(134, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 16);
            this.label5.TabIndex = 89;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(9, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 90;
            this.label6.Text = "Productos";
            // 
            // cmbProduc
            // 
            this.cmbProduc.FormattingEnabled = true;
            this.cmbProduc.Location = new System.Drawing.Point(147, 297);
            this.cmbProduc.Name = "cmbProduc";
            this.cmbProduc.Size = new System.Drawing.Size(122, 21);
            this.cmbProduc.TabIndex = 91;
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(147, 197);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(122, 21);
            this.cmbEmpleados.TabIndex = 92;
            // 
            // Realizar
            // 
            this.Realizar.Location = new System.Drawing.Point(374, 206);
            this.Realizar.Name = "Realizar";
            this.Realizar.Size = new System.Drawing.Size(192, 43);
            this.Realizar.TabIndex = 93;
            this.Realizar.Text = "Realizar";
            this.Realizar.UseVisualStyleBackColor = true;
            this.Realizar.Click += new System.EventHandler(this.Realizar_Click);
            // 
            // frmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 504);
            this.Controls.Add(this.Realizar);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.cmbProduc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MostrarRegistros);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.combxTipoOrden);
            this.Controls.Add(this.lblTipoOrden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumO);
            this.Controls.Add(this.txtNomCliente);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.Empleado);
            this.Controls.Add(this.lblNumO);
            this.Controls.Add(this.lblNomC);
            this.Name = "frmCaja";
            this.Text = "Formulario de caja";
            this.Load += new System.EventHandler(this.frmCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MostrarRegistros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox combxTipoOrden;
        private System.Windows.Forms.Label lblTipoOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtNumO;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label Empleado;
        private System.Windows.Forms.Label lblNumO;
        private System.Windows.Forms.Label lblNomC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProduc;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Button Realizar;
    }
}