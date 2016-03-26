namespace LegionLauncher
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkedListBoxAddons = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPathToArma = new System.Windows.Forms.TextBox();
            this.buttonSearchForArma = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelDownloadSpeed = new System.Windows.Forms.Label();
            this.labelLastDownload = new System.Windows.Forms.Label();
            this.buttonDownloadNow = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBoxAddonsForDownload = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSettingsShowModstring = new System.Windows.Forms.Button();
            this.buttonSettingsReloadAddons = new System.Windows.Forms.Button();
            this.buttonSettingsEditPasswords = new System.Windows.Forms.Button();
            this.checkBoxSettingsPauseOnDesktop = new System.Windows.Forms.CheckBox();
            this.buttonSettingsSetAddonsPath = new System.Windows.Forms.Button();
            this.textBoxSettingsAddonsPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSettingsAccept = new System.Windows.Forms.Button();
            this.textBoxSettingsAdditionalParameters = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxSettingsShowErrors = new System.Windows.Forms.CheckBox();
            this.checkBoxSettingsShowBohemiaIntro = new System.Windows.Forms.CheckBox();
            this.checkBoxSettingsStartWithEmptyWorld = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonProfileAdd = new System.Windows.Forms.Button();
            this.buttonProfileDelete = new System.Windows.Forms.Button();
            this.buttonProfileEdit = new System.Windows.Forms.Button();
            this.listBoxProfiles = new System.Windows.Forms.ListBox();
            this.comboBoxSelectModset = new System.Windows.Forms.ComboBox();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.comboBoxSelectServer = new System.Windows.Forms.ComboBox();
            this.buttonStartArma = new System.Windows.Forms.Button();
            this.pictureBoxFoundArma = new System.Windows.Forms.PictureBox();
            this.buttonProfilesAddCurrentSelection = new System.Windows.Forms.Button();
            this.buttonProfilesActivate = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoundArma)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxAddons
            // 
            this.checkedListBoxAddons.CheckOnClick = true;
            this.checkedListBoxAddons.FormattingEnabled = true;
            this.checkedListBoxAddons.Location = new System.Drawing.Point(12, 79);
            this.checkedListBoxAddons.Name = "checkedListBoxAddons";
            this.checkedListBoxAddons.Size = new System.Drawing.Size(255, 409);
            this.checkedListBoxAddons.TabIndex = 0;
            this.checkedListBoxAddons.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxAddons_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Installierte Addons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pfad zu Arma 3";
            // 
            // textBoxPathToArma
            // 
            this.textBoxPathToArma.Location = new System.Drawing.Point(37, 25);
            this.textBoxPathToArma.Name = "textBoxPathToArma";
            this.textBoxPathToArma.Size = new System.Drawing.Size(775, 20);
            this.textBoxPathToArma.TabIndex = 3;
            this.textBoxPathToArma.TextChanged += new System.EventHandler(this.textBoxPathToArma_TextChanged);
            // 
            // buttonSearchForArma
            // 
            this.buttonSearchForArma.Location = new System.Drawing.Point(818, 23);
            this.buttonSearchForArma.Name = "buttonSearchForArma";
            this.buttonSearchForArma.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchForArma.TabIndex = 4;
            this.buttonSearchForArma.Text = "Öffnen";
            this.buttonSearchForArma.UseVisualStyleBackColor = true;
            this.buttonSearchForArma.Click += new System.EventHandler(this.buttonSearchForArma_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Location = new System.Drawing.Point(273, 64);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(624, 424);
            this.tabControlMain.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelDownloadSpeed);
            this.tabPage1.Controls.Add(this.labelLastDownload);
            this.tabPage1.Controls.Add(this.buttonDownloadNow);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.checkedListBoxAddonsForDownload);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(616, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Addons";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelDownloadSpeed
            // 
            this.labelDownloadSpeed.AutoSize = true;
            this.labelDownloadSpeed.Location = new System.Drawing.Point(310, 353);
            this.labelDownloadSpeed.Name = "labelDownloadSpeed";
            this.labelDownloadSpeed.Size = new System.Drawing.Size(170, 13);
            this.labelDownloadSpeed.TabIndex = 4;
            this.labelDownloadSpeed.Text = "Downloadgeschwindigkeit: 0 KB/s";
            // 
            // labelLastDownload
            // 
            this.labelLastDownload.AutoSize = true;
            this.labelLastDownload.Location = new System.Drawing.Point(129, 353);
            this.labelLastDownload.Name = "labelLastDownload";
            this.labelLastDownload.Size = new System.Drawing.Size(150, 13);
            this.labelLastDownload.TabIndex = 3;
            this.labelLastDownload.Text = "Letzter Download: 00.00.0000";
            // 
            // buttonDownloadNow
            // 
            this.buttonDownloadNow.Location = new System.Drawing.Point(6, 348);
            this.buttonDownloadNow.Name = "buttonDownloadNow";
            this.buttonDownloadNow.Size = new System.Drawing.Size(117, 23);
            this.buttonDownloadNow.TabIndex = 2;
            this.buttonDownloadNow.Text = "Jetzt downloaden";
            this.buttonDownloadNow.UseVisualStyleBackColor = true;
            this.buttonDownloadNow.Click += new System.EventHandler(this.buttonDownloadNow_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Addons zum Download";
            // 
            // checkedListBoxAddonsForDownload
            // 
            this.checkedListBoxAddonsForDownload.CheckOnClick = true;
            this.checkedListBoxAddonsForDownload.FormattingEnabled = true;
            this.checkedListBoxAddonsForDownload.Location = new System.Drawing.Point(6, 23);
            this.checkedListBoxAddonsForDownload.Name = "checkedListBoxAddonsForDownload";
            this.checkedListBoxAddonsForDownload.Size = new System.Drawing.Size(604, 319);
            this.checkedListBoxAddonsForDownload.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonSettingsShowModstring);
            this.tabPage2.Controls.Add(this.buttonSettingsReloadAddons);
            this.tabPage2.Controls.Add(this.buttonSettingsEditPasswords);
            this.tabPage2.Controls.Add(this.checkBoxSettingsPauseOnDesktop);
            this.tabPage2.Controls.Add(this.buttonSettingsSetAddonsPath);
            this.tabPage2.Controls.Add(this.textBoxSettingsAddonsPath);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.buttonSettingsAccept);
            this.tabPage2.Controls.Add(this.textBoxSettingsAdditionalParameters);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.checkBoxSettingsShowErrors);
            this.tabPage2.Controls.Add(this.checkBoxSettingsShowBohemiaIntro);
            this.tabPage2.Controls.Add(this.checkBoxSettingsStartWithEmptyWorld);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Einstellungen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSettingsShowModstring
            // 
            this.buttonSettingsShowModstring.Location = new System.Drawing.Point(7, 259);
            this.buttonSettingsShowModstring.Name = "buttonSettingsShowModstring";
            this.buttonSettingsShowModstring.Size = new System.Drawing.Size(124, 23);
            this.buttonSettingsShowModstring.TabIndex = 15;
            this.buttonSettingsShowModstring.Text = "Modstring anzeigen";
            this.buttonSettingsShowModstring.UseVisualStyleBackColor = true;
            this.buttonSettingsShowModstring.Click += new System.EventHandler(this.buttonSettingsShowModstring_Click);
            // 
            // buttonSettingsReloadAddons
            // 
            this.buttonSettingsReloadAddons.Location = new System.Drawing.Point(7, 230);
            this.buttonSettingsReloadAddons.Name = "buttonSettingsReloadAddons";
            this.buttonSettingsReloadAddons.Size = new System.Drawing.Size(124, 23);
            this.buttonSettingsReloadAddons.TabIndex = 14;
            this.buttonSettingsReloadAddons.Text = "Addons neu laden";
            this.buttonSettingsReloadAddons.UseVisualStyleBackColor = true;
            this.buttonSettingsReloadAddons.Click += new System.EventHandler(this.buttonSettingsReloadAddons_Click);
            // 
            // buttonSettingsEditPasswords
            // 
            this.buttonSettingsEditPasswords.Location = new System.Drawing.Point(7, 200);
            this.buttonSettingsEditPasswords.Name = "buttonSettingsEditPasswords";
            this.buttonSettingsEditPasswords.Size = new System.Drawing.Size(124, 23);
            this.buttonSettingsEditPasswords.TabIndex = 13;
            this.buttonSettingsEditPasswords.Text = "Passwörter verwalten";
            this.buttonSettingsEditPasswords.UseVisualStyleBackColor = true;
            this.buttonSettingsEditPasswords.Click += new System.EventHandler(this.buttonSettingsEditPasswords_Click);
            // 
            // checkBoxSettingsPauseOnDesktop
            // 
            this.checkBoxSettingsPauseOnDesktop.AutoSize = true;
            this.checkBoxSettingsPauseOnDesktop.Location = new System.Drawing.Point(6, 76);
            this.checkBoxSettingsPauseOnDesktop.Name = "checkBoxSettingsPauseOnDesktop";
            this.checkBoxSettingsPauseOnDesktop.Size = new System.Drawing.Size(335, 17);
            this.checkBoxSettingsPauseOnDesktop.TabIndex = 12;
            this.checkBoxSettingsPauseOnDesktop.Text = "Arma Pausieren wenn auf Desktop (Hauptmenü und Singleplayer)";
            this.checkBoxSettingsPauseOnDesktop.UseVisualStyleBackColor = true;
            // 
            // buttonSettingsSetAddonsPath
            // 
            this.buttonSettingsSetAddonsPath.Location = new System.Drawing.Point(531, 171);
            this.buttonSettingsSetAddonsPath.Name = "buttonSettingsSetAddonsPath";
            this.buttonSettingsSetAddonsPath.Size = new System.Drawing.Size(75, 23);
            this.buttonSettingsSetAddonsPath.TabIndex = 11;
            this.buttonSettingsSetAddonsPath.Text = "Öffnen";
            this.buttonSettingsSetAddonsPath.UseVisualStyleBackColor = true;
            this.buttonSettingsSetAddonsPath.Click += new System.EventHandler(this.buttonSettingsSetAddonsPath_Click);
            // 
            // textBoxSettingsAddonsPath
            // 
            this.textBoxSettingsAddonsPath.Location = new System.Drawing.Point(6, 173);
            this.textBoxSettingsAddonsPath.Name = "textBoxSettingsAddonsPath";
            this.textBoxSettingsAddonsPath.Size = new System.Drawing.Size(519, 20);
            this.textBoxSettingsAddonsPath.TabIndex = 7;
            this.textBoxSettingsAddonsPath.TextChanged += new System.EventHandler(this.textBoxSettingsAddonsPath_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Addons Pfad";
            // 
            // buttonSettingsAccept
            // 
            this.buttonSettingsAccept.Location = new System.Drawing.Point(520, 369);
            this.buttonSettingsAccept.Name = "buttonSettingsAccept";
            this.buttonSettingsAccept.Size = new System.Drawing.Size(90, 23);
            this.buttonSettingsAccept.TabIndex = 5;
            this.buttonSettingsAccept.Text = "Übernehmen";
            this.buttonSettingsAccept.UseVisualStyleBackColor = true;
            this.buttonSettingsAccept.Click += new System.EventHandler(this.buttonSettingsAccept_Click);
            // 
            // textBoxSettingsAdditionalParameters
            // 
            this.textBoxSettingsAdditionalParameters.Location = new System.Drawing.Point(6, 125);
            this.textBoxSettingsAdditionalParameters.Name = "textBoxSettingsAdditionalParameters";
            this.textBoxSettingsAdditionalParameters.Size = new System.Drawing.Size(600, 20);
            this.textBoxSettingsAdditionalParameters.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Weitere Startparameter";
            // 
            // checkBoxSettingsShowErrors
            // 
            this.checkBoxSettingsShowErrors.AutoSize = true;
            this.checkBoxSettingsShowErrors.Location = new System.Drawing.Point(6, 53);
            this.checkBoxSettingsShowErrors.Name = "checkBoxSettingsShowErrors";
            this.checkBoxSettingsShowErrors.Size = new System.Drawing.Size(125, 17);
            this.checkBoxSettingsShowErrors.TabIndex = 2;
            this.checkBoxSettingsShowErrors.Text = "Scriptfehler anzeigen";
            this.checkBoxSettingsShowErrors.UseVisualStyleBackColor = true;
            // 
            // checkBoxSettingsShowBohemiaIntro
            // 
            this.checkBoxSettingsShowBohemiaIntro.AutoSize = true;
            this.checkBoxSettingsShowBohemiaIntro.Checked = true;
            this.checkBoxSettingsShowBohemiaIntro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSettingsShowBohemiaIntro.Location = new System.Drawing.Point(6, 30);
            this.checkBoxSettingsShowBohemiaIntro.Name = "checkBoxSettingsShowBohemiaIntro";
            this.checkBoxSettingsShowBohemiaIntro.Size = new System.Drawing.Size(208, 17);
            this.checkBoxSettingsShowBohemiaIntro.TabIndex = 1;
            this.checkBoxSettingsShowBohemiaIntro.Text = "Bohemia Interactive Intro überspringen";
            this.checkBoxSettingsShowBohemiaIntro.UseVisualStyleBackColor = true;
            // 
            // checkBoxSettingsStartWithEmptyWorld
            // 
            this.checkBoxSettingsStartWithEmptyWorld.AutoSize = true;
            this.checkBoxSettingsStartWithEmptyWorld.Checked = true;
            this.checkBoxSettingsStartWithEmptyWorld.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSettingsStartWithEmptyWorld.Location = new System.Drawing.Point(6, 7);
            this.checkBoxSettingsStartWithEmptyWorld.Name = "checkBoxSettingsStartWithEmptyWorld";
            this.checkBoxSettingsStartWithEmptyWorld.Size = new System.Drawing.Size(304, 17);
            this.checkBoxSettingsStartWithEmptyWorld.TabIndex = 0;
            this.checkBoxSettingsStartWithEmptyWorld.Text = "Leere Welt beim Start laden (Arma 3 startet damit schneller)";
            this.checkBoxSettingsStartWithEmptyWorld.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonProfilesActivate);
            this.tabPage3.Controls.Add(this.buttonProfilesAddCurrentSelection);
            this.tabPage3.Controls.Add(this.buttonProfileAdd);
            this.tabPage3.Controls.Add(this.buttonProfileDelete);
            this.tabPage3.Controls.Add(this.buttonProfileEdit);
            this.tabPage3.Controls.Add(this.listBoxProfiles);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(616, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Profile";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonProfileAdd
            // 
            this.buttonProfileAdd.Location = new System.Drawing.Point(4, 352);
            this.buttonProfileAdd.Name = "buttonProfileAdd";
            this.buttonProfileAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonProfileAdd.TabIndex = 3;
            this.buttonProfileAdd.Text = "Hinzufügen";
            this.buttonProfileAdd.UseVisualStyleBackColor = true;
            this.buttonProfileAdd.Click += new System.EventHandler(this.buttonProfileAdd_Click);
            // 
            // buttonProfileDelete
            // 
            this.buttonProfileDelete.Location = new System.Drawing.Point(324, 352);
            this.buttonProfileDelete.Name = "buttonProfileDelete";
            this.buttonProfileDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonProfileDelete.TabIndex = 2;
            this.buttonProfileDelete.Text = "Löschen";
            this.buttonProfileDelete.UseVisualStyleBackColor = true;
            this.buttonProfileDelete.Click += new System.EventHandler(this.buttonProfileDelete_Click);
            // 
            // buttonProfileEdit
            // 
            this.buttonProfileEdit.Location = new System.Drawing.Point(243, 352);
            this.buttonProfileEdit.Name = "buttonProfileEdit";
            this.buttonProfileEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonProfileEdit.TabIndex = 1;
            this.buttonProfileEdit.Text = "Bearbeiten";
            this.buttonProfileEdit.UseVisualStyleBackColor = true;
            this.buttonProfileEdit.Click += new System.EventHandler(this.buttonProfileEdit_Click);
            // 
            // listBoxProfiles
            // 
            this.listBoxProfiles.FormattingEnabled = true;
            this.listBoxProfiles.Location = new System.Drawing.Point(4, 4);
            this.listBoxProfiles.Name = "listBoxProfiles";
            this.listBoxProfiles.Size = new System.Drawing.Size(609, 342);
            this.listBoxProfiles.TabIndex = 0;
            // 
            // comboBoxSelectModset
            // 
            this.comboBoxSelectModset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectModset.Items.AddRange(new object[] {
            "Modset auswählen"});
            this.comboBoxSelectModset.Location = new System.Drawing.Point(146, 490);
            this.comboBoxSelectModset.Name = "comboBoxSelectModset";
            this.comboBoxSelectModset.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectModset.TabIndex = 6;
            this.comboBoxSelectModset.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectModset_SelectedIndexChanged);
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(12, 493);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(92, 17);
            this.checkBoxSelectAll.TabIndex = 7;
            this.checkBoxSelectAll.Text = "Alle markieren";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // comboBoxSelectServer
            // 
            this.comboBoxSelectServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectServer.Items.AddRange(new object[] {
            "Server auswählen"});
            this.comboBoxSelectServer.Location = new System.Drawing.Point(691, 491);
            this.comboBoxSelectServer.Name = "comboBoxSelectServer";
            this.comboBoxSelectServer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectServer.TabIndex = 8;
            // 
            // buttonStartArma
            // 
            this.buttonStartArma.Location = new System.Drawing.Point(818, 490);
            this.buttonStartArma.Name = "buttonStartArma";
            this.buttonStartArma.Size = new System.Drawing.Size(75, 23);
            this.buttonStartArma.TabIndex = 9;
            this.buttonStartArma.Text = "Starten";
            this.buttonStartArma.UseVisualStyleBackColor = true;
            this.buttonStartArma.Click += new System.EventHandler(this.buttonStartArma_Click);
            // 
            // pictureBoxFoundArma
            // 
            this.pictureBoxFoundArma.BackgroundImage = global::LegionLauncher.Properties.Resources.icon_delete;
            this.pictureBoxFoundArma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFoundArma.Location = new System.Drawing.Point(10, 24);
            this.pictureBoxFoundArma.Name = "pictureBoxFoundArma";
            this.pictureBoxFoundArma.Size = new System.Drawing.Size(21, 21);
            this.pictureBoxFoundArma.TabIndex = 10;
            this.pictureBoxFoundArma.TabStop = false;
            // 
            // buttonProfilesAddCurrentSelection
            // 
            this.buttonProfilesAddCurrentSelection.Location = new System.Drawing.Point(85, 352);
            this.buttonProfilesAddCurrentSelection.Name = "buttonProfilesAddCurrentSelection";
            this.buttonProfilesAddCurrentSelection.Size = new System.Drawing.Size(152, 23);
            this.buttonProfilesAddCurrentSelection.TabIndex = 4;
            this.buttonProfilesAddCurrentSelection.Text = "Aktuelle Auswahl hinzufügen";
            this.buttonProfilesAddCurrentSelection.UseVisualStyleBackColor = true;
            this.buttonProfilesAddCurrentSelection.Click += new System.EventHandler(this.buttonProfilesAddCurrentSelection_Click);
            // 
            // buttonProfilesActivate
            // 
            this.buttonProfilesActivate.Location = new System.Drawing.Point(538, 352);
            this.buttonProfilesActivate.Name = "buttonProfilesActivate";
            this.buttonProfilesActivate.Size = new System.Drawing.Size(75, 23);
            this.buttonProfilesActivate.TabIndex = 5;
            this.buttonProfilesActivate.Text = "Aktivieren";
            this.buttonProfilesActivate.UseVisualStyleBackColor = true;
            this.buttonProfilesActivate.Click += new System.EventHandler(this.buttonProfilesActivate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 527);
            this.Controls.Add(this.pictureBoxFoundArma);
            this.Controls.Add(this.buttonStartArma);
            this.Controls.Add(this.comboBoxSelectServer);
            this.Controls.Add(this.checkBoxSelectAll);
            this.Controls.Add(this.comboBoxSelectModset);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.buttonSearchForArma);
            this.Controls.Add(this.textBoxPathToArma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxAddons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(925, 565);
            this.MinimumSize = new System.Drawing.Size(925, 565);
            this.Name = "Form1";
            this.Text = "Legion Launcher 2.0.1 BETA >_<";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoundArma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxAddons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPathToArma;
        private System.Windows.Forms.Button buttonSearchForArma;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxSelectModset;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.Windows.Forms.ComboBox comboBoxSelectServer;
        private System.Windows.Forms.Button buttonStartArma;
        private System.Windows.Forms.TextBox textBoxSettingsAdditionalParameters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxSettingsShowErrors;
        private System.Windows.Forms.CheckBox checkBoxSettingsShowBohemiaIntro;
        private System.Windows.Forms.CheckBox checkBoxSettingsStartWithEmptyWorld;
        private System.Windows.Forms.Button buttonSettingsAccept;
        private System.Windows.Forms.PictureBox pictureBoxFoundArma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBoxAddonsForDownload;
        private System.Windows.Forms.Label labelDownloadSpeed;
        private System.Windows.Forms.Label labelLastDownload;
        private System.Windows.Forms.Button buttonDownloadNow;
        private System.Windows.Forms.TextBox textBoxSettingsAddonsPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSettingsSetAddonsPath;
        private System.Windows.Forms.CheckBox checkBoxSettingsPauseOnDesktop;
        private System.Windows.Forms.Button buttonSettingsEditPasswords;
        private System.Windows.Forms.Button buttonSettingsShowModstring;
        private System.Windows.Forms.Button buttonSettingsReloadAddons;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonProfileAdd;
        private System.Windows.Forms.Button buttonProfileDelete;
        private System.Windows.Forms.Button buttonProfileEdit;
        private System.Windows.Forms.ListBox listBoxProfiles;
        private System.Windows.Forms.Button buttonProfilesAddCurrentSelection;
        private System.Windows.Forms.Button buttonProfilesActivate;

    }
}

