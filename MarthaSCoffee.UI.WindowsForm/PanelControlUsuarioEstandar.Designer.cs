namespace MarthaSCoffee.UI.WindowsForm
{
    partial class PanelControlUsuarioEstandar
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
            this.btnTipoPago = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTipoPago
            // 
            this.btnTipoPago.Location = new System.Drawing.Point(235, 224);
            this.btnTipoPago.Name = "btnTipoPago";
            this.btnTipoPago.Size = new System.Drawing.Size(146, 89);
            this.btnTipoPago.TabIndex = 10;
            this.btnTipoPago.Text = "Tipo de pago";
            this.btnTipoPago.UseVisualStyleBackColor = true;
            // 
            // btnCaja
            // 
            this.btnCaja.Location = new System.Drawing.Point(338, 129);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(146, 89);
            this.btnCaja.TabIndex = 9;
            this.btnCaja.Text = "Formulario de caja";
            this.btnCaja.UseVisualStyleBackColor = true;
            // 
            // btnDelivery
            // 
            this.btnDelivery.Location = new System.Drawing.Point(151, 129);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(146, 89);
            this.btnDelivery.TabIndex = 8;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = true;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(229, 46);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(160, 31);
            this.lblBienvenido.TabIndex = 6;
            this.lblBienvenido.Text = "Bienvenid@";
            // 
            // PanelControlUsuarioEstandar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 368);
            this.Controls.Add(this.btnTipoPago);
            this.Controls.Add(this.btnCaja);
            this.Controls.Add(this.btnDelivery);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "PanelControlUsuarioEstandar";
            this.Text = "Panel de Control de Usuario Estandar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTipoPago;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Label lblBienvenido;
    }
}