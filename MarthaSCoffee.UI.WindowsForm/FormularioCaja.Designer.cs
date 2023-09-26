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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.combxTipoOrden = new System.Windows.Forms.ComboBox();
            this.combxTipoPago = new System.Windows.Forms.ComboBox();
            this.lblTipoOrden = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.lblPagoTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumO = new System.Windows.Forms.Label();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.Empleado = new System.Windows.Forms.Label();
            this.lblNumO = new System.Windows.Forms.Label();
            this.lblNomC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(287, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 52);
            this.button2.TabIndex = 88;
            this.button2.Text = "Imprimi factura";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(287, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 52);
            this.button1.TabIndex = 87;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(518, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 25);
            this.label4.TabIndex = 86;
            this.label4.Text = "Estado actual del proceso";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(373, 87);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(11, 16);
            this.lblTotal.TabIndex = 84;
            this.lblTotal.Text = "-";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(128, 392);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown1.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(282, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 81;
            this.label2.Text = "Pago";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(287, 132);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(192, 52);
            this.btnCalcular.TabIndex = 80;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // combxTipoOrden
            // 
            this.combxTipoOrden.FormattingEnabled = true;
            this.combxTipoOrden.Location = new System.Drawing.Point(390, 260);
            this.combxTipoOrden.Name = "combxTipoOrden";
            this.combxTipoOrden.Size = new System.Drawing.Size(89, 21);
            this.combxTipoOrden.TabIndex = 79;
            // 
            // combxTipoPago
            // 
            this.combxTipoPago.FormattingEnabled = true;
            this.combxTipoPago.Location = new System.Drawing.Point(390, 206);
            this.combxTipoPago.Name = "combxTipoPago";
            this.combxTipoPago.Size = new System.Drawing.Size(89, 21);
            this.combxTipoPago.TabIndex = 78;
            // 
            // lblTipoOrden
            // 
            this.lblTipoOrden.AutoSize = true;
            this.lblTipoOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoOrden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTipoOrden.Location = new System.Drawing.Point(284, 265);
            this.lblTipoOrden.Name = "lblTipoOrden";
            this.lblTipoOrden.Size = new System.Drawing.Size(92, 16);
            this.lblTipoOrden.TabIndex = 77;
            this.lblTipoOrden.Text = "Tipo de orden";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTipoPago.Location = new System.Drawing.Point(284, 211);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(89, 16);
            this.lblTipoPago.TabIndex = 76;
            this.lblTipoPago.Text = "Tipo de pago";
            // 
            // lblPagoTotal
            // 
            this.lblPagoTotal.AutoSize = true;
            this.lblPagoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPagoTotal.Location = new System.Drawing.Point(279, 85);
            this.lblPagoTotal.Name = "lblPagoTotal";
            this.lblPagoTotal.Size = new System.Drawing.Size(88, 16);
            this.lblPagoTotal.TabIndex = 75;
            this.lblPagoTotal.Text = "Total a pagar";
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
            this.lblCantidad.Location = new System.Drawing.Point(27, 392);
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
            this.Empleado.Location = new System.Drawing.Point(12, 255);
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
            this.label6.Location = new System.Drawing.Point(12, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 90;
            this.label6.Text = "Productos";
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(113, 192);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(122, 21);
            this.cmbProductos.TabIndex = 91;
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(113, 254);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(122, 21);
            this.cmbEmpleados.TabIndex = 92;
            // 
            // frmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 523);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.combxTipoOrden);
            this.Controls.Add(this.combxTipoPago);
            this.Controls.Add(this.lblTipoOrden);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.lblPagoTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumO);
            this.Controls.Add(this.txtNomCliente);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.Empleado);
            this.Controls.Add(this.lblNumO);
            this.Controls.Add(this.lblNomC);
            this.Name = "frmCaja";
            this.Text = "Formulario de caja";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox combxTipoOrden;
        private System.Windows.Forms.ComboBox combxTipoPago;
        private System.Windows.Forms.Label lblTipoOrden;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Label lblPagoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtNumO;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label Empleado;
        private System.Windows.Forms.Label lblNumO;
        private System.Windows.Forms.Label lblNomC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.ComboBox cmbEmpleados;
    }
}