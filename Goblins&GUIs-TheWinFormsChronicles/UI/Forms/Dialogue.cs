using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoblinsGUIsTheWinFormsChronicles.Controllers;

namespace GoblinsGUIsTheWinFormsChronicles.UI {
	public partial class Dialogue : Form {
		private IDialogueManager dialogueManager;

		public Dialogue(IDialogueManager dialogueManager) {
			InitializeComponent();
			this.dialogueManager = dialogueManager;
			StartDialogue();
		}

		private void StartDialogue() {
			var data = dialogueManager.GetFirstDialogue();
			dialogueBox.Text = data.name;
			dialogueText.Text = data.dialogue;
		}

		private void GoToNextDialogue(string? responseText = null) {
			var data = dialogueManager.GetNextDialogue(responseText);

			if(data.dialogue == "-1") {
				Close();
				return;
			}

			dialogueText.Text = data.dialogue;
			if(data.responses != null) {
				int numResponse = 0;
				foreach(var response in data.responses) {
					Button responseButton = new Button();
					responseButton.Location = new Point(6, 77 + (40 * numResponse));
					responseButton.Size = new Size(490, 40);
					responseButton.Click += responseButton_Click;
					responseButton.TabIndex = numResponse + 1;

					if(response.checkType == "None") {
						responseButton.Text = response.response;
					} else {
						responseButton.Text = "(" + response.checkType + " " + response.playerStat.ToString() + "/" + response.dc.ToString() + ") " + response.response;
					}

					dialogueBox.Controls.Add(responseButton);

					numResponse += 1;
				}
			}
		}

		private void dialogueText_Click(object sender, EventArgs e) {
			GoToNextDialogue();
		}

		private void responseButton_Click(object sender, EventArgs e) {
			IEnumerable<Button> buttons = dialogueBox.Controls.OfType<Button>();
			for(int i = buttons.Count(); i > 0; i--) {
				dialogueBox.Controls.Remove(buttons.ElementAt(i - 1));
			}

			string[] responseText = ((Button) sender).Text.Split(')');
			if(responseText.Length == 1) {
				GoToNextDialogue(responseText[0]);
			} else {
				GoToNextDialogue(responseText[1].Trim());
			}
		}
	}
}
