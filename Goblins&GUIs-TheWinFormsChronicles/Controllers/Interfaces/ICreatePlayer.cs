using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinsGUIsTheWinFormsChronicles.Characters;

namespace GoblinsGUIsTheWinFormsChronicles.Controllers {
	public interface ICreatePlayer {
		void CreatePlayer(string name, Characters.Character.ClassType classType, int str, int dex, int con, int inte, int wis, int cha);
	}
}
