using System;

namespace DelegateDemoMastek
{
    //1
    delegate int CalculatorDelegate(int first, int second);

    class Program
    {
        //2
        static int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }
        static int MulNumbers(int number1, int number2)
        {
            return number1 * number2;
        }

        static void Main(string[] args)
        {
            //3 delegate instance - points to a method
            //CalculatorDelegate demo1 = new CalculatorDelegate(AddNumbers);
            //CalculatorDelegate demo1 = AddNumbers;
            CalculatorDelegate demo1 = MulNumbers;

            //4 invoke delegate
            int result = demo1(4,3);
            //Console.WriteLine("Addition : "+result);

            //Multiplication
            Console.WriteLine("Multiplication : " + result);
            
            Console.WriteLine("-------------");

            //.net fw 3.5 - 2008 Lambda expression

            CalculatorDelegate demo2 = (a, b) => a + b;
            result = demo2(2, 4);
            Console.WriteLine("Addition = " + result);

            CalculatorDelegate demo3 = (a, b) => a - b;
            result = demo3(7, 4);
            Console.WriteLine("Minus = " + result);

            CalculatorDelegate demo4 = (a, b) => a * b;
            result = demo4(5, 7);
            Console.WriteLine("Multiplication = " + result);

            CalculatorDelegate demo5 = (a, b) => a / b;
            result = demo5(6, 8);
            Console.WriteLine("Division = " + result);

            demo2 = (x, y) => x * y;
            result = demo2(12, 5);

            //Action / Action<T>

            //Func<>

            //Predicate


        }
    }
}
