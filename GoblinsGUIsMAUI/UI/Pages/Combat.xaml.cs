using GoblinsGUIsMAUI.UI.Controls;
using GoblinsGUIsGameLogic.UI.Models;

namespace GoblinsGUIsMAUI.UI.Pages {
	public partial class Combat : ContentPage {
		UIController controller;
		Character player;
		Character enemy;

		public Combat(UIController controller) {
			InitializeComponent();
			this.controller = controller;
			StartCombat();
		}

		void StartCombat() {
			var combatants = controller.GetCombatants();
			player = combatants.player;
			enemy = combatants.enemy;

			playerNameLabel.Text = player.Name;
			enemyNameLabel.Text = enemy.Name;

			enemyAttackLabel.Text = string.Empty;

			playerHealthLabel.BindingContext = player;
			playerHealthLabel.SetBinding(Label.TextProperty, "Health");
			enemyHealthLabel.BindingContext = enemy;
			enemyHealthLabel.SetBinding(Label.TextProperty, "Health");

			List<string> playerAttacks = controller.GetPlayerAttacks();
			for(int i = 0; i < playerAttacks.Count; i++) {
				string attack = playerAttacks[i];

				Button attackButton = new Button();
				attackButton.Text = attack;

				attackButton.WidthRequest = 120;
				attackButton.HeightRequest = 40;

				//attackButton.Location = new Point(i * 120, 0);
				attackButton.HorizontalOptions = LayoutOptions.Start;
				attackButton.Margin = new Thickness(0, 0, 0, 0);

				attackButton.Clicked += attackButton_Clicked;

				attackButton.Parent = playerHealthLabel;
				layout.Children.Add(attackButton);
			}
		}

		void attackButton_Clicked(object sender, EventArgs e) {
			if(!controller.IsThereAVictor()) {
				enemy.Health = controller.PlayerAttack(((Button) sender).Text);

				var result = controller.EnemyAttack();
				player.Health = result.health;
				enemyAttackLabel.Text = "The enemy used " + result.attack + "!";
			}

			if(controller.IsThereAVictor()) {
				if(controller.IsThePlayerTheVictor()) {
					enemyAttackLabel.Text = "You Won!";
				} else {
					enemyAttackLabel.Text = "You Lost!";
				}
			}
		}
	}
}