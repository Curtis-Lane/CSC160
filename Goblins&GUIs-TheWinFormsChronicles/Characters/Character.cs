using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace GoblinsGUIsTheWinFormsChronicles.Characters {
	internal class Character {
		public readonly string name;
		public ClassType classType {get;}

		public int strength {get => strength; set => SetStat(value);}
		public int dexterity {get => dexterity; set => SetStat(value);}
		public int constitution {get => constitution; set => SetStat(value);}
		public int intelligence {get => intelligence; set => SetStat(value);}
		public int wisdom {get => wisdom; set => SetStat(value);}
		public int charisma {get => charisma; set => SetStat(value);}

		public Dictionary<string, int> attacks {get;}

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
