//Section DD
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

            p.Wordfind2();
        }

        

       
        public void Wordfind2()
        {
            int chr = 0, y = 0, z = 0;

            foreach (var line in File.ReadAllLines("U:/Users/730407/github/Beowulf.txt"))
            {
                if (line.Contains("fare"))
                {
                    chr++;
                }

            }
            foreach (var line in File.ReadAllLines("U:/Users/730407/github/Beowulf.txt"))
            {
                if (line.Contains("war") && line.Contains("fare"))
                {
                    y++;
                }

            }
            z = chr - y;
            Console.WriteLine("Total number of Lines which contain fare but not war: " + z);
        }

    }
} 
               