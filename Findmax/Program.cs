using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Maxvalue{
    public class Program{
        public static void Main(string[] args)
        {
            MAxInt obj = new MAxInt();
            int Maxvalue = obj.printMax(3,4,20);
            System.Console.WriteLine("max value : " + Maxvalue);
        }
    }
}