namespace GoblinsGUIsTheWinFormsChronicles.UI {
	partial class CharacterCreation {
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
			enterNameTextbox = new TextBox();
			enterNameLabel = new Label();
			randomizeStatsButton = new Button();
			strengthLabel = new Label();
			randomizeStrButton = new Button();
			randomizeDexButton = new Button();
			dexterityLabel = new Label();
			strengthDisplay = new TextBox();
			strengthEntry = new TextBox();
			dexterityDisplay = new TextBox();
			dexterityEntry = new TextBox();
			randomizeConButton = new Button();
			randomizeIntButton = new Button();
			randomizeWisButton = new Button();
			randomizeChaButton = new Button();
			constitutionLabel = new Label();
			constitutionDisplay = new TextBox();
			intelligenceLabel = new Label();
			wisdomLabel = new Label();
			charismaLabel = new Label();
			intelligenceDisplay = new TextBox();
			wisdomDisplay = new TextBox();
			charismaDisplay = new TextBox();
			constitutionEntry = new TextBox();
			intelligenceEntry = new TextBox();
			wisdomEntry = new TextBox();
			charismaEntry = new TextBox();
			setPlayerNameButton = new Button();
			statEntryBox = new GroupBox();
			enterNameDisplay = new TextBox();
			classSelectionBox = new ComboBox();
			classSelectionLabel = new Label();
			endCreationButton = new Button();
			statEntryBox.SuspendLayout();
			SuspendLayout();
			// 
			// enterNameTextbox
			// 
			enterNameTextbox.Location = new Point(12, 37);
			enterNameTextbox.Name = "enterNameTextbox";
			enterNameTextbox.Size = new Size(223, 31);
			enterNameTextbox.TabIndex = 1;
			enterNameTextbox.KeyDown += enterNameTextbox_KeyDown;
			// 
			// enterNameLabel
			// 
			enterNameLabel.AutoSize = true;
			enterNameLabel.Location = new Point(12, 9);
			enterNameLabel.Name = "enterNameLabel";
			enterNameLabel.Size = new Size(223, 25);
			enterNameLabel.TabIndex = 0;
			enterNameLabel.Text = "Enter the hero's name here";
			// 
			// randomizeStatsButton
			// 
			randomizeStatsButton.Location = new Point(26, 19);
			randomizeStatsButton.Name = "randomizeStatsButton";
			randomizeStatsButton.Size = new Size(176, 34);
			randomizeStatsButton.TabIndex = 3;
			randomizeStatsButton.Text = "Randomize all stats";
			randomizeStatsButton.UseVisualStyleBackColor = true;
			randomizeStatsButton.Click += randomizeStatsButton_Click;
			// 
			// strengthLabel
			// 
			strengthLabel.AutoSize = true;
			strengthLabel.Location = new Point(128, 64);
			strengthLabel.Name = "strengthLabel";
			strengthLabel.Size = new Size(88, 25);
			strengthLabel.TabIndex = 0;
			strengthLabel.Text = "Strength: ";
			// 
			// randomizeStrButton
			// 
			randomizeStrButton.Location = new Point(10, 59);
			randomizeStrButton.Name = "randomizeStrButton";
			randomizeStrButton.Size = new Size(112, 34);
			randomizeStrButton.TabIndex = 4;
			randomizeStrButton.Text = "Randomize";
			randomizeStrButton.UseVisualStyleBackColor = true;
			randomizeStrButton.Click += randomizeStrButton_Click;
			// 
			// randomizeDexButton
			// 
			randomizeDexButton.Location = new Point(10, 99);
			randomizeDexButton.Name = "randomizeDexButton";
			randomizeDexButton.Size = new Size(112, 34);
			randomizeDexButton.TabIndex = 5;
			randomizeDexButton.Text = "Randomize";
			randomizeDexButton.UseVisualStyleBackColor = true;
			randomizeDexButton.Click += randomizeDexButton_Click;
			// 
			// dexterityLabel
			// 
			dexterityLabel.AutoSize = true;
			dexterityLabel.Location = new Point(128, 104);
			dexterityLabel.Name = "dexterityLabel";
			dexterityLabel.Size = new Size(91, 25);
			dexterityLabel.TabIndex = 0;
			dexterityLabel.Text = "Dexterity: ";
			// 
			// strengthDisplay
			// 
			strengthDisplay.Location = new Point(252, 61);
			strengthDisplay.Name = "strengthDisplay";
			strengthDisplay.ReadOnly = true;
			strengthDisplay.Size = new Size(71, 31);
			strengthDisplay.TabIndex = 0;
			strengthDisplay.TabStop = false;
			// 
			// strengthEntry
			// 
			strengthEntry.Location = new Point(329, 61);
			strengthEntry.Name = "strengthEntry";
			strengthEntry.Size = new Size(74, 31);
			strengthEntry.TabIndex = 10;
			strengthEntry.KeyDown += strEntry_KeyDown;
			strengthEntry.KeyPress += statEntry_KeyPress;
			// 
			// dexterityDisplay
			// 
			dexterityDisplay.Location = new Point(252, 101);
			dexterityDisplay.Name = "dexterityDisplay";
			dexterityDisplay.ReadOnly = true;
			dexterityDisplay.Size = new Size(71, 31);
			dexterityDisplay.TabIndex = 0;
			dexterityDisplay.TabStop = false;
			// 
			// dexterityEntry
			// 
			dexterityEntry.Location = new Point(329, 102);
			dexterityEntry.Name = "dexterityEntry";
			dexterityEntry.Size = new Size(74, 31);
			dexterityEntry.TabIndex = 11;
			dexterityEntry.KeyDown += dexEntry_KeyDown;
			dexterityEntry.KeyPress += statEntry_KeyPress;
			// 
			// randomizeConButton
			// 
			randomizeConButton.Location = new Point(10, 139);
			randomizeConButton.Name = "randomizeConButton";
			randomizeConButton.Size = new Size(112, 34);
			randomizeConButton.TabIndex = 6;
			randomizeConButton.Text = "Randomize";
			randomizeConButton.UseVisualStyleBackColor = true;
			randomizeConButton.Click += randomizeConButton_Click;
			// 
			// randomizeIntButton
			// 
			randomizeIntButton.Location = new Point(10, 179);
			randomizeIntButton.Name = "randomizeIntButton";
			randomizeIntButton.Size = new Size(112, 34);
			randomizeIntButton.TabIndex = 7;
			randomizeIntButton.Text = "Randomize";
			randomizeIntButton.UseVisualStyleBackColor = true;
			randomizeIntButton.Click += randomizeIntButton_Click;
			// 
			// randomizeWisButton
			// 
			randomizeWisButton.Location = new Point(10, 219);
			randomizeWisButton.Name = "randomizeWisButton";
			randomizeWisButton.Size = new Size(112, 34);
			randomizeWisButton.TabIndex = 8;
			randomizeWisButton.Text = "Randomize";
			randomizeWisButton.UseVisualStyleBackColor = true;
			randomizeWisButton.Click += randomizeWisButton_Click;
			// 
			// randomizeChaButton
			// 
			randomizeChaButton.Location = new Point(10, 259);
			randomizeChaButton.Name = "randomizeChaButton";
			randomizeChaButton.Size = new Size(112, 34);
			randomizeChaButton.TabIndex = 9;
			randomizeChaButton.Text = "Randomize";
			randomizeChaButton.UseVisualStyleBackColor = true;
			randomizeChaButton.Click += randomizeChaButton_Click;
			// 
			// constitutionLabel
			// 
			constitutionLabel.AutoSize = true;
			constitutionLabel.Location = new Point(128, 144);
			constitutionLabel.Name = "constitutionLabel";
			constitutionLabel.Size = new Size(118, 25);
			constitutionLabel.TabIndex = 0;
			constitutionLabel.Text = "Constitution: ";
			// 
			// constitutionDisplay
			// 
			constitutionDisplay.Location = new Point(252, 141);
			constitutionDisplay.Name = "constitutionDisplay";
			constitutionDisplay.ReadOnly = true;
			constitutionDisplay.Size = new Size(71, 31);
			constitutionDisplay.TabIndex = 0;
			constitutionDisplay.TabStop = false;
			// 
			// intelligenceLabel
			// 
			intelligenceLabel.AutoSize = true;
			intelligenceLabel.Location = new Point(128, 184);
			intelligenceLabel.Name = "intelligenceLabel";
			intelligenceLabel.Size = new Size(110, 25);
			intelligenceLabel.TabIndex = 0;
			intelligenceLabel.Text = "Intelligence: ";
			// 
			// wisdomLabel
			// 
			wisdomLabel.AutoSize = true;
			wisdomLabel.Location = new Point(128, 224);
			wisdomLabel.Name = "wisdomLabel";
			wisdomLabel.Size = new Size(88, 25);
			wisdomLabel.TabIndex = 0;
			wisdomLabel.Text = "Wisdom: ";
			// 
			// charismaLabel
			// 
			charismaLabel.AutoSize = true;
			charismaLabel.Location = new Point(128, 264);
			charismaLabel.Name = "charismaLabel";
			charismaLabel.Size = new Size(94, 25);
			charismaLabel.TabIndex = 0;
			charismaLabel.Text = "Charisma: ";
			// 
			// intelligenceDisplay
			// 
			intelligenceDisplay.Location = new Point(252, 181);
			intelligenceDisplay.Name = "intelligenceDisplay";
			intelligenceDisplay.ReadOnly = true;
			intelligenceDisplay.Size = new Size(71, 31);
			intelligenceDisplay.TabIndex = 0;
			intelligenceDisplay.TabStop = false;
			// 
			// wisdomDisplay
			// 
			wisdomDisplay.Location = new Point(252, 221);
			wisdomDisplay.Name = "wisdomDisplay";
			wisdomDisplay.ReadOnly = true;
			wisdomDisplay.Size = new Size(71, 31);
			wisdomDisplay.TabIndex = 0;
			wisdomDisplay.TabStop = false;
			// 
			// charismaDisplay
			// 
			charismaDisplay.Location = new Point(252, 261);
			charismaDisplay.Name = "charismaDisplay";
			charismaDisplay.ReadOnly = true;
			charismaDisplay.Size = new Size(71, 31);
			charismaDisplay.TabIndex = 0;
			charismaDisplay.TabStop = false;
			// 
			// constitutionEntry
			// 
			constitutionEntry.Location = new Point(329, 141);
			constitutionEntry.Name = "constitutionEntry";
			constitutionEntry.Size = new Size(74, 31);
			constitutionEntry.TabIndex = 12;
			constitutionEntry.KeyDown += conEntry_KeyDown;
			constitutionEntry.KeyPress += statEntry_KeyPress;
			// 
			// intelligenceEntry
			// 
			intelligenceEntry.Location = new Point(329, 181);
			intelligenceEntry.Name = "intelligenceEntry";
			intelligenceEntry.Size = new Size(74, 31);
			intelligenceEntry.TabIndex = 13;
			intelligenceEntry.KeyDown += intEntry_KeyDown;
			intelligenceEntry.KeyPress += statEntry_KeyPress;
			// 
			// wisdomEntry
			// 
			wisdomEntry.Location = new Point(329, 221);
			wisdomEntry.Name = "wisdomEntry";
			wisdomEntry.Size = new Size(74, 31);
			wisdomEntry.TabIndex = 14;
			wisdomEntry.KeyDown += wisEntry_KeyDown;
			wisdomEntry.KeyPress += statEntry_KeyPress;
			// 
			// charismaEntry
			// 
			charismaEntry.Location = new Point(329, 261);
			charismaEntry.Name = "charismaEntry";
			charismaEntry.Size = new Size(74, 31);
			charismaEntry.TabIndex = 15;
			charismaEntry.KeyDown += chaEntry_KeyDown;
			charismaEntry.KeyPress += statEntry_KeyPress;
			// 
			// setPlayerNameButton
			// 
			setPlayerNameButton.Location = new Point(38, 111);
			setPlayerNameButton.Name = "setPlayerNameButton";
			setPlayerNameButton.Size = new Size(176, 34);
			setPlayerNameButton.TabIndex = 2;
			setPlayerNameButton.Text = "Set Player Name";
			setPlayerNameButton.UseVisualStyleBackColor = true;
			setPlayerNameButton.Click += setPlayerNameButton_Click;
			// 
			// statEntryBox
			// 
			statEntryBox.Controls.Add(randomizeStatsButton);
			statEntryBox.Controls.Add(strengthLabel);
			statEntryBox.Controls.Add(charismaEntry);
			statEntryBox.Controls.Add(randomizeStrButton);
			statEntryBox.Controls.Add(wisdomEntry);
			statEntryBox.Controls.Add(randomizeDexButton);
			statEntryBox.Controls.Add(intelligenceEntry);
			statEntryBox.Controls.Add(dexterityLabel);
			statEntryBox.Controls.Add(constitutionEntry);
			statEntryBox.Controls.Add(strengthDisplay);
			statEntryBox.Controls.Add(charismaDisplay);
			statEntryBox.Controls.Add(strengthEntry);
			statEntryBox.Controls.Add(wisdomDisplay);
			statEntryBox.Controls.Add(dexterityDisplay);
			statEntryBox.Controls.Add(intelligenceDisplay);
			statEntryBox.Controls.Add(dexterityEntry);
			statEntryBox.Controls.Add(charismaLabel);
			statEntryBox.Controls.Add(randomizeConButton);
			statEntryBox.Controls.Add(wisdomLabel);
			statEntryBox.Controls.Add(randomizeIntButton);
			statEntryBox.Controls.Add(intelligenceLabel);
			statEntryBox.Controls.Add(randomizeWisButton);
			statEntryBox.Controls.Add(constitutionDisplay);
			statEntryBox.Controls.Add(randomizeChaButton);
			statEntryBox.Controls.Add(constitutionLabel);
			statEntryBox.Location = new Point(12, 151);
			statEntryBox.Name = "statEntryBox";
			statEntryBox.Size = new Size(409, 302);
			statEntryBox.TabIndex = 16;
			statEntryBox.TabStop = false;
			// 
			// enterNameDisplay
			// 
			enterNameDisplay.Location = new Point(12, 74);
			enterNameDisplay.Name = "enterNameDisplay";
			enterNameDisplay.ReadOnly = true;
			enterNameDisplay.Size = new Size(223, 31);
			enterNameDisplay.TabIndex = 0;
			enterNameDisplay.TabStop = false;
			// 
			// classSelectionBox
			// 
			classSelectionBox.FormattingEnabled = true;
			classSelectionBox.Location = new Point(264, 35);
			classSelectionBox.Name = "classSelectionBox";
			classSelectionBox.Size = new Size(182, 33);
			classSelectionBox.TabIndex = 16;
			// 
			// classSelectionLabel
			// 
			classSelectionLabel.AutoSize = true;
			classSelectionLabel.Location = new Point(287, 9);
			classSelectionLabel.Name = "classSelectionLabel";
			classSelectionLabel.Size = new Size(143, 25);
			classSelectionLabel.TabIndex = 0;
			classSelectionLabel.Text = "Select Your Class";
			// 
			// endCreationButton
			// 
			endCreationButton.Location = new Point(554, 419);
			endCreationButton.Name = "endCreationButton";
			endCreationButton.Size = new Size(112, 34);
			endCreationButton.TabIndex = 17;
			endCreationButton.Text = "Finish";
			endCreationButton.UseVisualStyleBackColor = true;
			endCreationButton.Click += endCreationButton_Click;
			// 
			// CharacterCreation
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(678, 462);
			Controls.Add(endCreationButton);
			Controls.Add(classSelectionLabel);
			Controls.Add(classSelectionBox);
			Controls.Add(enterNameDisplay);
			Controls.Add(statEntryBox);
			Controls.Add(setPlayerNameButton);
			Controls.Add(enterNameLabel);
			Controls.Add(enterNameTextbox);
			Name = "CharacterCreation";
			Text = "Character Creation";
			statEntryBox.ResumeLayout(false);
			statEntryBox.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox enterNameTextbox;
		private Label enterNameLabel;
		private Button randomizeStatsButton;
		private Label strengthLabel;
		private Button randomizeStrButton;
		private Button randomizeDexButton;
		private Label dexterityLabel;
		private TextBox strengthDisplay;
		private TextBox strengthEntry;
		private TextBox dexterityDisplay;
		private TextBox dexterityEntry;
		private Button randomizeConButton;
		private Button randomizeIntButton;
		private Button randomizeWisButton;
		private Button randomizeChaButton;
		private Label constitutionLabel;
		private TextBox constitutionDisplay;
		private Label intelligenceLabel;
		private Label wisdomLabel;
		private Label charismaLabel;
		private TextBox intelligenceDisplay;
		private TextBox wisdomDisplay;
		private TextBox charismaDisplay;
		private TextBox constitutionEntry;
		private TextBox intelligenceEntry;
		private TextBox wisdomEntry;
		private TextBox charismaEntry;
		private Button setPlayerNameButton;
		private GroupBox statEntryBox;
		private TextBox enterNameDisplay;
		private ComboBox classSelectionBox;
		private Label classSelectionLabel;
		private Button endCreationButton;
	}
}