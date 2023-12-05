using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinsGUIsGameLogic.Characters;

namespace GoblinsGUIsGameLogic.Controllers {
	public class DialogueSystem : IDialogueManager {
		public static NPC currentNPC;
		public static NPC.DialogData currentData;
		public static Dictionary<string, NPC.ResponseData> currentResponses;

		public static Player player;

		public DialogueSystem(NPC currentDialogueNPC, Player currentPlayer) {
			currentNPC = currentDialogueNPC;
			player = currentPlayer;
			//Application.Run(new Dialogue(this));
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

		public (string dialogue, List<(string response, string checkType, int dc, int playerStat)>? responses) GetNextDialogue(string? responseText = null) {
			int responseID = int.MinValue;
			if(responseText != null) {
				NPC.ResponseData currentResponse = currentResponses[responseText];
				if(currentResponse.checkType == NPC.CheckType.None) {
					responseID = currentResponse.successDialogID;
				} else {
					int playerStat = -1;
					switch(currentResponse.checkType) {
						case NPC.CheckType.Str:
							playerStat = player.Strength;
							break;
						case NPC.CheckType.Dex:
							playerStat = player.Dexterity;
							break;
						case NPC.CheckType.Con:
							playerStat = player.Constitution;
							break;
						case NPC.CheckType.Int:
							playerStat = player.Intelligence;
							break;
						case NPC.CheckType.Wis:
							playerStat = player.Wisdom;
							break;
						case NPC.CheckType.Cha:
							playerStat = player.Charisma;
							break;
					}
					if(playerStat >= currentResponse.dc) {
						responseID = currentResponse.successDialogID;
					} else {
						responseID = currentResponse.failureDialogID;
					}
				}
			}

			string dialogue = currentData.dialog;

			foreach(NPC.DialogData data in currentNPC.dialogData) {
				if(currentData.nextDialogID == -1) {
					return ("-1", new List<(string response, string checkType, int dc, int playerStat)> { });
				}

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

			List<(string response, string checkType, int dc, int playerStat)>? responses = null;

			foreach(var data in currentNPC.responseData) {
				if(data.Key == currentData.nextDialogID) {
					currentResponses = data.Value;
					responses = new List<(string response, string checkType, int dc, int playerStat)>();
					foreach(string response in data.Value.Keys.ToList()) {
						NPC.ResponseData currentResponse = currentResponses[response];
						int playerStat = -1;
						switch(currentResponse.checkType) {
							case NPC.CheckType.Str:
								playerStat = player.Strength;
								break;
							case NPC.CheckType.Dex:
								playerStat = player.Dexterity;
								break;
							case NPC.CheckType.Con:
								playerStat = player.Constitution;
								break;
							case NPC.CheckType.Int:
								playerStat = player.Intelligence;
								break;
							case NPC.CheckType.Wis:
								playerStat = player.Wisdom;
								break;
							case NPC.CheckType.Cha:
								playerStat = player.Charisma;
								break;
						}

						responses.Add((response, currentResponse.checkType.ToString(), currentResponse.dc, playerStat));
					}
					break;
				}
			}

			return (dialogue, responses);
		}
	}
}
