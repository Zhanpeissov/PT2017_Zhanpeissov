using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(Console.ReadLine());
            List<FileSystemInfo> fi = new List<FileSystemInfo>();
            fi.AddRange(di.GetFiles());
            foreach (DirectoryInfo p in fi) {
                StreamReader sr = new StreamReader(p.Name);
                string str = sr.ReadToEnd();
                string[] arr = str.Split();
                for (int i = 0; i < arr.Length; i++) {
                    if (arr[i] == "test") {
                        Console.WriteLine(p.Name);
                    }
                }
                
            }
            Console.ReadKey();
        }
    }
}
