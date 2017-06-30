using System;

namespace Lab03SarahLuo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool isTrue = false;

            if(isTrue){
                Console.WriteLine("It is True!");
            }
            else{
                Console.WriteLine("It is False!");
            }

            Console.Write("Input a temperature in Fahrenheit: ");
            double fahr = Convert.ToDouble(Console.ReadLine());
            double cels = (fahr - 32d) * 5d / 9d;
            Console.WriteLine("The temperature you entered in Celsius is: {0:F}", cels);

            if (fahr < 40){
                Console.WriteLine("It is cold!");
            }
            else if (fahr > 90){
                Console.WriteLine("It is hot!");
            }
        }
    }
}
