//Section C
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Assignment_4
{
    class Program
    {
        ArrayList Beowulf;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Run();
        }

        public void Run() { this.Wordfind(); }

        public void Wordfind()

        {
            int chr = 0;
            foreach (var line in File.ReadAllLines("U:/Users/730407/github/Beowulf.txt"))
            {
                if (line.Contains("sea") && line.Contains("fare"))
                {
                    chr++;
                }

                
            }
            Console.WriteLine("Total words sea and fare in File are:" + chr);
        }
    }
} 
               