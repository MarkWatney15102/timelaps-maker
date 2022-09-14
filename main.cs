using System;
using System.IO;
using System.Collections;

using DirectoryProcessor.DirectoryProcessor;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "/images/";

            if (Directory.Exists(path)) 
            {
                DirectoryProcessor processor = new DirectoryProcessor(path);
                processor.LoadFiles();
            }
        }
    }
}