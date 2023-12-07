using GoblinsGUIsMAUI.UI.Controls;

namespace GoblinsGUIsMAUI.UI.Pages {
	public partial class Dialogue : ContentPage {
		UIController controller;

		public Dialogue(UIController controller) {
			InitializeComponent();
			this.controller = controller;
			StartDialogue();
		}

		private void StartDialogue() {
			var data = controller.GetFirstDialogue();
			dialogueLabel.Text = data.name;
			dialogueText.Text = data.dialogue;

			var clicked = new TapGestureRecognizer();
			clicked.Tapped += dialogueText_Clicked;
			dialogueText.GestureRecognizers.Add(clicked);
		}

		private void GoToNextDialogue(string? responseText = null) {
			var data = controller.GetNextDialogue(responseText);

			if(data.dialogue == "-1") {
				controller.SwitchToCombat();
				return;
			}

			dialogueText.Text = data.dialogue;
			if(data.responses != null) {
				int numResponse = 0;
				foreach(var response in data.responses) {
					Button responseButton = new Button();

					responseButton.Margin = new Thickness(0, 20, 0, 0);

					responseButton.WidthRequest = 490;
					responseButton.HeightRequest = 40;

					responseButton.Clicked += responseButton_Clicked;

					if(response.checkType == "None") {
						responseButton.Text = response.response;
					} else {
						responseButton.Text = "(" + response.checkType + " " + response.playerStat.ToString() + "/" + response.dc.ToString() + ") " + response.response;
					}

					responseButton.Parent = dialogueText;
					layout.Children.Add(responseButton);

					numResponse += 1;
				}
			}
		}

		private void dialogueText_Clicked(object sender, EventArgs e) {
			GoToNextDialogue();
		}

		private void responseButton_Clicked(object sender, EventArgs e) {
			IEnumerable<Button> buttons = layout.Children.OfType<Button>();
			for(int i = buttons.Count(); i > 0; i--) {
				layout.Children.Remove(buttons.ElementAt(i - 1));
			}

			string[] responseText = ((Button) sender).Text.Split(')');
			if(responseText.Length == 1) {
				GoToNextDialogue(responseText[0]);
			} else {
				GoToNextDialogue(responseText[1].Trim());
			}
		}
	}
}