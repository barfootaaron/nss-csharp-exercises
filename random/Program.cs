using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // Create a list
            // Populate the list

            List<int> randomNumList = new List<int>();
            for ( int i = 0; i < 20; i++ )
            {
                randomNumList.Add(random.Next(0,50));
            }

            foreach(int n in randomNumList)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("-------------------");

            List<int> randomNumListSqrd = new List<int>();
            foreach(int randomNum in randomNumList)
            {
                randomNumListSqrd.Add(randomNum * randomNum);
            }
            foreach(int num in randomNumListSqrd)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("-------------------");
            
            foreach(int squaredNum in randomNumListSqrd.ToList())
            {
                if(squaredNum % 2 != 0)
                {
                    randomNumListSqrd.Remove(squaredNum);
                } else
                {
                    Console.WriteLine(squaredNum);
                }
            }


        }
    }
}
