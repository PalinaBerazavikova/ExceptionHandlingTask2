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
            path = Console.ReadLine();
            try
            {

                if (!File.Exists(path))
                {
                    throw new System.IO.FileNotFoundException("Your file doesn't exist");
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                Logger.Write(ExceptionLogger.CreateExceptionString(e));
            }
            try
            {
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
