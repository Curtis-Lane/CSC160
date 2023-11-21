using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace GoblinsGUIsTheWinFormsChronicles.Characters {
	public class Character {
		public readonly string name;
		public ClassType classType {get;}

		private int strength;
		private int dexterity;
		private int constitution;
		private int intelligence;
		private int wisdom;
		private int charisma;

		public int Strength {get => strength; set => SetStat(value);}
		public int Dexterity {get => dexterity; set => SetStat(value);}
		public int Constitution {get => constitution; set => SetStat(value);}
		public int Intelligence {get => intelligence; set => SetStat(value);}
		public int Wisdom {get => wisdom; set => SetStat(value);}
		public int Charisma {get => charisma; set => SetStat(value);}

		public Dictionary<string, int> attacks {get;}

		public enum ClassType {
			Fighter,
			Wizard
		}

		public Character(string name, ClassType classType, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma) {
			this.name = name;
			this.classType = classType;
			this.Strength = strength;
			this.Dexterity = dexterity;
			this.Constitution = constitution;
			this.Intelligence = intelligence;
			this.Wisdom = wisdom;
			this.Charisma = charisma;

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
