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
            this.RedWL = new System.Windows.Forms.Label();
            this.RAvgTier = new System.Windows.Forms.Label();
            this.RCurrTier = new System.Windows.Forms.Label();
            this.RedName = new System.Windows.Forms.Label();
            this.KnownLossesR = new System.Windows.Forms.Label();
            this.KnownWinsR = new System.Windows.Forms.Label();
            this.BAvgTier = new System.Windows.Forms.Label();
            this.BCurrTier = new System.Windows.Forms.Label();
            this.BlueName = new System.Windows.Forms.Label();
            this.KnownLossesB = new System.Windows.Forms.Label();
            this.KnownWinsB = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BlueWL = new System.Windows.Forms.Label();
            this.BlueCrowd = new System.Windows.Forms.ProgressBar();
            this.RedCrowd = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.PredVal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.OddsBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PayoutBox = new System.Windows.Forms.TextBox();
            this.RedBet = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.ChatBox.Size = new System.Drawing.Size(281, 396);
            this.ChatBox.TabIndex = 0;
            this.ChatBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Twitch Chat";
            // 
            // ChatEntry
            // 
            this.ChatEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChatEntry.Location = new System.Drawing.Point(12, 432);
            this.ChatEntry.Name = "ChatEntry";
            this.ChatEntry.Size = new System.Drawing.Size(200, 20);
            this.ChatEntry.TabIndex = 2;
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SendButton.Location = new System.Drawing.Point(218, 430);
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
            this.groupBox1.Controls.Add(this.RedName);
            this.groupBox1.Controls.Add(this.KnownLossesR);
            this.groupBox1.Controls.Add(this.KnownWinsR);
            this.groupBox1.Location = new System.Drawing.Point(300, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 102);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Red Fighter";
            // 
            // RedWL
            // 
            this.RedWL.AutoSize = true;
            this.RedWL.Location = new System.Drawing.Point(6, 81);
            this.RedWL.Name = "RedWL";
            this.RedWL.Size = new System.Drawing.Size(66, 13);
            this.RedWL.TabIndex = 7;
            this.RedWL.Text = "W/L Streak:";
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
            this.groupBox2.Controls.Add(this.BlueName);
            this.groupBox2.Controls.Add(this.KnownLossesB);
            this.groupBox2.Controls.Add(this.KnownWinsB);
            this.groupBox2.Location = new System.Drawing.Point(468, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 102);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Blue Fighter";
            // 
            // BlueWL
            // 
            this.BlueWL.AutoSize = true;
            this.BlueWL.Location = new System.Drawing.Point(6, 81);
            this.BlueWL.Name = "BlueWL";
            this.BlueWL.Size = new System.Drawing.Size(66, 13);
            this.BlueWL.TabIndex = 8;
            this.BlueWL.Text = "W/L Streak:";
            // 
            // BlueCrowd
            // 
            this.BlueCrowd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BlueCrowd.Location = new System.Drawing.Point(171, 29);
            this.BlueCrowd.Name = "BlueCrowd";
            this.BlueCrowd.Size = new System.Drawing.Size(154, 23);
            this.BlueCrowd.TabIndex = 9;
            // 
            // RedCrowd
            // 
            this.RedCrowd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RedCrowd.Location = new System.Drawing.Point(6, 29);
            this.RedCrowd.Name = "RedCrowd";
            this.RedCrowd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RedCrowd.RightToLeftLayout = true;
            this.RedCrowd.Size = new System.Drawing.Size(159, 23);
            this.RedCrowd.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Crowd Confidence";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PredVal
            // 
            this.PredVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PredVal.Location = new System.Drawing.Point(405, 124);
            this.PredVal.Name = "PredVal";
            this.PredVal.Size = new System.Drawing.Size(57, 20);
            this.PredVal.TabIndex = 16;
            this.PredVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Algorithm Prediction";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Expected Value";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(405, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(520, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(57, 20);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Bet Value";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(467, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 23;
            this.button1.Text = "Calc EV";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(555, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 24;
            this.button2.Text = "Calc Bet";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Odds (Red:Blue)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OddsBox
            // 
            this.OddsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OddsBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OddsBox.Location = new System.Drawing.Point(108, 58);
            this.OddsBox.Name = "OddsBox";
            this.OddsBox.ReadOnly = true;
            this.OddsBox.Size = new System.Drawing.Size(57, 20);
            this.OddsBox.TabIndex = 25;
            this.OddsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Payout";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PayoutBox
            // 
            this.PayoutBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PayoutBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PayoutBox.Location = new System.Drawing.Point(216, 58);
            this.PayoutBox.Name = "PayoutBox";
            this.PayoutBox.ReadOnly = true;
            this.PayoutBox.Size = new System.Drawing.Size(109, 20);
            this.PayoutBox.TabIndex = 27;
            this.PayoutBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RedBet
            // 
            this.RedBet.AutoSize = true;
            this.RedBet.Location = new System.Drawing.Point(2, 3);
            this.RedBet.Name = "RedBet";
            this.RedBet.Size = new System.Drawing.Size(14, 13);
            this.RedBet.TabIndex = 29;
            this.RedBet.TabStop = true;
            this.RedBet.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.RedBet);
            this.panel1.Location = new System.Drawing.Point(588, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 20);
            this.panel1.TabIndex = 31;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.BlueCrowd);
            this.groupBox3.Controls.Add(this.RedCrowd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.PayoutBox);
            this.groupBox3.Controls.Add(this.OddsBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(300, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 95);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(163, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(130, 17);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "Stat Collection Enable";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(82, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 22);
            this.button3.TabIndex = 35;
            this.button3.Text = "Database";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ChatAndTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 459);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PredVal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ChatEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.checkBox1);
            this.Name = "ChatAndTrainer";
            this.Text = "SBTrainer V1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatAndTrainer_FormClosing);
            this.Load += new System.EventHandler(this.ChatAndTrainer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label RedName;
        private System.Windows.Forms.Label KnownLossesR;
        private System.Windows.Forms.Label KnownWinsR;
        private System.Windows.Forms.Label BAvgTier;
        private System.Windows.Forms.Label BCurrTier;
        private System.Windows.Forms.Label BlueName;
        private System.Windows.Forms.Label KnownLossesB;
        private System.Windows.Forms.Label KnownWinsB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label RedWL;
        private System.Windows.Forms.Label BlueWL;
        private System.Windows.Forms.ProgressBar BlueCrowd;
        internal System.Windows.Forms.ProgressBar RedCrowd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PredVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OddsBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PayoutBox;
        private System.Windows.Forms.RadioButton RedBet;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
    }
}