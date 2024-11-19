namespace ComputerManagementSystem
{
    partial class Home
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitel = new System.Windows.Forms.Label();
            this.btnBenutzerverwaltung = new System.Windows.Forms.Button();
            this.btnPCVerwaltung = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitel.Location = new System.Drawing.Point(80, 30);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(200, 26);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Computer Verwaltung";

            // 
            // btnBenutzerverwaltung
            // 
            this.btnBenutzerverwaltung.Location = new System.Drawing.Point(80, 100);
            this.btnBenutzerverwaltung.Name = "btnBenutzerverwaltung";
            this.btnBenutzerverwaltung.Size = new System.Drawing.Size(200, 40);
            this.btnBenutzerverwaltung.TabIndex = 1;
            this.btnBenutzerverwaltung.Text = "Benutzerverwaltung";
            this.btnBenutzerverwaltung.UseVisualStyleBackColor = true;
            this.btnBenutzerverwaltung.Click += new System.EventHandler(this.btnBenutzerverwaltung_Click);

            // 
            // btnPCVerwaltung
            // 
            this.btnPCVerwaltung.Location = new System.Drawing.Point(80, 160);
            this.btnPCVerwaltung.Name = "btnPCVerwaltung";
            this.btnPCVerwaltung.Size = new System.Drawing.Size(200, 40);
            this.btnPCVerwaltung.TabIndex = 2;
            this.btnPCVerwaltung.Text = "PC-Verwaltung";
            this.btnPCVerwaltung.UseVisualStyleBackColor = true;
            this.btnPCVerwaltung.Click += new System.EventHandler(this.btnPCVerwaltung_Click);

            // 
            // TextBox für Benutzername
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtUsername.Location = new System.Drawing.Point(80, 220);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "Benutzername"; // Platzhaltertext
            this.txtUsername.GotFocus += (s, e) => { if (this.txtUsername.Text == "Benutzername") this.txtUsername.Text = ""; };
            this.txtUsername.LostFocus += (s, e) => { if (string.IsNullOrWhiteSpace(this.txtUsername.Text)) this.txtUsername.Text = "Benutzername"; };

            // TextBox für Passwort
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword.Location = new System.Drawing.Point(80, 250);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true; // Versteckt das Passwort
            this.txtPassword.GotFocus += (s, e) => { if (this.txtPassword.Text == "Passwort") this.txtPassword.Text = ""; };
            this.txtPassword.LostFocus += (s, e) => { if (string.IsNullOrWhiteSpace(this.txtPassword.Text)) this.txtPassword.Text = "Passwort"; };
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(80, 280);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Anmelden";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(80, 320);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 6;

            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnPCVerwaltung);
            this.Controls.Add(this.btnBenutzerverwaltung);
            this.Controls.Add(this.lblTitel);
            this.Name = "Home";
            this.Text = "Startseite";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnBenutzerverwaltung;
        private System.Windows.Forms.Button btnPCVerwaltung;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblMessage;
    }
}