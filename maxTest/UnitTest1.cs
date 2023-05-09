
using System;
using Maxvalue;
namespace maxTest;

[TestClass]
public class UnitTest1
{
    MAxInt maxint;
    [TestInitialize] 
    public void Setup(){
         maxint  = new MAxInt();
    }

    [TestMethod]
    public void FirstPostion()
    {
        int value1 = 30;
        int value2 = 20 ;
        int value3 = 10;
        
        int output = maxint.printMax(value1, value2, value3);
        int expected = value1;
        Assert.AreEqual(expected, output);
    }
    [TestMethod]
    public void SecondPostion(){
        int value1 = 10;
        int value2 = 20;
        int value3 = 15;

        int output = maxint.printMax(value1, value2,value3);
        int expected = value2;
        Assert.AreEqual(expected, output);
    }
    [TestMethod]

    public void ThirdPostion(){
        int value1 = 10;
        int value2 = 20;
        int value3 = 30;

        int output = maxint.printMax(value1,value2,value3);
        int expected = value3;
        Assert.AreEqual(expected,output);
    }
    [TestMethod]
    public void FirstPostion_float(){
        float value1 = 30.6f;
        float value2 = 20.5f ;
        float value3 = 10.4f;
        
        float output = maxint.printMax_float(value1, value2, value3);
        float expected = value1;
        Assert.AreEqual(expected, output);
    }
    [TestMethod]
        public void SecondPostion_float(){
        float value1 = 20.5f;
        float value2 = 30.6f ;
        float value3 = 10.4f;
        
        float output = maxint.printMax_float(value1, value2, value3);
        float expected = value2;
        Assert.AreEqual(expected, output);
    }

    [TestMethod]
    public void ThirdPostion_float(){
        float value1 = 20.5f;
        float value2 = 10.4f ;
        float value3 = 30.6f ;
        
        float output = maxint.printMax_float(value1, value2, value3);
        float expected = value3;
        Assert.AreEqual(expected, output);
    }



}