using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class FileHandler
    {
        public string Extension { get; set; } = "txt";
        public string getPath()
        {
            string path = string.Empty;
            Console.WriteLine("Please enter the path to your txt file:");
            try
            {
                path = Console.ReadLine();
                if (Path.GetExtension(path) != this.Extension)
                {
                    throw new WrongExtensionException("Your file is not a txt file");
                }
            }
            catch (WrongExtensionException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                Logger.Write(ExceptionLogger.CreateExceptionString(e));
            }
            return path;
        }
    }
}
