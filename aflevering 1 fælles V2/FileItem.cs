using System.Diagnostics;

namespace aflevering_1_fælles_V2
{
    internal class FileItem : IMenuItem
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
            new Process
            {
                StartInfo = new ProcessStartInfo(Path)
                {
                    UseShellExecute = true
                }
            }.Start();
            return true;
        }

        public string Title()
        {
            return _Title;
        }
    }
}