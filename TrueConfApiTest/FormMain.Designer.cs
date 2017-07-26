namespace VideoConsultationsManagement {
	partial class FormMain {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.listView = new System.Windows.Forms.ListView();
			this.columnHeaderTopic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderInvitationTimestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.buttonCopy = new System.Windows.Forms.Button();
			this.buttonSendUrl = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonCreateWebinar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView
			// 
			this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTopic,
            this.columnHeaderStatus,
            this.columnHeaderOwner,
            this.columnHeaderInvitationTimestamp});
			this.listView.FullRowSelect = true;
			this.listView.GridLines = true;
			this.listView.Location = new System.Drawing.Point(12, 25);
			this.listView.Name = "listView";
			this.listView.ShowItemToolTips = true;
			this.listView.Size = new System.Drawing.Size(569, 583);
			this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listView.TabIndex = 6;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.Details;
			this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
			this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
			// 
			// columnHeaderTopic
			// 
			this.columnHeaderTopic.Text = "Название";
			this.columnHeaderTopic.Width = 62;
			// 
			// columnHeaderStatus
			// 
			this.columnHeaderStatus.Text = "Статус";
			this.columnHeaderStatus.Width = 46;
			// 
			// columnHeaderOwner
			// 
			this.columnHeaderOwner.Text = "Врач";
			this.columnHeaderOwner.Width = 36;
			// 
			// columnHeaderInvitationTimestamp
			// 
			this.columnHeaderInvitationTimestamp.Text = "Дата и время";
			this.columnHeaderInvitationTimestamp.Width = 401;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Список созданных консультаций:";
			// 
			// buttonCopy
			// 
			this.buttonCopy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonCopy.Enabled = false;
			this.buttonCopy.Image = global::VideoConsultationsManagement.Properties.Resources.CopyToClipboard_32x;
			this.buttonCopy.Location = new System.Drawing.Point(239, 614);
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.Size = new System.Drawing.Size(115, 40);
			this.buttonCopy.TabIndex = 9;
			this.buttonCopy.Text = "Скопировать ссылку";
			this.buttonCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopy.UseVisualStyleBackColor = true;
			this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
			// 
			// buttonSendUrl
			// 
			this.buttonSendUrl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonSendUrl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonSendUrl.Enabled = false;
			this.buttonSendUrl.Image = global::VideoConsultationsManagement.Properties.Resources.SendEmail_32x;
			this.buttonSendUrl.Location = new System.Drawing.Point(360, 614);
			this.buttonSendUrl.Name = "buttonSendUrl";
			this.buttonSendUrl.Size = new System.Drawing.Size(115, 40);
			this.buttonSendUrl.TabIndex = 8;
			this.buttonSendUrl.Text = "Отправить ссылку";
			this.buttonSendUrl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSendUrl.UseVisualStyleBackColor = true;
			this.buttonSendUrl.Click += new System.EventHandler(this.buttonSendUrl_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonDelete.Enabled = false;
			this.buttonDelete.Image = global::VideoConsultationsManagement.Properties.Resources.Cancel_32x;
			this.buttonDelete.Location = new System.Drawing.Point(118, 614);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(115, 40);
			this.buttonDelete.TabIndex = 7;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonUpdate.Image = global::VideoConsultationsManagement.Properties.Resources.Refresh_32x;
			this.buttonUpdate.Location = new System.Drawing.Point(12, 614);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(100, 40);
			this.buttonUpdate.TabIndex = 5;
			this.buttonUpdate.Text = "Обновить";
			this.buttonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// buttonCreateWebinar
			// 
			this.buttonCreateWebinar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCreateWebinar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonCreateWebinar.Image = global::VideoConsultationsManagement.Properties.Resources.Create_32x;
			this.buttonCreateWebinar.Location = new System.Drawing.Point(481, 614);
			this.buttonCreateWebinar.Name = "buttonCreateWebinar";
			this.buttonCreateWebinar.Size = new System.Drawing.Size(100, 40);
			this.buttonCreateWebinar.TabIndex = 4;
			this.buttonCreateWebinar.Text = "Создать";
			this.buttonCreateWebinar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCreateWebinar.UseVisualStyleBackColor = true;
			this.buttonCreateWebinar.Click += new System.EventHandler(this.buttonCreateWebinar_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(593, 666);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonCopy);
			this.Controls.Add(this.buttonSendUrl);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.listView);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.buttonCreateWebinar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(609, 705);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Управление видеоконсультациями";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonCreateWebinar;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader columnHeaderTopic;
		private System.Windows.Forms.ColumnHeader columnHeaderStatus;
		private System.Windows.Forms.ColumnHeader columnHeaderOwner;
		private System.Windows.Forms.ColumnHeader columnHeaderInvitationTimestamp;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonSendUrl;
		private System.Windows.Forms.Button buttonCopy;
		private System.Windows.Forms.Label label1;
	}
}

