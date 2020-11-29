using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumber = new int[1000];
            Random random = new Random();

            for (int i = 0; i < randomNumber.Length; i++)
            {
                randomNumber[i] = random.Next(0, 1000);
            }
            
            foreach (int i in randomNumber)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();
        }
    }
}
