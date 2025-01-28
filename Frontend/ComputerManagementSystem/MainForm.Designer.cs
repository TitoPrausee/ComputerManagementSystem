using System;

namespace ComputerManagementSystem
{
    partial class MainForm
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listViewComputerSystems = new System.Windows.Forms.ListView();
            this.columnCpuName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCpuProcessorId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHddSerialNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHddCapacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHddType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRamSerialNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRamSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMotherboardSerial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGpuName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMonitorPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Maximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.CloseButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ViewBoxElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnLoadData = new Guna.UI2.WinForms.Guna2Button();
            this.openAddScrean = new System.Windows.Forms.PictureBox();
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.HeadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openAddScrean)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewComputerSystems
            // 
            this.listViewComputerSystems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewComputerSystems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCpuName,
            this.columnCpuProcessorId,
            this.columnHddSerialNumber,
            this.columnHddCapacity,
            this.columnHddType,
            this.columnRamSerialNumber,
            this.columnRamSize,
            this.columnMotherboardSerial,
            this.columnGpuName,
            this.columnMonitorPort});
            this.listViewComputerSystems.FullRowSelect = true;
            this.listViewComputerSystems.GridLines = true;
            this.listViewComputerSystems.HideSelection = false;
            this.listViewComputerSystems.Location = new System.Drawing.Point(6, 83);
            this.listViewComputerSystems.Margin = new System.Windows.Forms.Padding(2);
            this.listViewComputerSystems.Name = "listViewComputerSystems";
            this.listViewComputerSystems.Size = new System.Drawing.Size(601, 326);
            this.listViewComputerSystems.TabIndex = 0;
            this.listViewComputerSystems.UseCompatibleStateImageBehavior = false;
            this.listViewComputerSystems.View = System.Windows.Forms.View.Details;
            this.listViewComputerSystems.SelectedIndexChanged += new System.EventHandler(this.listViewComputerSystems_SelectedIndexChanged);
            // 
            // columnCpuName
            // 
            this.columnCpuName.Text = "CPU Name";
            this.columnCpuName.Width = 120;
            // 
            // columnCpuProcessorId
            // 
            this.columnCpuProcessorId.Text = "CPU Processor ID";
            this.columnCpuProcessorId.Width = 150;
            // 
            // columnHddSerialNumber
            // 
            this.columnHddSerialNumber.Text = "HDD Serial Number";
            this.columnHddSerialNumber.Width = 150;
            // 
            // columnHddCapacity
            // 
            this.columnHddCapacity.Text = "HDD Capacity";
            this.columnHddCapacity.Width = 120;
            // 
            // columnHddType
            // 
            this.columnHddType.Text = "HDD Type";
            this.columnHddType.Width = 100;
            // 
            // columnRamSerialNumber
            // 
            this.columnRamSerialNumber.Text = "RAM Serial Number";
            this.columnRamSerialNumber.Width = 150;
            // 
            // columnRamSize
            // 
            this.columnRamSize.Text = "RAM Size";
            this.columnRamSize.Width = 100;
            // 
            // columnMotherboardSerial
            // 
            this.columnMotherboardSerial.Text = "Motherboard Serial";
            this.columnMotherboardSerial.Width = 150;
            // 
            // columnGpuName
            // 
            this.columnGpuName.Text = "GPU Name";
            this.columnGpuName.Width = 120;
            // 
            // columnMonitorPort
            // 
            this.columnMonitorPort.Text = "Monitor Port";
            this.columnMonitorPort.Width = 100;
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.HeadPanel.Controls.Add(this.Minimize);
            this.HeadPanel.Controls.Add(this.Maximize);
            this.HeadPanel.Controls.Add(this.CloseButton);
            this.HeadPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(618, 47);
            this.HeadPanel.TabIndex = 2;
            // 
            // Minimize
            // 
            this.Minimize.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize.FillColor = System.Drawing.Color.Transparent;
            this.Minimize.IconColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(483, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(45, 47);
            this.Minimize.TabIndex = 2;
            // 
            // Maximize
            // 
            this.Maximize.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.Maximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Maximize.FillColor = System.Drawing.Color.Transparent;
            this.Maximize.IconColor = System.Drawing.Color.White;
            this.Maximize.Location = new System.Drawing.Point(528, 0);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(45, 47);
            this.Maximize.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FillColor = System.Drawing.Color.Transparent;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(573, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 47);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.HeadPanel;
            this.DragControl.UseTransparentDrag = true;
            // 
            // ViewBoxElipse
            // 
            this.ViewBoxElipse.BorderRadius = 15;
            this.ViewBoxElipse.TargetControl = this.listViewComputerSystems;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadData.BorderRadius = 8;
            this.btnLoadData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnLoadData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadData.ForeColor = System.Drawing.Color.White;
            this.btnLoadData.Location = new System.Drawing.Point(12, 419);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(180, 45);
            this.btnLoadData.TabIndex = 3;
            this.btnLoadData.Text = "Daten erneut laden";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click_1);
            // 
            // openAddScrean
            // 
            this.openAddScrean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openAddScrean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openAddScrean.Image = ((System.Drawing.Image)(resources.GetObject("openAddScrean.Image")));
            this.openAddScrean.Location = new System.Drawing.Point(213, 428);
            this.openAddScrean.Name = "openAddScrean";
            this.openAddScrean.Size = new System.Drawing.Size(28, 27);
            this.openAddScrean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.openAddScrean.TabIndex = 4;
            this.openAddScrean.TabStop = false;
            this.openAddScrean.Click += new System.EventHandler(this.openAddScrean_Click);
            // 
            // Elipse
            // 
            this.Elipse.TargetControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 476);
            this.Controls.Add(this.openAddScrean);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.HeadPanel);
            this.Controls.Add(this.listViewComputerSystems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "w";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HeadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.openAddScrean)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListView listViewComputerSystems;
        private System.Windows.Forms.ColumnHeader columnCpuName;
        private System.Windows.Forms.ColumnHeader columnCpuProcessorId;
        private System.Windows.Forms.ColumnHeader columnHddSerialNumber;
        private System.Windows.Forms.ColumnHeader columnHddCapacity;
        private System.Windows.Forms.ColumnHeader columnHddType;
        private System.Windows.Forms.ColumnHeader columnRamSerialNumber;
        private System.Windows.Forms.ColumnHeader columnRamSize;
        private System.Windows.Forms.ColumnHeader columnMotherboardSerial;
        private System.Windows.Forms.ColumnHeader columnGpuName;
        private System.Windows.Forms.ColumnHeader columnMonitorPort;
        private System.Windows.Forms.Panel HeadPanel;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2ControlBox Minimize;
        private Guna.UI2.WinForms.Guna2ControlBox Maximize;
        private Guna.UI2.WinForms.Guna2ControlBox CloseButton;
        private Guna.UI2.WinForms.Guna2Elipse ViewBoxElipse;
        private Guna.UI2.WinForms.Guna2Button btnLoadData;
        private System.Windows.Forms.PictureBox openAddScrean;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
    }
}