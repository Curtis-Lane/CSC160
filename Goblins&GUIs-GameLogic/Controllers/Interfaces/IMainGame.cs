using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinsGUIsGameLogic.Characters;

namespace GoblinsGUIsGameLogic.Controllers {
	public interface IMainGame {
		void CreatePlayer(string name, Characters.Character.ClassType classType, int str, int dex, int con, int inte, int wis, int cha);

		Player GetPlayer();

		NPC GetNarrator();

		NPC GetBandit();
	}
}
