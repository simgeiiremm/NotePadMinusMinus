using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePadMinusMinus.Services
{
    public class FileService
    {
        public string Open(string path)
        {
            string filePath = path;
            //string filePath = @"C:\abov\textdosyasi.txt";
            return File.ReadAllText(filePath);
            //stirng content = File.ReadAllText(filePath);
            //return content;
        }
        public void Save(string path, string content)
        {
            File.WriteAllText(path, content);

        }
        public string GetTextLength(string text)
        {
            return text.Length.ToString();
        }
    }
}
