using System;
using System.IO;
using System.Collections;

namespace FileProcessor
{
    public class FileProcessor
    {
        public string Path { get; }

        public Process(string path)
        {
            this.Path = path;
        }

        public void LoadFiles()
        {
            string[] files = Directory.GetFiles(this.Path);

            foreach (string fileName in files)
                
        }
    }
}