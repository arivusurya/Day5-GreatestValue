
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


}