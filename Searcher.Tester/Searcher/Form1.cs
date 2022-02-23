using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Searcher
{
    public partial class Searcher : Form
    {
        BusinessLogic.BusinessLogic bl;

        string currentPath = "";
        string desierdPath = "";
        string pattern = "";
        string searchResults = "";
        int counter = 0;

        public Searcher()
        {
            InitializeComponent();
            bl = new BusinessLogic.BusinessLogic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void folderChooser_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "בחר תיקייה";
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                chosenPath.Text = fbd.SelectedPath;
                currentPath = fbd.SelectedPath;
            }
        }

        private void folderBrowserDialog1_HelpRequest_2(object sender, EventArgs e)
        {

        }

        private void allFilesButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<string> listOfFiles = new List<string>();
            if (!Directory.Exists(currentPath))
            {
                MessageBox.Show("תיקייה לא קיימת", "הודעת מערכת");
                return;
            }
            counter = 0;
            searchResults = "";
            if (allFilesButton.Checked)
            {
                listOfFiles = bl.GetAllFiles(currentPath);
            }
            else if (nameSearchButton.Checked)
            {
                pattern = fileNameTextBox.Text;
                listOfFiles = bl.GetFilesByName(currentPath, pattern);
                fileNameTextBox.Text = "";
            }
            else if (contextSearchButton.Checked)
            {
                pattern = fileContextTextBox.Text;
                listOfFiles = bl.GetFilesByContent(currentPath, pattern);
                fileContextTextBox.Text = "";
            }
            foreach (var result in listOfFiles)
            {
                string name = Path.GetFileName(result);
                if (name.Contains(pattern))
                {
                    counter++;
                    searchResults += counter + ". " + name + "\n";
                }
            }
            if (counter == 0)
            {
                MessageBox.Show($"הביטוי \"{pattern}\" לא נמצא", "הודעת מערכת");
                return;
            }
            MessageBox.Show(searchResults, $"{counter} קבצים נמצאו", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd2 = new FolderBrowserDialog();
            fbd2.RootFolder = Environment.SpecialFolder.Desktop;
            fbd2.Description = "בחר תיקייה";
            fbd2.ShowNewFolderButton = false;
            if (fbd2.ShowDialog() == DialogResult.OK)
            {
                actionChosenPath.Text = fbd2.SelectedPath;
                desierdPath = fbd2.SelectedPath;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            List<string> listOfFiles = new List<string>();
            if (!Directory.Exists(currentPath))
            {
                MessageBox.Show("תיקייה לא קיימת", "הודעת מערכת");
                return;
            }
            if (currentPath == desierdPath)
            {
                MessageBox.Show("תיקיית המוצא ותיקיית היעד זהות", "הודעת מערכת");
                return;
            }
            listOfFiles = bl.GetAllFiles(currentPath);
            if (deleteFilesButton.Checked)
            {
                if (listOfFiles.Count == 0)
                {
                    MessageBox.Show("אין קבצים בתיקייה", "הודעת מערכת");
                    return;
                }
                DialogResult toDelete = MessageBox.Show("?האם אתה בטוח שברצונך למחוק את כל הקבצים", "הודעת מערכת", MessageBoxButtons.YesNo);
                if (toDelete == DialogResult.No)
                {
                    return;
                }
                bool isSure = true; 
                bl.DeleteFiles(currentPath, isSure);
            }
            else if (transferFilesButton.Checked)
            {
                string chosenPath = actionChosenPath.Text;
                if (!Directory.Exists(chosenPath))
                {
                    MessageBox.Show("תקיית יעד לא קיימת", "הודעת מערכת");
                    return;
                }
                if (actionChosenPath.Text == "")
                {
                    MessageBox.Show("לא נבחרה תיקיית יעד", "הודעת מערכת");
                }
                bl.MoveFiles(listOfFiles, currentPath, desierdPath);
            }
            else if (switchInName.Checked)
            {
                if (switchFromName.Text == "" || switchToName.Text == "")
                {
                    MessageBox.Show("עליך למלא את 2 תיבות הטקסט הרלוונטיות", "הודעת מערכת");
                    return;
                }
                if (switchFromName.Text == switchToName.Text)
                {
                    MessageBox.Show("השם הקיים והשם החדש הינם זהים", "הודעת מערכת");
                    return;
                }
                string oldName = currentPath + "\\" + switchFromName.Text;
                string newName = currentPath + "\\" + switchToName.Text;
                bl.ChangeFileName(oldName, newName);
                MessageBox.Show("בוצע בהצלחה", "הודעת מערכת");

            }
            else if (switchInContext.Checked)
            {
                bl.ChangeFileContext(listOfFiles, switchFromContext.Text, switchToContext.Text);
            }
        }

        private void deleteFilesButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void actionChosenPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void switchInName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void switchFromName_TextChanged(object sender, EventArgs e)
        {

        }

        private void transferFilesButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
