using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SenderDemo
{
    class Program
    {
        public void Data()
        {
            string path = "sender.txt";

            if(!File.Exists(path))
                File.Create(path);

            string[] name = { "kavya", "gagan", "priya", "ramya", "riya"};
            System.IO.File.WriteAllLines(path, name);

            string curDir = Directory.GetCurrentDirectory();

            Console.WriteLine(Path.Combine(curDir, path));
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Data();
        }
    }
}
