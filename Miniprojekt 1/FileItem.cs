using System.Diagnostics;

namespace Miniprojekt_1
{
    public class FileItem : IMenuItem
    {
        private string _Title;
        private string Path;

        public FileItem(string _title, string _path)
        {
            _Title = _title;
            Path = _path;
        }

        public bool ExpandMenuItem()
        {
            try
            {
                new Process
                {
                    StartInfo = new ProcessStartInfo(Path)
                    {
                        UseShellExecute = true
                    }
                }.Start();
            }
            catch (System.ComponentModel.Win32Exception)
            {
                System.Console.WriteLine("File not found, shutting down gracefully...");
                return false;
            }
            return true;
        }

        public string Title()
        {
            return _Title;
        }
    }
}