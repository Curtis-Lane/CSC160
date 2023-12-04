using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinsGUIsGameLogic.UI.Models;
using GoblinsGUIsGameLogic.Characters;

namespace GoblinsGUIsGameLogic.Controllers {
	public interface ICombatManager {
		public static Player player;
		public static NPC enemy;

		static abstract (UI.Models.Character player, UI.Models.Character enemy) GetCombatants();

		static abstract List<string> GetPlayerAttacks();

		static abstract int PlayerAttack(string attack);

		static abstract (int health, string attack) EnemyAttack();

		static abstract bool IsThereAVictor();

		static abstract bool IsThePlayerTheVictor();
	}
}
