namespace MarthaSCoffee.UI.WindowsForm
{
    partial class TipoPago
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
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipoPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID_pago = new System.Windows.Forms.TextBox();
            this.lblIDEPago = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(206, 199);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(10, 13);
            this.lblMontoTotal.TabIndex = 37;
            this.lblMontoTotal.Text = "-";
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(84, 340);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(249, 70);
            this.btnMostrarDatos.TabIndex = 36;
            this.btnMostrarDatos.Text = "Mostrar datos guardados";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(84, 252);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(249, 70);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar datos";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Total";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(209, 143);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(124, 20);
            this.textBox4.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Precio";
            // 
            // txtTipoPago
            // 
            this.txtTipoPago.Location = new System.Drawing.Point(209, 102);
            this.txtTipoPago.Name = "txtTipoPago";
            this.txtTipoPago.Size = new System.Drawing.Size(124, 20);
            this.txtTipoPago.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tipo de pago";
            // 
            // txtID_pago
            // 
            this.txtID_pago.Location = new System.Drawing.Point(209, 53);
            this.txtID_pago.Name = "txtID_pago";
            this.txtID_pago.Size = new System.Drawing.Size(124, 20);
            this.txtID_pago.TabIndex = 29;
            // 
            // lblIDEPago
            // 
            this.lblIDEPago.AutoSize = true;
            this.lblIDEPago.Location = new System.Drawing.Point(81, 60);
            this.lblIDEPago.Name = "lblIDEPago";
            this.lblIDEPago.Size = new System.Drawing.Size(44, 13);
            this.lblIDEPago.TabIndex = 28;
            this.lblIDEPago.Text = "Id Pago";
            // 
            // TipoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 444);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTipoPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID_pago);
            this.Controls.Add(this.lblIDEPago);
            this.Name = "TipoPago";
            this.Text = "TipoPago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTipoPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID_pago;
        private System.Windows.Forms.Label lblIDEPago;
    }
}