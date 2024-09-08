using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    // Adaptee class with an incompatible interface (i.e., it plays VLC files)
    public class VLCPlayer
    {
        public void PlayVLCFile(string fileName)
        {
            Console.WriteLine("Playing VLC video: " + fileName);
        }
    }
}
