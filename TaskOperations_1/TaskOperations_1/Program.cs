using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOperations_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Creater creater = new Creater();
            try
            {
               
                   
                    path = $"{path}\\NewFile.txt";
                    using (FileStream fs = File.Create(path))
                    {
                        Console.WriteLine("The NewFile.txt was created successfully at {0}.", Directory.GetCreationTime(path));
                        Console.WriteLine("Enter the path to file to copy:");
                        string pathForCopy = Console.ReadLine();
                        string fullLine = string.Empty;
                        string line;
                        int counter = 0;
                    while (!File.Exists(pathForCopy)) {
                        Console.WriteLine("File doesn't exist. Try again:");
                        pathForCopy = Console.ReadLine();
                    }
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

                
                Console.WriteLine("Finish!");
            }

            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally
            {

            }
            Console.ReadKey();

        }
    }
}

