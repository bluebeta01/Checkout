namespace Checkout
{
    partial class PrintForm
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
            this.accept = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.lable = new System.Windows.Forms.Label();
            this.filenamebox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // accept
            // 
            this.accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept.Location = new System.Drawing.Point(256, 72);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(123, 39);
            this.accept.TabIndex = 12;
            this.accept.Text = "Print";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(10, 71);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(123, 39);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(14, 15);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(65, 27);
            this.lable.TabIndex = 10;
            this.lable.Text = "Date:";
            // 
            // filenamebox
            // 
            this.filenamebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filenamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenamebox.FormattingEnabled = true;
            this.filenamebox.Location = new System.Drawing.Point(85, 12);
            this.filenamebox.Name = "filenamebox";
            this.filenamebox.Size = new System.Drawing.Size(294, 34);
            this.filenamebox.TabIndex = 9;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 130);
            this.ControlBox = false;
            this.Controls.Add(this.accept);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.filenamebox);
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Record";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PrintForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.ComboBox filenamebox;
    }
}