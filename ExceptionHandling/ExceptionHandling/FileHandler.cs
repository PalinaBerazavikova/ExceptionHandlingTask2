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
        public const string Extension = ".txt";
        public const string Exception = "Exception:";
        private void CheckFileOnExceptions(string path)
        {
            if (!File.Exists(path))
            {
                throw new System.IO.FileNotFoundException($"file {path} doesn't exist");
            }
            if (!Path.GetExtension(path).Equals(Extension))
            {
                Console.WriteLine(Path.GetExtension(path));
                throw new Exceptions.WrongExtensionException($"file {path} is not a txt file");
            }
        }

        public string GetPath()
        {
            string path = string.Empty;
            bool isFileOkay;
            do
            {
                isFileOkay = true;
                Console.WriteLine("Please enter the path to your txt file:");
                path = Console.ReadLine();
                try
                {
                    this.CheckFileOnExceptions(path);
                }
                catch (FileNotFoundException e)
                {
                    isFileOkay = false;
                    Console.WriteLine($"{Exception} {e.Message}");
                    Logger.Write(ExceptionLogger.CreateExceptionString(e));
                }
                catch (Exceptions.WrongExtensionException e)
                {
                    isFileOkay = false;
                    Console.WriteLine($"{Exception} {e.Message}");
                    Logger.Write(ExceptionLogger.CreateExceptionString(e));
                }
            } while (!isFileOkay);

            return path;
        }
      
        public List<string> FindFirstSymbols(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            List<string> notEmptyLines = new List<string>();
            int lineNumber = 0;
            foreach (string line in lines)
            {
                bool isLineOkay = true;
                lineNumber++;
                try
                {
                    this.CheckEmptyLines(line, lineNumber);
                }
                catch (Exceptions.EmptyStringException e)
                {
                    isLineOkay = false;
                    Console.WriteLine($"{Exception} {e.Message}");
                    Logger.Write(ExceptionLogger.CreateExceptionString(e));
                }
                if (isLineOkay)
                {
                    string firstSymbol = line.Substring(0, 1);
                    if (firstSymbol.Equals(" "))
                    {
                        notEmptyLines.Add("Space symbol");
                    }else
                    {
                        notEmptyLines.Add(firstSymbol);
                    }
                }
            }
            return notEmptyLines;
        }

        private void CheckEmptyLines(string line, int lineNumber)
        {
            if(line == "")
            {
                throw new Exceptions.EmptyStringException($"empty line #{lineNumber} was founded");
            }
        }

        public void ShowFirstSymbols()
        {
            string path = this.GetPath();
            List<string> notEmptyLines = this.FindFirstSymbols(path);
            Console.WriteLine("Fist symbol of lines in file");
            foreach(string symb in notEmptyLines)
            {
                Console.WriteLine(symb);
            }
        }
    }
}
