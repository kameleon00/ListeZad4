using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeZad4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> godine = new List<int>() { 2009, 2010, 2012 };
            godine.Insert(2, 2011);
            Console.WriteLine("Lista nakon umetanja: ");
            foreach (int godina in godine)
                Console.WriteLine(godina);
            Console.WriteLine();
            Console.WriteLine("===================================");

            godine.InsertRange(godine.Count, new List<int>() { 2013, 2014, 2015 });
            Console.WriteLine("Lista nakon inser range: ");
            foreach (int godina in godine)
                Console.WriteLine(godina);
            Console.WriteLine();
            Console.WriteLine("===================================");

            Console.ReadLine();
        }
    }
}
