using GoblinsGUIsGameLogic.UI.Models;
using GoblinsGUIsMAUI.UI.Controls;

namespace GoblinsGUIsMAUI.UI.Pages {
	public partial class CharacterCreation : ContentPage {
		Random random = new Random();
		Character playerCharacter;
		string[] classTypes;

		UIController controller;

		public CharacterCreation(UIController controller) {
			InitializeComponent();

			this.controller = controller;

			playerCharacter = new Character();
			classTypes = new string[] {"Fighter", "Wizard"};

			InitializeCharacterInfo();
		}

		private void InitializeCharacterInfo() {
			strengthDisplay.BindingContext = playerCharacter;
			strengthDisplay.SetBinding(Entry.TextProperty, "Strength");
			dexterityDisplay.BindingContext = playerCharacter;
			dexterityDisplay.SetBinding(Entry.TextProperty, "Dexterity");
			constitutionDisplay.BindingContext = playerCharacter;
			constitutionDisplay.SetBinding(Entry.TextProperty, "Constitution");
			intelligenceDisplay.BindingContext = playerCharacter;
			intelligenceDisplay.SetBinding(Entry.TextProperty, "Intelligence");
			wisdomDisplay.BindingContext = playerCharacter;
			wisdomDisplay.SetBinding(Entry.TextProperty, "Wisdom");
			charismaDisplay.BindingContext = playerCharacter;
			charismaDisplay.SetBinding(Entry.TextProperty, "Charisma");
			enterNameDisplay.BindingContext = playerCharacter;
			enterNameDisplay.SetBinding(Entry.TextProperty, "Name");

			classSelectionBox.ItemsSource = classTypes;
			classSelectionBox.BindingContext = playerCharacter;
			classSelectionBox.SetBinding(Picker.SelectedItemProperty, "Classtype");
		}

		private void setPlayerNameButton_Clicked(object sender, EventArgs e) {
			playerCharacter.Name = enterNameTextbox.Text;
		}

		private void randomizeStatsButton_Clicked(object sender, EventArgs e) {
			randomizeStrButton_Clicked(sender, e);
			randomizeDexButton_Clicked(sender, e);
			randomizeConButton_Clicked(sender, e);
			randomizeIntButton_Clicked(sender, e);
			randomizeWisButton_Clicked(sender, e);
			randomizeChaButton_Clicked(sender, e);
		}

		private void randomizeStrButton_Clicked(object sender, EventArgs e) {
			playerCharacter.Strength = GenerateRandomStat();
		}

		private void randomizeDexButton_Clicked(object sender, EventArgs e) {
			playerCharacter.Dexterity = GenerateRandomStat();
		}

		private void randomizeConButton_Clicked(object sender, EventArgs e) {
			playerCharacter.Constitution = GenerateRandomStat();
		}

		private void randomizeIntButton_Clicked(object sender, EventArgs e) {
			playerCharacter.Intelligence = GenerateRandomStat();
		}

		private void randomizeWisButton_Clicked(object sender, EventArgs e) {
			playerCharacter.Wisdom = GenerateRandomStat();
		}

		private void randomizeChaButton_Clicked(object sender, EventArgs e) {
			playerCharacter.Charisma = GenerateRandomStat();
		}

		private int GenerateRandomStat() {
			return random.Next(1, 21);
		}

		private void statEntry_TextChanged(object sender, TextChangedEventArgs e) {
			if(e.NewTextValue == null) {
				return;
			}

			bool valid = true;
			foreach(char chara in e.NewTextValue) {
				if(!char.IsDigit(chara)) {
					valid = false;
					break;
				}
			}
			if(!valid) {
				((Entry) sender).Text = e.OldTextValue;
			}
		}

		private void enterNameTextbox_Completed(object sender, EventArgs e) {
			setPlayerNameButton_Clicked(sender, e);
		}

		private void strengthEntry_Completed(object sender, EventArgs e) {
			if(strengthEntry.Text != null && strengthEntry.Text != string.Empty) {
				playerCharacter.Strength = int.Parse(strengthEntry.Text);
			}
		}

		private void dexterityEntry_Completed(object sender, EventArgs e) {
			if(dexterityEntry.Text != null && dexterityEntry.Text != string.Empty) {
				playerCharacter.Dexterity = int.Parse(dexterityEntry.Text);
			}
		}

		private void constitutionEntry_Completed(object sender, EventArgs e) {
			if(constitutionEntry.Text != null && constitutionEntry.Text != string.Empty) {
				playerCharacter.Constitution = int.Parse(constitutionEntry.Text);
			}
		}

		private void intelligenceEntry_Completed(object sender, EventArgs e) {
			if(intelligenceEntry.Text != null && intelligenceEntry.Text != string.Empty) {
				playerCharacter.Intelligence = int.Parse(intelligenceEntry.Text);
			}
		}

		private void wisdomEntry_Completed(object sender, EventArgs e) {
			if(wisdomEntry.Text != null && wisdomEntry.Text != string.Empty) {
				playerCharacter.Wisdom = int.Parse(wisdomEntry.Text);
			}
		}

		private void charismaEntry_Completed(object sender, EventArgs e) {
			if(charismaEntry.Text != null && charismaEntry.Text != string.Empty) {
				playerCharacter.Charisma = int.Parse(charismaEntry.Text);
			}
		}

		private bool AreStatsValid() {
			if(playerCharacter.Name == string.Empty) {
				return false;
			}

			return true;
		}

		private void endCreationButton_Clicked(object sender, EventArgs e) {
			if(AreStatsValid()) {
				controller.CreatePlayer(playerCharacter.Name, (GoblinsGUIsGameLogic.Characters.Character.ClassType) playerCharacter.StringToClass(playerCharacter.Classtype), playerCharacter.Strength, playerCharacter.Dexterity, playerCharacter.Constitution, playerCharacter.Intelligence, playerCharacter.Wisdom, playerCharacter.Charisma);

				controller.SwitchToDialogue();
			}
		}
	}
}