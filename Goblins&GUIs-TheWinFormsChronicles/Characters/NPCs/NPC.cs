using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsGUIsTheWinFormsChronicles.Characters {
	internal class NPC : Character {
		public struct DialogData {
			string dialog;
			int dialogID;
			int nextDialogID;
			// Going to have to implement some way to have skill checks
			int dc;
			string ability;

			public DialogData(string dialog, int dialogID, int nextDialogID, int dc = -1, string ability = "") {
				this.dialog = dialog;
				this.dialogID = dialogID;
				this.nextDialogID = nextDialogID;
				this.dc = dc;
				this.ability = ability;
			}
		}

		public List<DialogData> dialogData {get;}
		public Dictionary<int, Dictionary<string, int>> responseData {get;}

		public NPC(string name, ClassType classType, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, List<DialogData> dialogData, Dictionary<int, Dictionary<string, int>> responseData) : base(name, classType, strength, dexterity, constitution, intelligence, wisdom, charisma) {
			this.dialogData = dialogData;
			this.responseData = responseData;
		}
	}
}
