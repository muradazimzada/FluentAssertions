using FluentAssertions;
using FluentAssertions.Execution;
using System.Runtime.InteropServices;

namespace FluentAssertions
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            TestClassUnitTesting.Sum();
            TestClassUnitTesting.Subtract();
            TestClassUnitTesting.Product();
            TestClassUnitTesting.Divide();
           
        }
    }
    internal class TestClass
    {
        public int Sum(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;

        public int Product(int a, int b) => a * b;

        public int Divide(int a, int b) => a / b;

    }
   static class TestClassUnitTesting
    {
        private static readonly TestClass @class = new TestClass();
        static readonly int a = 5, b = 12;
        public static void Sum()
        {
            @class.Sum(a,b).Should().Be(a*b);
        }
        public static void Subtract()
        {
            @class.Subtract(a,b).Should().Be(a-b);
        }
        public static void Product()
        {
            @class.Product(a, b).Should().Be(a+b);
        }
        public static void Divide()
        {
            @class.Divide(a, b).Should().Be(a / b);
        }
    }
}