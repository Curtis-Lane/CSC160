using System;
using System.Threading;

namespace GrabTheTreasure {
	class Program {
		static void Main(string[] args) {
			Console.Title = "Grab the Treasure!";

			Board board = new Board();
			int[] playerPos = new int[2] {3, 10};

			bool done = false;
			while(!done) {
				board.Draw(playerPos);
				if(Console.KeyAvailable) {
					ConsoleKeyInfo key = Console.ReadKey(true);

					switch(key.Key) {
						case ConsoleKey.LeftArrow:
							//Console.WriteLine("Left");
							if(board.IsValidMove(new int[2] {playerPos[0], playerPos[1] - 1})) {
								playerPos[1] -= 1;
							}
							break;
						case ConsoleKey.RightArrow:
							//Console.WriteLine("Right");
							if(board.IsValidMove(new int[2] {playerPos[0], playerPos[1] + 1})) {
								playerPos[1] += 1;
							}
							break;
						case ConsoleKey.UpArrow:
							//Console.WriteLine("Up");
							if(board.IsValidMove(new int[2] {playerPos[0] - 1, playerPos[1]})) {
								playerPos[0] -= 1;
							}
							break;
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

				if(!done) {
					Thread.Sleep(750);
				}
			}
		}
	}
}