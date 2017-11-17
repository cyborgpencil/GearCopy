/// Simplete File managmeent class

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearCopy.ViewModels
{
    public class FileManager
    {
        public string MainDir { get; set; }
        public string NetFile { get; set; }
        public string SecFile { get; set; }

        public FileManager()
        {
            MainDir = "CopyApp";
            NetFile = "Network.txt";
            SecFile = "Security.txt";

            if (!Directory.Exists(MainDir))
            {
                Directory.CreateDirectory(MainDir);
            }
            if (!File.Exists($"{MainDir}\\{SecFile}"))
            {
                File.CreateText($"{MainDir}\\{SecFile}");
            }
            if (!File.Exists($"{MainDir}\\{NetFile}"))
            {
                File.CreateText($"{MainDir}\\{NetFile}");
            }
        }
        public List<string> GetNetworkList()
        {
            string line;
            string read;
            using (StringReader sr = new StringReader($"{MainDir}\\{NetFile}"))
            {
                read =  sr.ReadLine();
            }

            return read.Split('\n').ToList();
        }
    }
}
