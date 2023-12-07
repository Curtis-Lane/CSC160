using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinsGUIsGameLogic.Controllers;
using GoblinsGUIsTheWinFormsChronicles.UI;

namespace GoblinsGUIsTheWinFormsChronicles.UI.Controls {
	internal class UIController {
		private IMainGame mainGame;
		private IDialogueManager dialogueManager;
		private ICombatManager combatManager;

		public void Run() {
			mainGame = new MainGame();

			while(mainGame.GetPlayer() == null) {
				Application.Run(new CharacterCreation(mainGame));
			}

			dialogueManager = new DialogueSystem(mainGame.GetNarrator(), mainGame.GetPlayer());

			Application.Run(new Dialogue(dialogueManager));

			combatManager = new CombatSystem(mainGame.GetPlayer(), mainGame.GetBandit());

			Application.Run(new Combat(combatManager));
		}
	}
}
