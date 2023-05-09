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
            float MaxFloat  = obj.printMax_float(3.5f,50.6f,4.3f);
            System.Console.WriteLine("max value : " + Maxvalue);
            System.Console.WriteLine("max Float : " + MaxFloat);

        }
    }
}