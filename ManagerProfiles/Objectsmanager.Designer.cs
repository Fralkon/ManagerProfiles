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
            this.components = new System.ComponentModel.Container();
            this.authData = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.активаныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactivateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.objectsData = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStripObjects = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stepSettingData = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStripStep = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.authData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectsData)).BeginInit();
            this.contextMenuStripObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepSettingData)).BeginInit();
            this.contextMenuStripStep.SuspendLayout();
            this.SuspendLayout();
            // 
            // authData
            // 
            this.authData.AllowUserToAddRows = false;
            this.authData.AllowUserToDeleteRows = false;
            this.authData.AllowUserToResizeColumns = false;
            this.authData.AllowUserToResizeRows = false;
            this.authData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.authData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.authData.Location = new System.Drawing.Point(325, 53);
            this.authData.MultiSelect = false;
            this.authData.Name = "authData";
            this.authData.ReadOnly = true;
            this.authData.RowHeadersVisible = false;
            this.authData.RowTemplate.Height = 25;
            this.authData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.authData.Size = new System.Drawing.Size(546, 535);
            this.authData.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1302, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.статусToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 92);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // статусToolStripMenuItem
            // 
            this.статусToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.активаныйToolStripMenuItem,
            this.deactivateToolStripMenuItem});
            this.статусToolStripMenuItem.Name = "статусToolStripMenuItem";
            this.статусToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.статусToolStripMenuItem.Text = "Статус";
            // 
            // активаныйToolStripMenuItem
            // 
            this.активаныйToolStripMenuItem.Name = "активаныйToolStripMenuItem";
            this.активаныйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.активаныйToolStripMenuItem.Text = "Activate";
            this.активаныйToolStripMenuItem.Click += new System.EventHandler(this.Status_ToolStripMenuItem_Click);
            // 
            // deactivateToolStripMenuItem
            // 
            this.deactivateToolStripMenuItem.Name = "deactivateToolStripMenuItem";
            this.deactivateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deactivateToolStripMenuItem.Text = "Deactivate";
            this.deactivateToolStripMenuItem.Click += new System.EventHandler(this.Status_ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Данные авторизации";
            // 
            // objectsData
            // 
            this.objectsData.AllowUserToAddRows = false;
            this.objectsData.AllowUserToDeleteRows = false;
            this.objectsData.AllowUserToResizeColumns = false;
            this.objectsData.AllowUserToResizeRows = false;
            this.objectsData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.objectsData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.objectsData.Location = new System.Drawing.Point(12, 53);
            this.objectsData.MultiSelect = false;
            this.objectsData.Name = "objectsData";
            this.objectsData.ReadOnly = true;
            this.objectsData.RowHeadersVisible = false;
            this.objectsData.RowTemplate.Height = 25;
            this.objectsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.objectsData.Size = new System.Drawing.Size(307, 535);
            this.objectsData.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Объект";
            // 
            // contextMenuStripObjects
            // 
            this.contextMenuStripObjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem1,
            this.изменитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1});
            this.contextMenuStripObjects.Name = "contextMenuStripObjects";
            this.contextMenuStripObjects.Size = new System.Drawing.Size(129, 70);
            // 
            // создатьToolStripMenuItem1
            // 
            this.создатьToolStripMenuItem1.Name = "создатьToolStripMenuItem1";
            this.создатьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.создатьToolStripMenuItem1.Text = "Создать";
            this.создатьToolStripMenuItem1.Click += new System.EventHandler(this.создатьToolStripMenuItem1_Click_1);
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            this.изменитьToolStripMenuItem1.Click += new System.EventHandler(this.изменитьToolStripMenuItem1_Click_1);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click_1);
            // 
            // stepSettingData
            // 
            this.stepSettingData.AllowUserToAddRows = false;
            this.stepSettingData.AllowUserToDeleteRows = false;
            this.stepSettingData.AllowUserToResizeColumns = false;
            this.stepSettingData.AllowUserToResizeRows = false;
            this.stepSettingData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepSettingData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.stepSettingData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.stepSettingData.Location = new System.Drawing.Point(877, 53);
            this.stepSettingData.MultiSelect = false;
            this.stepSettingData.Name = "stepSettingData";
            this.stepSettingData.ReadOnly = true;
            this.stepSettingData.RowHeadersVisible = false;
            this.stepSettingData.RowTemplate.Height = 25;
            this.stepSettingData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stepSettingData.Size = new System.Drawing.Size(413, 535);
            this.stepSettingData.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(877, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Step setting";
            // 
            // contextMenuStripStep
            // 
            this.contextMenuStripStep.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem2,
            this.изменитьToolStripMenuItem2,
            this.удалитьToolStripMenuItem2});
            this.contextMenuStripStep.Name = "contextMenuStripStep";
            this.contextMenuStripStep.Size = new System.Drawing.Size(129, 70);
            // 
            // создатьToolStripMenuItem2
            // 
            this.создатьToolStripMenuItem2.Name = "создатьToolStripMenuItem2";
            this.создатьToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.создатьToolStripMenuItem2.Text = "Создать";
            this.создатьToolStripMenuItem2.Click += new System.EventHandler(this.создатьToolStripMenuItem2_Click);
            // 
            // изменитьToolStripMenuItem2
            // 
            this.изменитьToolStripMenuItem2.Name = "изменитьToolStripMenuItem2";
            this.изменитьToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem2.Text = "Изменить";
            this.изменитьToolStripMenuItem2.Click += new System.EventHandler(this.изменитьToolStripMenuItem2_Click);
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem2.Text = "Удалить";
            this.удалитьToolStripMenuItem2.Click += new System.EventHandler(this.удалитьToolStripMenuItem2_Click);
            // 
            // ObjectsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stepSettingData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.objectsData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ObjectsManager";
            this.Text = "AuthForm";
            ((System.ComponentModel.ISupportInitialize)(this.authData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectsData)).EndInit();
            this.contextMenuStripObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stepSettingData)).EndInit();
            this.contextMenuStripStep.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}