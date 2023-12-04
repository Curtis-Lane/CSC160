using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinsGUIsGameLogic.Characters;

namespace GoblinsGUIsGameLogic.Controllers {
	public interface IDialogueManager {
		public static NPC currentNPC;
		public static NPC.DialogData currentData;
		public static Dictionary<string, int> currentResponses;

		/// <summary>
		/// Returns a tuple that contains, in order, the name of the NPC and the dialogue of the NPC
		/// </summary>
		/// <returns></returns>
		static abstract (string name, string dialogue) GetFirstDialogue();

		/// <summary>
		/// Returns a tuple that contains, in order, the dialogue of the NPC and any potential repsonses that the player might be able to use,
		/// optionally taking in a string that represents what response the player has selected
		/// 
		/// Also returns any relevant information regarding skill checks for the current responses
		/// </summary>
		/// <returns></returns>
		static abstract (string dialogue, List<(string response, string checkType, int dc, int playerStat)>? responses) GetNextDialogue(string? responseText = null);
	}
}
