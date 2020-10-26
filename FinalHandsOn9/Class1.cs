using System;
using System.Collections.Generic;
using System.Text;

namespace FinalHandsOn9
{
    class Class1
    {
        static void Main(string[] args)
        {
            Shoe vans = new Shoe(11, "gray", "white", false, "white");
            Console.WriteLine(vans.ToString());
            Shoe work = new Shoe(11, "gray", "black", false, "black");
            Console.WriteLine(work.ToString());
        }
    }
}
