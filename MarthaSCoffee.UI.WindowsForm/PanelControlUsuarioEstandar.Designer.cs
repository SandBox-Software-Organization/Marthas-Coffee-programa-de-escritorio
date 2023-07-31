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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(327, 234);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 89);
            this.button5.TabIndex = 11;
            this.button5.Text = "Operadora";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(151, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 89);
            this.button4.TabIndex = 10;
            this.button4.Text = "Tipo de pago";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 89);
            this.button3.TabIndex = 9;
            this.button3.Text = "Formulario de caja";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 89);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delivery";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 89);
            this.button1.TabIndex = 7;
            this.button1.Text = "Menú para clientes";
            this.button1.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "PanelControlUsuarioEstandar";
            this.Text = "Panel de Control de Usuario Estandar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBienvenido;
    }
}