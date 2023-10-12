namespace TicTacToe {
	public class Board {
		private BoardSpace[,] board = new BoardSpace[3, 3];

		private enum BoardSpace {
			EMPTY, X, O
		}

		public void DisplayBoard() {
			for(int i = 0; i < board.GetLength(0); i++) {
				for(int j = 0; j < board.GetLength(1); j++) {
					switch(board[i, j]) {
						case BoardSpace.EMPTY:
							Console.Write(' ');
							break;
						case BoardSpace.X:
							Console.Write('X');
							break;
						case BoardSpace.O:
							Console.Write('O');
							break;
					}
					if(j != (board.GetLength(1) - 1)) {
						Console.Write("|");
					}
				}
				if(i != (board.GetLength(0) - 1)) {
					Console.WriteLine("\n-----");
				} else {
					Console.WriteLine("\n");
				}
			}
		}

		public bool PlaceMark(int boardX, int boardY, char charToPlace) {
			if(boardX < 0 || boardX > 2 || boardY < 0 || boardY > 2) {
				return false;
			}
			if(board[boardX, boardY] != BoardSpace.EMPTY) {
				return false;
			}
			if(!(charToPlace == 'X' || charToPlace == 'O')) {
				return false;
			}
			switch(charToPlace) {
				case 'X':
					board[boardX, boardY] = BoardSpace.X;
					break;
				case 'O':
					board[boardX, boardY] = BoardSpace.O;
					break;
			}
			return true;
		}

		public enum Winner {
			NONE, TIE, X, O
		}

		public Winner CheckForWinner() {
			for(int i = 0; i < board.GetLength(0); i++) {
				BoardSpace? currentSpace = null;
				int streak = 0;
				for(int j = 0; j < board.GetLength(1); j++) {
					if(currentSpace == null) {
						currentSpace = board[i, j];
					} else if(currentSpace != board[i, j]) {
						break;
					}
					streak += 1;
				}
				if(streak == 3) {
					switch(currentSpace) {
						case BoardSpace.X:
							return Winner.X;
						case BoardSpace.O:
							return Winner.O;
						default:
							continue;
					}
				}
			}

			for(int i = 0; i < board.GetLength(1); i++) {
				BoardSpace? currentSpace = null;
				int streak = 0;
				for(int j = 0; j < board.GetLength(0); j++) {
					if(currentSpace == null) {
						currentSpace = board[j, i];
					} else if(currentSpace != board[j, i]) {
						break;
					}
					streak += 1;
				}
				if(streak == 3) {
					switch(currentSpace) {
						case BoardSpace.X:
							return Winner.X;
						case BoardSpace.O:
							return Winner.O;
						default:
							continue;
					}
				}
			}

			BoardSpace? diagCurrentSpace = null;
			int diagStreak = 0;
			for(int i = 0, j = 0; i < board.GetLength(0) && j < board.GetLength(1); i++, j++) {
				if(diagCurrentSpace == null) {
					diagCurrentSpace = board[i, j];
				} else if (diagCurrentSpace != board[i, j]) {
					break;
				}
				diagStreak += 1;
			}
			if(diagStreak == 3) {
				switch(diagCurrentSpace) {
					case BoardSpace.X:
						return Winner.X;
					case BoardSpace.O:
						return Winner.O;
					default:
						break;
				}
			}

			diagCurrentSpace = null;
			diagStreak = 0;
			for(int i = 0, j = 2; i < board.GetLength(0) && j >= 0; i++, j--) {
				if(diagCurrentSpace == null) {
					diagCurrentSpace = board[i, j];
				} else if(diagCurrentSpace != board[i, j]) {
					break;
				}
				diagStreak += 1;
			}
			if(diagStreak == 3) {
				switch(diagCurrentSpace) {
					case BoardSpace.X:
						return Winner.X;
					case BoardSpace.O:
						return Winner.O;
					default:
						break;
				}
			}

			return CheckForTie();
		}

		private Winner CheckForTie() {
			int filledSpaces = 0;

			for(int i = 0; i < board.GetLength(0); i++) {
				for(int j = 0; j < board.GetLength(1); j++) {
					if(board[i, j] != BoardSpace.EMPTY) {
						filledSpaces += 1;
					} else {
						return Winner.NONE;
					}
				}
			}

			if(filledSpaces == 9) {
				return Winner.TIE;
			}

			return Winner.NONE;
		}

		public void Clear() {
			for(int i = 0; i < board.GetLength(0); i++) {
				for(int j = 0; j < board.GetLength(1); j++) {
					board[i, j] = BoardSpace.EMPTY;
				}
			}
		}
	}
}