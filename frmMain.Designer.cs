namespace CarRentalApp
{
    partial class frmMain
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmManageVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeRentalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmManageVehicle,
            this.mangeRentalRecordsToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(840, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // tsmManageVehicle
            // 
            this.tsmManageVehicle.Name = "tsmManageVehicle";
            this.tsmManageVehicle.Size = new System.Drawing.Size(140, 20);
            this.tsmManageVehicle.Text = "Manage Vehicle Listing";
            this.tsmManageVehicle.Click += new System.EventHandler(this.tsmManageVehicle_Click);
            // 
            // mangeRentalRecordsToolStripMenuItem
            // 
            this.mangeRentalRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRToolStripMenuItem,
            this.editRentalToolStripMenuItem,
            this.viewArchiveToolStripMenuItem});
            this.mangeRentalRecordsToolStripMenuItem.Name = "mangeRentalRecordsToolStripMenuItem";
            this.mangeRentalRecordsToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.mangeRentalRecordsToolStripMenuItem.Text = "Mange Rental Records";
            // 
            // addRToolStripMenuItem
            // 
            this.addRToolStripMenuItem.Name = "addRToolStripMenuItem";
            this.addRToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addRToolStripMenuItem.Text = "Add Rental";
            this.addRToolStripMenuItem.Click += new System.EventHandler(this.addRToolStripMenuItem_Click);
            // 
            // editRentalToolStripMenuItem
            // 
            this.editRentalToolStripMenuItem.Name = "editRentalToolStripMenuItem";
            this.editRentalToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.editRentalToolStripMenuItem.Text = "Edit Rental";
            // 
            // viewArchiveToolStripMenuItem
            // 
            this.viewArchiveToolStripMenuItem.Name = "viewArchiveToolStripMenuItem";
            this.viewArchiveToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.viewArchiveToolStripMenuItem.Text = "View Archive";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 479);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "frmMain";
            this.Text = "Rental System Management";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmManageVehicle;
        private System.Windows.Forms.ToolStripMenuItem mangeRentalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArchiveToolStripMenuItem;
    }
}