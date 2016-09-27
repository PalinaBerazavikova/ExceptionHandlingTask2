using System;
using System.IO;
using System.Text;


namespace OperationsTask1
{
    class Creater
    {
        public Talker MyTalker { get; set; } = new Talker();
        public string Path { get; set; } = string.Empty;
        public string PathToFileForCopy { get; set; } = string.Empty;
        public const string FileName = "\\NewFile.txt";
        public int CountOfLines { get; set; } = 20;

        public Creater()
        {
            this.MyTalker.EnterThePathToNewDirectory();
            this.Path = Console.ReadLine();
            this.IsDirectoryExists();
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
            this.MyTalker.IsCreatedMethod();
            this.CreateFile();
        }

        public void CreateFile()
        {
            this.Path = $"{this.Path}{FileName}";
            using (FileStream fileStream = File.Create(this.Path))
            {
                this.MyTalker.IsCreatedFileMethod();
                this.FindFileToCopy();
                Byte[] info = this.CopyFileLines();
                fileStream.Write(info, 0, info.Length);
            }
            this.MyTalker.Finish();
        }

        public void FindFileToCopy()
        {
            this.MyTalker.EnterPathToCopy();
            this.PathToFileForCopy = Console.ReadLine();

            while (!File.Exists(this.PathToFileForCopy))
            {
                this.MyTalker.WrongPathFile();
                this.PathToFileForCopy = Console.ReadLine();
            }
        }
        public byte[] CopyFileLines()
        {
            string fullLine = string.Empty;
            string line;
            int counter = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(this.PathToFileForCopy);
            while (((line = file.ReadLine()) != null) && (counter < this.CountOfLines))
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
