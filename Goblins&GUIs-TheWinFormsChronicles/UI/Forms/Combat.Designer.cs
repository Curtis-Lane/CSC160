namespace GoblinsGUIsTheWinFormsChronicles.UI {
	partial class Combat {
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
			playerControlsBox = new GroupBox();
			playerAttacksBox = new GroupBox();
			playerHealthLabel = new Label();
			playerHealth = new Label();
			enemyControlsBox = new GroupBox();
			enemyHealthLabel = new Label();
			enemyHealth = new Label();
			enemyAttackLabel = new Label();
			playerControlsBox.SuspendLayout();
			enemyControlsBox.SuspendLayout();
			SuspendLayout();
			// 
			// playerControlsBox
			// 
			playerControlsBox.Controls.Add(playerAttacksBox);
			playerControlsBox.Controls.Add(playerHealthLabel);
			playerControlsBox.Controls.Add(playerHealth);
			playerControlsBox.Location = new Point(12, 288);
			playerControlsBox.Name = "playerControlsBox";
			playerControlsBox.Size = new Size(300, 150);
			playerControlsBox.TabIndex = 0;
			playerControlsBox.TabStop = false;
			playerControlsBox.Text = "playerName";
			// 
			// playerAttacksBox
			// 
			playerAttacksBox.Location = new Point(6, 55);
			playerAttacksBox.Name = "playerAttacksBox";
			playerAttacksBox.Size = new Size(288, 84);
			playerAttacksBox.TabIndex = 0;
			playerAttacksBox.TabStop = false;
			// 
			// playerHealthLabel
			// 
			playerHealthLabel.AutoSize = true;
			playerHealthLabel.Location = new Point(79, 27);
			playerHealthLabel.Name = "playerHealthLabel";
			playerHealthLabel.Size = new Size(23, 25);
			playerHealthLabel.TabIndex = 0;
			playerHealthLabel.Text = "#";
			// 
			// playerHealth
			// 
			playerHealth.AutoSize = true;
			playerHealth.Location = new Point(6, 27);
			playerHealth.Name = "playerHealth";
			playerHealth.Size = new Size(67, 25);
			playerHealth.TabIndex = 0;
			playerHealth.Text = "Health:";
			// 
			// enemyControlsBox
			// 
			enemyControlsBox.Controls.Add(enemyHealthLabel);
			enemyControlsBox.Controls.Add(enemyHealth);
			enemyControlsBox.Location = new Point(488, 12);
			enemyControlsBox.Name = "enemyControlsBox";
			enemyControlsBox.Size = new Size(300, 150);
			enemyControlsBox.TabIndex = 0;
			enemyControlsBox.TabStop = false;
			enemyControlsBox.Text = "enemyName";
			// 
			// enemyHealthLabel
			// 
			enemyHealthLabel.AutoSize = true;
			enemyHealthLabel.Location = new Point(79, 27);
			enemyHealthLabel.Name = "enemyHealthLabel";
			enemyHealthLabel.Size = new Size(23, 25);
			enemyHealthLabel.TabIndex = 0;
			enemyHealthLabel.Text = "#";
			// 
			// enemyHealth
			// 
			enemyHealth.AutoSize = true;
			enemyHealth.Location = new Point(6, 27);
			enemyHealth.Name = "enemyHealth";
			enemyHealth.Size = new Size(67, 25);
			enemyHealth.TabIndex = 0;
			enemyHealth.Text = "Health:";
			// 
			// enemyAttackLabel
			// 
			enemyAttackLabel.AutoSize = true;
			enemyAttackLabel.Location = new Point(283, 200);
			enemyAttackLabel.Name = "enemyAttackLabel";
			enemyAttackLabel.Size = new Size(23, 25);
			enemyAttackLabel.TabIndex = 0;
			enemyAttackLabel.Text = "#";
			// 
			// Combat
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(enemyAttackLabel);
			Controls.Add(enemyControlsBox);
			Controls.Add(playerControlsBox);
			Name = "Combat";
			Text = "Combat";
			playerControlsBox.ResumeLayout(false);
			playerControlsBox.PerformLayout();
			enemyControlsBox.ResumeLayout(false);
			enemyControlsBox.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox playerControlsBox;
		private GroupBox enemyControlsBox;
		private Label playerHealthLabel;
		private Label playerHealth;
		private Label enemyHealthLabel;
		private Label enemyHealth;
		private GroupBox playerAttacksBox;
		private Label enemyAttackLabel;
	}
}