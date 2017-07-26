namespace VideoConsultationsManagement {
	partial class FormCreate {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.GroupBox groupBox1;
			System.Windows.Forms.Label label8;
			System.Windows.Forms.Label label7;
			System.Windows.Forms.Label label5;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreate));
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.buttonNow = new System.Windows.Forms.Button();
			this.trackBarMinutes = new System.Windows.Forms.TrackBar();
			this.trackBarHours = new System.Windows.Forms.TrackBar();
			this.monthCalendar = new System.Windows.Forms.MonthCalendar();
			this.labelHistoryID = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelPhone = new System.Windows.Forms.Label();
			this.labelOwner = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.comboBoxOwner = new System.Windows.Forms.ComboBox();
			this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
			this.labelURL = new System.Windows.Forms.Label();
			this.textBoxURL = new System.Windows.Forms.TextBox();
			this.textBoxHistoryID = new System.Windows.Forms.TextBox();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonSend = new System.Windows.Forms.Button();
			this.buttonCopy = new System.Windows.Forms.Button();
			this.buttonCreate = new System.Windows.Forms.Button();
			this.groupBoxLinks = new System.Windows.Forms.GroupBox();
			this.checkBoxAndroid = new System.Windows.Forms.CheckBox();
			this.checkBoxIos = new System.Windows.Forms.CheckBox();
			groupBox1 = new System.Windows.Forms.GroupBox();
			label8 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarMinutes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarHours)).BeginInit();
			this.groupBoxLinks.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(this.dateTimePicker);
			groupBox1.Controls.Add(this.buttonNow);
			groupBox1.Controls.Add(this.trackBarMinutes);
			groupBox1.Controls.Add(this.trackBarHours);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(this.monthCalendar);
			groupBox1.Location = new System.Drawing.Point(12, 138);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(356, 291);
			groupBox1.TabIndex = 4;
			groupBox1.TabStop = false;
			groupBox1.Text = "Дата и время проведения:";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.CustomFormat = "HH:mm";
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker.Location = new System.Drawing.Point(180, 193);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.ShowUpDown = true;
			this.dateTimePicker.Size = new System.Drawing.Size(50, 20);
			this.dateTimePicker.TabIndex = 5;
			this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
			// 
			// buttonNow
			// 
			this.buttonNow.Enabled = false;
			this.buttonNow.Image = global::VideoConsultationsManagement.Properties.Resources.Time_16x;
			this.buttonNow.Location = new System.Drawing.Point(255, 191);
			this.buttonNow.Name = "buttonNow";
			this.buttonNow.Size = new System.Drawing.Size(75, 23);
			this.buttonNow.TabIndex = 6;
			this.buttonNow.Text = "Сейчас";
			this.buttonNow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonNow.UseVisualStyleBackColor = true;
			this.buttonNow.Click += new System.EventHandler(this.buttonNow_Click);
			// 
			// trackBarMinutes
			// 
			this.trackBarMinutes.AutoSize = false;
			this.trackBarMinutes.Location = new System.Drawing.Point(58, 254);
			this.trackBarMinutes.Maximum = 59;
			this.trackBarMinutes.Name = "trackBarMinutes";
			this.trackBarMinutes.Size = new System.Drawing.Size(292, 29);
			this.trackBarMinutes.TabIndex = 8;
			this.trackBarMinutes.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBarMinutes.Scroll += new System.EventHandler(this.trackBarMinutes_Scroll);
			// 
			// trackBarHours
			// 
			this.trackBarHours.AutoSize = false;
			this.trackBarHours.Location = new System.Drawing.Point(58, 219);
			this.trackBarHours.Maximum = 23;
			this.trackBarHours.Name = "trackBarHours";
			this.trackBarHours.Size = new System.Drawing.Size(292, 29);
			this.trackBarHours.TabIndex = 7;
			this.trackBarHours.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBarHours.Scroll += new System.EventHandler(this.trackBarHours_Scroll);
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(6, 256);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(46, 13);
			label8.TabIndex = 15;
			label8.Text = "Минуты";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(6, 221);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(35, 13);
			label7.TabIndex = 14;
			label7.Text = "Часы";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(127, 196);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(47, 13);
			label5.TabIndex = 12;
			label5.Text = "Начало:";
			// 
			// monthCalendar
			// 
			this.monthCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
			this.monthCalendar.Location = new System.Drawing.Point(12, 25);
			this.monthCalendar.MaxSelectionCount = 1;
			this.monthCalendar.Name = "monthCalendar";
			this.monthCalendar.TabIndex = 4;
			// 
			// labelHistoryID
			// 
			this.labelHistoryID.AutoSize = true;
			this.labelHistoryID.Location = new System.Drawing.Point(12, 12);
			this.labelHistoryID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.labelHistoryID.Name = "labelHistoryID";
			this.labelHistoryID.Size = new System.Drawing.Size(298, 13);
			this.labelHistoryID.TabIndex = 0;
			this.labelHistoryID.Text = "Номер истории болезни пациента из МИС Инфоклиника:";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(12, 54);
			this.labelName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(87, 13);
			this.labelName.TabIndex = 2;
			this.labelName.Text = "ФИО пациента:";
			// 
			// labelPhone
			// 
			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(12, 96);
			this.labelPhone.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(193, 13);
			this.labelPhone.TabIndex = 4;
			this.labelPhone.Text = "Номер телефона для отправки СМС:\r\n";
			// 
			// labelOwner
			// 
			this.labelOwner.AutoSize = true;
			this.labelOwner.Location = new System.Drawing.Point(13, 435);
			this.labelOwner.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.labelOwner.Name = "labelOwner";
			this.labelOwner.Size = new System.Drawing.Size(208, 13);
			this.labelOwner.TabIndex = 13;
			this.labelOwner.Text = "Врач, проводящий видеоконсультацию:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(12, 70);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(356, 20);
			this.textBoxName.TabIndex = 2;
			// 
			// comboBoxOwner
			// 
			this.comboBoxOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxOwner.FormattingEnabled = true;
			this.comboBoxOwner.Location = new System.Drawing.Point(12, 451);
			this.comboBoxOwner.Name = "comboBoxOwner";
			this.comboBoxOwner.Size = new System.Drawing.Size(356, 21);
			this.comboBoxOwner.TabIndex = 9;
			// 
			// maskedTextBoxPhone
			// 
			this.maskedTextBoxPhone.Location = new System.Drawing.Point(13, 113);
			this.maskedTextBoxPhone.Mask = "(999) 000-0000";
			this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
			this.maskedTextBoxPhone.Size = new System.Drawing.Size(355, 20);
			this.maskedTextBoxPhone.TabIndex = 3;
			this.maskedTextBoxPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// labelURL
			// 
			this.labelURL.AutoSize = true;
			this.labelURL.Enabled = false;
			this.labelURL.Location = new System.Drawing.Point(12, 524);
			this.labelURL.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.labelURL.Name = "labelURL";
			this.labelURL.Size = new System.Drawing.Size(140, 13);
			this.labelURL.TabIndex = 14;
			this.labelURL.Text = "Ссылка для подключения:";
			// 
			// textBoxURL
			// 
			this.textBoxURL.Enabled = false;
			this.textBoxURL.Location = new System.Drawing.Point(12, 540);
			this.textBoxURL.Name = "textBoxURL";
			this.textBoxURL.ReadOnly = true;
			this.textBoxURL.Size = new System.Drawing.Size(356, 20);
			this.textBoxURL.TabIndex = 15;
			// 
			// textBoxHistoryID
			// 
			this.textBoxHistoryID.Location = new System.Drawing.Point(12, 28);
			this.textBoxHistoryID.Name = "textBoxHistoryID";
			this.textBoxHistoryID.Size = new System.Drawing.Size(356, 20);
			this.textBoxHistoryID.TabIndex = 1;
			this.textBoxHistoryID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHistoryID_KeyPress);
			// 
			// buttonClear
			// 
			this.buttonClear.Image = global::VideoConsultationsManagement.Properties.Resources.F12_ClearWindowContent_32x32;
			this.buttonClear.Location = new System.Drawing.Point(12, 614);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(115, 40);
			this.buttonClear.TabIndex = 18;
			this.buttonClear.Text = "Очистить";
			this.buttonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonSend
			// 
			this.buttonSend.Enabled = false;
			this.buttonSend.Image = global::VideoConsultationsManagement.Properties.Resources.SendEmail_32x;
			this.buttonSend.Location = new System.Drawing.Point(254, 614);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(115, 40);
			this.buttonSend.TabIndex = 17;
			this.buttonSend.Text = "Отправить СМС";
			this.buttonSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSend.UseVisualStyleBackColor = true;
			this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
			// 
			// buttonCopy
			// 
			this.buttonCopy.Enabled = false;
			this.buttonCopy.Image = global::VideoConsultationsManagement.Properties.Resources.CopyToClipboard_32x;
			this.buttonCopy.Location = new System.Drawing.Point(133, 614);
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.Size = new System.Drawing.Size(115, 40);
			this.buttonCopy.TabIndex = 16;
			this.buttonCopy.Text = "Скопировать\r\nссылку";
			this.buttonCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopy.UseVisualStyleBackColor = true;
			this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
			// 
			// buttonCreate
			// 
			this.buttonCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonCreate.Image = global::VideoConsultationsManagement.Properties.Resources.Create_32x;
			this.buttonCreate.Location = new System.Drawing.Point(140, 478);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(100, 40);
			this.buttonCreate.TabIndex = 10;
			this.buttonCreate.Text = "Создать";
			this.buttonCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// groupBoxLinks
			// 
			this.groupBoxLinks.Controls.Add(this.checkBoxAndroid);
			this.groupBoxLinks.Controls.Add(this.checkBoxIos);
			this.groupBoxLinks.Enabled = false;
			this.groupBoxLinks.Location = new System.Drawing.Point(12, 566);
			this.groupBoxLinks.Name = "groupBoxLinks";
			this.groupBoxLinks.Size = new System.Drawing.Size(356, 42);
			this.groupBoxLinks.TabIndex = 21;
			this.groupBoxLinks.TabStop = false;
			this.groupBoxLinks.Text = "Отправить ссылку для установки TrueConf";
			// 
			// checkBoxAndroid
			// 
			this.checkBoxAndroid.AutoSize = true;
			this.checkBoxAndroid.Checked = true;
			this.checkBoxAndroid.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxAndroid.Location = new System.Drawing.Point(168, 19);
			this.checkBoxAndroid.Name = "checkBoxAndroid";
			this.checkBoxAndroid.Size = new System.Drawing.Size(120, 17);
			this.checkBoxAndroid.TabIndex = 1;
			this.checkBoxAndroid.Text = "для Google Android";
			this.checkBoxAndroid.UseVisualStyleBackColor = true;
			// 
			// checkBoxIos
			// 
			this.checkBoxIos.AutoSize = true;
			this.checkBoxIos.Checked = true;
			this.checkBoxIos.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxIos.Location = new System.Drawing.Point(68, 19);
			this.checkBoxIos.Name = "checkBoxIos";
			this.checkBoxIos.Size = new System.Drawing.Size(94, 17);
			this.checkBoxIos.TabIndex = 0;
			this.checkBoxIos.Text = "для Apple iOS";
			this.checkBoxIos.UseVisualStyleBackColor = true;
			// 
			// FormCreate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 666);
			this.Controls.Add(this.groupBoxLinks);
			this.Controls.Add(this.textBoxHistoryID);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonSend);
			this.Controls.Add(this.buttonCopy);
			this.Controls.Add(this.textBoxURL);
			this.Controls.Add(this.labelURL);
			this.Controls.Add(this.maskedTextBoxPhone);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.comboBoxOwner);
			this.Controls.Add(this.labelOwner);
			this.Controls.Add(groupBox1);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.labelHistoryID);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormCreate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Создание видеоконсультации";
			this.Load += new System.EventHandler(this.FormCreate_Load);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarMinutes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarHours)).EndInit();
			this.groupBoxLinks.ResumeLayout(false);
			this.groupBoxLinks.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.MonthCalendar monthCalendar;
		private System.Windows.Forms.TrackBar trackBarHours;
		private System.Windows.Forms.TrackBar trackBarMinutes;
		private System.Windows.Forms.ComboBox comboBoxOwner;
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Button buttonNow;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
		private System.Windows.Forms.Label labelURL;
		private System.Windows.Forms.TextBox textBoxURL;
		private System.Windows.Forms.Button buttonCopy;
		private System.Windows.Forms.Button buttonSend;
		private System.Windows.Forms.Label labelHistoryID;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelOwner;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.TextBox textBoxHistoryID;
		private System.Windows.Forms.GroupBox groupBoxLinks;
		private System.Windows.Forms.CheckBox checkBoxAndroid;
		private System.Windows.Forms.CheckBox checkBoxIos;
	}
}