using System;
using System.Collections.Generic;
using System.Linq;
using static System.String;

namespace TextWrapping
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please input data to wrap");
            var listOfData = new[] { Console.ReadLine() };
            
            while (listOfData[0] == Empty)
            {
                Console.WriteLine("Please input valid data");
                listOfData = new[] { Console.ReadLine() };
            }

            int fixedLength;
            Console.WriteLine("Please input a number for limit");

            //Validate limit input
            while (!int.TryParse(Console.ReadLine(), out fixedLength))
            {
                Console.WriteLine("Please input a Valid number for limit");
            }


            foreach (var s in listOfData)
            {
                var data = WrapClass.DataWrap(s, fixedLength);
                foreach (var t in data)
                {
                    Console.WriteLine(t);
                }
            }
        }


       
    }
}
