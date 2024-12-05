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
            this.btnLoadData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewComputerSystems
            // 
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
            this.listViewComputerSystems.Location = new System.Drawing.Point(9, 10);
            this.listViewComputerSystems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(9, 341);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(90, 24);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Daten Laden";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 375);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.listViewComputerSystems);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Computer Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.Button btnLoadData;
    }
}