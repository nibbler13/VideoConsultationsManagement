using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace VideoConsultationsManagement {
	public partial class FormMain : Form {
		private TrueConf trueConf = new TrueConf();
		private ListViewColumnSorter listViewColumnSorter = new ListViewColumnSorter();
		private Dictionary<string, Webinar> webinars = new Dictionary<string, Webinar>();



		public FormMain() {
			InitializeComponent();
			listView.ListViewItemSorter = listViewColumnSorter;
		}

		private void FormMain_Load(object sender, EventArgs e) {
			System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
			timer.Interval = (60 * 1000);
			timer.Tick += Timer_Tick;
			timer.Start();
			UpdateWebinarsList();
			listView_ColumnClick(listView, new ColumnClickEventArgs(3));
		}

	

		private void buttonUpdate_Click(object sender, EventArgs e) {
			UpdateWebinarsList();
		}

		private void buttonDelete_Click(object sender, EventArgs e) {
			if (ShowMessageBox("Вы действительно хотите удалить выбранные консультации?",
				"Удаление", MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) == DialogResult.No)
				return;

			List<string> webinarsIdToDelete = new List<string>();
			foreach (ListViewItem item in listView.SelectedItems)
				webinarsIdToDelete.Add(item.Name);

			Thread thread = new Thread(() => {
				foreach (string id in webinarsIdToDelete) {
					try {
						if (webinars[id].State.Equals("Активная")) {
							string tmp = "";
							tmp = trueConf.StopWebinar(id).Result;
						}

						string result = trueConf.DeleteWebinar(id).Result;
						if (result.Contains(id))
							webinars.Remove(id);
					} catch (Exception exception) {
						ShowMessageBox("Не удалось удалить консультацию " + id + Environment.NewLine +
							exception.Message, "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}

				UpdateListView(webinars);
			});
			thread.Start();
		}

		private void buttonCopy_Click(object sender, EventArgs e) {
			if (listView.SelectedItems.Count != 1)
				return;

			string link = @"\c\" + listView.SelectedItems[0].Name;
			Clipboard.SetText(link);
			ShowMessageBox("Ссылка скопирована, теперь ее можно вставить в МИС Инфоклиника",
				"Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void buttonCreateWebinar_Click(object sender, EventArgs e) {
			FormCreate formCreate = new FormCreate();
			formCreate.ShowDialog();
			UpdateWebinarsList();
		}

		private void buttonSendUrl_Click(object sender, EventArgs e) {
			if (listView.SelectedItems.Count != 1)
				return;

			Webinar webinar = webinars[listView.SelectedItems[0].Name];
			string name = webinar.topic;
			string dateTime = webinar.GetStartDateAndTime();
			string url = webinar.url;
			string phoneNumber = webinar.GetPhoneNumber();
			FormSendUrl formSendUrl = new FormSendUrl(name, dateTime, url, phoneNumber);
			formSendUrl.ShowDialog();
		}



		private void Timer_Tick(object sender, EventArgs e) {
			UpdateWebinarsList();
		}

		private void GetWebinars() {
			try {
				webinars = trueConf.GetAllWebinars().Result;
				UpdateListView(webinars);
			} catch (Exception e) {
				webinars.Clear();
				ShowMessageBox(e.Message + Environment.NewLine + e.StackTrace, "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateWebinarsList() {
			Thread thread = new Thread(GetWebinars);
			thread.Start();
		}

		private void UpdateListView(Dictionary<string, Webinar> webinars) {
			if (InvokeRequired) {
				Invoke(new Action<Dictionary<string, Webinar>>(UpdateListView), new object[] { webinars });
				return;
			}

			foreach (ListViewItem item in listView.Items)
				if (!webinars.ContainsKey(item.Name))
					listView.Items.Remove(item);

			foreach (KeyValuePair<string, Webinar> pair in webinars) {
				try {
					if (listView.Items.ContainsKey(pair.Value.id)) {
						string state = pair.Value.State;
						int index = listView.Items.IndexOfKey(pair.Value.id);
						listView.Items[index].SubItems[1].Text = state;
						continue;
					}

					ListViewItem item = new ListViewItem(new string[] {
						pair.Value.topic,
						pair.Value.State,
						pair.Value.GetOwner(),
						pair.Value.GetStartDateAndTime()});
					item.Name = pair.Value.id;
					listView.Items.Add(item);
				} catch (Exception) {
				}
			}

			listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}


		private void listView_ColumnClick(object sender, ColumnClickEventArgs e) {
			if (e.Column == listViewColumnSorter.ColumnToSort) {
				if (listViewColumnSorter.OrderOfSort == SortOrder.Ascending) {
					listViewColumnSorter.OrderOfSort = SortOrder.Descending;
				} else {
					listViewColumnSorter.OrderOfSort = SortOrder.Ascending;
				}
			} else {
				listViewColumnSorter.ColumnToSort = e.Column;
				listViewColumnSorter.OrderOfSort = SortOrder.Ascending;
			}

			listView.SetSortIcon(e.Column, listViewColumnSorter.OrderOfSort);
			listView.Sort();
		}

		private void listView_SelectedIndexChanged(object sender, EventArgs e) {
			UpdateButtonsState();
		}

		private void UpdateButtonsState() {
			int selectedItems = listView.SelectedItems.Count;

			buttonDelete.Enabled = selectedItems > 0;
			buttonCopy.Enabled = selectedItems == 1;
			buttonSendUrl.Enabled = selectedItems == 1;
		}

		
		private DialogResult ShowMessageBox(string message, string title,
			MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None) {
			if (InvokeRequired) {
				return (DialogResult)Invoke(new Func<DialogResult>(() => {
					return ShowMessageBox(message, title, buttons, icon);
				}));
			}

			return MessageBox.Show(null, message, title, buttons, icon);
		}
	}
}
