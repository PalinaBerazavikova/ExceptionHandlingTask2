﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Logger
    {
        public static string FileName { get; set; } = @"\log.txt";
        public static void Write(String lines)
        {
            string path = $@"{Environment.CurrentDirectory}{FileName}";
            if (!File.Exists(path))
            {
                using (FileStream fileStream = File.Create(path))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("Exceptions:");
                    fileStream.Write(info, 0, info.Length);
                }
            }
            using (StreamWriter streanWriter = File.AppendText(path))
            {
                streanWriter.WriteLine(lines);
            }

        }
    }
}
