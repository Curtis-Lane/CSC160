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

			new DialogueSystem(narrator, player);

			new CombatSystem(player, new NPC("Enemy", Character.ClassType.Fighter, 8, 8, 1, 8, 8, 8));
		}

		public void CreatePlayer(string name, Character.ClassType classType, int str, int dex, int con, int inte, int wis, int cha) {
			player = new Player(name, classType, str, dex, con, inte, wis, cha);
		}

		private void InitializeNarrator() {
			List<NPC.DialogData> narratorDialogue = new List<Characters.NPC.DialogData>();
			narratorDialogue.Add(new NPC.DialogData("Welcome adventurer, to the world of Goblins and GUIs!", 0, 1));
			narratorDialogue.Add(new NPC.DialogData("Within this land, you will hopefully travel far and have many adventures.", 1, 2));
			narratorDialogue.Add(new NPC.DialogData("Now to get started!", 2, 3));
			narratorDialogue.Add(new NPC.DialogData("In front of you lies a tavern, do you choose to enter it?", 3, 4));
			narratorDialogue.Add(new NPC.DialogData("Inside the tavern, you spot a quest board against the wall.", 5, 8));
			narratorDialogue.Add(new NPC.DialogData("On the quest board are a number of different possible adventures for you to go on.", 8, 9));
			narratorDialogue.Add(new NPC.DialogData("Relying on complete randomness, you pick a piece of paper off the board and head out.", 9, 10));
			narratorDialogue.Add(new NPC.DialogData("Once you exit the tavern, you read the contents of the quest you picked.", 10, 11));
			narratorDialogue.Add(new NPC.DialogData("You notice that it was posted just earlier today.", 11, 12));
			narratorDialogue.Add(new NPC.DialogData("It reads: \"A local woman needs help to get her cat out of a tree\".", 12, 13));
			narratorDialogue.Add(new NPC.DialogData("A very simple and mudane quest, it would seem. Never the less, you carry on, heading in the direction of this tree.", 13, 14));
			narratorDialogue.Add(new NPC.DialogData("After a brief period of travel, you spot the tree that was mentioned in the paper.", 14, 15));
			narratorDialogue.Add(new NPC.DialogData("The woman is at the base of the tree, staring up at her cat that is in the branches.", 15, 17));
			
			narratorDialogue.Add(new NPC.DialogData("You chose not to enter the tavern, and you instead wonder off in a random direction.", 6, 7));
			narratorDialogue.Add(new NPC.DialogData("After a brief period of wondering around, you spot a woman standing in front of a tree.", 7, 16));
			narratorDialogue.Add(new NPC.DialogData("She is currently staring up into the branches, as if something is there.", 16, 17));
			narratorDialogue.Add(new NPC.DialogData("You decide to approach the woman.", 17, 18));

			narratorDialogue.Add(new NPC.DialogData("\"Oh, could you help me? My little baby got scared and ran up this tree and now won't come down.\"", 18, 19));
			narratorDialogue.Add(new NPC.DialogData("You decide to help the woman.", 19, 20));

			narratorDialogue.Add(new NPC.DialogData("After a small struggle with the cat, you successfully get it out of the tree.", 21, 22));
			narratorDialogue.Add(new NPC.DialogData("\"Oh, thank you so much dear! Now me and my little baby can go home.\"", 22, 23));
			narratorDialogue.Add(new NPC.DialogData("You give the cat back to the woman and then proceed on your way.", 23, 27));

			narratorDialogue.Add(new NPC.DialogData("After struggling with the cat for an embarissingly long time, you admit defeat and climb down from the tree.", 24, 25));
			narratorDialogue.Add(new NPC.DialogData("\"Well, thanks for trying dear. I know how fiesty my baby can get.\"", 25, 26));
			narratorDialogue.Add(new NPC.DialogData("After bidding the woman farewell, you proceed on your way.", 26, 27));

			narratorDialogue.Add(new NPC.DialogData("//", 27, -1));

			Dictionary<int, Dictionary<string, NPC.ResponseData>> narratorResponses = new Dictionary<int, Dictionary<string, NPC.ResponseData>>();
			narratorResponses[4] = new Dictionary<string, NPC.ResponseData>() {{"Yes", new NPC.ResponseData(5)}, {"No", new NPC.ResponseData(6)}};
			narratorResponses[20] = new Dictionary<string, NPC.ResponseData>() {{"Get the cat out of the tree", new NPC.ResponseData(21, NPC.CheckType.Dex, 8, 24)}};

			narrator = new NPC("Narrator", Character.ClassType.Fighter, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, narratorDialogue, narratorResponses);
		}
	}
}
