using System;

namespace Lab02SarahLuo
{
    class MainClass
    {// comment
        public static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.Write("Enter an integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The product of the numbers you entered is {0}", num1 * num2);

            Console.WriteLine("Hello World!\nFrom Sarah Luo");

            Console.WriteLine("Hello World! \t From Sarah Luo");

        }
    }
}
