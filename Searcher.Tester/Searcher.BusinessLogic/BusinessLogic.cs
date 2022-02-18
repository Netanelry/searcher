﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searcher.BusinessLogic
{
    public class BusinessLogic
    {
        //return all files
        public List <string> GetAllFiles(string directory)
        {
            string [] results = Directory.GetFiles(directory);
            List<string> searchResults = results.ToList();
            return searchResults;
        }

        //get file and string and return files with the string in name
        public List<string> GetFilesByName(string directory, string pattern)
        {
            List<string> allFiles = GetAllFiles(directory);
            int counter = 0;
            List<string> searchResults = new List<string>();
            foreach (string file in allFiles)
            {
                string name = Path.GetFileName(file);
                if (name.Contains(pattern))
                {
                    counter++;
                    searchResults.Add(file);
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("לא נמצא");
            }
            else
            {
                Console.WriteLine($"{counter} קבצים נמצאו");
            }
            return searchResults;
        }

        //get file and string and return files with the string in contant
        public List <string> GetFilesByContent(string directory, string pattern)
        {
            List<string> allFiles = GetAllFiles(directory);
            int counter = 0;
            List <string> searchResults = new List<string>();
            foreach (string file in allFiles)
            {
                string fileContext = File.ReadAllText(file);
                if (fileContext.Contains(pattern))
                {
                    counter++;
                    searchResults.Add(file);
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine($"{counter} file(s) found");
            }
            return searchResults;
        }

        //delete file or all files
        public void DeleteFiles(List<string> listOffiles, string name = null)
        {
            if (name == null)
            {
                foreach (string file in listOffiles)
                {
                    Directory.Delete(file);
                }
            }
            else
            {
                foreach (string file in listOffiles)
                {
                    if ((Path.GetFileName(file)) == name)
                    {
                        Directory.Delete(file);
                    }
                }
            }
        }
            //moving file to a new location
            public void MoveFiles(List<string> listOfFiles, string oldPath, string newPath)
        {
            foreach (string file in listOfFiles)
            {
                File.Move(oldPath, newPath);
            }
        }

        //change file name
        public void ChangeFileNames(string[] listOfFiles, string oldName, string newName)
        {
            foreach (string file in listOfFiles)
            {
                File.Move(oldName, newName);
            }
        }

        //change the file contant
        public void ChangeFileContext(string[] listOfFiles, string originalPattern, string newPattern)
        {
            foreach (string file in listOfFiles)
            {
                string fileContants = File.ReadAllText(file);
                if (fileContants.Contains(originalPattern))
                {
                    File.WriteAllText(file, newPattern);
                }

            }
        }
    }
}
