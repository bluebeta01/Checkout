namespace Checkout
{
    partial class Search
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
            this.filenamebox = new System.Windows.Forms.ComboBox();
            this.lable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filenamebox
            // 
            this.filenamebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filenamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenamebox.FormattingEnabled = true;
            this.filenamebox.Location = new System.Drawing.Point(83, 12);
            this.filenamebox.Name = "filenamebox";
            this.filenamebox.Size = new System.Drawing.Size(294, 34);
            this.filenamebox.TabIndex = 0;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(12, 15);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(65, 27);
            this.lable.TabIndex = 1;
            this.lable.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(83, 87);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(294, 32);
            this.id.TabIndex = 3;
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(12, 146);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(123, 39);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // accept
            // 
            this.accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept.Location = new System.Drawing.Point(254, 146);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(123, 39);
            this.accept.TabIndex = 5;
            this.accept.Text = "Search";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 197);
            this.ControlBox = false;
            this.Controls.Add(this.accept);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.filenamebox);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox filenamebox;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button accept;
    }
}