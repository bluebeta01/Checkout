﻿namespace Checkout
{
    partial class NewDatabaseForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nobutton = new System.Windows.Forms.Button();
            this.yesbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 66);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 297);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Does this table appear correctly with the\r\nIDs on the left and the names on the r" +
    "ight?";
            // 
            // nobutton
            // 
            this.nobutton.Location = new System.Drawing.Point(12, 369);
            this.nobutton.Name = "nobutton";
            this.nobutton.Size = new System.Drawing.Size(106, 34);
            this.nobutton.TabIndex = 2;
            this.nobutton.Text = "NO";
            this.nobutton.UseVisualStyleBackColor = true;
            this.nobutton.Click += new System.EventHandler(this.nobutton_Click);
            // 
            // yesbutton
            // 
            this.yesbutton.Location = new System.Drawing.Point(256, 369);
            this.yesbutton.Name = "yesbutton";
            this.yesbutton.Size = new System.Drawing.Size(106, 34);
            this.yesbutton.TabIndex = 3;
            this.yesbutton.Text = "YES";
            this.yesbutton.UseVisualStyleBackColor = true;
            this.yesbutton.Click += new System.EventHandler(this.yesbutton_Click);
            // 
            // NewDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 415);
            this.ControlBox = false;
            this.Controls.Add(this.yesbutton);
            this.Controls.Add(this.nobutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewDatabaseForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Database";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NewDatabaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nobutton;
        private System.Windows.Forms.Button yesbutton;
    }
}