using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Maxvalue{
    public class MAxInt{
        public int printMax(int value1, int value2,int value3){
            if(value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0){
                return value1;
            }else if(value2.CompareTo(value3) > 0){
                return value2;
            }   else{
                    return value3;
            }
        }
    }
}