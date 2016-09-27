using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOperations_1
{
    class Talker
    {
        public const string EnterThePathToDirectory = "Enter the path to new directory.";
        public const string WrongDirectory  = "That path exists already.\nEnter another path.";
        public string DirectoryIsCreated { get; set; } = $"The {0} was created successfully in {1}.";
        public const string EnterThePathToFileForCopy = "Enter the path to file to copy:";


        public Talker()
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

        public void IsCreatedMethod(string str, string path)
        {
            Console.WriteLine(DirectoryIsCreated, str, path);
        }
    }
}
