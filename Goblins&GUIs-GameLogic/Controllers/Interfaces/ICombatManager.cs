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

		(UI.Models.Character player, UI.Models.Character enemy) GetCombatants();

		List<string> GetPlayerAttacks();

		int PlayerAttack(string attack);

		(int health, string attack) EnemyAttack();

		bool IsThereAVictor();

		bool IsThePlayerTheVictor();
	}
}
