using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SIREMBA.konfigurasi
{
    internal class Setting
    {
        public static string[] ambilSeting(string file)
        {
            return File.ReadAllLines(file);
        }
    }
}
