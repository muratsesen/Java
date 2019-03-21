using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder
{
    public static class FileProcessor
    {
        public static string[] GetImageFileList(string directory,string extention)
        {
            string[] fileList =  Directory.GetFiles(directory, extention);
            return fileList;
        }
    }
}
