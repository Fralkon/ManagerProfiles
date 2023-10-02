namespace ManagerProfiles
{
    partial class ObjectsManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            authData = new DataGridView();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            settingToolStripMenuItem = new ToolStripMenuItem();
            sitesToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            создатьToolStripMenuItem = new ToolStripMenuItem();
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            статусToolStripMenuItem = new ToolStripMenuItem();
            активаныйToolStripMenuItem = new ToolStripMenuItem();
            deactivateToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            objectsData = new DataGridView();
            label2 = new Label();
            contextMenuStripObjects = new ContextMenuStrip(components);
            создатьToolStripMenuItem1 = new ToolStripMenuItem();
            изменитьToolStripMenuItem1 = new ToolStripMenuItem();
            удалитьToolStripMenuItem1 = new ToolStripMenuItem();
            stepSettingData = new DataGridView();
            label3 = new Label();
            contextMenuStripStep = new ContextMenuStrip(components);
            создатьToolStripMenuItem2 = new ToolStripMenuItem();
            изменитьToolStripMenuItem2 = new ToolStripMenuItem();
            удалитьToolStripMenuItem2 = new ToolStripMenuItem();
            mashineComboBox = new ComboBox();
            stepComboBox = new ComboBox();
            siteComboBox = new ComboBox();
            statusComboBox = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)authData).BeginInit();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)objectsData).BeginInit();
            contextMenuStripObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stepSettingData).BeginInit();
            contextMenuStripStep.SuspendLayout();
            SuspendLayout();
            // 
            // authData
            // 
            authData.AllowUserToAddRows = false;
            authData.AllowUserToDeleteRows = false;
            authData.AllowUserToResizeColumns = false;
            authData.AllowUserToResizeRows = false;
            authData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            authData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            authData.BackgroundColor = SystemColors.ButtonFace;
            authData.Location = new Point(325, 75);
            authData.MultiSelect = false;
            authData.Name = "authData";
            authData.ReadOnly = true;
            authData.RowHeadersVisible = false;
            authData.RowTemplate.Height = 25;
            authData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            authData.Size = new Size(546, 513);
            authData.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, settingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1302, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sitesToolStripMenuItem });
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(56, 20);
            settingToolStripMenuItem.Text = "Setting";
            // 
            // sitesToolStripMenuItem
            // 
            sitesToolStripMenuItem.Name = "sitesToolStripMenuItem";
            sitesToolStripMenuItem.Size = new Size(98, 22);
            sitesToolStripMenuItem.Text = "Sites";
            sitesToolStripMenuItem.Click += sitesToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, изменитьToolStripMenuItem, удалитьToolStripMenuItem, статусToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(129, 92);
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(128, 22);
            создатьToolStripMenuItem.Text = "Создать";
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.Size = new Size(128, 22);
            изменитьToolStripMenuItem.Text = "Изменить";
            изменитьToolStripMenuItem.Click += изменитьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(128, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // статусToolStripMenuItem
            // 
            статусToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { активаныйToolStripMenuItem, deactivateToolStripMenuItem });
            статусToolStripMenuItem.Name = "статусToolStripMenuItem";
            статусToolStripMenuItem.Size = new Size(128, 22);
            статусToolStripMenuItem.Text = "Статус";
            // 
            // активаныйToolStripMenuItem
            // 
            активаныйToolStripMenuItem.Name = "активаныйToolStripMenuItem";
            активаныйToolStripMenuItem.Size = new Size(129, 22);
            активаныйToolStripMenuItem.Text = "Activate";
            активаныйToolStripMenuItem.Click += Status_ToolStripMenuItem_Click;
            // 
            // deactivateToolStripMenuItem
            // 
            deactivateToolStripMenuItem.Name = "deactivateToolStripMenuItem";
            deactivateToolStripMenuItem.Size = new Size(129, 22);
            deactivateToolStripMenuItem.Text = "Deactivate";
            deactivateToolStripMenuItem.Click += Status_ToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 57);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 7;
            label1.Text = "Данные авторизации";
            // 
            // objectsData
            // 
            objectsData.AllowUserToAddRows = false;
            objectsData.AllowUserToDeleteRows = false;
            objectsData.AllowUserToResizeColumns = false;
            objectsData.AllowUserToResizeRows = false;
            objectsData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            objectsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            objectsData.BackgroundColor = SystemColors.ButtonFace;
            objectsData.Location = new Point(12, 75);
            objectsData.MultiSelect = false;
            objectsData.Name = "objectsData";
            objectsData.ReadOnly = true;
            objectsData.RowHeadersVisible = false;
            objectsData.RowTemplate.Height = 25;
            objectsData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            objectsData.Size = new Size(307, 513);
            objectsData.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 9;
            label2.Text = "Объект";
            // 
            // contextMenuStripObjects
            // 
            contextMenuStripObjects.Items.AddRange(new ToolStripItem[] { создатьToolStripMenuItem1, изменитьToolStripMenuItem1, удалитьToolStripMenuItem1 });
            contextMenuStripObjects.Name = "contextMenuStripObjects";
            contextMenuStripObjects.Size = new Size(129, 70);
            // 
            // создатьToolStripMenuItem1
            // 
            создатьToolStripMenuItem1.Name = "создатьToolStripMenuItem1";
            создатьToolStripMenuItem1.Size = new Size(128, 22);
            создатьToolStripMenuItem1.Text = "Создать";
            создатьToolStripMenuItem1.Click += создатьToolStripMenuItem1_Click_1;
            // 
            // изменитьToolStripMenuItem1
            // 
            изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            изменитьToolStripMenuItem1.Size = new Size(128, 22);
            изменитьToolStripMenuItem1.Text = "Изменить";
            изменитьToolStripMenuItem1.Click += изменитьToolStripMenuItem1_Click_1;
            // 
            // удалитьToolStripMenuItem1
            // 
            удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            удалитьToolStripMenuItem1.Size = new Size(128, 22);
            удалитьToolStripMenuItem1.Text = "Удалить";
            удалитьToolStripMenuItem1.Click += удалитьToolStripMenuItem1_Click_1;
            // 
            // stepSettingData
            // 
            stepSettingData.AllowUserToAddRows = false;
            stepSettingData.AllowUserToDeleteRows = false;
            stepSettingData.AllowUserToResizeColumns = false;
            stepSettingData.AllowUserToResizeRows = false;
            stepSettingData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stepSettingData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            stepSettingData.BackgroundColor = SystemColors.ButtonFace;
            stepSettingData.Location = new Point(877, 75);
            stepSettingData.MultiSelect = false;
            stepSettingData.Name = "stepSettingData";
            stepSettingData.ReadOnly = true;
            stepSettingData.RowHeadersVisible = false;
            stepSettingData.RowTemplate.Height = 25;
            stepSettingData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            stepSettingData.Size = new Size(413, 513);
            stepSettingData.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(877, 57);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 11;
            label3.Text = "Step setting";
            // 
            // contextMenuStripStep
            // 
            contextMenuStripStep.Items.AddRange(new ToolStripItem[] { создатьToolStripMenuItem2, изменитьToolStripMenuItem2, удалитьToolStripMenuItem2 });
            contextMenuStripStep.Name = "contextMenuStripStep";
            contextMenuStripStep.Size = new Size(129, 70);
            // 
            // создатьToolStripMenuItem2
            // 
            создатьToolStripMenuItem2.Name = "создатьToolStripMenuItem2";
            создатьToolStripMenuItem2.Size = new Size(128, 22);
            создатьToolStripMenuItem2.Text = "Создать";
            создатьToolStripMenuItem2.Click += создатьToolStripMenuItem2_Click;
            // 
            // изменитьToolStripMenuItem2
            // 
            изменитьToolStripMenuItem2.Name = "изменитьToolStripMenuItem2";
            изменитьToolStripMenuItem2.Size = new Size(128, 22);
            изменитьToolStripMenuItem2.Text = "Изменить";
            изменитьToolStripMenuItem2.Click += изменитьToolStripMenuItem2_Click;
            // 
            // удалитьToolStripMenuItem2
            // 
            удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            удалитьToolStripMenuItem2.Size = new Size(128, 22);
            удалитьToolStripMenuItem2.Text = "Удалить";
            удалитьToolStripMenuItem2.Click += удалитьToolStripMenuItem2_Click;
            // 
            // mashineComboBox
            // 
            mashineComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            mashineComboBox.FormattingEnabled = true;
            mashineComboBox.Location = new Point(325, 31);
            mashineComboBox.Name = "mashineComboBox";
            mashineComboBox.Size = new Size(121, 23);
            mashineComboBox.TabIndex = 12;
            mashineComboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // stepComboBox
            // 
            stepComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stepComboBox.FormattingEnabled = true;
            stepComboBox.Location = new Point(468, 31);
            stepComboBox.Name = "stepComboBox";
            stepComboBox.Size = new Size(121, 23);
            stepComboBox.TabIndex = 13;
            stepComboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // siteComboBox
            // 
            siteComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            siteComboBox.FormattingEnabled = true;
            siteComboBox.Location = new Point(612, 31);
            siteComboBox.Name = "siteComboBox";
            siteComboBox.Size = new Size(121, 23);
            siteComboBox.TabIndex = 14;
            siteComboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // statusComboBox
            // 
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(750, 31);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(121, 23);
            statusComboBox.TabIndex = 15;
            statusComboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(1215, 31);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ObjectsManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 600);
            Controls.Add(button1);
            Controls.Add(statusComboBox);
            Controls.Add(siteComboBox);
            Controls.Add(stepComboBox);
            Controls.Add(mashineComboBox);
            Controls.Add(label3);
            Controls.Add(stepSettingData);
            Controls.Add(label2);
            Controls.Add(objectsData);
            Controls.Add(label1);
            Controls.Add(authData);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ObjectsManager";
            Text = "AuthForm";
            ((System.ComponentModel.ISupportInitialize)authData).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)objectsData).EndInit();
            contextMenuStripObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)stepSettingData).EndInit();
            contextMenuStripStep.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView authData;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private Label label1;
        private DataGridView objectsData;
        private Label label2;
        private ContextMenuStrip contextMenuStripObjects;
        private ToolStripMenuItem создатьToolStripMenuItem1;
        private ToolStripMenuItem изменитьToolStripMenuItem1;
        private ToolStripMenuItem удалитьToolStripMenuItem1;
        private DataGridView stepSettingData;
        private Label label3;
        private ContextMenuStrip contextMenuStripStep;
        private ToolStripMenuItem создатьToolStripMenuItem2;
        private ToolStripMenuItem изменитьToolStripMenuItem2;
        private ToolStripMenuItem удалитьToolStripMenuItem2;
        private ToolStripMenuItem статусToolStripMenuItem;
        private ToolStripMenuItem активаныйToolStripMenuItem;
        private ToolStripMenuItem deactivateToolStripMenuItem;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem sitesToolStripMenuItem;
        private ComboBox mashineComboBox;
        private ComboBox stepComboBox;
        private ComboBox siteComboBox;
        private ComboBox statusComboBox;
        private Button button1;
    }
}