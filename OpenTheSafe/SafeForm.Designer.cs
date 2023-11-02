namespace OpenTheSafe {
	partial class SafeForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SafeForm));
			codePart1 = new TextBox();
			codePart2 = new TextBox();
			codePart3 = new TextBox();
			exitButton = new Button();
			codePartsBox = new GroupBox();
			guessButton = new Button();
			maxGuessesLabel = new Label();
			currentGuessesLabel = new Label();
			guessStatusLabel = new Label();
			resetButton = new Button();
			cheatBox = new GroupBox();
			cheatCodeLabel = new Label();
			cheatButton = new Button();
			safePictureBox = new PictureBox();
			guessLog = new ListView();
			codePartsBox.SuspendLayout();
			cheatBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) safePictureBox).BeginInit();
			SuspendLayout();
			// 
			// codePart1
			// 
			codePart1.Location = new Point(6, 30);
			codePart1.Name = "codePart1";
			codePart1.Size = new Size(150, 31);
			codePart1.TabIndex = 3;
			codePart1.TextAlign = HorizontalAlignment.Center;
			codePart1.WordWrap = false;
			codePart1.KeyDown += codePart_KeyDown;
			codePart1.KeyPress += codePart_KeyPress;
			// 
			// codePart2
			// 
			codePart2.Location = new Point(268, 30);
			codePart2.Name = "codePart2";
			codePart2.Size = new Size(150, 31);
			codePart2.TabIndex = 4;
			codePart2.TextAlign = HorizontalAlignment.Center;
			codePart2.WordWrap = false;
			codePart2.KeyDown += codePart_KeyDown;
			codePart2.KeyPress += codePart_KeyPress;
			// 
			// codePart3
			// 
			codePart3.Location = new Point(519, 30);
			codePart3.Name = "codePart3";
			codePart3.Size = new Size(150, 31);
			codePart3.TabIndex = 5;
			codePart3.TextAlign = HorizontalAlignment.Center;
			codePart3.WordWrap = false;
			codePart3.KeyDown += codePart_KeyDown;
			codePart3.KeyPress += codePart_KeyPress;
			// 
			// exitButton
			// 
			exitButton.BackColor = SystemColors.ControlLight;
			exitButton.ForeColor = Color.Black;
			exitButton.Location = new Point(619, 432);
			exitButton.Name = "exitButton";
			exitButton.Size = new Size(112, 34);
			exitButton.TabIndex = 9;
			exitButton.Text = "Exit";
			exitButton.UseVisualStyleBackColor = false;
			exitButton.Click += exitButton_Click;
			// 
			// codePartsBox
			// 
			codePartsBox.Controls.Add(guessButton);
			codePartsBox.Controls.Add(maxGuessesLabel);
			codePartsBox.Controls.Add(currentGuessesLabel);
			codePartsBox.Controls.Add(guessStatusLabel);
			codePartsBox.Controls.Add(codePart1);
			codePartsBox.Controls.Add(codePart2);
			codePartsBox.Controls.Add(codePart3);
			codePartsBox.Location = new Point(56, 230);
			codePartsBox.Name = "codePartsBox";
			codePartsBox.Size = new Size(675, 147);
			codePartsBox.TabIndex = 4;
			codePartsBox.TabStop = false;
			// 
			// guessButton
			// 
			guessButton.Location = new Point(288, 107);
			guessButton.Name = "guessButton";
			guessButton.Size = new Size(112, 34);
			guessButton.TabIndex = 6;
			guessButton.Text = "Guess";
			guessButton.UseVisualStyleBackColor = true;
			guessButton.Click += guessButton_Click;
			// 
			// maxGuessesLabel
			// 
			maxGuessesLabel.AutoSize = true;
			maxGuessesLabel.Location = new Point(528, 73);
			maxGuessesLabel.Name = "maxGuessesLabel";
			maxGuessesLabel.Size = new Size(23, 25);
			maxGuessesLabel.TabIndex = 999;
			maxGuessesLabel.Text = "#";
			// 
			// currentGuessesLabel
			// 
			currentGuessesLabel.AutoSize = true;
			currentGuessesLabel.Location = new Point(6, 73);
			currentGuessesLabel.Name = "currentGuessesLabel";
			currentGuessesLabel.Size = new Size(23, 25);
			currentGuessesLabel.TabIndex = 999;
			currentGuessesLabel.Text = "#";
			// 
			// guessStatusLabel
			// 
			guessStatusLabel.AutoSize = true;
			guessStatusLabel.Location = new Point(226, 73);
			guessStatusLabel.Name = "guessStatusLabel";
			guessStatusLabel.Size = new Size(23, 25);
			guessStatusLabel.TabIndex = 999;
			guessStatusLabel.Text = "#";
			guessStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// resetButton
			// 
			resetButton.Location = new Point(56, 432);
			resetButton.Name = "resetButton";
			resetButton.Size = new Size(112, 34);
			resetButton.TabIndex = 7;
			resetButton.Text = "Reset";
			resetButton.UseVisualStyleBackColor = true;
			resetButton.Click += resetButton_Click;
			// 
			// cheatBox
			// 
			cheatBox.Controls.Add(cheatCodeLabel);
			cheatBox.Controls.Add(cheatButton);
			cheatBox.Location = new Point(56, 12);
			cheatBox.Name = "cheatBox";
			cheatBox.Size = new Size(205, 78);
			cheatBox.TabIndex = 6;
			cheatBox.TabStop = false;
			cheatBox.Text = "Cheats";
			// 
			// cheatCodeLabel
			// 
			cheatCodeLabel.AutoSize = true;
			cheatCodeLabel.Location = new Point(140, 34);
			cheatCodeLabel.Name = "cheatCodeLabel";
			cheatCodeLabel.Size = new Size(23, 25);
			cheatCodeLabel.TabIndex = 999;
			cheatCodeLabel.Text = "#";
			// 
			// cheatButton
			// 
			cheatButton.Location = new Point(6, 30);
			cheatButton.Name = "cheatButton";
			cheatButton.Size = new Size(112, 34);
			cheatButton.TabIndex = 8;
			cheatButton.Text = "Cheat";
			cheatButton.UseVisualStyleBackColor = true;
			cheatButton.Click += cheatButton_Click;
			// 
			// safePictureBox
			// 
			safePictureBox.Image = (Image) resources.GetObject("safePictureBox.Image");
			safePictureBox.Location = new Point(282, 43);
			safePictureBox.Name = "safePictureBox";
			safePictureBox.Size = new Size(231, 181);
			safePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			safePictureBox.TabIndex = 7;
			safePictureBox.TabStop = false;
			// 
			// guessLog
			// 
			guessLog.Alignment = ListViewAlignment.Left;
			guessLog.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			guessLog.Location = new Point(311, 400);
			guessLog.Name = "guessLog";
			guessLog.Scrollable = false;
			guessLog.Size = new Size(182, 94);
			guessLog.TabIndex = 999;
			guessLog.TabStop = false;
			guessLog.UseCompatibleStateImageBehavior = false;
			guessLog.View = View.List;
			// 
			// SafeForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 506);
			Controls.Add(guessLog);
			Controls.Add(safePictureBox);
			Controls.Add(cheatBox);
			Controls.Add(resetButton);
			Controls.Add(codePartsBox);
			Controls.Add(exitButton);
			Name = "SafeForm";
			Text = "SafeForm";
			codePartsBox.ResumeLayout(false);
			codePartsBox.PerformLayout();
			cheatBox.ResumeLayout(false);
			cheatBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize) safePictureBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TextBox codePart1;
		private TextBox codePart2;
		private TextBox codePart3;
		private Button exitButton;
		private GroupBox codePartsBox;
		private Button resetButton;
		private Label guessStatusLabel;
		private GroupBox cheatBox;
		private Label cheatCodeLabel;
		private Button cheatButton;
		private PictureBox safePictureBox;
		private ListView guessLog;
		private Label maxGuessesLabel;
		private Label currentGuessesLabel;
		private Button guessButton;
	}
}