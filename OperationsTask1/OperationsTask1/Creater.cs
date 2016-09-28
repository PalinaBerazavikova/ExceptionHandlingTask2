using System;
using System.IO;
using System.Text;


namespace OperationsTask1
{
    class Creater
    {
        public Talker MyTalker { get; set; } = new Talker();
        private string path = string.Empty;
        private string pathToFileForCopy = string.Empty;
        public string Path { get { return path; } set { path = value.Trim().ToLower(); } }
        public string PathToFileForCopy { get { return pathToFileForCopy; } set { pathToFileForCopy = value.Trim().ToLower(); } }
        public const string FileName = "\\NewFile.txt";
        public int CountOfLines { get; set; } = 20;
        public const string EnterThePathToDirectory = "Enter the path to new directory.";
        public const string WrongDirectory = "That directory exists already or invalid path\nEnter another path.";
        public const string DirectoryIsCreated = "The directory was created successfully.";
        public const string FileIsCreated = "The NewFile.txt in your directory was created successfully.";
        public const string EnterThePathToFileForCopy = "Enter the file path to copy (you need text file with extension txt):";
        public const string WrongFile = "File doesn't exist or wrong file. Try again:";
        public const string FinishString = "Finish!";
        public const string Txt = ".txt";

        public void Start()
        {
            Console.WriteLine(EnterThePathToDirectory);
            this.Path = Console.ReadLine();
            while (Directory.Exists(this.Path))
            {
                Console.WriteLine(WrongDirectory);
                this.Path = Console.ReadLine();
            }
            this.CreateDirectory();
            Console.WriteLine(DirectoryIsCreated);
            this.CreateFile();
        }

        public void CreateDirectory()
        {
            try
            {
                DirectoryInfo MyDirectory = Directory.CreateDirectory(this.Path);
            } catch(System.ArgumentException e)
            {
                Console.WriteLine(WrongDirectory);
                this.Start();
            }
            
        }

        public void CreateFile()
        {
            this.Path = $"{this.Path}{FileName}";
            using (FileStream fileStream = File.Create(this.Path))
            {
                Console.WriteLine(FileIsCreated);
                this.FindFileToCopy();
                Byte[] info = this.ReadFileLines(this.PathToFileForCopy, this.CountOfLines);
                fileStream.Write(info, 0, info.Length);
            }
            Console.WriteLine(FinishString);
        }

        public void FindFileToCopy()
        {
            Console.WriteLine(EnterThePathToFileForCopy);
            this.PathToFileForCopy = Console.ReadLine();
            while (!File.Exists(this.PathToFileForCopy) || (!this.PathToFileForCopy.EndsWith(Txt)))
            {
                Console.WriteLine(WrongFile);
                this.PathToFileForCopy = Console.ReadLine();
                
            }
        }
        public byte[] ReadFileLines(String path, int countOfLines)
        {
            string fullLine = string.Empty;
            string line;
            int counter = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while (((line = file.ReadLine()) != null) && (counter < countOfLines))
            {
                fullLine = $"{fullLine}{line}{Environment.NewLine}";
                counter++;
            }
            file.Close();
            Byte[] info = new UTF8Encoding(true).GetBytes(fullLine);
            return info;
        }
    }
}
