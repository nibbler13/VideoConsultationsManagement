using System;
using System.DirectoryServices.AccountManagement;
using System.Threading;
using System.Windows.Forms;

namespace VideoConsultationsManagement {
	public partial class FormCreate : Form {
		private TrueConf trueConf = new TrueConf();
		private Webinar webinar = new Webinar();

		public FormCreate() {
			InitializeComponent();

			trackBarHours.Value = DateTime.Now.Hour;
			trackBarMinutes.Value = DateTime.Now.Minute;
			dateTimePicker.Value = DateTime.Now;
		}

		private void dateTimePicker_ValueChanged(object sender, EventArgs e) {
			trackBarHours.Value = dateTimePicker.Value.Hour;
			trackBarMinutes.Value = dateTimePicker.Value.Minute;
			CheckNowButtonState();
		}

		private void CheckNowButtonState() {
			buttonNow.Enabled = !(DateTime.Now.Hour == dateTimePicker.Value.Hour &&
								  DateTime.Now.Minute == dateTimePicker.Value.Minute);
		}


		private void trackBarHours_Scroll(object sender, EventArgs e) {
			dateTimePicker.Value = new DateTime(
				dateTimePicker.Value.Year,
				dateTimePicker.Value.Month,
				dateTimePicker.Value.Day,
				trackBarHours.Value,
				dateTimePicker.Value.Minute,
				dateTimePicker.Value.Second);
		}

		private void trackBarMinutes_Scroll(object sender, EventArgs e) {
			dateTimePicker.Value = new DateTime(
				dateTimePicker.Value.Year,
				dateTimePicker.Value.Month,
				dateTimePicker.Value.Day,
				dateTimePicker.Value.Hour,
				trackBarMinutes.Value,
				dateTimePicker.Value.Second);
		}


