﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class newage
    {
        public class returnAge
        {
            public static int age(DateTime dob)
            {
                int CurrentYear = DateTime.Now.Year;
                int C = DateTime.Now.Month;
                return CurrentYear - dob.Year;

            }

            public static void Main()
            {


                DateTime date = DateTime.Parse(Console.ReadLine());
                int res = (age(date)); ;
                Console.WriteLine($"your age is{res}");
            }
        }
    }
}
