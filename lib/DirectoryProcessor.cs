using System;
using System.IO;
using System.Collections;

using FileProcessor.FileProcessor;

namespace DirectoryProcessor
{
    public class DirectoryProcessor 
    {
        public string Path { get; }
        public FileProcess[] processedFiles { get; }

        public Process(string path)
        {
            this.Path = path;
        }

        public void LoadFiles()
        {
            string[] files = Directory.GetFiles(this.Path);

            foreach (string fileName in files)
            {
                FileProcess file = new FileProcess();

                this.processedFiles.Add(file);
            } 
        }
    }
}