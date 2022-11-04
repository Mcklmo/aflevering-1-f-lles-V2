using System;
using System.IO;

namespace Miniprojekt_1
{
    public class FileSystemMenu : MainMenu, IMenuItem
    {
        private DirectoryInfo directoryInfo;

        public FileSystemMenu(string _title, DirectoryInfo _directoryInfo) :
            base(_title)
        {
            directoryInfo = _directoryInfo;
        }
        public new bool ExpandMenuItem() 
        {
            foreach(DirectoryInfo dir in directoryInfo.GetDirectories())
            {
                Add(new FileSystemMenu(dir.Name, new DirectoryInfo(dir.FullName)));

            }
            foreach (FileInfo item in directoryInfo.GetFiles())
            {
                Add(new FileItem(item.Name, item.FullName));
            }
            return Expand(); 
        }
    }
}