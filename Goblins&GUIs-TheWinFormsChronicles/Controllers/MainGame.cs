using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GoblinsGUIsTheWinFormsChronicles.Characters;
//using GoblinsGUIsTheWinFormsChronicles.UI;

namespace GoblinsGUIsTheWinFormsChronicles.Controllers {
	internal class MainGame : ICreatePlayer {
		private Characters.NPC narrator;
		static Player? player = null;

		public MainGame() {
			InitializeNarrator();
		}

		public void Run() {
			while(player == null) {
				Application.Run(new UI.CharacterCreation(this));
			}

			new DialogueSystem(narrator);
		}

		public void CreatePlayer(string name, Characters.Character.ClassType classType, int str, int dex, int con, int inte, int wis, int cha) {
			player = new Player(name, classType, str, dex, con, inte, wis, cha);
		}

		private void InitializeNarrator() {
			List<Characters.NPC.DialogData> narratorDialogue = new List<Characters.NPC.DialogData>();
			narratorDialogue.Add(new Characters.NPC.DialogData("Welcome adventurer, to the world of Goblins and GUIs!", 0, 1));
			narratorDialogue.Add(new Characters.NPC.DialogData("Within this land, you will hopefully travel far and have many adventures.", 1, 2));
			narratorDialogue.Add(new Characters.NPC.DialogData("Now to get started!", 2, 3));
			narratorDialogue.Add(new Characters.NPC.DialogData("In front of you lies a tavern, do you choose to enter it?", 3, 4));
			narratorDialogue.Add(new Characters.NPC.DialogData("Inside the tavern, you spot a quest board against the wall", 5, 8));
			narratorDialogue.Add(new Characters.NPC.DialogData("On the quest board are a number of different possible adventures for you to go on", 8, 9));
			narratorDialogue.Add(new Characters.NPC.DialogData("Relying on complete randomness, you pick a piece of paper off the board and head out", 9, 10));

			Dictionary<int, Dictionary<string, int>> narratorResponses = new Dictionary<int, Dictionary<string, int>>();
			narratorResponses[4] = new Dictionary<string, int>() {{"Yes", 5}, {"No", 6}};

			narrator = new NPC("Narrator", Character.ClassType.Fighter, 20, 20, 20, 20, 20, 20, narratorDialogue, narratorResponses);
		}
	}
}
