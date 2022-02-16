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
            this.Folder = new System.Windows.Forms.Button();
            this.chosenPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.allFilesButton = new System.Windows.Forms.RadioButton();
            this.nameSearchButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
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
            // chosenPath
            // 
            this.chosenPath.Font = new System.Drawing.Font("Varela Round", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenPath.Location = new System.Drawing.Point(12, 75);
            this.chosenPath.Name = "chosenPath";
            this.chosenPath.Size = new System.Drawing.Size(404, 23);
            this.chosenPath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Varela Round", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(215, 118);
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
            this.allFilesButton.Location = new System.Drawing.Point(258, 3);
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
            this.nameSearchButton.Location = new System.Drawing.Point(182, 40);
            this.nameSearchButton.Name = "nameSearchButton";
            this.nameSearchButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameSearchButton.Size = new System.Drawing.Size(215, 31);
            this.nameSearchButton.TabIndex = 6;
            this.nameSearchButton.TabStop = true;
            this.nameSearchButton.Text = "חיפוש בשם הקובץ:";
            this.nameSearchButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Varela Round", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 23);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Varela Round", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(3, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 23);
            this.textBox2.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButton1.Location = new System.Drawing.Point(175, 77);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(222, 31);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "חיפוש בתוכן הקובץ:";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.nameSearchButton);
            this.panel1.Controls.Add(this.allFilesButton);
            this.panel1.Location = new System.Drawing.Point(12, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 127);
            this.panel1.TabIndex = 10;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(198, 325);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 20);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Searcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.radioButton2);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

