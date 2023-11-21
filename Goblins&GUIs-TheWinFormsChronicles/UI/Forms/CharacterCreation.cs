using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GoblinsGUIsTheWinFormsChronicles.Controllers;
using GoblinsGUIsTheWinFormsChronicles.Characters;

namespace GoblinsGUIsTheWinFormsChronicles.UI {
	public partial class CharacterCreation : Form {
		Random random = new Random();
		UI.Character playerCharacter;
		string[] classTypes;

		ICreatePlayer game;

		public CharacterCreation(ICreatePlayer mainGame) {
			InitializeComponent();

			this.game = mainGame;

			playerCharacter = new Character();
			classTypes = new string[] { "Fighter", "Wizard" };

			InitializeCharacterInfo();
		}

		private void InitializeCharacterInfo() {
			strengthDisplay.DataBindings.Add("Text", playerCharacter, "strength", false, DataSourceUpdateMode.OnPropertyChanged);
			dexterityDisplay.DataBindings.Add("Text", playerCharacter, "dexterity", false, DataSourceUpdateMode.OnPropertyChanged);
			constitutionDisplay.DataBindings.Add("Text", playerCharacter, "constitution", false, DataSourceUpdateMode.OnPropertyChanged);
			intelligenceDisplay.DataBindings.Add("Text", playerCharacter, "intelligence", false, DataSourceUpdateMode.OnPropertyChanged);
			wisdomDisplay.DataBindings.Add("Text", playerCharacter, "wisdom", false, DataSourceUpdateMode.OnPropertyChanged);
			charismaDisplay.DataBindings.Add("Text", playerCharacter, "charisma", false, DataSourceUpdateMode.OnPropertyChanged);
			enterNameDisplay.DataBindings.Add("Text", playerCharacter, "name", false, DataSourceUpdateMode.OnPropertyChanged);

			classSelectionBox.DataSource = classTypes;
			classSelectionBox.DataBindings.Add("Text", playerCharacter, "classType", false, DataSourceUpdateMode.OnPropertyChanged);
		}

		private void setPlayerNameButton_Click(object sender, EventArgs e) {
			playerCharacter.Name = enterNameTextbox.Text;
		}

		private void randomizeStatsButton_Click(object sender, EventArgs e) {
			randomizeStrButton_Click(sender, e);
			randomizeDexButton_Click(sender, e);
			randomizeConButton_Click(sender, e);
			randomizeIntButton_Click(sender, e);
			randomizeWisButton_Click(sender, e);
			randomizeChaButton_Click(sender, e);
		}

		private void randomizeStrButton_Click(object sender, EventArgs e) {
			int str = GenerateRandomStat();
			playerCharacter.Strength = str;
		}

		private void randomizeDexButton_Click(object sender, EventArgs e) {
			int dex = GenerateRandomStat();
			playerCharacter.Dexterity = dex;
		}

		private void randomizeConButton_Click(object sender, EventArgs e) {
			int con = GenerateRandomStat();
			playerCharacter.Constitution = con;
		}

		private void randomizeIntButton_Click(object sender, EventArgs e) {
			int inte = GenerateRandomStat();
			playerCharacter.Intelligence = inte;
		}

		private void randomizeWisButton_Click(object sender, EventArgs e) {
			int wis = GenerateRandomStat();
			playerCharacter.Wisdom = wis;
		}

		private void randomizeChaButton_Click(object sender, EventArgs e) {
			int cha = GenerateRandomStat();
			playerCharacter.Charisma = cha;
		}

		private int GenerateRandomStat() {
			return random.Next(1, 21);
		}

		private void statEntry_KeyPress(object sender, KeyPressEventArgs e) {
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
				e.Handled = true;
			}

			if(((TextBox) sender).Text.Length >= 2 && !char.IsControl(e.KeyChar)) {
				e.Handled = true;
			}
		}

		private void enterNameTextbox_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				setPlayerNameButton_Click(sender, e);
			}
		}

		private void strEntry_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				playerCharacter.Strength = int.Parse(strengthEntry.Text);
			}
		}

		private void dexEntry_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				playerCharacter.Dexterity = int.Parse(dexterityEntry.Text);
			}
		}

		private void conEntry_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				playerCharacter.Constitution = int.Parse(constitutionEntry.Text);
			}
		}

		private void intEntry_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				playerCharacter.Intelligence = int.Parse(intelligenceDisplay.Text);
			}
		}

		private void wisEntry_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				playerCharacter.Wisdom = int.Parse(wisdomEntry.Text);
			}
		}

		private void chaEntry_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				playerCharacter.Charisma = int.Parse(charismaEntry.Text);
			}
		}

		private bool AreStatsValid() {
			if(playerCharacter.Name == "") {
				return false;
			}

			return true;
		}

		private void endCreationButton_Click(object sender, EventArgs e) {
			if(AreStatsValid()) {
				game.CreatePlayer(playerCharacter.Name, (Characters.Character.ClassType) playerCharacter.StringToClass(playerCharacter.Classtype), playerCharacter.Strength, playerCharacter.Dexterity, playerCharacter.Constitution, playerCharacter.Intelligence, playerCharacter.Wisdom, playerCharacter.Charisma);
				Close();
			}
		}
	}
}
