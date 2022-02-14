namespace LolCopyGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblGameFolder = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.btnGetLanguage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameFolder
            // 
            this.lblGameFolder.AutoSize = true;
            this.lblGameFolder.Location = new System.Drawing.Point(12, 38);
            this.lblGameFolder.Name = "lblGameFolder";
            this.lblGameFolder.Size = new System.Drawing.Size(16, 15);
            this.lblGameFolder.TabIndex = 0;
            this.lblGameFolder.Text = "...";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 8);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(122, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select Game Folder";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(363, 8);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(60, 23);
            this.cbLanguage.TabIndex = 2;
            // 
            // btnGetLanguage
            // 
            this.btnGetLanguage.Location = new System.Drawing.Point(363, 34);
            this.btnGetLanguage.Name = "btnGetLanguage";
            this.btnGetLanguage.Size = new System.Drawing.Size(60, 23);
            this.btnGetLanguage.TabIndex = 3;
            this.btnGetLanguage.Text = "Copy";
            this.btnGetLanguage.UseVisualStyleBackColor = true;
            this.btnGetLanguage.Click += new System.EventHandler(this.btnGetLanguage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 60);
            this.Controls.Add(this.btnGetLanguage);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblGameFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "League Of LEgends Language Copier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGameFolder;
        private Button btnSelect;
        private ComboBox cbLanguage;
        private Button btnGetLanguage;
    }
}