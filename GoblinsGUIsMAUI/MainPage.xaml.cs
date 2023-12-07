using GoblinsGUIsMAUI.UI.Controls;
using GoblinsGUIsMAUI.UI.Pages;

namespace GoblinsGUIsMAUI {
	public partial class MainPage : ContentPage {
		UIController controller;
		//int count = 0;

		public MainPage() {
			InitializeComponent();
			controller = new UIController();
		}

		private void ContentPage_Loaded(object sender, EventArgs e) {
			controller.SwitchToCharaCreation(Window);
		}

		/*
		private void OnCounterClicked(object sender, EventArgs e) {
			count++;

			if(count == 1)
				CounterBtn.Text = $"Clicked {count} time";
			else
				CounterBtn.Text = $"Clicked {count} times";

			SemanticScreenReader.Announce(CounterBtn.Text);
			// CombatPage = new CombatPage(uiController)
			controller.SwitchToDialogue(this.Window);
		}
		*/
	}
}