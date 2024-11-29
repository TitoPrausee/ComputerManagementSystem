namespace ComputerManagementSystem
{
    partial class MainForm
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
            this.listViewComputerSystems.HideSelection = false;
            this.listViewComputerSystems.Location = new System.Drawing.Point(12, 12);
            this.listViewComputerSystems.Name = "listViewComputerSystems";
            this.listViewComputerSystems.Size = new System.Drawing.Size(800, 426);
            this.listViewComputerSystems.TabIndex = 0;
            this.listViewComputerSystems.UseCompatibleStateImageBehavior = false;
            this.listViewComputerSystems.View = System.Windows.Forms.View.Details;
            this.listViewComputerSystems.SelectedIndexChanged += new System.EventHandler(this.listViewComputerSystems_SelectedIndexChanged);
            // 
            // columnCpuName
            // 
            this.columnCpuName.Text = "CPU Name";
            this.columnCpuName.Width = 150;
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
            this.columnHddCapacity.Width = 100;
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
            this.columnGpuName.Width = 150;
            // // 
            // columnMonitorPort
            // 
            this.columnMonitorPort.Text = "Monitor Port";
            this.columnMonitorPort.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewComputerSystems);
            this.Name = "MainForm";
            this.Text = "Computer Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
        }

        #endregion

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
    }
}