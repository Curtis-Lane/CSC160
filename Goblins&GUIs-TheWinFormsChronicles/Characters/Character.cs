using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace GoblinsGUIsTheWinFormsChronicles.Characters {
	internal class Character {
		public readonly string name;
		protected ClassType classType {get;}

		protected int strength {get;}
		protected int dexterity {get;}
		protected int constitution {get;}
		protected int intelligence {get;}
		protected int wisdom {get;}
		protected int charisma {get;}

		protected Dictionary<string, int> attacks {get;}

		public enum ClassType {
			Fighter,
			Wizard
		}

		public Character(string name, ClassType classType, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma) {
			this.name = name;
			this.classType = classType;
			this.strength = SetStat(strength);
			this.dexterity = SetStat(dexterity);
			this.constitution = SetStat(constitution);
			this.intelligence = SetStat(intelligence);
			this.wisdom = SetStat(wisdom);
			this.charisma = SetStat(charisma);

			attacks = new Dictionary<string, int>();

			switch(classType) {
				case ClassType.Fighter:
					attacks["Punch"] = 1;
					attacks["Sword"] = 3;
					break;
				case ClassType.Wizard:
					attacks["Punch"] = 1;
					attacks["Fireball"] = 5;
					break;
				default:
					// AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
					throw new ArgumentException("Class type not recognized");
			}
		}

		private int SetStat(int stat) {
			return Math.Clamp(stat, 1, 20);
		}
	}
}
