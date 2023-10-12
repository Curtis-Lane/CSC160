using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe {
	class Program {
		static void Main(string[] args) {
			Board board = new Board();

			string[] players = new string[2];

			for(int i = 0; i < players.Length; i++) {
				Console.WriteLine("Please enter your name.");
				
				string? playerName = Console.ReadLine();

				if(playerName == null || playerName == "") {
					Console.WriteLine("Names cannot be null or empty!" + "\n");
					i -= 1;
					continue;
				} else if(players.Contains(playerName)) {
					Console.WriteLine("Names must be unique per player!" + "\n");
					i -= 1;
					continue;
				}

				Console.Write("\n");

				players[i] = playerName;
			}

			bool player1Turn = true;
			while(true) {
				board.DisplayBoard();

				int markX = 0, markY = 0;
				while(true) {
					Console.WriteLine("Please enter where you want to place your mark, " + ((player1Turn) ? players[0] : players[1]));
					string? x = Console.ReadLine();
					string? y = Console.ReadLine();
					try {
						markX = int.Parse(x) - 1;
						markY = int.Parse(y) - 1;
					} catch {
						Console.WriteLine("\n" + "Please enter a number" + "\n");
						continue;
					}

					bool valid;
					if(player1Turn) {
						valid = board.PlaceMark(markX, markY, 'X');
					} else {
						valid = board.PlaceMark(markX, markY, 'O');
					}

					if(!valid) {
						Console.WriteLine("\n" + "Please enter a valid location" + "\n");
					} else {
						Console.Write("\n");
						break;
					}
				}

				Board.Winner checkWinner = board.CheckForWinner();
				if(checkWinner != Board.Winner.NONE) {
					break;
				}

				player1Turn = !player1Turn;
			}

			board.DisplayBoard();

			Board.Winner winner = board.CheckForWinner();
			if(winner != Board.Winner.TIE) {
				switch(winner) {
					case Board.Winner.X:
						Console.WriteLine("Congratulations " + players[0] + ", you won the game!");
						break;
					case Board.Winner.O:
						Console.WriteLine("Congratulations " + players[1] + ", you won the game!");
						break;
				}
			} else {
				Console.WriteLine("This game was a cat's game.");
			}
		}
	}
}