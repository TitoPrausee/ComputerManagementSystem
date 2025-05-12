using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ComputerManagement3
{
    partial class Add
    {
        private IContainer components = null;

        private Guna2Elipse Elipse;
        private Guna2TextBox txtCpuName;
        private Guna2TextBox txtCpuProcessorId;
        private Guna2TextBox txtHddSerialNumber;
        private Guna2TextBox txtHddCapacity;
        private Guna2TextBox txtHddType;
        private Guna2TextBox txtRamSerialNumber;
        private Guna2TextBox txtRamSize;
        private Guna2TextBox txtMotherboardSerial;
        private Guna2TextBox txtGpuName;
        private Guna2TextBox txtMonitorPort;
        private Guna2Button btnSave;
        private Guna2Button btnNext;
        private Guna2Button btnBack; // Neuer Zurück-Button
        private Panel panel1;
        private Guna2ControlBox Close;
        private Guna2DragControl Drag;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Elipse = new Guna2Elipse(components);
            txtCpuName = new Guna2TextBox();
            txtCpuProcessorId = new Guna2TextBox();
            txtHddSerialNumber = new Guna2TextBox();
            txtHddCapacity = new Guna2TextBox();
            txtHddType = new Guna2TextBox();
            txtRamSerialNumber = new Guna2TextBox();
            txtRamSize = new Guna2TextBox();
            txtMotherboardSerial = new Guna2TextBox();
            txtGpuName = new Guna2TextBox();
            txtMonitorPort = new Guna2TextBox();
            btnSave = new Guna2Button();
            btnNext = new Guna2Button();
            btnBack = new Guna2Button();
            panel1 = new Panel();
            Close = new Guna2ControlBox();
            Drag = new Guna2DragControl(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Elipse
            // 
            Elipse.BorderRadius = 15;
            Elipse.TargetControl = this;
            // 
            // txtCpuName
            // 
            txtCpuName.BorderRadius = 15;
            txtCpuName.CustomizableEdges = customizableEdges3;
            txtCpuName.DefaultText = "";
            txtCpuName.Font = new Font("Segoe UI", 9F);
            txtCpuName.Location = new Point(48, 79);
            txtCpuName.Margin = new Padding(3, 4, 3, 4);
            txtCpuName.Name = "txtCpuName";
            txtCpuName.PlaceholderText = "CPU Name";
            txtCpuName.SelectedText = "";
            txtCpuName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtCpuName.Size = new Size(300, 40);
            txtCpuName.TabIndex = 0;
            // 
            // txtCpuProcessorId
            // 
            txtCpuProcessorId.BorderRadius = 15;
            txtCpuProcessorId.CustomizableEdges = customizableEdges5;
            txtCpuProcessorId.DefaultText = "";
            txtCpuProcessorId.Font = new Font("Segoe UI", 9F);
            txtCpuProcessorId.Location = new Point(48, 79);
            txtCpuProcessorId.Margin = new Padding(3, 4, 3, 4);
            txtCpuProcessorId.Name = "txtCpuProcessorId";
            txtCpuProcessorId.PlaceholderText = "CPU Processor ID";
            txtCpuProcessorId.SelectedText = "";
            txtCpuProcessorId.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtCpuProcessorId.Size = new Size(300, 40);
            txtCpuProcessorId.TabIndex = 1;
            txtCpuProcessorId.Visible = false;
            // 
            // txtHddSerialNumber
            // 
            txtHddSerialNumber.BorderRadius = 15;
            txtHddSerialNumber.CustomizableEdges = customizableEdges7;
            txtHddSerialNumber.DefaultText = "";
            txtHddSerialNumber.Font = new Font("Segoe UI", 9F);
            txtHddSerialNumber.Location = new Point(48, 79);
            txtHddSerialNumber.Margin = new Padding(3, 4, 3, 4);
            txtHddSerialNumber.Name = "txtHddSerialNumber";
            txtHddSerialNumber.PlaceholderText = "HDD Serial Number";
            txtHddSerialNumber.SelectedText = "";
            txtHddSerialNumber.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtHddSerialNumber.Size = new Size(300, 40);
            txtHddSerialNumber.TabIndex = 2;
            txtHddSerialNumber.Visible = false;
            // 
            // txtHddCapacity
            // 
            txtHddCapacity.BorderRadius = 15;
            txtHddCapacity.CustomizableEdges = customizableEdges9;
            txtHddCapacity.DefaultText = "";
            txtHddCapacity.Font = new Font("Segoe UI", 9F);
            txtHddCapacity.Location = new Point(48, 79);
            txtHddCapacity.Margin = new Padding(3, 4, 3, 4);
            txtHddCapacity.Name = "txtHddCapacity";
            txtHddCapacity.PlaceholderText = "HDD Capacity";
            txtHddCapacity.SelectedText = "";
            txtHddCapacity.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtHddCapacity.Size = new Size(300, 40);
            txtHddCapacity.TabIndex = 3;
            txtHddCapacity.Visible = false;
            // 
            // txtHddType
            // 
            txtHddType.BorderRadius = 15;
            txtHddType.CustomizableEdges = customizableEdges11;
            txtHddType.DefaultText = "";
            txtHddType.Font = new Font("Segoe UI", 9F);
            txtHddType.Location = new Point(48, 79);
            txtHddType.Margin = new Padding(3, 4, 3, 4);
            txtHddType.Name = "txtHddType";
            txtHddType.PlaceholderText = "HDD Type";
            txtHddType.SelectedText = "";
            txtHddType.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtHddType.Size = new Size(300, 40);
            txtHddType.TabIndex = 4;
            txtHddType.Visible = false;
            // 
            // txtRamSerialNumber
            // 
            txtRamSerialNumber.BorderRadius = 15;
            txtRamSerialNumber.CustomizableEdges = customizableEdges13;
            txtRamSerialNumber.DefaultText = "";
            txtRamSerialNumber.Font = new Font("Segoe UI", 9F);
            txtRamSerialNumber.Location = new Point(48, 79);
            txtRamSerialNumber.Margin = new Padding(3, 4, 3, 4);
            txtRamSerialNumber.Name = "txtRamSerialNumber";
            txtRamSerialNumber.PlaceholderText = "RAM Serial Number";
            txtRamSerialNumber.SelectedText = "";
            txtRamSerialNumber.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtRamSerialNumber.Size = new Size(300, 40);
            txtRamSerialNumber.TabIndex = 5;
            txtRamSerialNumber.Visible = false;
            // 
            // txtRamSize
            // 
            txtRamSize.BorderRadius = 15;
            txtRamSize.CustomizableEdges = customizableEdges15;
            txtRamSize.DefaultText = "";
            txtRamSize.Font = new Font("Segoe UI", 9F);
            txtRamSize.Location = new Point(48, 79);
            txtRamSize.Margin = new Padding(3, 4, 3, 4);
            txtRamSize.Name = "txtRamSize";
            txtRamSize.PlaceholderText = "RAM Size";
            txtRamSize.SelectedText = "";
            txtRamSize.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtRamSize.Size = new Size(300, 40);
            txtRamSize.TabIndex = 6;
            txtRamSize.Visible = false;
            // 
            // txtMotherboardSerial
            // 
            txtMotherboardSerial.BorderRadius = 15;
            txtMotherboardSerial.CustomizableEdges = customizableEdges17;
            txtMotherboardSerial.DefaultText = "";
            txtMotherboardSerial.Font = new Font("Segoe UI", 9F);
            txtMotherboardSerial.Location = new Point(48, 79);
            txtMotherboardSerial.Margin = new Padding(3, 4, 3, 4);
            txtMotherboardSerial.Name = "txtMotherboardSerial";
            txtMotherboardSerial.PlaceholderText = "Motherboard Serial";
            txtMotherboardSerial.SelectedText = "";
            txtMotherboardSerial.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtMotherboardSerial.Size = new Size(300, 40);
            txtMotherboardSerial.TabIndex = 7;
            txtMotherboardSerial.Visible = false;
            // 
            // txtGpuName
            // 
            txtGpuName.BorderRadius = 15;
            txtGpuName.CustomizableEdges = customizableEdges19;
            txtGpuName.DefaultText = "";
            txtGpuName.Font = new Font("Segoe UI", 9F);
            txtGpuName.Location = new Point(48, 79);
            txtGpuName.Margin = new Padding(3, 4, 3, 4);
            txtGpuName.Name = "txtGpuName";
            txtGpuName.PlaceholderText = "GPU Name";
            txtGpuName.SelectedText = "";
            txtGpuName.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtGpuName.Size = new Size(300, 40);
            txtGpuName.TabIndex = 8;
            txtGpuName.Visible = false;
            // 
            // txtMonitorPort
            // 
            txtMonitorPort.BorderRadius = 15;
            txtMonitorPort.CustomizableEdges = customizableEdges21;
            txtMonitorPort.DefaultText = "";
            txtMonitorPort.Font = new Font("Segoe UI", 9F);
            txtMonitorPort.Location = new Point(48, 79);
            txtMonitorPort.Margin = new Padding(3, 4, 3, 4);
            txtMonitorPort.Name = "txtMonitorPort";
            txtMonitorPort.PlaceholderText = "Monitor Port";
            txtMonitorPort.SelectedText = "";
            txtMonitorPort.ShadowDecoration.CustomizableEdges = customizableEdges22;
            txtMonitorPort.Size = new Size(300, 40);
            txtMonitorPort.TabIndex = 9;
            txtMonitorPort.Visible = false;
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 15;
            btnSave.CustomizableEdges = customizableEdges25;
            btnSave.FillColor = Color.Gray;
            btnSave.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(139, 96);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges26;
            btnSave.Size = new Size(126, 58);
            btnSave.TabIndex = 11;
            btnSave.Text = "Speichern";
            btnSave.Visible = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnNext
            // 
            btnNext.BorderRadius = 15;
            btnNext.CustomizableEdges = customizableEdges23;
            btnNext.FillColor = Color.Gray;
            btnNext.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(48, 139);
            btnNext.Name = "btnNext";
            btnNext.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btnNext.Size = new Size(100, 40);
            btnNext.TabIndex = 10;
            btnNext.Text = "Weiter";
            btnNext.Click += BtnNext_Click;
            // 
            // btnBack
            // 
            btnBack.BorderRadius = 15;
            btnBack.CustomizableEdges = customizableEdges27;
            btnBack.FillColor = Color.Gray;
            btnBack.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(154, 139);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges28;
            btnBack.Size = new Size(100, 40);
            btnBack.TabIndex = 12;
            btnBack.Text = "Zurück";
            btnBack.Visible = false;
            btnBack.Click += BtnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(Close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 35);
            panel1.TabIndex = 13;
            // 
            // Close
            // 
            Close.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            Close.CustomizableEdges = customizableEdges1;
            Close.Dock = DockStyle.Right;
            Close.FillColor = Color.Transparent;
            Close.ForeColor = SystemColors.ControlLightLight;
            Close.IconColor = Color.Black;
            Close.Location = new Point(324, 0);
            Close.Name = "Close";
            Close.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Close.Size = new Size(76, 35);
            Close.TabIndex = 0;
            Close.Click += Close_Click;
            // 
            // Drag
            // 
            Drag.DockIndicatorTransparencyValue = 0.6D;
            Drag.TargetControl = panel1;
            Drag.UseTransparentDrag = true;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 204);
            Controls.Add(panel1);
            Controls.Add(txtCpuName);
            Controls.Add(txtCpuProcessorId);
            Controls.Add(txtHddSerialNumber);
            Controls.Add(txtHddCapacity);
            Controls.Add(txtHddType);
            Controls.Add(txtRamSerialNumber);
            Controls.Add(txtRamSize);
            Controls.Add(txtMotherboardSerial);
            Controls.Add(txtGpuName);
            Controls.Add(txtMonitorPort);
            Controls.Add(btnNext);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}

