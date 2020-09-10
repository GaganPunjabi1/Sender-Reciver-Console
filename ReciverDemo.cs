using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReciverDemo
{
    class Program
    {
         public void WriteData(string path)
         {
            //Console.WriteLine(path+ " " + File.Exists(path));
            if (File.Exists(path))
            {
                string data = System.IO.File.ReadAllText(path);
                Console.WriteLine(data);
                Console.ReadLine();
            }
         }
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            Program obj = new Program();
            //Console.WriteLine(path);
            obj.WriteData(path);
        }
    }
}
