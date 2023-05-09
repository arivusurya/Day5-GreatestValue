using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Maxvalue{
    public class Program{
        public static void Main(string[] args)
        {
            MAxValue obj = new MAxValue();
            int Maxvalue = obj.printMax(3,4,20);
            float MaxFloat  = obj.printMax_float(3.5f,50.6f,4.3f);
            string MaxString = obj.printMax_string("Apple" , "Peach","Banana");
            System.Console.WriteLine("max value : " + Maxvalue);
            System.Console.WriteLine("max Float : " + MaxFloat);
            System.Console.WriteLine("MaxString : " + MaxString);

        }
    }
}