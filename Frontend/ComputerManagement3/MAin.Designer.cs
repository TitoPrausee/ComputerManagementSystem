using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComputerManagement3
{
    partial class MAin
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            txtSuche = new Guna.UI2.WinForms.Guna2TextBox();
            btnSuche = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            Close = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(245, 100);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(1385, 607);
            guna2DataGridView1.TabIndex = 0;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // Elipse
            // 
            Elipse.BorderRadius = 15;
            Elipse.TargetControl = this;
            // 
            // Elipse2
            // 
            Elipse2.BorderRadius = 15;
            Elipse2.TargetControl = guna2DataGridView1;
            // 
            // txtSuche
            // 
            txtSuche.BorderRadius = 15;
            txtSuche.CustomizableEdges = customizableEdges7;
            txtSuche.DefaultText = "";
            txtSuche.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSuche.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSuche.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSuche.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSuche.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSuche.Font = new Font("Segoe UI", 9F);
            txtSuche.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSuche.Location = new Point(30, 120);
            txtSuche.Margin = new Padding(3, 4, 3, 4);
            txtSuche.Name = "txtSuche";
            txtSuche.PlaceholderText = "z.B: Intel";
            txtSuche.SelectedText = "";
            txtSuche.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSuche.Size = new Size(180, 43);
            txtSuche.TabIndex = 3;
            // 
            // btnSuche
            // 
            btnSuche.BorderRadius = 15;
            btnSuche.Cursor = Cursors.Hand;
            btnSuche.CustomizableEdges = customizableEdges5;
            btnSuche.DisabledState.BorderColor = Color.DarkGray;
            btnSuche.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSuche.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSuche.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSuche.FillColor = Color.Gray;
            btnSuche.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuche.ForeColor = Color.White;
            btnSuche.Location = new Point(30, 170);
            btnSuche.Name = "btnSuche";
            btnSuche.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSuche.Size = new Size(179, 47);
            btnSuche.TabIndex = 4;
            btnSuche.Text = "Suchen";
            btnSuche.Click += btnSuche_Click;
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
            panel1.Size = new Size(1680, 66);
            panel1.TabIndex = 5;
            // 
            // Minimize
            // 
            Minimize.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            Minimize.Cursor = Cursors.Hand;
            Minimize.CustomizableEdges = customizableEdges1;
            Minimize.Dock = DockStyle.Right;
            Minimize.FillColor = Color.Transparent;
            Minimize.ForeColor = SystemColors.ControlLightLight;
            Minimize.IconColor = Color.Black;
            Minimize.Location = new Point(1528, 0);
            Minimize.Name = "Minimize";
            Minimize.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Minimize.Size = new Size(76, 66);
            Minimize.TabIndex = 1;
            // 
            // Close
            // 
            Close.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            Close.Cursor = Cursors.Hand;
            Close.CustomizableEdges = customizableEdges3;
            Close.Dock = DockStyle.Right;
            Close.FillColor = Color.Transparent;
            Close.ForeColor = SystemColors.ControlLightLight;
            Close.IconColor = Color.Black;
            Close.Location = new Point(1604, 0);
            Close.Name = "Close";
            Close.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Close.Size = new Size(76, 66);
            Close.TabIndex = 0;
            // 
            // MAin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1680, 747);
            Controls.Add(panel1);
            Controls.Add(btnSuche);
            Controls.Add(txtSuche);
            Controls.Add(guna2DataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MAin";
            Text = "MAin";
            Load += MAin_Load;
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2Elipse Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox txtSuche;
        private Guna.UI2.WinForms.Guna2Button btnSuche;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox Minimize;
        private Guna.UI2.WinForms.Guna2ControlBox Close;
    }
}
