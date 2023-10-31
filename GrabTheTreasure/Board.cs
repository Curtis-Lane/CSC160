using System;
using System.Collections.Generic;
using System.Linq;

namespace GrabTheTreasure {
	public class Board {
		private char[][] board = new char[13][];
		private char[] wallChars = {'|', '_'};
		private int[] enemyPos = {6, 1};
		private int[] exitPos = {3, 11};
		private int[] treasurePos = {10, 2};
		private bool grabbedTreasure = false;
		/* {
			{' ', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', ' '},
			{'|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'P', 'D'},
			{'|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', 'E', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', ' ', 'O', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|'}
		}; */

		public Board() {
			board[0] = new char[12]  { ' ', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', ' '};
			board[1] = new char[12]  { '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' };
			board[2] = new char[12]  { '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' };
			board[3] = new char[12]  { '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
			board[4] = new char[12]  { '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' };
			board[5] = new char[12]  { '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' };
			board[6] = new char[12]  { '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' };
			board[7] = new char[12]  { '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' };
			board[8] = new char[12]  { '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' };
			board[9] = new char[12]  { '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' };
			board[10] = new char[12] { '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' };
			board[11] = new char[12] { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' };
			board[12] = new char[12] { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|' };
		}

		public void Draw(int[] playerPos) {
			char[][] tempBoard = new char[board.Length][];

			for(int i = 0; i < board.Length; i++) {
				tempBoard[i] = new char[board[i].Length];
				board[i].CopyTo(tempBoard[i], 0);
			}

			tempBoard[exitPos[0]][exitPos[1]] = 'D';
			if(!grabbedTreasure) {
				tempBoard[treasurePos[0]][treasurePos[1]] = 'O';
			}

			tempBoard[playerPos[0]][playerPos[1]] = 'P';
			tempBoard[enemyPos[0]][enemyPos[1]] = 'E';

			//Console.Clear();
			for(int row = 0; row < board.GetLength(0); row++) {
				for(int column = 0; column < board[row].GetLength(0); column++) {
					Console.Write(tempBoard[row][column]);
				}
				Console.Write('\n');
			}
		}

		public bool IsValidMove(int[] newPos) {
			if(newPos[0] < 0 || newPos[0] >= board.Length || newPos[1] < 0 || newPos[1] >= board[0].Length) {
				return false;
			} else if(wallChars.Contains(board[newPos[0]][newPos[1]])) {
				return false;
			}

			return true;
		}

		public void MoveEnemy() {
			int direction = new Random().Next(0, 4);
			switch(direction) {
				// Up
				case 0:
					if(IsValidMove(new int[] {enemyPos[0] - 1, enemyPos[1]})) {
						enemyPos[0] -= 1;
					}
					break;
				// Right
				case 1:
					if(IsValidMove(new int[] {enemyPos[0], enemyPos[1] + 1})) {
						enemyPos[1] += 1;
					}
					break;
				// Down
				case 2:
                    if(IsValidMove(new int[] {enemyPos[0] + 1, enemyPos[1]})) {
                        enemyPos[0] += 1;
                    }
                    break;
				// Left
				case 3:
                    if(IsValidMove(new int[] {enemyPos[0], enemyPos[1] - 1})) {
                        enemyPos[1] -= 1;
                    }
                    break;
			}
		}

		public bool HasEnemyTouchedPlayer(int[] playerPos) {
			if(playerPos[0] == enemyPos[0] && playerPos[1] == enemyPos[1]) {
				return true;
			}

			return false;
		}

		public void HasPlayerGrabbedTreasure(int[] playerPos) {
			if(!grabbedTreasure) {
				if(playerPos[0] == treasurePos[0] && playerPos[1] == treasurePos[1]) {
					grabbedTreasure = true;
				}
			}
		}

		public bool HasPlayerWon(int[] playerPos) {
			if(grabbedTreasure && (playerPos[0] == exitPos[0] && playerPos[1] == exitPos[1])) {
				return true;
			}

			return false;
		}
	}
}
