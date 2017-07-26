using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoConsultationsManagement {
	public partial class FormSendUrl : Form {
		public FormSendUrl(string name, string dateTime, string url, string phoneNumber) {
			InitializeComponent();

			textBoxName.Text = name;
			textBoxDateTime.Text = dateTime;
			textBoxUrl.Text = url;
			maskedTextBoxPhoneNumber.Text = phoneNumber;
		}

		private void buttonSend_Click(object sender, EventArgs e) {
			if (!maskedTextBoxPhoneNumber.MaskCompleted) {
				ShowMessageBox("Необходимо указать корректный номер телефона", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Cursor = Cursors.WaitCursor;

			string phoneNumber = maskedTextBoxPhoneNumber.Text;
			string url = textBoxUrl.Text;
			string dateTimeText = textBoxDateTime.Text;

			DateTime dateTime = new DateTime();
			DateTime.TryParse(dateTimeText, out dateTime);

			Thread thread = new Thread(() => {
				string result = "";
				result += SmsSystem.SendInvitation(phoneNumber, url, dateTime);
				result += SmsSystem.SendLinks(phoneNumber, checkBoxIos.Checked, checkBoxAndroid.Checked);

				if (!string.IsNullOrEmpty(result)) {
					ShowMessageBox(result, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
					if (ShowMessageBox("СМС сообщение подготовлено к отправке" + Environment.NewLine +
						"Ожидамое время получения пациентом - 1 минута" + Environment.NewLine + Environment.NewLine +
						"Вернуться к списку консультаций?", "Успешно", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
						== DialogResult.Yes) {
						Invoke((MethodInvoker)delegate {
							Close();
						});
					} else {
						Invoke((MethodInvoker)delegate {
							Cursor = Cursors.Default;
						});
					}
				}
			});
			thread.Start();
		}

		private DialogResult ShowMessageBox(string message, string title, 
			MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None) {
			if (InvokeRequired) {
				return (DialogResult)Invoke(new Func<DialogResult>(() => {
					return ShowMessageBox(message, title, buttons, icon);
				}));
			}

			return MessageBox.Show(this, message, title, buttons, icon);
		}
	}
}
