using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator_tp_lab_1;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() //тесты на операцию +
        {
            Class1 test1 = new Class1();
            char operation_key = '+';
            bool operation_active1 = false;
            bool operation_active2 = true;
            double result = 25;
            string textBox1Text = "21,2";
            double number = 0;
            double expected = 46.2;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod11()//тесты на операцию +
        {
            Class1 test1 = new Class1();
            char operation_key = '+';
            bool operation_active1 = false;
            bool operation_active2 = true;
            double result = 120.12;
            string textBox1Text = "29,88";
            double number = 0;
            double expected = 150;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2() //тесты на операцию -
        {
            Class1 test1 = new Class1();
            char operation_key = '-';
            bool operation_active1 = false;
            bool operation_active2 = true;
            double result = 25;
            string textBox1Text = "21,2";
            double number = 0;
            double expected = 3.8;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod22()//тесты на операцию -
        {
            Class1 test1 = new Class1();
            char operation_key = '-';
            bool operation_active1 = false;
            bool operation_active2 = true;
            double result = 66.66;
            string textBox1Text = "67";
            double number = 0;
            double expected = -0.34;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 2);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void TestMethod3() //тесты на операцию *
        {
            Class1 test1 = new Class1();
            char operation_key = '*';
            bool operation_active1 = true;
            bool operation_active2 = true;
            double result = 2;
            string textBox1Text = "3";
            double number = 0;
            double expected = 6;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod33()//тесты на операцию *
        {
            Class1 test1 = new Class1();
            char operation_key = '*';
            bool operation_active1 = true;
            bool operation_active2 = true;
            double result = 15;
            string textBox1Text = "-1";
            double number = 0;
            double expected = -15;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 1);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void TestMethod4()//тесты на операцию /
        {
            Class1 test1 = new Class1();
            char operation_key = '/';
            bool operation_active1 = false;
            bool operation_active2 = false;
            double result = 10.4;
            string textBox1Text = "21,2";
            double number = 2;
            double expected = 5.2;
            test1.Result1(operation_key, ref result, ref number, textBox1Text, ref operation_active1, ref operation_active2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod44()//тесты на операцию /
        {
            Class1 test1 = new Class1();
            char operation_key = '/';
            bool operation_active1 = false;
            bool operation_active2 = false;
            double result = -5;
            string textBox1Text = "21.5";
            double number = -1;
            double expected = 5;
            test1.Result1(operation_key, ref result, ref number, textBox1Text, ref operation_active1, ref operation_active2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod5()//тесты на метод результата
        {
            Class1 test1 = new Class1();
            char operation_key = '+';
            bool operation_active1 = false;
            bool operation_active2 = false;
            double result = 5;
            string textBox1Text = "21.2";
            double number = 2;
            double expected = 7;
            test1.Result(operation_key, ref result, ref number, textBox1Text, ref operation_active1, ref operation_active2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod6()//тест на операцию косинуса
        {
            Class1 test1 = new Class1();
            char operation_key = 'c';
            bool operation_active1 = true;
            bool operation_active2 = true;
            double result = 23;
            string textBox1Text = "-2";
            double number = 0;
            double expected = -0.42;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod66() //тест на операцию косинуса
        {
            Class1 test1 = new Class1();
            char operation_key = 'c';
            bool operation_active1 = true;
            bool operation_active2 = true;
            double result = 23;
            string textBox1Text = "1";
            double number = 0;
            double expected = 0.54;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod7() //тест на операцию синуса
        {
            Class1 test1 = new Class1();
            char operation_key = 's';
            bool operation_active1 = true;
            bool operation_active2 = true;
            double result = 25;
            string textBox1Text = "1";
            double number = 0;
            double expected = 0.84;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result,2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod77() //тест на операцию синуса
        {
            Class1 test1 = new Class1();
            char operation_key = 's';
            bool operation_active1 = true;
            bool operation_active2 = true;
            double result = 25;
            string textBox1Text = "3";
            double number = 0;
            double expected = 0.14;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod8()
        {
            Class1 test1 = new Class1(); //тест на операцию 1/x
            char operation_key = 'd';
            bool operation_active1 = true;
            bool operation_active2 = true;
            double result = 25;
            string textBox1Text = "2";
            double number = 0;
            double expected = 0.5;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod88()//тест на операцию 1/x
        {
            Class1 test1 = new Class1();
            char operation_key = 'd';
            bool operation_active1 = true;
            bool operation_active2 = true;
            double result = 25;
            string textBox1Text = "-2";
            double number = 0;
            double expected = -0.5;
            test1.Operations(ref operation_key, textBox1Text, ref result, ref operation_active1, ref number, ref operation_active2);
            result = Math.Round(result, 4);
            Assert.AreEqual(expected, result);
        }
    }
}
