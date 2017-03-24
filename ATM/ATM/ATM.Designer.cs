namespace ATM
{
	partial class ATM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM));
            this.cashLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.np0 = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.correctionBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.np9 = new System.Windows.Forms.Button();
            this.np6 = new System.Windows.Forms.Button();
            this.np8 = new System.Windows.Forms.Button();
            this.np5 = new System.Windows.Forms.Button();
            this.np7 = new System.Windows.Forms.Button();
            this.np4 = new System.Windows.Forms.Button();
            this.np3 = new System.Windows.Forms.Button();
            this.np2 = new System.Windows.Forms.Button();
            this.np1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.BackColor = System.Drawing.Color.Transparent;
            this.cashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLabel.Location = new System.Drawing.Point(139, 86);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(0, 42);
            this.cashLabel.TabIndex = 24;
            this.cashLabel.Visible = false;
            this.cashLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.questionLabel);
            this.panel1.Controls.Add(this.yLabel);
            this.panel1.Controls.Add(this.nLabel);
            this.panel1.Controls.Add(this.amountLabel);
            this.panel1.Controls.Add(this.amLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cashLabel);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(150, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 300);
            this.panel1.TabIndex = 23;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yLabel.ForeColor = System.Drawing.Color.White;
            this.yLabel.Location = new System.Drawing.Point(3, 253);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(93, 32);
            this.yLabel.TabIndex = 27;
            this.yLabel.Text = "<- Yes";
            this.yLabel.Visible = false;
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nLabel.ForeColor = System.Drawing.Color.White;
            this.nLabel.Location = new System.Drawing.Point(320, 253);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(80, 32);
            this.nLabel.TabIndex = 27;
            this.nLabel.Text = "No ->";
            this.nLabel.Visible = false;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.ForeColor = System.Drawing.Color.White;
            this.amountLabel.Location = new System.Drawing.Point(26, 34);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(371, 25);
            this.amountLabel.TabIndex = 26;
            this.amountLabel.Text = "Enter amount and click enter";
            this.amountLabel.Visible = false;
            // 
            // amLabel
            // 
            this.amLabel.AutoSize = true;
            this.amLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amLabel.ForeColor = System.Drawing.Color.White;
            this.amLabel.Location = new System.Drawing.Point(69, 34);
            this.amLabel.Name = "amLabel";
            this.amLabel.Size = new System.Drawing.Size(275, 32);
            this.amLabel.TabIndex = 25;
            this.amLabel.Text = "Available money:";
            this.amLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 40);
            this.label1.TabIndex = 24;
            this.label1.Text = "Account number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(44, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 40);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // np0
            // 
            this.np0.BackColor = System.Drawing.Color.Transparent;
            this.np0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.np0.ForeColor = System.Drawing.Color.Transparent;
            this.np0.Location = new System.Drawing.Point(75, 124);
            this.np0.Margin = new System.Windows.Forms.Padding(2);
            this.np0.Name = "np0";
            this.np0.Size = new System.Drawing.Size(62, 32);
            this.np0.TabIndex = 22;
            this.np0.UseVisualStyleBackColor = false;
            this.np0.Click += new System.EventHandler(this.np0_Click_1);
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.Transparent;
            this.acceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acceptBtn.ForeColor = System.Drawing.Color.Transparent;
            this.acceptBtn.Location = new System.Drawing.Point(238, 84);
            this.acceptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(71, 32);
            this.acceptBtn.TabIndex = 21;
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // correctionBtn
            // 
            this.correctionBtn.BackColor = System.Drawing.Color.Transparent;
            this.correctionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.correctionBtn.ForeColor = System.Drawing.Color.Transparent;
            this.correctionBtn.Location = new System.Drawing.Point(238, 42);
            this.correctionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.correctionBtn.Name = "correctionBtn";
            this.correctionBtn.Size = new System.Drawing.Size(71, 32);
            this.correctionBtn.TabIndex = 20;
            this.correctionBtn.UseVisualStyleBackColor = false;
            this.correctionBtn.Click += new System.EventHandler(this.correctionBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.ForeColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Location = new System.Drawing.Point(238, 3);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(71, 32);
            this.cancelBtn.TabIndex = 19;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // np9
            // 
            this.np9.BackColor = System.Drawing.Color.Transparent;
            this.np9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.np9.ForeColor = System.Drawing.Color.Transparent;
            this.np9.Location = new System.Drawing.Point(147, 83);
            this.np9.Margin = new System.Windows.Forms.Padding(2);
            this.np9.Name = "np9";
            this.np9.Size = new System.Drawing.Size(62, 32);
            this.np9.TabIndex = 17;
            this.np9.UseVisualStyleBackColor = false;
            this.np9.Click += new System.EventHandler(this.np9_Click_1);
            // 
            // np6
            // 
            this.np6.BackColor = System.Drawing.Color.Transparent;
            this.np6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.np6.ForeColor = System.Drawing.Color.Transparent;
            this.np6.Location = new System.Drawing.Point(147, 43);
            this.np6.Margin = new System.Windows.Forms.Padding(2);
            this.np6.Name = "np6";
            this.np6.Size = new System.Drawing.Size(62, 32);
            this.np6.TabIndex = 16;
            this.np6.UseVisualStyleBackColor = false;
            this.np6.Click += new System.EventHandler(this.np6_Click);
            // 
            // np8
            // 
            this.np8.BackColor = System.Drawing.Color.Transparent;
            this.np8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.np8.ForeColor = System.Drawing.Color.Transparent;
            this.np8.Location = new System.Drawing.Point(75, 83);
            this.np8.Margin = new System.Windows.Forms.Padding(2);
            this.np8.Name = "np8";
            this.np8.Size = new System.Drawing.Size(62, 32);
            this.np8.TabIndex = 15;
            this.np8.UseVisualStyleBackColor = false;
            this.np8.Click += new System.EventHandler(this.np8_Click_1);
            // 
            // np5
            // 
            this.np5.BackColor = System.Drawing.Color.Transparent;
            this.np5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.np5.ForeColor = System.Drawing.Color.Transparent;
            this.np5.Location = new System.Drawing.Point(75, 43);
            this.np5.Margin = new System.Windows.Forms.Padding(2);
            this.np5.Name = "np5";
            this.np5.Size = new System.Drawing.Size(62, 32);
            this.np5.TabIndex = 14;
            this.np5.UseVisualStyleBackColor = false;
            this.np5.Click += new System.EventHandler(this.np5_Click);
            // 
            // np7
            // 
            this.np7.BackColor = System.Drawing.Color.Transparent;
            this.np7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.np7.ForeColor = System.Drawing.Color.Transparent;
            this.np7.Location = new System.Drawing.Point(2, 84);
            this.np7.Margin = new System.Windows.Forms.Padding(2);
            this.np7.Name = "np7";
            this.np7.Size = new System.Drawing.Size(62, 32);
            this.np7.TabIndex = 13;
            this.np7.UseVisualStyleBackColor = false;
            this.np7.Click += new System.EventHandler(this.np7_Click);
            // 
            // np4
            // 
            this.np4.BackColor = System.Drawing.Color.Transparent;
            this.np4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.np4.ForeColor = System.Drawing.Color.Transparent;
            this.np4.Location = new System.Drawing.Point(2, 42);
            this.np4.Margin = new System.Windows.Forms.Padding(2);
            this.np4.Name = "np4";
            this.np4.Size = new System.Drawing.Size(62, 32);
            this.np4.TabIndex = 12;
            this.np4.UseVisualStyleBackColor = false;
            this.np4.Click += new System.EventHandler(this.np4_Click);
            // 
            // np3
            // 
            this.np3.BackColor = System.Drawing.Color.Transparent;
            this.np3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.np3.ForeColor = System.Drawing.Color.Transparent;
            this.np3.Location = new System.Drawing.Point(148, 2);
            this.np3.Margin = new System.Windows.Forms.Padding(2);
            this.np3.Name = "np3";
            this.np3.Size = new System.Drawing.Size(62, 32);
            this.np3.TabIndex = 11;
            this.np3.UseVisualStyleBackColor = false;
            this.np3.Click += new System.EventHandler(this.np3_Click);
            // 
            // np2
            // 
            this.np2.BackColor = System.Drawing.Color.Transparent;
            this.np2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.np2.ForeColor = System.Drawing.Color.Transparent;
            this.np2.Location = new System.Drawing.Point(75, 2);
            this.np2.Margin = new System.Windows.Forms.Padding(2);
            this.np2.Name = "np2";
            this.np2.Size = new System.Drawing.Size(62, 32);
            this.np2.TabIndex = 10;
            this.np2.UseVisualStyleBackColor = false;
            this.np2.Click += new System.EventHandler(this.np2_Click);
            // 
            // np1
            // 
            this.np1.BackColor = System.Drawing.Color.Transparent;
            this.np1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.np1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.np1.ForeColor = System.Drawing.Color.Transparent;
            this.np1.Location = new System.Drawing.Point(2, 2);
            this.np1.Margin = new System.Windows.Forms.Padding(2);
            this.np1.Name = "np1";
            this.np1.Size = new System.Drawing.Size(62, 32);
            this.np1.TabIndex = 9;
            this.np1.UseVisualStyleBackColor = false;
            this.np1.Click += new System.EventHandler(this.np1_Click);
            // 
            // btn6
            // 
            this.btn6.Image = global::ATM.Properties.Resources.leftArrow;
            this.btn6.Location = new System.Drawing.Point(555, 152);
            this.btn6.Margin = new System.Windows.Forms.Padding(2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 60);
            this.btn6.TabIndex = 7;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn4
            // 
            this.btn4.Image = global::ATM.Properties.Resources.leftArrow;
            this.btn4.Location = new System.Drawing.Point(555, 216);
            this.btn4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 60);
            this.btn4.TabIndex = 6;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn2
            // 
            this.btn2.Image = global::ATM.Properties.Resources.leftArrow;
            this.btn2.Location = new System.Drawing.Point(555, 280);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 60);
            this.btn2.TabIndex = 5;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn5
            // 
            this.btn5.Image = global::ATM.Properties.Resources.rightArrow;
            this.btn5.Location = new System.Drawing.Point(85, 152);
            this.btn5.Margin = new System.Windows.Forms.Padding(2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 60);
            this.btn5.TabIndex = 3;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn3
            // 
            this.btn3.Image = global::ATM.Properties.Resources.rightArrow;
            this.btn3.Location = new System.Drawing.Point(85, 216);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 60);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn1
            // 
            this.btn1.Image = global::ATM.Properties.Resources.rightArrow;
            this.btn1.Location = new System.Drawing.Point(85, 280);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 60);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.acceptBtn);
            this.panel2.Controls.Add(this.correctionBtn);
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.np3);
            this.panel2.Controls.Add(this.np2);
            this.panel2.Controls.Add(this.np1);
            this.panel2.Controls.Add(this.np0);
            this.panel2.Controls.Add(this.np6);
            this.panel2.Controls.Add(this.np5);
            this.panel2.Controls.Add(this.np8);
            this.panel2.Controls.Add(this.np9);
            this.panel2.Controls.Add(this.np4);
            this.panel2.Controls.Add(this.np7);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(194, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 158);
            this.panel2.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 64);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(42, 180);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(314, 25);
            this.questionLabel.TabIndex = 27;
            this.questionLabel.Text = "Do you want to continue?";
            this.questionLabel.Visible = false;
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ATM";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.ATM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button np1;
		private System.Windows.Forms.Button np2;
		private System.Windows.Forms.Button np3;
		private System.Windows.Forms.Button np4;
		private System.Windows.Forms.Button np7;
		private System.Windows.Forms.Button np5;
		private System.Windows.Forms.Button np8;
		private System.Windows.Forms.Button np6;
		private System.Windows.Forms.Button np9;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Button correctionBtn;
		private System.Windows.Forms.Button acceptBtn;
		private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button np0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label amLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label questionLabel;
	}
}

