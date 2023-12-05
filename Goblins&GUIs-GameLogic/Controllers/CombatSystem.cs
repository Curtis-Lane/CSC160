using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoblinsGUIsGameLogic.Characters;
using GoblinsGUIsGameLogic.UI.Models;

namespace GoblinsGUIsGameLogic.Controllers {
	public class CombatSystem : ICombatManager {
		public static Player player;
		public static NPC enemy;

		private bool gameWon;
		private bool playerWon;

		public CombatSystem(Characters.Player currentPlayer, Characters.NPC currentEnemy) {
			player = currentPlayer;
			enemy = currentEnemy;

			//Application.Run(new Combat(this));
		}

		public (UI.Models.Character player, UI.Models.Character enemy) GetCombatants() {
			return (CharacterToUI(player), CharacterToUI(enemy));
		}

		public List<string> GetPlayerAttacks() {
			return player.attacks.Keys.ToList();
		}

		private int Attack(string attack, bool isPlayerAttack) {
			Characters.Character dealer;
			Characters.Character reciever;
			if(isPlayerAttack) {
				dealer = player;
				reciever = enemy;
			} else {
				dealer = enemy;
				reciever = player;
			}

			int characterStat;
			switch(dealer.attacks[attack].type) {
				case Characters.Character.CheckType.Str:
					characterStat = dealer.Strength;
					break;
				case Characters.Character.CheckType.Dex:
					characterStat = dealer.Dexterity;
					break;
				case Characters.Character.CheckType.Con:
					characterStat = dealer.Constitution;
					break;
				case Characters.Character.CheckType.Int:
					characterStat = dealer.Intelligence;
					break;
				case Characters.Character.CheckType.Wis:
					characterStat = dealer.Wisdom;
					break;
				case Characters.Character.CheckType.Cha:
					characterStat = dealer.Charisma;
					break;
				default:
					characterStat = 10;
					break;
			}

			float damage = dealer.attacks[attack].damage * (characterStat * 0.1f);

			reciever.Health -= (int) (damage * (1 - (reciever.Constitution * 0.025f)));

			return reciever.Health;
		}

		public int PlayerAttack(string attack) {
			return Attack(attack, true);
		}

		public (int health, string attack) EnemyAttack() {
			Random random = new Random();
			string attack = enemy.attacks.Keys.ToList().ElementAt(random.Next(0, enemy.attacks.Count));

			return (Attack(attack, false), attack);
		}

		private UI.Models.Character CharacterToUI(Characters.Character characterToConvert) {
			UI.Models.Character character = new UI.Models.Character();

			character.Name = characterToConvert.name;
			character.Classtype = characterToConvert.classType.ToString();

			character.Health = characterToConvert.Health;
			character.Strength = characterToConvert.Strength;
			character.Dexterity = characterToConvert.Dexterity;
			character.Constitution = characterToConvert.Constitution;
			character.Intelligence = characterToConvert.Intelligence;
			character.Wisdom = characterToConvert.Wisdom;
			character.Charisma = characterToConvert.Charisma;

			return character;
		}

		public bool IsThereAVictor() {
			gameWon = (player.Health == 0 || enemy.Health == 0);
			return gameWon;
		}

		public bool IsThePlayerTheVictor() {
			playerWon = (enemy.Health == 0);
			return playerWon;
		}
	}
}
