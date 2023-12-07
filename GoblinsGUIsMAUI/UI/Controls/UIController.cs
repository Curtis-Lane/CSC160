using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinsGUIsGameLogic.Controllers;
using GoblinsGUIsGameLogic.Characters;
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
			SwitchPage(new Dialogue());
		}

		private void SwitchPage(Page page) {
			var oldWindow = this.currentWindow;
			currentWindow = new Window(page);
			Application.Current.OpenWindow(currentWindow);
			Application.Current.CloseWindow(oldWindow);
		}

		public void CreatePlayer(string name, Character.ClassType classType, int str, int dex, int con, int inte, int wis, int cha) {
			mainGame.CreatePlayer(name, classType, str, dex, con, inte, wis, cha);

			dialogueManager = new DialogueSystem(mainGame.GetNarrator(), mainGame.GetPlayer());
			combatManager = new CombatSystem(mainGame.GetPlayer(), mainGame.GetBandit());
		}
	}
}
