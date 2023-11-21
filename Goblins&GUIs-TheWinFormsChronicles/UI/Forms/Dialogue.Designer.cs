namespace GoblinsGUIsTheWinFormsChronicles.UI {
	partial class Dialogue {
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
			dialogueBox = new GroupBox();
			dialogueText = new Label();
			dialogueBox.SuspendLayout();
			SuspendLayout();
			// 
			// dialogueBox
			// 
			dialogueBox.Controls.Add(dialogueText);
			dialogueBox.Location = new Point(157, 207);
			dialogueBox.Name = "dialogueBox";
			dialogueBox.Size = new Size(505, 216);
			dialogueBox.TabIndex = 0;
			dialogueBox.TabStop = false;
			// 
			// dialogueText
			// 
			dialogueText.AutoSize = true;
			dialogueText.Location = new Point(6, 27);
			dialogueText.MaximumSize = new Size(490, 50);
			dialogueText.Name = "dialogueText";
			dialogueText.Size = new Size(23, 25);
			dialogueText.TabIndex = 0;
			dialogueText.Text = "#";
			dialogueText.Click += dialogueText_Click;
			// 
			// Dialogue
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dialogueBox);
			Name = "Dialogue";
			Text = "Dialogue";
			dialogueBox.ResumeLayout(false);
			dialogueBox.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox dialogueBox;
		private Label dialogueText;
	}
}