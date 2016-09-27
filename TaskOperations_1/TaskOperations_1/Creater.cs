using System;
using System.IO;

namespace TaskOperations_1
{
    class Creater
    {
        public Talker MyTalker { get; set; } = new Talker();
        public string Path { get; set; } = string.Empty;
        public string PathToFileForCopy { get; set; } = string.Empty;
        public const string FileName = "\\NewFile.txt";
        public string[] FileAndDirectory { get; set; } = { "directory", "new file" };

        public Creater()
        {
            this.Path = Console.ReadLine();
        }


        public void IsDirectoryExists()
        {
            while (Directory.Exists(this.Path))
            {
                this.MyTalker.WrongDirectoryMethod();
                this.Path = Console.ReadLine();
            }
            this.CreateDirectory();
        }

        public void CreateDirectory()
        {
            DirectoryInfo MyDirectory = Directory.CreateDirectory(this.Path);
            this.MyTalker.IsCreatedMethod(FileAndDirectory[0], this.Path);
        }

        public void CreateFile()
        {
            this.Path = $"{this.Path}{FileName}";
            using (FileStream fileStream = File.Create(this.Path))
            {
                this.MyTalker.IsCreatedMethod(FileAndDirectory[1], this.Path);
                this.FindFileToCopy();

            }
        }

        public void FindFileToCopy()
        {
            this.MyTalker.EnterPathToCopy();
            this.PathToFileForCopy = Console.ReadLine();

            while (!File.Exists(pathForCopy))
            {
                Console.WriteLine("File doesn't exist. Try again:");
                pathForCopy = Console.ReadLine();
            }
        }
        string fullLine = string.Empty;
            string line;
            int counter = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(pathForCopy);
                while (((line = file.ReadLine()) != null) && (counter < 20))
                {
                    fullLine = $"{fullLine}{line}{Environment.NewLine}";
                    counter++;
                }

                file.Close();
                Byte[] info = new UTF8Encoding(true).GetBytes(fullLine);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }

        
        }

    }
}
