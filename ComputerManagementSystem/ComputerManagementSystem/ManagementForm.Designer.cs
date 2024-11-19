namespace ComputerManagementSystem
{
    partial class ManagementForm
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
            this.btnUser Management = new System.Windows.Forms.Button();
            this.btnPCManagement = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dgvPCs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUser Management
            // 
            this.btnUser Management.Location = new System.Drawing.Point(30, 30);
            this.btnUser Management.Name = "btnUser Management";
            this.btnUser Management.Size = new System.Drawing.Size(150, 30);
            this.btnUser Management.TabIndex = 0;
            this.btnUser Management.Text = "Benutzerverwaltung";
            this.btnUser Management.UseVisualStyleBackColor = true;
            this.btnUser Management.Click += new System.EventHandler(this.btnUser Management_Click);
            // 
            // btnPCManagement
            // 
            this.btnPCManagement.Location = new System.Drawing.Point(30, 70);
            this.btnPCManagement.Name = "btnPCManagement";
            this.btnPCManagement.Size = new System.Drawing.Size(150, 30);
            this.btnPCManagement.TabIndex = 1;
            this.btnPCManagement.Text = "PC-Verwaltung";
            this.btnPCManagement.UseVisualStyleBackColor = true;
            this.btnPCManagement.Click += new System.EventHandler(this.btnPCManagement_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(30, 120);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(400, 200);
            this.dgvUsers.TabIndex = 2;
            // 
            // dgvPCs
            // 
            this.dgvPCs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPCs.Location = new System.Drawing.Point(450, 120);
            this.dgvPCs.Name = "dgvPCs";
            this.dgvPCs.Size = new System.Drawing.Size(400, 200);
            this.dgvPCs.TabIndex = 3;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.dgvPCs);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnPCManagement);
            this.Controls.Add(this.btnUser Management);
            this.Name = "ManagementForm";
            this.Text = "Benutzer- und PC-Verwaltung";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPCs)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnUser Management;
        private System.Windows.Forms.Button btnPCManagement;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvPCs;
    }
}