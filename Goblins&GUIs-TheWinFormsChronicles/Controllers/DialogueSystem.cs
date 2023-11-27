using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinsGUIsTheWinFormsChronicles.Characters;
using GoblinsGUIsTheWinFormsChronicles.UI;

namespace GoblinsGUIsTheWinFormsChronicles.Controllers {
	public class DialogueSystem : IDialogueManager {
		public static NPC currentNPC;
		public static NPC.DialogData currentData;
		public static Dictionary<string, int> currentResponses;

		public DialogueSystem(NPC currentDialogueNPC) {
			currentNPC = currentDialogueNPC;
			Application.Run(new Dialogue(this));
		}

		public (string name, string dialogue) GetFirstDialogue() {
			foreach(NPC.DialogData data in currentNPC.dialogData) {
				if(data.dialogID == 0) {
					currentData = data;
					return (currentNPC.name, data.dialog);
				}
			}
			throw new Exception("Could not find any beginning dialogue for NPC " + currentNPC.name);
		}

		public (string dialogue, List<string>? responses) GetNextDialogue(string? responseText = null) {
			int responseID = int.MinValue;
			if(responseText != null) {
				responseID = currentResponses[responseText];
			}

			string dialogue = currentData.dialog;

			foreach(NPC.DialogData data in currentNPC.dialogData) {
				if(responseID == int.MinValue) {
					if(data.dialogID == currentData.nextDialogID) {
						dialogue = data.dialog;
						currentData = data;
						break;
					}
				} else {
					if(data.dialogID == responseID) {
						dialogue = data.dialog;
						currentData = data;
						break;
					}
				}
			}

			List<string>? responses = null;

			foreach(var data in currentNPC.responseData) {
				if(data.Key == currentData.nextDialogID) {
					currentResponses = data.Value;
					responses = data.Value.Keys.ToList();
					break;
				}
			}

			return (dialogue, responses);
		}
	}
}
