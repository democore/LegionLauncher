namespace LegionLauncher
{
    partial class EditPasswords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPasswords));
            this.listBoxSavedPasswords = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSavedPasswords
            // 
            this.listBoxSavedPasswords.FormattingEnabled = true;
            this.listBoxSavedPasswords.Location = new System.Drawing.Point(12, 28);
            this.listBoxSavedPasswords.Name = "listBoxSavedPasswords";
            this.listBoxSavedPasswords.Size = new System.Drawing.Size(327, 212);
            this.listBoxSavedPasswords.TabIndex = 0;
            this.listBoxSavedPasswords.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSavedPasswords_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server mit gespeichertem Passwort (Doppelklick zum bearbeiten)";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(264, 254);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 3;
            this.buttonAccept.Text = "Schließen";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // EditPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 289);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSavedPasswords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPasswords";
            this.Text = "Passwörter verwalten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSavedPasswords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAccept;
    }
}