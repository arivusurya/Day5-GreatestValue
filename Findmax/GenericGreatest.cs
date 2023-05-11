using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace Maxvalue{
   public  class MaxValue<T> where T : IComparable{
        public  T value1 ,value2,value3;
       

        public MaxValue(T value1,T value2,T value3){
          this.value1 = value1;
            this.value2 = value2;
           this.value3 = value3;
        }

        public  T testMaximumValue(){
            T maxvalue = testMaximum(value1,value2,value3);
            return maxvalue;

        }

        private static T testMaximum(T value1,T value2,T value3){
              if(value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0){
               return value1;
            }else if(value2.CompareTo(value3) > 0){
                return value2;
            }else{
                return value3;
            }
        }
    }
}