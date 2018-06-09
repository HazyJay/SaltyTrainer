namespace WindowsFormsApp1
{
    partial class DbControl
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
            this.FilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OvwConfirm = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(63, 10);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(251, 20);
            this.FilePath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filepath";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Overwrite DB from file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Append to DB from file";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OvwConfirm
            // 
            this.OvwConfirm.AutoSize = true;
            this.OvwConfirm.Location = new System.Drawing.Point(27, 70);
            this.OvwConfirm.Name = "OvwConfirm";
            this.OvwConfirm.Size = new System.Drawing.Size(15, 14);
            this.OvwConfirm.TabIndex = 4;
            this.OvwConfirm.UseVisualStyleBackColor = true;
            // 
            // DbControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 103);
            this.Controls.Add(this.OvwConfirm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilePath);
            this.Name = "DbControl";
            this.Text = "DbControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox OvwConfirm;
    }
}