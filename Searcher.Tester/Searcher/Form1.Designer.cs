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
            this.label2 = new System.Windows.Forms.Label();
            this.deleteFilesButton = new System.Windows.Forms.RadioButton();
            this.transferFilesButton = new System.Windows.Forms.RadioButton();
            this.actionChosenPath = new System.Windows.Forms.TextBox();
            this.folderBrowser2ndButton = new System.Windows.Forms.Button();
            this.switchFromName = new System.Windows.Forms.TextBox();
            this.switchInName = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.switchToName = new System.Windows.Forms.TextBox();
            this.switchToContext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.switchFromContext = new System.Windows.Forms.TextBox();
            this.switchInContext = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.Folder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseFolder
            // 
            this.chooseFolder.AutoSize = true;
            this.chooseFolder.Font = new System.Drawing.Font("Varela Round", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chooseFolder.Location = new System.Drawing.Point(191, 18);
            this.chooseFolder.Name = "chooseFolder";
            this.chooseFolder.Size = new System.Drawing.Size(163, 37);
            this.chooseFolder.TabIndex = 1;
            this.chooseFolder.Text = "בחר תיקייה";
            this.chooseFolder.Click += new System.EventHandler(this.label1_Click);
            // 
            // chosenPath
            // 
            this.chosenPath.Font = new System.Drawing.Font("Varela Round", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenPath.Location = new System.Drawing.Point(23, 67);
            this.chosenPath.Name = "chosenPath";
            this.chosenPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chosenPath.Size = new System.Drawing.Size(404, 23);
            this.chosenPath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Varela Round", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(16, 125);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(215, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "בחר סוג חיפוש:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // allFilesButton
            // 
            this.allFilesButton.AutoSize = true;
            this.allFilesButton.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.allFilesButton.Location = new System.Drawing.Point(293, 13);
            this.allFilesButton.Name = "allFilesButton";
            this.allFilesButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.allFilesButton.Size = new System.Drawing.Size(130, 31);
            this.allFilesButton.TabIndex = 5;
            this.allFilesButton.TabStop = true;
            this.allFilesButton.Text = "כל הקבצים";
            this.allFilesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.allFilesButton.UseVisualStyleBackColor = true;
            this.allFilesButton.CheckedChanged += new System.EventHandler(this.allFilesButton_CheckedChanged);
            // 
            // nameSearchButton
            // 
            this.nameSearchButton.AutoSize = true;
            this.nameSearchButton.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameSearchButton.Location = new System.Drawing.Point(224, 50);
            this.nameSearchButton.Name = "nameSearchButton";
            this.nameSearchButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameSearchButton.Size = new System.Drawing.Size(199, 31);
            this.nameSearchButton.TabIndex = 6;
            this.nameSearchButton.TabStop = true;
            this.nameSearchButton.Text = "חיפוש בשם הקובץ:";
            this.nameSearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameSearchButton.UseVisualStyleBackColor = true;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Font = new System.Drawing.Font("Varela Round", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameTextBox.Location = new System.Drawing.Point(19, 57);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fileNameTextBox.Size = new System.Drawing.Size(194, 23);
            this.fileNameTextBox.TabIndex = 7;
            this.fileNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fileContextTextBox
            // 
            this.fileContextTextBox.Font = new System.Drawing.Font("Varela Round", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileContextTextBox.Location = new System.Drawing.Point(19, 95);
            this.fileContextTextBox.Name = "fileContextTextBox";
            this.fileContextTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fileContextTextBox.Size = new System.Drawing.Size(192, 23);
            this.fileContextTextBox.TabIndex = 9;
            this.fileContextTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextSearchButton
            // 
            this.contextSearchButton.AutoSize = true;
            this.contextSearchButton.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.contextSearchButton.Location = new System.Drawing.Point(219, 87);
            this.contextSearchButton.Name = "contextSearchButton";
            this.contextSearchButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextSearchButton.Size = new System.Drawing.Size(204, 31);
            this.contextSearchButton.TabIndex = 8;
            this.contextSearchButton.TabStop = true;
            this.contextSearchButton.Text = "חיפוש בתוכן הקובץ:";
            this.contextSearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.contextSearchButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fileContextTextBox);
            this.panel1.Controls.Add(this.contextSearchButton);
            this.panel1.Controls.Add(this.fileNameTextBox);
            this.panel1.Controls.Add(this.nameSearchButton);
            this.panel1.Controls.Add(this.allFilesButton);
            this.panel1.Location = new System.Drawing.Point(3, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 127);
            this.panel1.TabIndex = 10;
            // 
            // FolderButtonExp
            // 
            this.FolderButtonExp.AutoSize = true;
            this.FolderButtonExp.Font = new System.Drawing.Font("Varela Round", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FolderButtonExp.Location = new System.Drawing.Point(24, 93);
            this.FolderButtonExp.Name = "FolderButtonExp";
            this.FolderButtonExp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FolderButtonExp.Size = new System.Drawing.Size(316, 17);
            this.FolderButtonExp.TabIndex = 11;
            this.FolderButtonExp.Text = "*לחץ על תמונת התיקייה על מנת לפתוח את בורר התיקיות";
            this.FolderButtonExp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Varela Round", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(16, 370);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(196, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "פעולה לביצוע:";
            // 
            // deleteFilesButton
            // 
            this.deleteFilesButton.AutoSize = true;
            this.deleteFilesButton.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.deleteFilesButton.ForeColor = System.Drawing.Color.Red;
            this.deleteFilesButton.Location = new System.Drawing.Point(286, 10);
            this.deleteFilesButton.Name = "deleteFilesButton";
            this.deleteFilesButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deleteFilesButton.Size = new System.Drawing.Size(136, 31);
            this.deleteFilesButton.TabIndex = 14;
            this.deleteFilesButton.TabStop = true;
            this.deleteFilesButton.Text = "מחק קבצים";
            this.deleteFilesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteFilesButton.UseVisualStyleBackColor = true;
            this.deleteFilesButton.CheckedChanged += new System.EventHandler(this.deleteFilesButton_CheckedChanged);
            // 
            // transferFilesButton
            // 
            this.transferFilesButton.AutoSize = true;
            this.transferFilesButton.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.transferFilesButton.Location = new System.Drawing.Point(258, 47);
            this.transferFilesButton.Name = "transferFilesButton";
            this.transferFilesButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transferFilesButton.Size = new System.Drawing.Size(164, 31);
            this.transferFilesButton.TabIndex = 15;
            this.transferFilesButton.TabStop = true;
            this.transferFilesButton.Text = "העבר קבצים ל:";
            this.transferFilesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.transferFilesButton.UseVisualStyleBackColor = true;
            this.transferFilesButton.CheckedChanged += new System.EventHandler(this.transferFilesButton_CheckedChanged);
            // 
            // actionChosenPath
            // 
            this.actionChosenPath.Font = new System.Drawing.Font("Varela Round", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionChosenPath.Location = new System.Drawing.Point(53, 55);
            this.actionChosenPath.Name = "actionChosenPath";
            this.actionChosenPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.actionChosenPath.Size = new System.Drawing.Size(199, 23);
            this.actionChosenPath.TabIndex = 18;
            this.actionChosenPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.actionChosenPath.TextChanged += new System.EventHandler(this.actionChosenPath_TextChanged);
            // 
            // folderBrowser2ndButton
            // 
            this.folderBrowser2ndButton.Font = new System.Drawing.Font("Varela Round", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.folderBrowser2ndButton.Location = new System.Drawing.Point(18, 55);
            this.folderBrowser2ndButton.Name = "folderBrowser2ndButton";
            this.folderBrowser2ndButton.Size = new System.Drawing.Size(36, 23);
            this.folderBrowser2ndButton.TabIndex = 19;
            this.folderBrowser2ndButton.Text = "...";
            this.folderBrowser2ndButton.UseVisualStyleBackColor = true;
            this.folderBrowser2ndButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // switchFromName
            // 
            this.switchFromName.Font = new System.Drawing.Font("Varela Round", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchFromName.Location = new System.Drawing.Point(178, 92);
            this.switchFromName.Name = "switchFromName";
            this.switchFromName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.switchFromName.Size = new System.Drawing.Size(111, 23);
            this.switchFromName.TabIndex = 21;
            this.switchFromName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.switchFromName.TextChanged += new System.EventHandler(this.switchFromName_TextChanged);
            // 
            // switchInName
            // 
            this.switchInName.AutoSize = true;
            this.switchInName.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.switchInName.Location = new System.Drawing.Point(286, 86);
            this.switchInName.Name = "switchInName";
            this.switchInName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.switchInName.Size = new System.Drawing.Size(136, 31);
            this.switchInName.TabIndex = 20;
            this.switchInName.TabStop = true;
            this.switchInName.Text = "החלף שם מ";
            this.switchInName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.switchInName.UseVisualStyleBackColor = true;
            this.switchInName.CheckedChanged += new System.EventHandler(this.switchInName_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(149, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "ל";
            // 
            // switchToName
            // 
            this.switchToName.Font = new System.Drawing.Font("Varela Round", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchToName.Location = new System.Drawing.Point(18, 92);
            this.switchToName.Name = "switchToName";
            this.switchToName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.switchToName.Size = new System.Drawing.Size(125, 23);
            this.switchToName.TabIndex = 23;
            this.switchToName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // switchToContext
            // 
            this.switchToContext.Font = new System.Drawing.Font("Varela Round", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchToContext.Location = new System.Drawing.Point(18, 128);
            this.switchToContext.Name = "switchToContext";
            this.switchToContext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.switchToContext.Size = new System.Drawing.Size(104, 23);
            this.switchToContext.TabIndex = 27;
            this.switchToContext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(128, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 27);
            this.label4.TabIndex = 26;
            this.label4.Text = "ל";
            // 
            // switchFromContext
            // 
            this.switchFromContext.Font = new System.Drawing.Font("Varela Round", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchFromContext.Location = new System.Drawing.Point(157, 128);
            this.switchFromContext.Name = "switchFromContext";
            this.switchFromContext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.switchFromContext.Size = new System.Drawing.Size(111, 23);
            this.switchFromContext.TabIndex = 25;
            this.switchFromContext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // switchInContext
            // 
            this.switchInContext.AutoSize = true;
            this.switchInContext.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.switchInContext.Location = new System.Drawing.Point(268, 121);
            this.switchInContext.Name = "switchInContext";
            this.switchInContext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.switchInContext.Size = new System.Drawing.Size(154, 31);
            this.switchInContext.TabIndex = 24;
            this.switchInContext.TabStop = true;
            this.switchInContext.Text = "החלף בתוכן מ";
            this.switchInContext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.switchInContext.UseVisualStyleBackColor = true;
            this.switchInContext.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.switchToContext);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.switchFromContext);
            this.panel2.Controls.Add(this.switchInContext);
            this.panel2.Controls.Add(this.switchToName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.switchFromName);
            this.panel2.Controls.Add(this.switchInName);
            this.panel2.Controls.Add(this.folderBrowser2ndButton);
            this.panel2.Controls.Add(this.actionChosenPath);
            this.panel2.Controls.Add(this.transferFilesButton);
            this.panel2.Controls.Add(this.deleteFilesButton);
            this.panel2.Location = new System.Drawing.Point(3, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 187);
            this.panel2.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Searcher.Properties.Resources.noatun_play_start_arrow_60481;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(338, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 87);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::Searcher.Properties.Resources.iconfinder_search_4341327_1205532;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(338, 298);
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
            this.Folder.Location = new System.Drawing.Point(109, 10);
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
            this.ClientSize = new System.Drawing.Size(455, 702);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.FolderButtonExp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chosenPath);
            this.Controls.Add(this.Folder);
            this.Controls.Add(this.chooseFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Searcher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "המחפש";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton deleteFilesButton;
        private System.Windows.Forms.RadioButton transferFilesButton;
        private System.Windows.Forms.TextBox actionChosenPath;
        private System.Windows.Forms.Button folderBrowser2ndButton;
        private System.Windows.Forms.TextBox switchFromName;
        private System.Windows.Forms.RadioButton switchInName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox switchToName;
        private System.Windows.Forms.TextBox switchToContext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox switchFromContext;
        private System.Windows.Forms.RadioButton switchInContext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}

