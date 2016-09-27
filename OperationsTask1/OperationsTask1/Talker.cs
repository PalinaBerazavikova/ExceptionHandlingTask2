using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsTask1
{
    class Talker
    {
        public const string EnterThePathToDirectory = "Enter the path to new directory.";
        public const string WrongDirectory = "That path exists already.\nEnter another path.";
        public const string DirectoryIsCreated = "The directory was created successfully.";
        public const string FileIsCreated = "The NewFile.txt in your directory was created successfully.";
        public const string EnterThePathToFileForCopy = "Enter the file path to copy:";
        public const string WrongFile = "File doesn't exist. Try again:";
        public const string FinishString = "Finish!";

        public void EnterThePathToNewDirectory()
        {
            Console.WriteLine(EnterThePathToDirectory);
        }

        public void EnterPathToCopy()
        {
            Console.WriteLine(EnterThePathToFileForCopy);
        }

        public void WrongDirectoryMethod()
        {
            Console.WriteLine(WrongDirectory);
        }
        public void WrongPathFile()
        {
            Console.WriteLine(WrongFile);
        }

        public void Finish()
        {
            Console.WriteLine(FinishString);
        }

        public void IsCreatedMethod()
        {
            Console.WriteLine(DirectoryIsCreated);
        }
        public void IsCreatedFileMethod()
        {
            Console.WriteLine(FileIsCreated);
        }
    }
}
