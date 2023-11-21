using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoblinsGUIsTheWinFormsChronicles.UI {
	public partial class Dialogue : Form {
		static NPC currentNPC;
		static NPC.DialogData currentData;
		static Dictionary<string, int> currentResponses;

		public Dialogue(NPC currentDialogueNPC) {
			InitializeComponent();
			currentNPC = currentDialogueNPC;
			StartDialogue();
		}

		private void StartDialogue() {
			dialogueBox.Text = currentNPC.Name;
			foreach(NPC.DialogData data in currentNPC.dialogData) {
				if(data.dialogID == 0) {
					dialogueText.Text = data.dialog;
					currentData = data;
					break;
				}
			}
		}

		private void GoToNextDialogue(int dialogID = int.MinValue) {
			foreach(NPC.DialogData data in currentNPC.dialogData) {
				if(dialogID == int.MinValue) {
					if(data.dialogID == currentData.nextDialogID) {
						dialogueText.Text = data.dialog;
						currentData = data;
						return;
					}
				} else {
					if(data.dialogID == dialogID) {
						dialogueText.Text = data.dialog;
						currentData = data;
						return;
					}
				}
			}
			foreach(var data in currentNPC.responseData) {
				if(dialogID == int.MinValue) {
					if(data.Key == currentData.nextDialogID) {
						currentResponses = data.Value;
						int numResponse = 0;
						foreach(var response in data.Value) {
							Button responseButton = new Button();
							responseButton.Location = new Point(6, 77 + (40 * numResponse));
							responseButton.Text = response.Key;
							responseButton.Size = new Size(490, 40);
							responseButton.Click += responseButton_Click;

							dialogueBox.Controls.Add(responseButton);

							numResponse += 1;
						}
						return;
					}
				} else {
					if(data.Key == dialogID) {
						currentResponses = data.Value;
						int numResponse = 0;
						foreach(var response in data.Value) {
							Button responseButton = new Button();
							responseButton.Location = new Point(6, 77 + (40 * numResponse));
							responseButton.Text = response.Key;
							responseButton.Size = new Size(490, 40);
							responseButton.Click += responseButton_Click;

							dialogueBox.Controls.Add(responseButton);

							numResponse += 1;
						}
						return;
					}
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
			GoToNextDialogue(currentResponses[((Button) sender).Text]);
		}
	}
}
