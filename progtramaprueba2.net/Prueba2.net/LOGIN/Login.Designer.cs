namespace LOGIN
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
            this.btncontra = new System.Windows.Forms.Button();
            this.lblcajero = new System.Windows.Forms.Label();
            this.lblcontra = new System.Windows.Forms.Label();
            this.txtcajero = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncontra
            // 
            this.btncontra.Location = new System.Drawing.Point(301, 263);
            this.btncontra.Name = "btncontra";
            this.btncontra.Size = new System.Drawing.Size(75, 23);
            this.btncontra.TabIndex = 0;
            this.btncontra.Text = "Login";
            this.btncontra.UseVisualStyleBackColor = true;
            this.btncontra.Click += new System.EventHandler(this.btncontra_Click);
            // 
            // lblcajero
            // 
            this.lblcajero.AutoSize = true;
            this.lblcajero.Location = new System.Drawing.Point(151, 103);
            this.lblcajero.Name = "lblcajero";
            this.lblcajero.Size = new System.Drawing.Size(37, 13);
            this.lblcajero.TabIndex = 1;
            this.lblcajero.Text = "Cajero";
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.Location = new System.Drawing.Point(150, 145);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(61, 13);
            this.lblcontra.TabIndex = 2;
            this.lblcontra.Text = "Contraseña";
            // 
            // txtcajero
            // 
            this.txtcajero.Location = new System.Drawing.Point(301, 103);
            this.txtcajero.Name = "txtcajero";
            this.txtcajero.Size = new System.Drawing.Size(100, 20);
            this.txtcajero.TabIndex = 3;
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(301, 142);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.PasswordChar = '*';
            this.txtcontra.Size = new System.Drawing.Size(100, 20);
            this.txtcontra.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtcajero);
            this.Controls.Add(this.lblcontra);
            this.Controls.Add(this.lblcajero);
            this.Controls.Add(this.btncontra);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncontra;
        private System.Windows.Forms.Label lblcajero;
        private System.Windows.Forms.Label lblcontra;
        private System.Windows.Forms.TextBox txtcajero;
        private System.Windows.Forms.TextBox txtcontra;
    }
}

