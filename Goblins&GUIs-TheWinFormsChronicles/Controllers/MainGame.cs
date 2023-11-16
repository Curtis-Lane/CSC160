using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GoblinsGUIsTheWinFormsChronicles.Characters;
//using GoblinsGUIsTheWinFormsChronicles.UI;

namespace GoblinsGUIsTheWinFormsChronicles.Controllers {
	internal class MainGame {
		static Player? player = null;

		public void Run() {
			while(player == null) {
				Application.Run(new UI.CharacterCreation());
			}

			//
		}

		public static void CreatePlayer(string name, Characters.Character.ClassType classType, int str, int dex, int con, int inte, int wis, int cha) {
			player = new Player(name, classType, str, dex, con, inte, wis, cha);
		}
	}
}
