using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ionic.Zip;

namespace ConsoleApp1
{
    internal class Zip
    {
        private const int MaxDegreeOfParallelism = 5;
        private readonly ZipFile _zipFile;

        public Zip()
        {
            _zipFile = new ZipFile(Encoding.UTF8)
            {
                UseZip64WhenSaving = Zip64Option.AsNecessary
            };
        }

        public void MakeZipFile(string path, string archiveName)
        {
            try
            {
                ZipDirectory(path);
                _zipFile.Save(archiveName + ".zip");
                Console.WriteLine("Program is finished");
            }

            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e);
            }
        }

        private void AddItem(string file, string path)
        {
            _zipFile.AddItem(file, path);
        }

        private void ZipDirectory(string path)
        {
            var dirs = Directory.GetDirectories(path);
            var files = Directory.GetFiles(path);

            Parallel.ForEach(files, new ParallelOptions { MaxDegreeOfParallelism = MaxDegreeOfParallelism }, x =>
            {
                AddItem(x, path);
                Console.WriteLine("Thread - {0}", Thread.CurrentThread.ManagedThreadId);
            });

            Parallel.ForEach(dirs,  x =>
            {
                ZipDirectory(x);
                Console.WriteLine("Thread - {0}", Thread.CurrentThread.ManagedThreadId);
            });
        }
    }
}