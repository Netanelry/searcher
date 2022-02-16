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
        string currentPath = "";
        BusinessLogic.BusinessLogic bl;
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
                MessageBox.Show("תיקייה לא קיימת");
                return;
            }
            if (allFilesButton.Checked)
            {
                listOfFiles = bl.GetAllFiles(currentPath);
            }
            else if (nameSearchButton.Checked)
            {
                string pattern = fileNameTextBox.Text;
                listOfFiles = bl.GetFilesByName(currentPath, pattern);
            }
            else if (contextSearchButton.Checked)
            {
                string pattern = fileNameTextBox.Text;
                listOfFiles = bl.GetFilesByContent(currentPath, pattern);
            }
            string searchResults = "";
            int counter = 0;
            foreach (var result in listOfFiles)
            {
                counter++;
                string name = Path.GetFileName(result);
                searchResults += counter + "." + name + "\n";
            }
            MessageBox.Show(searchResults, "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }
    }
}
