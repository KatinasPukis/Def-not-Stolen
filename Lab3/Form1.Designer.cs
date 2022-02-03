namespace Lab3
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
            this.buttonPannel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.yellowsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.neighborsComboBox = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.candidateButton = new System.Windows.Forms.Button();
            this.bluesButton = new System.Windows.Forms.Button();
            this.redsButton = new System.Windows.Forms.Button();
            this.closestNiggers = new System.Windows.Forms.RichTextBox();
            this.buttonPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPannel
            // 
            this.buttonPannel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonPannel.Controls.Add(this.closestNiggers);
            this.buttonPannel.Controls.Add(this.label8);
            this.buttonPannel.Controls.Add(this.label9);
            this.buttonPannel.Controls.Add(this.label6);
            this.buttonPannel.Controls.Add(this.label7);
            this.buttonPannel.Controls.Add(this.label4);
            this.buttonPannel.Controls.Add(this.label5);
            this.buttonPannel.Controls.Add(this.label3);
            this.buttonPannel.Controls.Add(this.label2);
            this.buttonPannel.Controls.Add(this.button3);
            this.buttonPannel.Controls.Add(this.yellowsButton);
            this.buttonPannel.Controls.Add(this.label1);
            this.buttonPannel.Controls.Add(this.button1);
            this.buttonPannel.Controls.Add(this.neighborsComboBox);
            this.buttonPannel.Controls.Add(this.calculateButton);
            this.buttonPannel.Controls.Add(this.clearButton);
            this.buttonPannel.Controls.Add(this.candidateButton);
            this.buttonPannel.Controls.Add(this.bluesButton);
            this.buttonPannel.Controls.Add(this.redsButton);
            this.buttonPannel.Location = new System.Drawing.Point(9, 9);
            this.buttonPannel.Name = "buttonPannel";
            this.buttonPannel.Size = new System.Drawing.Size(190, 669);
            this.buttonPannel.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 504);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Melyna:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Raudona:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Geltona:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Zalia:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(14, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "Zalia";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // yellowsButton
            // 
            this.yellowsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yellowsButton.Location = new System.Drawing.Point(14, 59);
            this.yellowsButton.Name = "yellowsButton";
            this.yellowsButton.Size = new System.Drawing.Size(159, 35);
            this.yellowsButton.TabIndex = 11;
            this.yellowsButton.Text = "Geltona";
            this.yellowsButton.UseVisualStyleBackColor = false;
            this.yellowsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Neibourghs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // neighborsComboBox
            // 
            this.neighborsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.neighborsComboBox.FormattingEnabled = true;
            this.neighborsComboBox.Items.AddRange(new object[] {
            "5",
            "9",
            "15"});
            this.neighborsComboBox.Location = new System.Drawing.Point(14, 248);
            this.neighborsComboBox.Name = "neighborsComboBox";
            this.neighborsComboBox.Size = new System.Drawing.Size(159, 33);
            this.neighborsComboBox.TabIndex = 8;
            this.neighborsComboBox.Text = "5";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(17, 327);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(159, 35);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(14, 381);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(159, 35);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // candidateButton
            // 
            this.candidateButton.Location = new System.Drawing.Point(14, 182);
            this.candidateButton.Name = "candidateButton";
            this.candidateButton.Size = new System.Drawing.Size(159, 35);
            this.candidateButton.TabIndex = 2;
            this.candidateButton.Text = "Candidate";
            this.candidateButton.UseVisualStyleBackColor = true;
            this.candidateButton.Click += new System.EventHandler(this.candidateButton_Click);
            // 
            // bluesButton
            // 
            this.bluesButton.BackColor = System.Drawing.Color.Aqua;
            this.bluesButton.Location = new System.Drawing.Point(14, 141);
            this.bluesButton.Name = "bluesButton";
            this.bluesButton.Size = new System.Drawing.Size(159, 35);
            this.bluesButton.TabIndex = 1;
            this.bluesButton.Text = "Melyna";
            this.bluesButton.UseVisualStyleBackColor = false;
            this.bluesButton.Click += new System.EventHandler(this.bluesButton_Click);
            // 
            // redsButton
            // 
            this.redsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.redsButton.Location = new System.Drawing.Point(14, 100);
            this.redsButton.Name = "redsButton";
            this.redsButton.Size = new System.Drawing.Size(159, 35);
            this.redsButton.TabIndex = 0;
            this.redsButton.Text = "Raudona";
            this.redsButton.UseVisualStyleBackColor = false;
            this.redsButton.Click += new System.EventHandler(this.redsButton_Click);
            // 
            // closestNiggers
            // 
            this.closestNiggers.Location = new System.Drawing.Point(17, 539);
            this.closestNiggers.Name = "closestNiggers";
            this.closestNiggers.Size = new System.Drawing.Size(159, 161);
            this.closestNiggers.TabIndex = 21;
            this.closestNiggers.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 721);
            this.Controls.Add(this.buttonPannel);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MaximumSize = new System.Drawing.Size(1020, 760);
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flying Points";
            this.buttonPannel.ResumeLayout(false);
            this.buttonPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonPannel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button bluesButton;
        private System.Windows.Forms.Button redsButton;
        private System.Windows.Forms.Button candidateButton;
        private System.Windows.Forms.ComboBox neighborsComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button yellowsButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox closestNiggers;
    }
}

