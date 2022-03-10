using System;
using System.Collections.Generic;

namespace TextWrapping
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= decimal.Zero)
            {
                Console.WriteLine("Please input data");
                args = new[] { Console.ReadLine() };
            }

            int fixedLength;
            Console.WriteLine("Please input a number for limit");
            //Validate limit input
            while (!int.TryParse(Console.ReadLine(), out fixedLength))
            {
                Console.WriteLine("Please input a Valid number for limit");
            }
            

            foreach (var s in args)
            {
                var data = DataWrap(s, fixedLength);
                foreach (var t in data)
                {
                    Console.WriteLine(t);
                }
            }
        }


        private static List<string> DataWrap(string data, int limit)
        {
            int currentIndex;
            var lastWrap = 0;
            var whitespace = new[] { '\r', '\n', '\t' };
            var list = new List<string>();

            do
            {
                currentIndex = lastWrap + limit > data.Length ? data.Length : (data.LastIndexOfAny(new[] {  ',', '.', '?', '!', ':', ';', '-', '\n', '\r', '\t' }, Math.Min(data.Length - 1, lastWrap + limit)) + 1);
                if (currentIndex <= lastWrap)
                    currentIndex = Math.Min(lastWrap + limit, data.Length);
                list.Add(data.Substring(lastWrap, currentIndex - lastWrap).Trim(whitespace));
                lastWrap = currentIndex;
            } while (currentIndex < data.Length);
            return list;
        }
    }
}
