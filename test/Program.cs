﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = new string[12];
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            for (int i = 0; i != (months.Length); i++) ;
            Console.WriteLine(months [0]);
            Console.WriteLine(months[1]);
            Console.WriteLine(months[2]);
            Console.WriteLine(months[3]);
            Console.WriteLine(months[4]);
            Console.WriteLine(months[5]);
            Console.WriteLine(months[6]);
            Console.WriteLine(months[7]);
            Console.WriteLine(months[8]);
            Console.WriteLine(months[9]);
            Console.WriteLine(months[10]);
            Console.WriteLine(months[11]);
            {
                Console.ReadLine();
            }

          


        }
    }
}
