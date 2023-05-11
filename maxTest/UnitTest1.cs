
using System;
using Maxvalue;
namespace maxTest;

[TestClass]
public class UnitTest1
{
    
    MAxValue maxint;
    [TestInitialize] 
    public void Setup(){
        maxint  = new MAxValue();
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
    [TestMethod] 
    public void FirstPostion_string(){
        string value1 = "Peach";
        string value2 = "Apple";
        string value3 = "Banana";
        string output = maxint.printMax_string(value1, value2, value3);
        string expected = value1;
        Assert.AreEqual(expected,output);
    }
       [TestMethod] 
    public void SecondPostion_string(){
        string value1 = "Apple";
        string value2 =  "Peach";
        string value3 = "Banana";
        string output = maxint.printMax_string(value1, value2, value3);
        string expected = value2;
        Assert.AreEqual(expected,output);
    }
         [TestMethod] 
    public void ThirdPostion_string(){
        string value1 = "Apple";
        string value2 =  "Banana";
        string value3 =  "Peach";
        string output = maxint.printMax_string(value1, value2, value3);
        string expected = value3;
        Assert.AreEqual(expected,output);
    }
    [TestMethod]
    public void Refactor1_1(){
        int value1 = 10;
        int value2 = 20;
        int value3 = 30;

        int output = maxint.Printgratest<int>(value1,value2,value3);
        int expected = value3;
        Assert.AreEqual(expected,output);
    }
    [TestMethod] 
    public void Refactor1_2(){
        float value1 = 20.5f;
        float value2 = 10.4f ;
        float value3 = 30.6f ;
        
        float output = maxint.Printgratest<float>(value1, value2, value3);
        float expected = value3;
        Assert.AreEqual(expected, output);

    }
    [TestMethod]
    public void Refactor1_3(){
        string value1 = "Apple";
        string value2 =  "Banana";
        string value3 =  "Peach";
        string output = maxint.Printgratest<string>(value1, value2, value3);
        string expected = value3;
        Assert.AreEqual(expected,output);
    }
     [TestMethod]
    public void Refactor2_1_int(){
        int value1 = 10;
        int value2 = 20;
        int value3 = 30;
        MaxValue<int> maxvalue = new MaxValue<int>(value1, value2, value3);
        int output = maxvalue.testMaximumValue();
        int expected = value3;
        Assert.AreEqual(expected,output);
    }
     [TestMethod]
    public void Refactor2_2_float(){
        float value1 = 20.5f;
        float value2 = 10.4f ;
        float value3 = 30.6f ;

        MaxValue<float> maxvalue = new MaxValue<float>(value1, value2, value3);
        float output = maxvalue.testMaximumValue();
        float expected = value3;
        Assert.AreEqual(expected,output);
    }
     [TestMethod]
    public void Refactor2_2_String(){
        string value1 = "Apple";
        string value2 =  "Banana";
        string value3 =  "Peach";

        MaxValue<string> maxvalue = new MaxValue<string>(value1, value2, value3);
        string output = maxvalue.testMaximumValue();
        string expected = value3;
        Assert.AreEqual(expected,output);
    }
    
}