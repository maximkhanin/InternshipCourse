using System;
using System.IO;
using System.Threading.Tasks;

namespace HW1
{
    class ReplaceText
    {
        private const int MaxDegreeOfParallelism = 5;
        private readonly string _oldText;
        private readonly string _newText;

        public ReplaceText(string oldText, string newText)
        {
            _oldText = oldText;
            _newText = newText;
            var fileStream = File.Create("log.txt");
            fileStream.Close();      
        }

        public void ReplaceTextInFiles(string path)
        {
            var dirs = Directory.GetDirectories(path);
            var files = Directory.GetFiles(path, "*.txt");

            string str;
            var logFile = string.Empty;

            Parallel.ForEach(files, new ParallelOptions { MaxDegreeOfParallelism = MaxDegreeOfParallelism }, x =>
            {
                
                Console.WriteLine(x);
                var streamReader = File.OpenText(x);
                var text = string.Empty;
                while ((str = streamReader.ReadLine())!=null)
                {
                    if (str.Contains(_oldText))
                    {
                        logFile += "Name of the file: " + x + " String:" + str;
                        str = str.Replace(_oldText, _newText);
                        logFile +=" Result:" + str + "\r\n";
                    }
                    text += str + "\r\n";
                }

                streamReader.Close();

                File.WriteAllText(x, text);
                lock (this)
                {
                   File.AppendAllText("log.txt", logFile);
                }  
            });

            Parallel.ForEach(dirs, ReplaceTextInFiles);
        }
    }
}
