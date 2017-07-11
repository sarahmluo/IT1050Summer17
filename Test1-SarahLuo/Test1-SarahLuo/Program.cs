using System;

namespace Test1SarahLuo
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //bool keepLooping = true;
            //while(keepLooping){
            //    Console.WriteLine("I'm stuck!");
            //}

            // Problem 3
            int counter = 2;
            while (counter <= 64){
                Console.WriteLine("[{0}]", counter);
                counter *= 2; 
            }
            Console.WriteLine("[{0}]", counter);

            Console.WriteLine();

            // Problem 4
            for (int i = 49; i >= 1; i--){
                Console.Write("{0}", i);
                if(i != 1){
                    Console.Write(", ");
                }
            }

            Console.Write("\n\n");

            // Problem 5
            int index = 1;
            int oddNumber = 2 * index - 1;
            while(oddNumber <= 21){
                Console.Write("{0} ", oddNumber);
                index++;
                oddNumber = 2 * index - 1;
            }

            Console.Write("\n\n");

            // Extra Credit
            int num = 1;
            int numrows = 5;
            int numcols = 9;
            for (int row = 0; row < numrows;row++){
                num = 1; //reset

                //print leading spaces
                for (int space = 0; space < row ; space++)
                {
                    Console.Write(" ");
                }

                // print numbers
                for (int j = 1; j <= numcols - (2 * row); j++)
                {
                    Console.Write("{0}", num);
                    if (j < numrows - row)
                    {
                        num++;
                    }
                    else
                    {
                        num--;
                    }
                }

                Console.WriteLine();
            }


		}
    }
}
