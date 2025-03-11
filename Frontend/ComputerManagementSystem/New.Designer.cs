using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ComputerManagementSystem
{
    partial class New : Form
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
            this.txtCpuName = new System.Windows.Forms.TextBox();
            this.txtCpuProcessorId = new System.Windows.Forms.TextBox();
            this.txtHddSerialNumber = new System.Windows.Forms.TextBox();
            this.txtHddCapacity = new System.Windows.Forms.TextBox();
            this.txtHddType = new System.Windows.Forms.TextBox();
            this.txtRamSerialNumber = new System.Windows.Forms.TextBox();
            this.txtRamSize = new System.Windows.Forms.TextBox();
            this.txtMotherboardSerial = new System.Windows.Forms.TextBox();
            this.txtGpuName = new System.Windows.Forms.TextBox();
            this.txtMonitorPort = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCpuName
            // 
            this.txtCpuName.Location = new System.Drawing.Point(12, 12);
            this.txtCpuName.Name = "txtCpuName";
            this.txtCpuName.Size = new System.Drawing.Size(260, 20);
            this.txtCpuName.TabIndex = 0;
            this.txtCpuName.Text = "CPU Name";
            this.txtCpuName.Enter += new System.EventHandler(this.txtCpuName_Enter);
            this.txtCpuName.Leave += new System.EventHandler(this.txtCpuName_Leave);
            // 
            // txtCpuProcessorId
            // 
            this.txtCpuProcessorId.Location = new System.Drawing.Point(12, 38);
            this.txtCpuProcessorId.Name = "txtCpuProcessorId";
            this.txtCpuProcessorId.Size = new System.Drawing.Size(260, 20);
            this.txtCpuProcessorId.TabIndex = 1;
            this.txtCpuProcessorId.Text = "CPU Processor ID";
            this.txtCpuProcessorId.Enter += new System.EventHandler(this.txtCpuProcessorId_Enter);
            this.txtCpuProcessorId.Leave += new System.EventHandler(this.txtCpuProcessorId_Leave);
            // 
            // txtHddSerialNumber
            // 
            this.txtHddSerialNumber.Location = new System.Drawing.Point(12, 64);
            this.txtHddSerialNumber.Name = "txtHddSerialNumber";
            this.txtHddSerialNumber.Size = new System.Drawing.Size(260, 20);
            this.txtHddSerialNumber.TabIndex = 2;
            this.txtHddSerialNumber.Text = "HDD Serial Number";
            this.txtHddSerialNumber.Enter += new System.EventHandler(this.txtHddSerialNumber_Enter);
            this.txtHddSerialNumber.Leave += new System.EventHandler(this.txtHddSerialNumber_Leave);
            // 
            // txtHddCapacity
            // 
            this.txtHddCapacity.Location = new System.Drawing.Point(12, 90);
            this.txtHddCapacity.Name = "txtHddCapacity";
            this.txtHddCapacity.Size = new System.Drawing.Size(260, 20);
            this.txtHddCapacity.TabIndex = 3;
            this.txtHddCapacity.Text = "HDD Capacity";
            this.txtHddCapacity.Enter += new System.EventHandler(this.txtHddCapacity_Enter);
            this.txtHddCapacity.Leave += new System.EventHandler(this.txtHddCapacity_Leave);
            // 
            // txtHddType
            // 
            this.txtHddType.Location = new System.Drawing.Point(12, 116);
            this.txtHddType.Name = "txtHddType";
            this.txtHddType.Size = new System.Drawing.Size(260, 20);
            this.txtHddType.TabIndex = 4;
            this.txtHddType.Text = "HDD Type";
            this.txtHddType.Enter += new System.EventHandler(this.txtHddType_Enter);
            this.txtHddType.Leave += new System.EventHandler(this.txtHddType_Leave);
            // 
            // txtRamSerialNumber
            // 
            this.txtRamSerialNumber.Location = new System.Drawing.Point(12, 142);
            this.txtRamSerialNumber.Name = "txtRamSerialNumber";
            this.txtRamSerialNumber.Size = new System.Drawing.Size(260, 20);
            this.txtRamSerialNumber.TabIndex = 5;
            this.txtRamSerialNumber.Text = "RAM Serial Number";
            this.txtRamSerialNumber.Enter += new System.EventHandler(this.txtRamSerialNumber_Enter);
            this.txtRamSerialNumber.Leave += new System.EventHandler(this.txtRamSerialNumber_Leave);
            // 
            // txtRamSize
            // 
            this.txtRamSize.Location = new System.Drawing.Point(12, 168);
            this.txtRamSize.Name = "txtRamSize";
            this.txtRamSize.Size = new System.Drawing.Size(260, 20);
            this.txtRamSize.TabIndex = 6;
            this.txtRamSize.Text = "RAM Size";
            this.txtRamSize.Enter += new System.EventHandler(this.txtRamSize_Enter);
            this.txtRamSize.Leave += new System.EventHandler(this.txtRamSize_Leave);
            // 
            // txtMotherboardSerial
            // 
            this.txtMotherboardSerial.Location = new System.Drawing.Point(12, 194);
            this.txtMotherboardSerial.Name = "txtMotherboardSerial";
            this.txtMotherboardSerial.Size = new System.Drawing.Size(260, 20);
            this.txtMotherboardSerial.TabIndex = 7;
            this.txtMotherboardSerial.Text = "Motherboard Serial";
            this.txtMotherboardSerial.Enter += new System.EventHandler(this.txtMotherboardSerial_Enter);
            this.txtMotherboardSerial.Leave += new System.EventHandler(this.txtMotherboardSerial_Leave);
            // 
            // txtGpuName
            // 
            this.txtGpuName.Location = new System.Drawing.Point(12, 220);
            this.txtGpuName.Name = "txtGpuName";
            this.txtGpuName.Size = new System.Drawing.Size(260, 20);
            this.txtGpuName.TabIndex = 8;
            this.txtGpuName.Text = "GPU Name";
            this.txtGpuName.Enter += new System.EventHandler(this.txtGpuName_Enter);
            this.txtGpuName.Leave += new System.EventHandler(this.txtGpuName_Leave);
            // 
            // txtMonitorPort
            // 
            this.txtMonitorPort.Location = new System.Drawing.Point(12, 246);
            this.txtMonitorPort.Name = "txtMonitorPort";
            this.txtMonitorPort.Size = new System.Drawing.Size(260, 20);
            this.txtMonitorPort.TabIndex = 9;
            this.txtMonitorPort.Text = "Monitor Port";
            this.txtMonitorPort.Enter += new System.EventHandler(this.txtMonitorPort_Enter);
            this.txtMonitorPort.Leave += new System.EventHandler(this.txtMonitorPort_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 272);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(260, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // New
            // 
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtMonitorPort);
            this.Controls.Add(this.txtGpuName);
            this.Controls.Add(this.txtMotherboardSerial);
            this.Controls.Add(this.txtRamSize);
            this.Controls.Add(this.txtRamSerialNumber);
            this.Controls.Add(this.txtHddType);
            this.Controls.Add(this.txtHddCapacity);
            this.Controls.Add(this.txtHddSerialNumber);
            this.Controls.Add(this.txtCpuProcessorId);
            this.Controls.Add(this.txtCpuName);
            this.Name = "New";
            this.Text = "Neues Gerät hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCpuName;
        private System.Windows.Forms.TextBox txtCpuProcessorId;
        private System.Windows.Forms.TextBox txtHddSerialNumber;
        private System.Windows.Forms.TextBox txtHddCapacity;
        private System.Windows.Forms.TextBox txtHddType;
        private System.Windows.Forms.TextBox txtRamSerialNumber;
        private System.Windows.Forms.TextBox txtRamSize;
        private System.Windows.Forms.TextBox txtMotherboardSerial;
        private System.Windows.Forms.TextBox txtGpuName;
        private System.Windows.Forms.TextBox txtMonitorPort;
        private System.Windows.Forms.Button btnSubmit;

        private void txtCpuName_Enter(object sender, EventArgs e)
        {
            if (txtCpuName.Text == "CPU Name")
            {
                txtCpuName.Text = "";
                txtCpuName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtCpuName_Leave(object sender, EventArgs e)
        {
            if (txtCpuName.Text == "")
            {
                txtCpuName.Text = "CPU Name";
                txtCpuName.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtCpuProcessorId_Enter(object sender, EventArgs e)
        {
            if (txtCpuProcessorId.Text == "CPU Processor ID")
            {
                txtCpuProcessorId.Text = "";
                txtCpuProcessorId.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtCpuProcessorId_Leave(object sender, EventArgs e)
        {
            if (txtCpuProcessorId.Text == "")
            {
                txtCpuProcessorId.Text = "CPU Processor ID";
                txtCpuProcessorId.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtHddSerialNumber_Enter(object sender, EventArgs e)
        {
            if (txtHddSerialNumber.Text == "HDD Serial Number")
            {
                txtHddSerialNumber.Text = "";
                txtHddSerialNumber.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtHddSerialNumber_Leave(object sender, EventArgs e)
        {
            if (txtHddSerialNumber.Text == "")
            {
                txtHddSerialNumber.Text = "HDD Serial Number";
                txtHddSerialNumber.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtHddCapacity_Enter(object sender, EventArgs e)
        {
            if (txtHddCapacity.Text == "HDD Capacity")
            {
                txtHddCapacity.Text = "";
                txtHddCapacity.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtHddCapacity_Leave(object sender, EventArgs e)
        {
            if (txtHddCapacity.Text == "")
            {
                txtHddCapacity.Text = "HDD Capacity";
                txtHddCapacity.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtHddType_Enter(object sender, EventArgs e)
        {
            if (txtHddType.Text == "HDD Type")
            {
                txtHddType.Text = "";
                txtHddType.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtHddType_Leave(object sender, EventArgs e)
        {
            if (txtHddType.Text == "")
            {
                txtHddType.Text = "HDD Type";
                txtHddType.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtRamSerialNumber_Enter(object sender, EventArgs e)
        {
            if (txtRamSerialNumber.Text == "RAM Serial Number")
            {
                txtRamSerialNumber.Text = "";
                txtRamSerialNumber.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtRamSerialNumber_Leave(object sender, EventArgs e)
        {
            if (txtRamSerialNumber.Text == "")
            {
                txtRamSerialNumber.Text = "RAM Serial Number";
                txtRamSerialNumber.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtRamSize_Enter(object sender, EventArgs e)
        {
            if (txtRamSize.Text == "RAM Size")
            {
                txtRamSize.Text = "";
                txtRamSize.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtRamSize_Leave(object sender, EventArgs e)
        {
            if (txtRamSize.Text == "")
            {
                txtRamSize.Text = "RAM Size";
                txtRamSize.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtMotherboardSerial_Enter(object sender, EventArgs e)
        {
            if (txtMotherboardSerial.Text == "Motherboard Serial")
            {
                txtMotherboardSerial.Text = "";
                txtMotherboardSerial.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtMotherboardSerial_Leave(object sender, EventArgs e)
        {
            if (txtMotherboardSerial.Text == "")
            {
                txtMotherboardSerial.Text = "Motherboard Serial";
                txtMotherboardSerial.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtGpuName_Enter(object sender, EventArgs e)
        {
            if (txtGpuName.Text == "GPU Name")
            {
                txtGpuName.Text = "";
                txtGpuName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtGpuName_Leave(object sender, EventArgs e)
        {
            if (txtGpuName.Text == "")
            {
                txtGpuName.Text = "GPU Name";
                txtGpuName.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtMonitorPort_Enter(object sender, EventArgs e)
        {
            if (txtMonitorPort.Text == "Monitor Port")
            {
                txtMonitorPort.Text = "";
                txtMonitorPort.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtMonitorPort_Leave(object sender, EventArgs e)
        {
            if (txtMonitorPort.Text == "")
            {
                txtMonitorPort.Text = "Monitor Port";
                txtMonitorPort.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
