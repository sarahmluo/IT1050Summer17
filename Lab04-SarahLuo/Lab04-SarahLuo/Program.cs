using System;

namespace Lab04SarahLuo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Problem 4
            // Output whether a variable is even or odd
            for (int i = 1; i <= 100; i++){
                if(i % 2 == 0){
                    Console.WriteLine("{0} is even", i);
                }
                else{
                    Console.WriteLine("{0} is odd", i);
                }

            } //end for

            // Problem 5
            Console.Write("\nPlease enter a temperature: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if(temp < 10){
                Console.WriteLine("Polar Bear");
            } else if(temp < 20){
                Console.WriteLine("Penguin");
            } else if(temp < 40){
                Console.WriteLine("Moose");
			} else if (temp < 50){
				Console.WriteLine("Reindeer");
            } else if(temp < 60){
                Console.WriteLine("Deer");
            } else if(temp < 70){
                Console.WriteLine("Turtle");
            } else if(temp < 80){
                Console.WriteLine("Lion");
            } else if(temp < 90){
                Console.WriteLine("Fish");
            } else {
                Console.WriteLine("Bug");
            }

            // Problem 6
            Console.Write("\nPlease enter the exhibit number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num){
                case 1:
                    Console.WriteLine("Polar Bear");
                    break;
                case 2:
					Console.WriteLine("Penguin");
					break;
				case 3:
					Console.WriteLine("Moose");
					break;
				case 4:
					Console.WriteLine("Reindeer");
					break;
				case 5:
					Console.WriteLine("Deer");
                    break;
				case 6:
					Console.WriteLine("Turtle");
					break;
				case 7:
					Console.WriteLine("Lion");
					break;
				case 8:
					Console.WriteLine("Fish");
					break;
				case 9:
					Console.WriteLine("Bug");
					break;
                default:
                    Console.WriteLine("No exhibit corresponds to your entry.");
                    break;
            } // end switch

            // Extra Credit
            int len = 10;
            for (int i = 1; i <= len; i++){
                for (int j = 1; j <= i; j++){
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            for (int i = len; i >= 1; i--){
                for (int j = 1; j <= i; j++){
                    Console.Write('*');
                }
                Console.WriteLine();
            }

			for (int i = len; i >= 1; i--)
			{
				for (int j = len; j > i; j--)
				{
					Console.Write(' ');
				}

                for (int k = 1; k <= i; k++){
                    Console.Write('*');
                }
				Console.WriteLine();
			}

			for (int i = 1; i <= len; i++)
			{
				for (int j = len; j > i; j--)
				{
					Console.Write(' ');
				}

				for (int k = 1; k <= i; k++)
				{
					Console.Write('*');
				}
				Console.WriteLine();
			}

		}// end Main
    }
}