		private void buttonCreate_Click(object sender, EventArgs e) {
			string errorMessage = "";

			if (string.IsNullOrEmpty(textBoxHistoryID.Text))
				errorMessage += "-" + labelHistoryID.Text.Replace(":", "") + Environment.NewLine;

			if (string.IsNullOrEmpty(textBoxName.Text))
				errorMessage += "-" + labelName.Text.Replace(":", "") + Environment.NewLine;

			if (!maskedTextBoxPhone.MaskFull)
				errorMessage += "-" + labelPhone.Text.Replace(":", "") + Environment.NewLine;

			if (string.IsNullOrEmpty(comboBoxOwner.Text))
				errorMessage += "-" + labelOwner.Text.Replace(":", "") + Environment.NewLine;

			if (!string.IsNullOrEmpty(errorMessage)) {
				errorMessage = "Необходимо заполнить следующие поля:" + Environment.NewLine +
					errorMessage;
				ShowMessageBox(errorMessage, "Не хватает данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Cursor = Cursors.WaitCursor;

			string topic = textBoxHistoryID.Text + " " + textBoxName.Text + " " + maskedTextBoxPhone.Text;
			string comboText = comboBoxOwner.Text;
			int ownerStart = comboText.IndexOf("(");
			string owner = comboText.Substring(ownerStart + 1, comboText.Length - ownerStart - 2);
			DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			long unixDateTime = (long)(GetSelectedDateTime().ToUniversalTime() - epoch).TotalSeconds;
			string timestamp = unixDateTime.ToString();

			Thread thread = new Thread(() => CreateWebinar(topic, owner, timestamp));
			thread.Start();
		}

		private void buttonNow_Click(object sender, EventArgs e) {
			dateTimePicker.Value = DateTime.Now;
		}

		private void buttonCopy_Click(object sender, EventArgs e) {
			string link = @"\c\" + webinar.id;
			Clipboard.SetText(link);
			ShowMessageBox("Ссылка скопирована, теперь ее можно вставить в МИС Инфоклиника", "Успешно");
		}

		private void buttonSend_Click(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;

			string phoneNumber = maskedTextBoxPhone.Text;
			string url = textBoxURL.Text;

			Thread thread = new Thread(() => {
				string result = "";
				result += SmsSystem.SendInvitation(phoneNumber, url, GetSelectedDateTime());
				result += SmsSystem.SendLinks(phoneNumber, checkBoxIos.Checked, checkBoxAndroid.Checked);

				if (!string.IsNullOrEmpty(result)) {
					ShowMessageBox(result, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
					ShowMessageBox("СМС сообщение подготовлено к отправке" + Environment.NewLine +
						"Ожидамое время получения пациентом - 1 минута", "Успешно");
				}

				Invoke((MethodInvoker)delegate {
					Cursor = Cursors.Default;
				});
			});
			thread.Start();
		}

		private void buttonClear_Click(object sender, EventArgs e) {
			if (ShowMessageBox("Вернуть форму к начальному состоянию?", "Сброс",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				return;

			textBoxHistoryID.Text = "";
			textBoxName.Text = "";
			maskedTextBoxPhone.Text = "";
			comboBoxOwner.Text = "";
			monthCalendar.SelectionStart = DateTime.Now;
			dateTimePicker.Value = DateTime.Now;

			labelURL.Enabled = false;
			textBoxURL.Text = "";
			textBoxURL.Enabled = false;
			buttonCopy.Enabled = false;
			checkBoxIos.Checked = true;
			checkBoxAndroid.Checked = true;
			groupBoxLinks.Enabled = false;
		}


		private void textBoxHistoryID_KeyPress(object sender, KeyPressEventArgs e) {
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
				e.Handled = true;
		}

		private void CreateWebinar(string topic, string owner, string timestamp) {
			try {
				webinar = trueConf.CreateNewWebinar(topic, owner, timestamp).Result;
				UpdateURLControls(webinar.url);
			} catch (Exception exception) {
				ShowMessageBox(exception.Message + Environment.NewLine + exception.StackTrace,
					"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			Invoke((MethodInvoker)delegate {
				Cursor = Cursors.Default;
			});
		}

		private void UpdateURLControls(string url) {
			if (InvokeRequired) {
				Invoke(new Action<string>(UpdateURLControls), new object[] { url });
				return;
			}

			textBoxURL.Enabled = true;
			textBoxURL.Text = url;
			labelURL.Enabled = true;
			buttonSend.Enabled = true;
			buttonCopy.Enabled = true;
			groupBoxLinks.Enabled = true;
		}

		private DateTime GetSelectedDateTime() {
			DateTime selectedFromCalendar = monthCalendar.SelectionStart;
			DateTime selectedFromTimePicker = dateTimePicker.Value;

			return new DateTime(
				selectedFromCalendar.Year,
				selectedFromCalendar.Month,
				selectedFromCalendar.Day,
				selectedFromTimePicker.Hour, //Must be UTC +3 Moscow
				selectedFromTimePicker.Minute,
				0);
		}

		private void FormCreate_Load(object sender, EventArgs e) {
			string groupName = "Врачи TrueConf";
			using (PrincipalContext context = new PrincipalContext(ContextType.Domain)) {

				using (GroupPrincipal group = GroupPrincipal.FindByIdentity(context, groupName)) {
					if (group == null) {
						ShowMessageBox("Не удалось загрузить список врачей из группы " + groupName,
							"Ошибка ActiveDirectory",
							MessageBoxButtons.OK,
							MessageBoxIcon.Error);
					} else {
						PrincipalSearchResult<Principal> users = group.GetMembers(true);
						foreach (UserPrincipal user in users)
							comboBoxOwner.Items.Add(user.DisplayName + " (" + user.SamAccountName + "@ruh93.trueconf.name)");
					}
				}
			}
		}

		

		private DialogResult ShowMessageBox(string message, string title,
			MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information) {
			if (InvokeRequired) {
				return (DialogResult)Invoke(new Func<DialogResult>(() => {
					return ShowMessageBox(message, title, buttons, icon);
				}));
			}

			return MessageBox.Show(this, message, title, buttons, icon);
		}
	}
}
