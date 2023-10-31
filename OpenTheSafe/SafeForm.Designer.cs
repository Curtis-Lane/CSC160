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
			codePart1 = new TextBox();
			codePart2 = new TextBox();
			codePart3 = new TextBox();
			exitButton = new Button();
			codePartsBox = new GroupBox();
			guessStatusLabel = new Label();
			resetButton = new Button();
			cheatBox = new GroupBox();
			cheatCodeLabel = new Label();
			cheatButton = new Button();
			codePartsBox.SuspendLayout();
			cheatBox.SuspendLayout();
			SuspendLayout();
			// 
			// codePart1
			// 
			codePart1.Location = new Point(6, 30);
			codePart1.Name = "codePart1";
			codePart1.Size = new Size(150, 31);
			codePart1.TabIndex = 0;
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
			codePart2.TabIndex = 1;
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
			codePart3.TabIndex = 2;
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
			exitButton.TabIndex = 3;
			exitButton.Text = "Exit";
			exitButton.UseVisualStyleBackColor = false;
			exitButton.Click += exitButton_Click;
			// 
			// codePartsBox
			// 
			codePartsBox.Controls.Add(guessStatusLabel);
			codePartsBox.Controls.Add(codePart1);
			codePartsBox.Controls.Add(codePart2);
			codePartsBox.Controls.Add(codePart3);
			codePartsBox.Location = new Point(56, 283);
			codePartsBox.Name = "codePartsBox";
			codePartsBox.Size = new Size(675, 111);
			codePartsBox.TabIndex = 4;
			codePartsBox.TabStop = false;
			// 
			// guessStatusLabel
			// 
			guessStatusLabel.AutoSize = true;
			guessStatusLabel.Location = new Point(246, 73);
			guessStatusLabel.Name = "guessStatusLabel";
			guessStatusLabel.Size = new Size(49, 25);
			guessStatusLabel.TabIndex = 3;
			guessStatusLabel.Text = "TEST";
			guessStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// resetButton
			// 
			resetButton.Location = new Point(56, 432);
			resetButton.Name = "resetButton";
			resetButton.Size = new Size(112, 34);
			resetButton.TabIndex = 5;
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
			cheatBox.Size = new Size(236, 78);
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
			cheatCodeLabel.TabIndex = 1;
			cheatCodeLabel.Text = "#";
			// 
			// cheatButton
			// 
			cheatButton.Location = new Point(6, 30);
			cheatButton.Name = "cheatButton";
			cheatButton.Size = new Size(112, 34);
			cheatButton.TabIndex = 0;
			cheatButton.Text = "Cheat";
			cheatButton.UseVisualStyleBackColor = true;
			cheatButton.Click += cheatButton_Click;
			// 
			// SafeForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 506);
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
	}
}