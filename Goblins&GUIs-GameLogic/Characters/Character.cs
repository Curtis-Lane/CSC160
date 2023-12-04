using System;
using System.Collections.Generic;

namespace GoblinsGUIsGameLogic.Characters {
	public class Character {
		public readonly string name;
		public ClassType classType {get;}

		private readonly int max_health;
		private int health;

		private int strength;
		private int dexterity;
		private int constitution;
		private int intelligence;
		private int wisdom;
		private int charisma;

		public int Health {
			get {
				return health;
			}
			set {
				health = SetHealth(value);
			}
		}
		public int Strength {
			get {
				return strength;
			} set {
				strength = SetStat(value);
			}
		}
		public int Dexterity {
			get {
				return dexterity;
			}
			set {
				dexterity = SetStat(value);
			}
		}
		public int Constitution {
			get {
				return constitution;
			}
			set {
				constitution = SetStat(value);
			}
		}
		public int Intelligence {
			get {
				return intelligence;
			}
			set {
				intelligence = SetStat(value);
			}
		}
		public int Wisdom {
			get {
				return wisdom;
			}
			set {
				wisdom = SetStat(value);
			}
		}
		public int Charisma {
			get {
				return charisma;
			}
			set {
				charisma = SetStat(value);
			}
		}

		public Dictionary<string, (int damage, CheckType type)> attacks {get;}

		public enum ClassType {
			Fighter,
			Wizard
		}

		public enum CheckType {
			None,
			Str,
			Dex,
			Con,
			Int,
			Wis,
			Cha
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

			attacks = new Dictionary<string, (int damage, CheckType type)>();

			switch(classType) {
				case ClassType.Fighter:
					attacks["Punch"] = (2, CheckType.Str);
					attacks["Sword"] = (5, CheckType.Str);
					max_health = 50;
					break;
				case ClassType.Wizard:
					attacks["Punch"] = (2, CheckType.Str);
					attacks["Fireball"] = (8, CheckType.Int);
					max_health = 30;
					break;
				default:
					// AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
					throw new ArgumentException("Class type not recognized");
			}

			this.health = max_health;
		}

		private int SetStat(int stat) {
			return Math.Clamp(stat, 1, 20);
		}

		private int SetHealth(int health) {
			return Math.Max(0, health);
		}
	}
}
