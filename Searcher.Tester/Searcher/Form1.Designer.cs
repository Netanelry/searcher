namespace Searcher
{
    partial class Searcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Searcher));
            this.chooseFolder = new System.Windows.Forms.Label();
            this.chosenPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.allFilesButton = new System.Windows.Forms.RadioButton();
            this.nameSearchButton = new System.Windows.Forms.RadioButton();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.fileContextTextBox = new System.Windows.Forms.TextBox();
            this.contextSearchButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FolderButtonExp = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.Folder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseFolder
            // 
            this.chooseFolder.AutoSize = true;
            this.chooseFolder.Font = new System.Drawing.Font("Varela Round", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chooseFolder.Location = new System.Drawing.Point(191, 26);
            this.chooseFolder.Name = "chooseFolder";
            this.chooseFolder.Size = new System.Drawing.Size(153, 37);
            this.chooseFolder.TabIndex = 1;
            this.chooseFolder.Text = "בחר תיקייה";
            this.chooseFolder.Click += new System.EventHandler(this.label1_Click);
            // 
            // chosenPath
            // 
            this.chosenPath.Font = new System.Drawing.Font("Varela Round", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenPath.Location = new System.Drawing.Point(23, 75);
            this.chosenPath.Name = "chosenPath";
            this.chosenPath.Size = new System.Drawing.Size(404, 23);
            this.chosenPath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Varela Round", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(233, 133);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(201, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "בחר סוג חיפוש:";
            // 
            // allFilesButton
            // 
            this.allFilesButton.AutoSize = true;
            this.allFilesButton.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.allFilesButton.Location = new System.Drawing.Point(282, 13);
            this.allFilesButton.Name = "allFilesButton";
            this.allFilesButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.allFilesButton.Size = new System.Drawing.Size(139, 31);
            this.allFilesButton.TabIndex = 5;
            this.allFilesButton.TabStop = true;
            this.allFilesButton.Text = "כל הקבצים";
            this.allFilesButton.UseVisualStyleBackColor = true;
            this.allFilesButton.CheckedChanged += new System.EventHandler(this.allFilesButton_CheckedChanged);
            // 
            // nameSearchButton
            // 
            this.nameSearchButton.AutoSize = true;
            this.nameSearchButton.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameSearchButton.Location = new System.Drawing.Point(206, 47);
            this.nameSearchButton.Name = "nameSearchButton";
            this.nameSearchButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameSearchButton.Size = new System.Drawing.Size(215, 31);
            this.nameSearchButton.TabIndex = 6;
            this.nameSearchButton.TabStop = true;
            this.nameSearchButton.Text = "חיפוש בשם הקובץ:";
            this.nameSearchButton.UseVisualStyleBackColor = true;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Font = new System.Drawing.Font("Varela Round", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameTextBox.Location = new System.Drawing.Point(20, 54);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fileNameTextBox.Size = new System.Drawing.Size(175, 23);
            this.fileNameTextBox.TabIndex = 7;
            this.fileNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fileContextTextBox
            // 
            this.fileContextTextBox.Font = new System.Drawing.Font("Varela Round", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileContextTextBox.Location = new System.Drawing.Point(20, 92);
            this.fileContextTextBox.Name = "fileContextTextBox";
            this.fileContextTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fileContextTextBox.Size = new System.Drawing.Size(175, 23);
            this.fileContextTextBox.TabIndex = 9;
            this.fileContextTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextSearchButton
            // 
            this.contextSearchButton.AutoSize = true;
            this.contextSearchButton.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.contextSearchButton.Location = new System.Drawing.Point(199, 84);
            this.contextSearchButton.Name = "contextSearchButton";
            this.contextSearchButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextSearchButton.Size = new System.Drawing.Size(222, 31);
            this.contextSearchButton.TabIndex = 8;
            this.contextSearchButton.TabStop = true;
            this.contextSearchButton.Text = "חיפוש בתוכן הקובץ:";
            this.contextSearchButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fileContextTextBox);
            this.panel1.Controls.Add(this.contextSearchButton);
            this.panel1.Controls.Add(this.fileNameTextBox);
            this.panel1.Controls.Add(this.nameSearchButton);
            this.panel1.Controls.Add(this.allFilesButton);
            this.panel1.Location = new System.Drawing.Point(3, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 127);
            this.panel1.TabIndex = 10;
            // 
            // FolderButtonExp
            // 
            this.FolderButtonExp.AutoSize = true;
            this.FolderButtonExp.Font = new System.Drawing.Font("Varela Round", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FolderButtonExp.Location = new System.Drawing.Point(59, 101);
            this.FolderButtonExp.Name = "FolderButtonExp";
            this.FolderButtonExp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FolderButtonExp.Size = new System.Drawing.Size(316, 17);
            this.FolderButtonExp.TabIndex = 11;
            this.FolderButtonExp.Text = "*לחץ על תמונת התיקייה על מנת לפתוח את בורר התיקיות";
            this.FolderButtonExp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::Searcher.Properties.Resources.iconfinder_search_4341327_1205532;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(23, 306);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(89, 87);
            this.searchButton.TabIndex = 12;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Folder
            // 
            this.Folder.BackgroundImage = global::Searcher.Properties.Resources.documents_folder_188751;
            this.Folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Folder.FlatAppearance.BorderSize = 0;
            this.Folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Folder.Location = new System.Drawing.Point(109, 18);
            this.Folder.Name = "Folder";
            this.Folder.Size = new System.Drawing.Size(75, 51);
            this.Folder.TabIndex = 2;
            this.Folder.UseVisualStyleBackColor = true;
            this.Folder.Click += new System.EventHandler(this.button1_Click);
            // 
            // Searcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(455, 664);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.FolderButtonExp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chosenPath);
            this.Controls.Add(this.Folder);
            this.Controls.Add(this.chooseFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Searcher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "המחפש";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label chooseFolder;
        private System.Windows.Forms.Button Folder;
        private System.Windows.Forms.TextBox chosenPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton allFilesButton;
        private System.Windows.Forms.RadioButton nameSearchButton;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.TextBox fileContextTextBox;
        private System.Windows.Forms.RadioButton contextSearchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FolderButtonExp;
        private System.Windows.Forms.Button searchButton;
    }
}

