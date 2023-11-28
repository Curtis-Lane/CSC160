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

namespace GoblinsGUIsTheWinFormsChronicles.UI {
	public partial class Combat : Form {
		ICombatManager combatManager;
		Character player;
		Character enemy;

		public Combat(ICombatManager combatManager) {
			InitializeComponent();
			this.combatManager = combatManager;
			StartCombat();
		}

		void StartCombat() {
			var combatants = combatManager.GetCombatants();
			player = combatants.player;
			enemy = combatants.enemy;

			playerControlsBox.Text = player.Name;
			enemyControlsBox.Text = enemy.Name;

			enemyAttackLabel.Text = string.Empty;

			playerHealthLabel.DataBindings.Add("Text", player, "health", false, DataSourceUpdateMode.OnPropertyChanged);
			enemyHealthLabel.DataBindings.Add("Text", enemy, "health", false, DataSourceUpdateMode.OnPropertyChanged);

			List<string> playerAttacks = combatManager.GetPlayerAttacks();
			for(int i = 0; i < playerAttacks.Count; i++) {
				string attack = playerAttacks[i];

				Button attackButton = new Button();
				attackButton.Text = attack;
				attackButton.Size = new Size(120, 40);
				attackButton.Location = new Point(i * 120, 0);
				attackButton.TabIndex = i + 1;
				attackButton.Click += attackButton_Click;

				playerAttacksBox.Controls.Add(attackButton);
			}
		}

		void attackButton_Click(object sender, EventArgs e) {
			if(!combatManager.IsThereAVictor()) {
				enemy.Health = combatManager.PlayerAttack(((Button) sender).Text);

				var result = combatManager.EnemyAttack();
				player.Health = result.health;
				enemyAttackLabel.Text = "The enemy used " + result.attack + "!";
			}

			if(combatManager.IsThereAVictor()) {
				if(combatManager.IsThePlayerTheVictor()) {
					enemyAttackLabel.Text = "You Won!";
				} else {
					enemyAttackLabel.Text = "You Lost!";
				}
			}
		}
	}
}
