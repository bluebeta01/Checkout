namespace Checkout
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSingleStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFullRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.outputbox = new System.Windows.Forms.TextBox();
            this.printReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastid = new System.Windows.Forms.TextBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.recordsToolStripMenuItem,
            this.printReportToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(522, 28);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDatabaseToolStripMenuItem,
            this.addSingleStudentToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // addNewDatabaseToolStripMenuItem
            // 
            this.addNewDatabaseToolStripMenuItem.Name = "addNewDatabaseToolStripMenuItem";
            this.addNewDatabaseToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.addNewDatabaseToolStripMenuItem.Text = "Add New Database";
            this.addNewDatabaseToolStripMenuItem.Click += new System.EventHandler(this.addNewDatabaseToolStripMenuItem_Click);
            // 
            // addSingleStudentToolStripMenuItem
            // 
            this.addSingleStudentToolStripMenuItem.Name = "addSingleStudentToolStripMenuItem";
            this.addSingleStudentToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.addSingleStudentToolStripMenuItem.Text = "Add Single Student";
            this.addSingleStudentToolStripMenuItem.Click += new System.EventHandler(this.addSingleStudentToolStripMenuItem_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForStudentToolStripMenuItem,
            this.viewFullRecordToolStripMenuItem});
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.recordsToolStripMenuItem.Text = "Records";
            // 
            // searchForStudentToolStripMenuItem
            // 
            this.searchForStudentToolStripMenuItem.Name = "searchForStudentToolStripMenuItem";
            this.searchForStudentToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.searchForStudentToolStripMenuItem.Text = "Search for Student";
            this.searchForStudentToolStripMenuItem.Click += new System.EventHandler(this.searchForStudentToolStripMenuItem_Click);
            // 
            // viewFullRecordToolStripMenuItem
            // 
            this.viewFullRecordToolStripMenuItem.Name = "viewFullRecordToolStripMenuItem";
            this.viewFullRecordToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.viewFullRecordToolStripMenuItem.Text = "View Full Record";
            this.viewFullRecordToolStripMenuItem.Click += new System.EventHandler(this.viewFullRecordToolStripMenuItem_Click);
            // 
            // inputbox
            // 
            this.inputbox.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputbox.Location = new System.Drawing.Point(12, 265);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(492, 32);
            this.inputbox.TabIndex = 1;
            this.inputbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputbox.TextChanged += new System.EventHandler(this.inputbox_TextChanged);
            // 
            // outputbox
            // 
            this.outputbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputbox.Location = new System.Drawing.Point(12, 371);
            this.outputbox.Multiline = true;
            this.outputbox.Name = "outputbox";
            this.outputbox.ReadOnly = true;
            this.outputbox.Size = new System.Drawing.Size(492, 312);
            this.outputbox.TabIndex = 2;
            // 
            // printReportToolStripMenuItem
            // 
            this.printReportToolStripMenuItem.Name = "printReportToolStripMenuItem";
            this.printReportToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.printReportToolStripMenuItem.Text = "Print Report";
            this.printReportToolStripMenuItem.Click += new System.EventHandler(this.printReportToolStripMenuItem_Click);
            // 
            // lastid
            // 
            this.lastid.BackColor = System.Drawing.Color.LawnGreen;
            this.lastid.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastid.Location = new System.Drawing.Point(12, 333);
            this.lastid.Name = "lastid";
            this.lastid.ReadOnly = true;
            this.lastid.Size = new System.Drawing.Size(492, 32);
            this.lastid.TabIndex = 3;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 698);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lastid);
            this.Controls.Add(this.outputbox);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDatabaseToolStripMenuItem;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.TextBox outputbox;
        private System.Windows.Forms.ToolStripMenuItem addSingleStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchForStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFullRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printReportToolStripMenuItem;
        private System.Windows.Forms.TextBox lastid;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

