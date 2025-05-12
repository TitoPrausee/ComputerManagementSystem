using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComputerManagement3
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form Designer generierter Code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            Close = new Guna.UI2.WinForms.Guna2ControlBox();
            Name = new Guna.UI2.WinForms.Guna2TextBox();
            Passwort = new Guna.UI2.WinForms.Guna2TextBox();
            Weiter = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Drag = new Guna.UI2.WinForms.Guna2DragControl(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Elipse
            // 
            Elipse.BorderRadius = 15;
            Elipse.TargetControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(Minimize);
            panel1.Controls.Add(Close);
            panel1.Cursor = Cursors.SizeAll;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 66);
            panel1.TabIndex = 0;
            // 
            // Minimize
            // 
            Minimize.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            Minimize.Cursor = Cursors.Hand;
            Minimize.CustomizableEdges = customizableEdges7;
            Minimize.Dock = DockStyle.Right;
            Minimize.FillColor = Color.Transparent;
            Minimize.ForeColor = SystemColors.ControlLightLight;
            Minimize.IconColor = Color.Black;
            Minimize.Location = new Point(281, 0);
            Minimize.Name = "Minimize";
            Minimize.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Minimize.Size = new Size(76, 66);
            Minimize.TabIndex = 1;
            // 
            // Close
            // 
            Close.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            Close.Cursor = Cursors.Hand;
            Close.CustomizableEdges = customizableEdges9;
            Close.Dock = DockStyle.Right;
            Close.FillColor = Color.Transparent;
            Close.ForeColor = SystemColors.ControlLightLight;
            Close.IconColor = Color.Black;
            Close.Location = new Point(357, 0);
            Close.Name = "Close";
            Close.ShadowDecoration.CustomizableEdges = customizableEdges10;
            Close.Size = new Size(76, 66);
            Close.TabIndex = 0;
            Close.Click += Close_Click;
            // 
            // Name
            // 
            Name.BorderRadius = 15;
            Name.CustomizableEdges = customizableEdges5;
            Name.DefaultText = "";
            Name.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Name.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Name.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Name.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Name.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Name.Font = new Font("Segoe UI", 9F);
            Name.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Name.Location = new Point(71, 196);
            Name.Margin = new Padding(3, 4, 3, 4);
            Name.Name = "Name";
            Name.PlaceholderText = "Name";
            Name.SelectedText = "";
            Name.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Name.Size = new Size(286, 60);
            Name.TabIndex = 1;
            Name.TextChanged += Name_TextChanged;
            // 
            // Passwort
            // 
            Passwort.BorderRadius = 15;
            Passwort.CustomizableEdges = customizableEdges3;
            Passwort.DefaultText = "";
            Passwort.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Passwort.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Passwort.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Passwort.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Passwort.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Passwort.Font = new Font("Segoe UI", 9F);
            Passwort.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Passwort.Location = new Point(71, 264);
            Passwort.Margin = new Padding(3, 4, 3, 4);
            Passwort.Name = "Passwort";
            Passwort.PlaceholderText = "Passwort";
            Passwort.SelectedText = "";
            Passwort.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Passwort.Size = new Size(286, 60);
            Passwort.TabIndex = 2;
            Passwort.TextChanged += Passwort_TextChanged;
            // 
            // Weiter
            // 
            Weiter.BorderRadius = 15;
            Weiter.Cursor = Cursors.Hand;
            Weiter.CustomizableEdges = customizableEdges1;
            Weiter.DisabledState.BorderColor = Color.DarkGray;
            Weiter.DisabledState.CustomBorderColor = Color.DarkGray;
            Weiter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Weiter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Weiter.FillColor = Color.Gray;
            Weiter.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Weiter.ForeColor = Color.White;
            Weiter.Location = new Point(99, 345);
            Weiter.Name = "Weiter";
            Weiter.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Weiter.Size = new Size(225, 56);
            Weiter.TabIndex = 3;
            Weiter.Text = "Weiter";
            Weiter.Click += Weiter_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.Gray;
            guna2HtmlLabel1.Location = new Point(154, 107);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(119, 53);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "Login";
            // 
            // Drag
            // 
            Drag.DockIndicatorTransparencyValue = 0.6D;
            Drag.TargetControl = panel1;
            Drag.UseTransparentDrag = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 479);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(Weiter);
            Controls.Add(Passwort);
            Controls.Add(Name);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            this.Text = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox Passwort;
        private new Guna.UI2.WinForms.Guna2TextBox Name;
        private Guna.UI2.WinForms.Guna2Button Weiter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ControlBox Close;
        private Guna.UI2.WinForms.Guna2ControlBox Minimize;
        private Guna.UI2.WinForms.Guna2DragControl Drag;
    }
}
