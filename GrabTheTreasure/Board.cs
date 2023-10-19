using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace GrabTheTreasure {
	public class Board {
		private char[][] board = new char[12][]; /* {
			{' ', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', ' '},
			{'|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'P', 'E'},
			{'|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
			{'|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|'}
		}; */

		public Board() {
			board[0] = new char[12]  { ' ', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', ' '};
			board[1] = new char[12]  { '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' };
			board[2] = new char[12]  { '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' };
			board[3] = new char[12]  { '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'E' };
			board[4] = new char[12]  { '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' };
			board[5] = new char[12]  { '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' };
			board[6] = new char[12]  { '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' };
			board[7] = new char[12]  { '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' };
			board[8] = new char[12]  { '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' };
			board[9] = new char[12]  { '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' };
			board[10] = new char[12] { '|', ' ', 'O', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|' };
			board[11] = new char[12] { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|' };
		}

		public void Draw(int[] playerPos) {
			// Going to have to get the pos of entities, unless I store them here
			char[][] tempBoard = new char[12][];// = board;

			for(int i = 0; i < board.GetLength(0); i++) {
				tempBoard[i] = new char[12];
				board[i].CopyTo(tempBoard[i], 0);
			}

			tempBoard[playerPos[0]][playerPos[1]] = 'P';

			Console.Clear();
			for(int row = 0; row < board.GetLength(0); row++) {
				for(int column = 0; column < board[row].GetLength(0); column++) {
					Console.Write(tempBoard[row][column]);
				}
				Console.Write('\n');
			}
		}

		public bool IsValidMove(int[] newPlayerPos) {
			if(board[newPlayerPos[0]][newPlayerPos[1]] == '|' || board[newPlayerPos[0]][newPlayerPos[1]] == '_') {
				return false;
			}

			return true;
		}
	}
}
