namespace VideoConsultationsManagement {
	partial class FormSendUrl {
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
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label4;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSendUrl));
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxDateTime = new System.Windows.Forms.TextBox();
			this.textBoxUrl = new System.Windows.Forms.TextBox();
			this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
			this.buttonSend = new System.Windows.Forms.Button();
			this.groupBoxLinks = new System.Windows.Forms.GroupBox();
			this.checkBoxAndroid = new System.Windows.Forms.CheckBox();
			this.checkBoxIos = new System.Windows.Forms.CheckBox();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			this.groupBoxLinks.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(12, 12);
			label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(133, 13);
			label1.TabIndex = 0;
			label1.Text = "Название консультации:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(12, 54);
			label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(171, 13);
			label2.TabIndex = 2;
			label2.Text = "Запланированная дата и время:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(12, 138);
			label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(208, 13);
			label3.TabIndex = 4;
			label3.Text = "Номер телефона для отправки ссылки:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(12, 96);
			label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(140, 13);
			label4.TabIndex = 5;
			label4.Text = "Ссылка для подключения:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(12, 28);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.ReadOnly = true;
			this.textBoxName.Size = new System.Drawing.Size(356, 20);
			this.textBoxName.TabIndex = 3;
			// 
			// textBoxDateTime
			// 
			this.textBoxDateTime.Location = new System.Drawing.Point(12, 70);
			this.textBoxDateTime.Name = "textBoxDateTime";
			this.textBoxDateTime.ReadOnly = true;
			this.textBoxDateTime.Size = new System.Drawing.Size(356, 20);
			this.textBoxDateTime.TabIndex = 4;
			// 
			// textBoxUrl
			// 
			this.textBoxUrl.Location = new System.Drawing.Point(12, 112);
			this.textBoxUrl.Name = "textBoxUrl";
			this.textBoxUrl.ReadOnly = true;
			this.textBoxUrl.Size = new System.Drawing.Size(356, 20);
			this.textBoxUrl.TabIndex = 5;
			// 
			// maskedTextBoxPhoneNumber
			// 
			this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(12, 154);
			this.maskedTextBoxPhoneNumber.Mask = "(999) 000-0000";
			this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
			this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(356, 20);
			this.maskedTextBoxPhoneNumber.TabIndex = 2;
			this.maskedTextBoxPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// buttonSend
			// 
			this.buttonSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonSend.Image = global::VideoConsultationsManagement.Properties.Resources.SendEmail_32x;
			this.buttonSend.Location = new System.Drawing.Point(133, 228);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(115, 40);
			this.buttonSend.TabIndex = 1;
			this.buttonSend.Text = "Отправить СМС";
			this.buttonSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSend.UseVisualStyleBackColor = true;
			this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
			// 
			// groupBoxLinks
			// 
			this.groupBoxLinks.Controls.Add(this.checkBoxAndroid);
			this.groupBoxLinks.Controls.Add(this.checkBoxIos);
			this.groupBoxLinks.Location = new System.Drawing.Point(12, 180);
			this.groupBoxLinks.Name = "groupBoxLinks";
			this.groupBoxLinks.Size = new System.Drawing.Size(356, 42);
			this.groupBoxLinks.TabIndex = 20;
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
			// FormSendUrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 280);
			this.Controls.Add(this.groupBoxLinks);
			this.Controls.Add(this.buttonSend);
			this.Controls.Add(this.maskedTextBoxPhoneNumber);
			this.Controls.Add(this.textBoxUrl);
			this.Controls.Add(label4);
			this.Controls.Add(label3);
			this.Controls.Add(this.textBoxDateTime);
			this.Controls.Add(label2);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormSendUrl";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Отправка ссылки";
			this.groupBoxLinks.ResumeLayout(false);
			this.groupBoxLinks.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxDateTime;
		private System.Windows.Forms.TextBox textBoxUrl;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
		private System.Windows.Forms.Button buttonSend;
		private System.Windows.Forms.GroupBox groupBoxLinks;
		private System.Windows.Forms.CheckBox checkBoxAndroid;
		private System.Windows.Forms.CheckBox checkBoxIos;
	}
}