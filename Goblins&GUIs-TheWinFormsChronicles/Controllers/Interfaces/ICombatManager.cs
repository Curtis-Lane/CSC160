using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinsGUIsTheWinFormsChronicles.UI;
using GoblinsGUIsTheWinFormsChronicles.Characters;

namespace GoblinsGUIsTheWinFormsChronicles.Controllers {
	public interface ICombatManager {
		public static Player player;
		public static NPC enemy;

		(UI.Character player, UI.Character enemy) GetCombatants();

		List<string> GetPlayerAttacks();

		int PlayerAttack(string attack);

		(int health, string attack) EnemyAttack();

		bool IsThereAVictor();

		bool IsThePlayerTheVictor();
	}
}
