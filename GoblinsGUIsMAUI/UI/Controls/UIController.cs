using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinsGUIsGameLogic.Controllers;
using GoblinsGUIsGameLogic.Characters;
using GoblinsGUIsGameLogic.UI.Models;
using GoblinsGUIsMAUI.UI.Pages;

namespace GoblinsGUIsMAUI.UI.Controls {
	public class UIController {
		private IMainGame mainGame;
		private IDialogueManager dialogueManager;
		private ICombatManager combatManager;

		private Window currentWindow;

		public UIController() {
			mainGame = new MainGame();
		}

		public void SwitchToCharaCreation(Window oldWindow) {
			this.currentWindow = oldWindow;
			SwitchPage(new CharacterCreation(this));
		}

		public void SwitchToDialogue() {
			SwitchPage(new Dialogue(this));
		}

		public void SwitchToCombat() {
			SwitchPage(new Combat(this));
		}

		private void SwitchPage(Page page) {
			var oldWindow = currentWindow;
			currentWindow = new Window(page);
			Application.Current.OpenWindow(currentWindow);
			Application.Current.CloseWindow(oldWindow);
		}

		public void CreatePlayer(string name, GoblinsGUIsGameLogic.Characters.Character.ClassType classType, int str, int dex, int con, int inte, int wis, int cha) {
			mainGame.CreatePlayer(name, classType, str, dex, con, inte, wis, cha);

			dialogueManager = new DialogueSystem(mainGame.GetNarrator(), mainGame.GetPlayer());
			combatManager = new CombatSystem(mainGame.GetPlayer(), mainGame.GetBandit());
		}

		public (string name, string dialogue) GetFirstDialogue() {
			return dialogueManager.GetFirstDialogue();
		}

		public (string dialogue, List<(string response, string checkType, int dc, int playerStat)>? responses) GetNextDialogue(string? responseText = null) {
			return dialogueManager.GetNextDialogue(responseText);
		}

		public (GoblinsGUIsGameLogic.UI.Models.Character player, GoblinsGUIsGameLogic.UI.Models.Character enemy) GetCombatants() {
			return combatManager.GetCombatants();
		}

		public List<string> GetPlayerAttacks() {
			return combatManager.GetPlayerAttacks();
		}

		public int PlayerAttack(string attack) {
			return combatManager.PlayerAttack(attack);
		}

		public (int health, string attack) EnemyAttack() {
			return combatManager.EnemyAttack();
		}

		public bool IsThereAVictor() {
			return combatManager.IsThereAVictor();
		}

		public bool IsThePlayerTheVictor() {
			return combatManager.IsThePlayerTheVictor();
		}
	}
}
