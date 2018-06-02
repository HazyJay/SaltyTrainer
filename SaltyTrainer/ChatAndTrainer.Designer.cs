namespace WindowsFormsApp1
{
    partial class ChatAndTrainer
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
            this.ChatBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChatEntry = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RAvgTier = new System.Windows.Forms.Label();
            this.RCurrTier = new System.Windows.Forms.Label();
            this.RLossesVsBlue = new System.Windows.Forms.Label();
            this.RWinsVsBlue = new System.Windows.Forms.Label();
            this.RedName = new System.Windows.Forms.Label();
            this.KnownLossesR = new System.Windows.Forms.Label();
            this.KnownWinsR = new System.Windows.Forms.Label();
            this.BAvgTier = new System.Windows.Forms.Label();
            this.BCurrTier = new System.Windows.Forms.Label();
            this.BLossesVsRed = new System.Windows.Forms.Label();
            this.BWinsVsRed = new System.Windows.Forms.Label();
            this.BlueName = new System.Windows.Forms.Label();
            this.KnownLossesB = new System.Windows.Forms.Label();
            this.KnownWinsB = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RedWL = new System.Windows.Forms.Label();
            this.BlueWL = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChatBox
            // 
            this.ChatBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChatBox.Location = new System.Drawing.Point(12, 29);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.ReadOnly = true;
            this.ChatBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.ChatBox.Size = new System.Drawing.Size(301, 414);
            this.ChatBox.TabIndex = 0;
            this.ChatBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Twitch Chat";
            // 
            // ChatEntry
            // 
            this.ChatEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChatEntry.Location = new System.Drawing.Point(12, 450);
            this.ChatEntry.Name = "ChatEntry";
            this.ChatEntry.Size = new System.Drawing.Size(216, 20);
            this.ChatEntry.TabIndex = 2;
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SendButton.Location = new System.Drawing.Point(238, 448);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.groupBox1.Controls.Add(this.RedWL);
            this.groupBox1.Controls.Add(this.RAvgTier);
            this.groupBox1.Controls.Add(this.RCurrTier);
            this.groupBox1.Controls.Add(this.RLossesVsBlue);
            this.groupBox1.Controls.Add(this.RWinsVsBlue);
            this.groupBox1.Controls.Add(this.RedName);
            this.groupBox1.Controls.Add(this.KnownLossesR);
            this.groupBox1.Controls.Add(this.KnownWinsR);
            this.groupBox1.Location = new System.Drawing.Point(332, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Red Fighter";
            // 
            // RAvgTier
            // 
            this.RAvgTier.AutoSize = true;
            this.RAvgTier.Location = new System.Drawing.Point(6, 42);
            this.RAvgTier.Name = "RAvgTier";
            this.RAvgTier.Size = new System.Drawing.Size(53, 13);
            this.RAvgTier.TabIndex = 6;
            this.RAvgTier.Text = "Avg Tier: ";
            // 
            // RCurrTier
            // 
            this.RCurrTier.AutoSize = true;
            this.RCurrTier.Location = new System.Drawing.Point(6, 29);
            this.RCurrTier.Name = "RCurrTier";
            this.RCurrTier.Size = new System.Drawing.Size(31, 13);
            this.RCurrTier.TabIndex = 5;
            this.RCurrTier.Text = "Tier: ";
            // 
            // RLossesVsBlue
            // 
            this.RLossesVsBlue.AutoSize = true;
            this.RLossesVsBlue.Location = new System.Drawing.Point(6, 94);
            this.RLossesVsBlue.Name = "RLossesVsBlue";
            this.RLossesVsBlue.Size = new System.Drawing.Size(79, 13);
            this.RLossesVsBlue.TabIndex = 4;
            this.RLossesVsBlue.Text = "Losses v Blue: ";
            // 
            // RWinsVsBlue
            // 
            this.RWinsVsBlue.AutoSize = true;
            this.RWinsVsBlue.Location = new System.Drawing.Point(6, 81);
            this.RWinsVsBlue.Name = "RWinsVsBlue";
            this.RWinsVsBlue.Size = new System.Drawing.Size(70, 13);
            this.RWinsVsBlue.TabIndex = 3;
            this.RWinsVsBlue.Text = "Wins v Blue: ";
            // 
            // RedName
            // 
            this.RedName.AutoSize = true;
            this.RedName.Location = new System.Drawing.Point(6, 16);
            this.RedName.Name = "RedName";
            this.RedName.Size = new System.Drawing.Size(41, 13);
            this.RedName.TabIndex = 2;
            this.RedName.Text = "Name: ";
            // 
            // KnownLossesR
            // 
            this.KnownLossesR.AutoSize = true;
            this.KnownLossesR.Location = new System.Drawing.Point(6, 68);
            this.KnownLossesR.Name = "KnownLossesR";
            this.KnownLossesR.Size = new System.Drawing.Size(46, 13);
            this.KnownLossesR.TabIndex = 1;
            this.KnownLossesR.Text = "Losses: ";
            // 
            // KnownWinsR
            // 
            this.KnownWinsR.AutoSize = true;
            this.KnownWinsR.Location = new System.Drawing.Point(6, 55);
            this.KnownWinsR.Name = "KnownWinsR";
            this.KnownWinsR.Size = new System.Drawing.Size(37, 13);
            this.KnownWinsR.TabIndex = 0;
            this.KnownWinsR.Text = "Wins: ";
            // 
            // BAvgTier
            // 
            this.BAvgTier.AutoSize = true;
            this.BAvgTier.Location = new System.Drawing.Point(6, 42);
            this.BAvgTier.Name = "BAvgTier";
            this.BAvgTier.Size = new System.Drawing.Size(53, 13);
            this.BAvgTier.TabIndex = 6;
            this.BAvgTier.Text = "Avg Tier: ";
            // 
            // BCurrTier
            // 
            this.BCurrTier.AutoSize = true;
            this.BCurrTier.Location = new System.Drawing.Point(6, 29);
            this.BCurrTier.Name = "BCurrTier";
            this.BCurrTier.Size = new System.Drawing.Size(31, 13);
            this.BCurrTier.TabIndex = 5;
            this.BCurrTier.Text = "Tier: ";
            // 
            // BLossesVsRed
            // 
            this.BLossesVsRed.AutoSize = true;
            this.BLossesVsRed.Location = new System.Drawing.Point(6, 94);
            this.BLossesVsRed.Name = "BLossesVsRed";
            this.BLossesVsRed.Size = new System.Drawing.Size(78, 13);
            this.BLossesVsRed.TabIndex = 4;
            this.BLossesVsRed.Text = "Losses v Red: ";
            // 
            // BWinsVsRed
            // 
            this.BWinsVsRed.AutoSize = true;
            this.BWinsVsRed.Location = new System.Drawing.Point(6, 81);
            this.BWinsVsRed.Name = "BWinsVsRed";
            this.BWinsVsRed.Size = new System.Drawing.Size(69, 13);
            this.BWinsVsRed.TabIndex = 3;
            this.BWinsVsRed.Text = "Wins v Red: ";
            // 
            // BlueName
            // 
            this.BlueName.AutoSize = true;
            this.BlueName.Location = new System.Drawing.Point(6, 16);
            this.BlueName.Name = "BlueName";
            this.BlueName.Size = new System.Drawing.Size(41, 13);
            this.BlueName.TabIndex = 2;
            this.BlueName.Text = "Name: ";
            // 
            // KnownLossesB
            // 
            this.KnownLossesB.AutoSize = true;
            this.KnownLossesB.Location = new System.Drawing.Point(6, 68);
            this.KnownLossesB.Name = "KnownLossesB";
            this.KnownLossesB.Size = new System.Drawing.Size(46, 13);
            this.KnownLossesB.TabIndex = 1;
            this.KnownLossesB.Text = "Losses: ";
            // 
            // KnownWinsB
            // 
            this.KnownWinsB.AutoSize = true;
            this.KnownWinsB.Location = new System.Drawing.Point(6, 55);
            this.KnownWinsB.Name = "KnownWinsB";
            this.KnownWinsB.Size = new System.Drawing.Size(37, 13);
            this.KnownWinsB.TabIndex = 0;
            this.KnownWinsB.Text = "Wins: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.BlueWL);
            this.groupBox2.Controls.Add(this.BAvgTier);
            this.groupBox2.Controls.Add(this.BCurrTier);
            this.groupBox2.Controls.Add(this.BLossesVsRed);
            this.groupBox2.Controls.Add(this.BWinsVsRed);
            this.groupBox2.Controls.Add(this.BlueName);
            this.groupBox2.Controls.Add(this.KnownLossesB);
            this.groupBox2.Controls.Add(this.KnownWinsB);
            this.groupBox2.Location = new System.Drawing.Point(524, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 133);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Blue Fighter";
            // 
            // RedWL
            // 
            this.RedWL.AutoSize = true;
            this.RedWL.Location = new System.Drawing.Point(6, 107);
            this.RedWL.Name = "RedWL";
            this.RedWL.Size = new System.Drawing.Size(66, 13);
            this.RedWL.TabIndex = 7;
            this.RedWL.Text = "W/L Streak:";
            // 
            // BlueWL
            // 
            this.BlueWL.AutoSize = true;
            this.BlueWL.Location = new System.Drawing.Point(6, 107);
            this.BlueWL.Name = "BlueWL";
            this.BlueWL.Size = new System.Drawing.Size(66, 13);
            this.BlueWL.TabIndex = 8;
            this.BlueWL.Text = "W/L Streak:";
            // 
            // ChatAndTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ChatEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChatBox);
            this.Name = "ChatAndTrainer";
            this.Text = "SBTrainer V1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatAndTrainer_FormClosing);
            this.Load += new System.EventHandler(this.ChatAndTrainer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ChatBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChatEntry;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label RAvgTier;
        private System.Windows.Forms.Label RCurrTier;
        private System.Windows.Forms.Label RLossesVsBlue;
        private System.Windows.Forms.Label RWinsVsBlue;
        private System.Windows.Forms.Label RedName;
        private System.Windows.Forms.Label KnownLossesR;
        private System.Windows.Forms.Label KnownWinsR;
        private System.Windows.Forms.Label BAvgTier;
        private System.Windows.Forms.Label BCurrTier;
        private System.Windows.Forms.Label BLossesVsRed;
        private System.Windows.Forms.Label BWinsVsRed;
        private System.Windows.Forms.Label BlueName;
        private System.Windows.Forms.Label KnownLossesB;
        private System.Windows.Forms.Label KnownWinsB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label RedWL;
        private System.Windows.Forms.Label BlueWL;
    }
}