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

		public SafeForm() {
			InitializeComponent();
			InitializeMembers();
		}

		private void InitializeMembers() {
			codeParts = new TextBox[3] { codePart1, codePart2, codePart3 };

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

			guessStatusLabel.Text = "";
			cheatCodeLabel.Text = "";
		}

		private enum GuessStatus {
			NOT_CLOSE,
			CLOSE,
			CORRECT
		}

		private GuessStatus Guess() {
			StringBuilder code = new StringBuilder(codeParts.Length);

			foreach(TextBox codePart in codeParts) {
				if(codePart.Text == "") {
					code.Append(' ');
				}
				code.Append(codePart.Text);
			}

			int correctChars = 0;
			for(int i = 0; i < codeParts.Length; i++) {
				if(code[i] == safeCode[i]) {
					correctChars += 1;
				}
			}

			switch(correctChars) {
				case 0:
				case 1:
					return GuessStatus.NOT_CLOSE;
				case 2:
					return GuessStatus.CLOSE;
				default:
					return GuessStatus.CORRECT;
			}
		}

		private void codePart_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				switch(Guess()) {
					case GuessStatus.NOT_CLOSE:
						guessStatusLabel.Text = "That was not close at all.";
						break;
					case GuessStatus.CLOSE:
						guessStatusLabel.Text = "You're getting closer!";
						break;
					case GuessStatus.CORRECT:
						guessStatusLabel.Text = "You've cracked the safe!";
						break;
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
	}
}
