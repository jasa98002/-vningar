                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string namn;
        
            Console.WriteLine("vad är ditt namn?");
            namn = Console.ReadLine();
            Console.WriteLine("vad är ditt efternamn*?");
            namn += Console.ReadLine();
            Console.WriteLine(namn);

            Console.ReadLine();
        }
    }
}
