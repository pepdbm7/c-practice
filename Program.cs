using System;

namespace exercises
{
    class LoopExercises
    {
        static void Main()
        {
            int i, odd = 0, even = 0, input = 0;
            float num, acu = 0;

            //1) Show odd numbers from 0 to 100:
            for (i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("{0}|", i);
                    odd++;
                }
            }

            Console.Write("\n\n");

            //2) Show also even numbers from 0 to 100:
            for (i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}|", i);
                    even++;
                }
            }
            Console.Write("\n\nFrom 0 to 100 there are {0} even numbers and {1} odd numbers\n\n", even, odd);

            //3) Show all numbers from 0 to 100:
            Console.Write("All numbers from 0 to 100: ");
            for (i = 0; i < 101; i++)
                Console.Write("{0}|", i);

            Console.Write("\n\n");

            //4) Show all numbers from 100 to 0:
            Console.Write("All numbers from 100 to 0: ");
            for (i = 100; i > -1; i--)
                Console.Write("{0}|", i);

            Console.Write("\n\n");

            //5) Show multiples of 5 numbers from 0 to 100:
            Console.Write("All multiples of 5 numbers: ");
            for (i = 0; i < 100; i++)
                if (i % 5 == 0)
                    Console.Write("{0}|", i);

            Console.Write("\n\n");

            //6) Show multiples of 2 and 5 numbers from 0 to 100:
            Console.Write("All multiples of 2 and 5 numbers: ");
            for (i = 0; i < 100; i++)
                if (i % 2 == 0 || i % 5 == 0)
                    Console.Write("{0}|", i);

            Console.Write("\n\n\n\n");

            //7) add 5 numbers and return average:
            while (input < 5)
            {
                Console.Write("Write the {0}º number:", input + 1);
                num = float.Parse(Console.ReadLine());
                acu += num;
                input++;
            }
            Console.Write("The average of these 5 numbers is {0}", acu / 5);
            Console.Read();

        }
    }
}
