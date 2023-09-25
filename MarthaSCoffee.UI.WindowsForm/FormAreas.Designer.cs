namespace MarthaSCoffee.UI.WindowsForm
{
    partial class FormAreas
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
            this.GridAreas = new System.Windows.Forms.DataGridView();
            this.Aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridAreas)).BeginInit();
            this.SuspendLayout();
            // 
            // GridAreas
            // 
            this.GridAreas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAreas.Location = new System.Drawing.Point(37, 45);
            this.GridAreas.Name = "GridAreas";
            this.GridAreas.Size = new System.Drawing.Size(355, 320);
            this.GridAreas.TabIndex = 0;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(126, 390);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(194, 46);
            this.Aceptar.TabIndex = 1;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // FormAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 448);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.GridAreas);
            this.Name = "FormAreas";
            this.Text = "FormAreas";
            this.Load += new System.EventHandler(this.FormAreas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAreas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridAreas;
        private System.Windows.Forms.Button Aceptar;
    }
}