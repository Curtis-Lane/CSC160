using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsGUIsTheWinFormsChronicles.Characters {
	public class NPC : Character {
		public struct DialogData {
			public string dialog;
			public int dialogID;
			public int nextDialogID;

			public DialogData(string dialog, int dialogID, int nextDialogID) {
				this.dialog = dialog;
				this.dialogID = dialogID;
				this.nextDialogID = nextDialogID;
			}
		}

		public struct ResponseData {
			public CheckType checkType;
			public int dc;
			public int successDialogID;
			public int failureDialogID;

			public ResponseData(int successDialogID, CheckType checkType = CheckType.None, int dc = -1, int failureDialogID = 0) {
				this.successDialogID = successDialogID;
				this.checkType = checkType;
				this.dc = dc;
				this.failureDialogID = failureDialogID;
			}
		}

		public List<DialogData> dialogData {get;}
		// Going to have to implement some way to have skill checks
		public Dictionary<int, Dictionary<string, ResponseData>> responseData {get;}

		public NPC(string name, ClassType classType, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, List<DialogData> dialogData = null, Dictionary<int, Dictionary<string, ResponseData>> responseData = null) : base(name, classType, strength, dexterity, constitution, intelligence, wisdom, charisma) {
			this.dialogData = dialogData;
			this.responseData = responseData;
		}
	}
}
