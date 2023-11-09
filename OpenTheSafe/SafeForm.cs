using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTheSafe {
	public partial class SafeForm : Form {
		private TextBox[] codeParts;
		private string safeCode;

		private const int MAX_NUM_GUESSES = 5;
		private int currentNumGuesses = 0;

		private Bitmap CLOSED_SAFE_IMAGE = new Bitmap("../../../Images/closed.png");
		private Bitmap ALMOST_OPEN_SAFE_IMAGE = new Bitmap("../../../Images/almost-open.png");
		private Bitmap OPEN_SAFE_IMAGE = new Bitmap("../../../Images/open.png");

		public SafeForm() {
			InitializeComponent();
			InitializeMembers();
		}

		private void InitializeMembers() {
			codeParts = new TextBox[3] {codePart1, codePart2, codePart3};

			Reset();
		}

		private void Reset() {
			foreach(TextBox codePart in codeParts) {
				codePart.Text = "";
			}

			safeCode = "";

			for(int i = 0; i < codeParts.Length; i++) {
				safeCode += new Random().Next(0, 10);
			}

			currentNumGuesses = 0;

			guessStatusLabel.Text = "";
			cheatCodeLabel.Text = "";
			currentGuessesLabel.Text = "Current Guesses: 0";
			maxGuessesLabel.Text = "Max Guesses: " + MAX_NUM_GUESSES.ToString();

			safePictureBox.Image = CLOSED_SAFE_IMAGE;

			guessLog.Items.Clear();
		}

		private enum GuessStatus {
			NOT_CLOSE,
			CLOSE,
			CORRECT
		}

		private GuessStatus Guess() {
			StringBuilder code = new StringBuilder(codeParts.Length);

			currentNumGuesses += 1;
			currentGuessesLabel.Text = "Current Guesses: " + currentNumGuesses.ToString();

			foreach(TextBox codePart in codeParts) {
				if(codePart.Text == "") {
					code.Append(' ');
				} else {
					code.Append(codePart.Text);
				}
			}

			int correctChars = 0;
			for(int i = 0; i < codeParts.Length; i++) {
				if(code[i] == safeCode[i]) {
					correctChars += 1;
				}
			}

			if(guessLog.Items.Count == 2) {
				guessLog.Items.RemoveAt(0);
			}

			switch(correctChars) {
				case 0:
				case 1:
					guessLog.Items.Add(code.ToString() + " Was not close");
					return GuessStatus.NOT_CLOSE;
				case 2:
					guessLog.Items.Add(code.ToString() + " Was close");
					return GuessStatus.CLOSE;
				default:
					guessLog.Items.Add(code.ToString() + " Was correct");
					return GuessStatus.CORRECT;
			}
		}

		private void codePart_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter && currentNumGuesses != MAX_NUM_GUESSES && safePictureBox.Image != OPEN_SAFE_IMAGE) {
				switch(Guess()) {
					case GuessStatus.NOT_CLOSE:
						guessStatusLabel.Text = "That was not close at all.";
						safePictureBox.Image = CLOSED_SAFE_IMAGE;
						break;
					case GuessStatus.CLOSE:
						guessStatusLabel.Text = "You're getting closer!";
						safePictureBox.Image = ALMOST_OPEN_SAFE_IMAGE;
						break;
					case GuessStatus.CORRECT:
						guessStatusLabel.Text = "You've cracked the safe! You Win!";
						safePictureBox.Image = OPEN_SAFE_IMAGE;
						break;
				}

				if(currentNumGuesses == MAX_NUM_GUESSES && safePictureBox.Image != OPEN_SAFE_IMAGE) {
					guessStatusLabel.Text = "The safe's set off an alarm! You lost.";
				}
			}
		}

		private void codePart_KeyPress(object sender, KeyPressEventArgs e) {
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
				e.Handled = true;
			}

			if(((TextBox) sender).Text.Length >= 1 && !char.IsControl(e.KeyChar)) {
				e.Handled = true;
			}
		}

		private void exitButton_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void cheatButton_Click(object sender, EventArgs e) {
			cheatCodeLabel.Text = safeCode;
		}

		private void resetButton_Click(object sender, EventArgs e) {
			Reset();
		}

		private void guessButton_Click(object sender, EventArgs e) {
			codePart_KeyDown(sender, new KeyEventArgs(Keys.Enter));
		}
	}
}
