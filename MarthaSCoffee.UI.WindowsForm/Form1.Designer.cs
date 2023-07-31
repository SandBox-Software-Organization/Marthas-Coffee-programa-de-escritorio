namespace MarthaSCoffee.UI.WindowsForm
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciarSesión = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciarSesión
            // 
            this.btnIniciarSesión.Location = new System.Drawing.Point(132, 200);
            this.btnIniciarSesión.Name = "btnIniciarSesión";
            this.btnIniciarSesión.Size = new System.Drawing.Size(139, 32);
            this.btnIniciarSesión.TabIndex = 9;
            this.btnIniciarSesión.Text = "Iniciar Sesión";
            this.btnIniciarSesión.UseVisualStyleBackColor = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(160, 122);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(153, 20);
            this.txtContraseña.TabIndex = 8;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Items.AddRange(new object[] {
            "Usuario estandar",
            "Usuario Administrador"});
            this.cmbUsuario.Location = new System.Drawing.Point(160, 71);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(153, 21);
            this.cmbUsuario.TabIndex = 7;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(77, 129);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 6;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(77, 79);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 268);
            this.Controls.Add(this.btnIniciarSesión);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Name = "Login";
            this.Text = "Inicio de sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarSesión;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
    }
}

