using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> randomList = new List<int>();
            Random r = new Random();

            for (int i = 0; i < 20; i++)
            {
                int j = r.Next(1, 50);
                randomList.Add(j);
            }

            List<int> RandomDoubled = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                RandomDoubled.Add(randomList[i] * randomList[i]);
            }

            Console.Write("length");
            Console.WriteLine(RandomDoubled.Count);

            for (int i = 0, j = 0; i < RandomDoubled.Count; i++, j++)
            {
                Console.Write("I is: ");
                Console.WriteLine(i);
                Console.WriteLine("RandomList[i] is:");
                Console.WriteLine(randomList[j]);
                Console.WriteLine("RandomDoubled[i] is:");
                Console.WriteLine(RandomDoubled[i]);
                Console.Write("Modulo: ");
                Console.WriteLine(RandomDoubled[i] % 2);
                if (RandomDoubled[i] % 2 != 0)
                {
                    RandomDoubled.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine("Final List:");

            RandomDoubled.ForEach(rkkk =>
            {
                Console.WriteLine(rkkk);
            });

        }
    }
}
