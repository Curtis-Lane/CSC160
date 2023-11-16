using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsGUIsTheWinFormsChronicles.UI {
	internal class Character : INotifyPropertyChanged {
		public event PropertyChangedEventHandler? PropertyChanged;

		private string name;
		private ClassType classType;

		public string Name {
			get {
				return name;
			} set {
				name = value;
				NotifyPropertyChanged();
			}
		}
		public string Classtype {
			get {
				return classType.ToString();
			} set {
				classType = StringToClass(value);
				NotifyPropertyChanged();
			}
		}

		private int strength;
		private int dexterity;
		private int constitution;
		private int intelligence;
		private int wisdom;
		private int charisma;

		public int Strength {
			get {
				return this.strength;
			} set {
				this.strength = SetStat(value);
				NotifyPropertyChanged();
			}
		}
		public int Dexterity {
			get {
				return this.dexterity;
			}
			set {
				this.dexterity = SetStat(value);
				NotifyPropertyChanged();
			}
		}
		public int Constitution {
			get {
				return this.constitution;
			}
			set {
				this.constitution = SetStat(value);
				NotifyPropertyChanged();
			}
		}
		public int Intelligence {
			get {
				return this.intelligence;
			}
			set {
				this.intelligence = SetStat(value);
				NotifyPropertyChanged();
			}
		}
		public int Wisdom {
			get {
				return this.wisdom;
			}
			set {
				this.wisdom = SetStat(value);
				NotifyPropertyChanged();
			}
		}
		public int Charisma {
			get {
				return this.charisma;
			}
			set {
				this.charisma = SetStat(value);
				NotifyPropertyChanged();
			}
		}

		public enum ClassType {
			Fighter,
			Wizard
		}

		public Character() {
			name = "";

			strength = 1;
			dexterity = 1;
			constitution = 1;
			intelligence = 1;
			wisdom = 1;
			charisma = 1;
		}

		private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
			if(PropertyChanged != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private int SetStat(int stat) {
			return Math.Clamp(stat, 1, 20);
		}

		public ClassType StringToClass(string str) {
			switch(str) {
				case "Fighter":
					return ClassType.Fighter;
				default:
					return ClassType.Wizard;
			}
		}
	}
}
