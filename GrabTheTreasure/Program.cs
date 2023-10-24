using System;
using System.Threading;

namespace GrabTheTreasure {
	class Program {
		static void Main(string[] args) {
			Console.Title = "Grab the Treasure!";

			Board board = new Board();

			string exitState = "";

			int[] playerPos = new int[2] {3, 11};
			string? playerName = null;

			Console.WriteLine("What is your name, mighty adventurer?");
			bool valid = false;
			while(!valid) {
				playerName = Console.ReadLine();
				if(playerName == null || playerName == "") {
					Console.WriteLine("\n" + "Please enter a valid name!");
				} else {
					valid = true;
				}
			}
			Console.WriteLine("\n" + "Welcome adventurer " + playerName + ", you must grab the treasure and get out as fast as you can!" + "\n");

			bool done = false;
			while(!done) {
				if(Console.KeyAvailable) {
					ConsoleKeyInfo key = Console.ReadKey(true);

					switch(key.Key) {
						case ConsoleKey.A:
						case ConsoleKey.LeftArrow:
							//Console.WriteLine("Left");
							if(board.IsValidMove(new int[2] {playerPos[0], playerPos[1] - 1})) {
								playerPos[1] -= 1;
							}
							break;
						case ConsoleKey.D:
						case ConsoleKey.RightArrow:
							//Console.WriteLine("Right");
							if(board.IsValidMove(new int[2] {playerPos[0], playerPos[1] + 1})) {
								playerPos[1] += 1;
							}
							break;
						case ConsoleKey.W:
						case ConsoleKey.UpArrow:
							//Console.WriteLine("Up");
							if(board.IsValidMove(new int[2] {playerPos[0] - 1, playerPos[1]})) {
								playerPos[0] -= 1;
							}
							break;
						case ConsoleKey.S:
						case ConsoleKey.DownArrow:
							//Console.WriteLine("Down");
							if(board.IsValidMove(new int[2] {playerPos[0] + 1, playerPos[1]})) {
								playerPos[0] += 1;
							}
							break;
						case ConsoleKey.Escape:
							done = true;
							break;
						default:
							break;
					}
				}
				board.HasPlayerGrabbedTreasure(playerPos);
				board.MoveEnemy();
				board.Draw(playerPos);

				if(board.HasEnemyTouchedPlayer(playerPos)) {
					done = true;
					exitState = "Unfortunately adventurer " + playerName + ", you have fallen in battle.";
				} else if(board.HasPlayerWon(playerPos)) {
					done = true;
					exitState = "Great job adventurer " + playerName + ", you have collected the treasure and escaped successfully!";
				}

				if(!done) {
					Thread.Sleep(750);
				}
			}
			Console.WriteLine("\n" + exitState);
		}
	}
}