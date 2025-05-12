namespace ComputerManagement3
{
    partial class AddUser
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            Close = new Guna.UI2.WinForms.Guna2ControlBox();
            Drag = new Guna.UI2.WinForms.Guna2DragControl(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BorderRadius = 13;
            txtUsername.CustomizableEdges = customizableEdges1;
            txtUsername.DefaultText = "";
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.Location = new Point(49, 66);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Benutzername";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUsername.Size = new Size(200, 40);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BorderRadius = 13;
            txtPassword.CustomizableEdges = customizableEdges3;
            txtPassword.DefaultText = "";
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.Location = new Point(49, 116);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Passwort";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPassword.Size = new Size(200, 40);
            txtPassword.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 13;
            btnSave.Cursor = Cursors.Hand;
            btnSave.CustomizableEdges = customizableEdges5;
            btnSave.FillColor = Color.Gray;
            btnSave.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(49, 163);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSave.Size = new Size(200, 40);
            btnSave.TabIndex = 3;
            btnSave.Text = "Speichern";
            btnSave.Click += btnSave_Click;
            // 
            // Elipse
            // 
            Elipse.TargetControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(Close);
            panel1.Cursor = Cursors.SizeAll;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 30);
            panel1.TabIndex = 4;
            // 
            // Close
            // 
            Close.Cursor = Cursors.Hand;
            Close.CustomizableEdges = customizableEdges7;
            Close.Dock = DockStyle.Right;
            Close.FillColor = Color.Transparent;
            Close.IconColor = Color.Black;
            Close.Location = new Point(270, 0);
            Close.Name = "Close";
            Close.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Close.Size = new Size(30, 30);
            Close.TabIndex = 0;
            // 
            // Drag
            // 
            Drag.DockIndicatorTransparencyValue = 0.6D;
            Drag.TargetControl = panel1;
            Drag.UseTransparentDrag = true;
            // 
            // AddUser
            // 
            ClientSize = new Size(300, 241);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnSave);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nutzer hinzufügen";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox Close;
        private Guna.UI2.WinForms.Guna2DragControl Drag;
    }
}
