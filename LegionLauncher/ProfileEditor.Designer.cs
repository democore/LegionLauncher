namespace LegionLauncher
{
    partial class ProfileEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileEditor));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.listBoxAddons = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.buttonAddAddon = new System.Windows.Forms.Button();
            this.comboBoxAddAddon = new System.Windows.Forms.ComboBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonDeleteSelection = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(270, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // listBoxAddons
            // 
            this.listBoxAddons.FormattingEnabled = true;
            this.listBoxAddons.Location = new System.Drawing.Point(12, 69);
            this.listBoxAddons.Name = "listBoxAddons";
            this.listBoxAddons.Size = new System.Drawing.Size(270, 225);
            this.listBoxAddons.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Addons";
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(12, 388);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(75, 23);
            this.buttonAbort.TabIndex = 4;
            this.buttonAbort.Text = "Abbrechen";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // buttonAddAddon
            // 
            this.buttonAddAddon.Location = new System.Drawing.Point(207, 350);
            this.buttonAddAddon.Name = "buttonAddAddon";
            this.buttonAddAddon.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAddon.TabIndex = 5;
            this.buttonAddAddon.Text = "Hinzufügen";
            this.buttonAddAddon.UseVisualStyleBackColor = true;
            this.buttonAddAddon.Click += new System.EventHandler(this.buttonAddAddon_Click);
            // 
            // comboBoxAddAddon
            // 
            this.comboBoxAddAddon.FormattingEnabled = true;
            this.comboBoxAddAddon.Location = new System.Drawing.Point(12, 352);
            this.comboBoxAddAddon.Name = "comboBoxAddAddon";
            this.comboBoxAddAddon.Size = new System.Drawing.Size(189, 21);
            this.comboBoxAddAddon.TabIndex = 6;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(207, 388);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 7;
            this.buttonAccept.Text = "Speichern";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonDeleteSelection
            // 
            this.buttonDeleteSelection.Location = new System.Drawing.Point(12, 300);
            this.buttonDeleteSelection.Name = "buttonDeleteSelection";
            this.buttonDeleteSelection.Size = new System.Drawing.Size(118, 23);
            this.buttonDeleteSelection.TabIndex = 8;
            this.buttonDeleteSelection.Text = "Selektion löschen";
            this.buttonDeleteSelection.UseVisualStyleBackColor = true;
            this.buttonDeleteSelection.Click += new System.EventHandler(this.buttonDeleteSelection_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Addon einfügen";
            // 
            // ProfileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 420);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDeleteSelection);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.comboBoxAddAddon);
            this.Controls.Add(this.buttonAddAddon);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxAddons);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfileEditor";
            this.Text = "Profil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ListBox listBoxAddons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.Button buttonAddAddon;
        private System.Windows.Forms.ComboBox comboBoxAddAddon;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonDeleteSelection;
        private System.Windows.Forms.Label label3;
    }
}