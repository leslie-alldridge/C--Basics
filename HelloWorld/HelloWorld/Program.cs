using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 25.95f;
            char character = 'A';
            string name = "leslie";
            bool isTrue = false;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(name);
            Console.WriteLine(isTrue);
            // template strings
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            const float Pi = 3.14f;
            Console.WriteLine("{0} {1}", Pi, isTrue);
        }
    }
}
