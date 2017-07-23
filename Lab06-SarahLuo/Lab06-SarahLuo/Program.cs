using System;

namespace Lab06SarahLuo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /******* Problem 2 *******/
            String[] months = {"January", "February", "March", "April", "May", "June", "July",
                "August", "September", "October", "November", "December"};

            for (int i = 0; i < months.Length; i++)
                Console.WriteLine("{0:D2}   " + months[i], i+1);

            Console.Write("\n\n");

			/******* Problem 3 *******/
			String[] seasons = { "Fall", "Winter", "Spring", "Summer" };

            foreach (String item in seasons)
                Console.Write(item + "   ");

            Console.Write("\n\n");

			/******* Problem 4 *******/
			Random random = new Random();
            int[] randomInts = new int[1000];

            for (int i = 0; i < randomInts.Length; i++)
                randomInts[i] = random.Next(0, 100);

            foreach(int num in randomInts)
                Console.WriteLine(num.ToString());


            Console.Write("\n\n");

			/******* Problem 5 *******/
			string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

			int j = 0;
			while (j < names.Length)
			{
				Console.WriteLine(names[j]);
                j++;
			}

            Console.Write("\n\n");

			/******* Problem 6 *******/
			int k = 0;
			while (k < names.Length)
			{
				Console.WriteLine("{0,2}. {1}", k, names[k]);
				k++;
			}

			Console.Write("\n\n");

			/******* Problem 7 *******/
			k = 0;
            foreach(String name in names)
			{
				Console.WriteLine("{0,2}. {1}", k, name);
				k++;
			}


		}
    }
}
