using System;
using System.Collections.Generic;

namespace TextWrapping
{
    public class WrapClass
    {
        public static List<string> DataWrap(string data, int limit)
        {
            int currentIndex;
            var lastWrap = 0;
            var whitespace = new[] { '\r', '\n', '\t' };
            var list = new List<string>();

            do
            {
                currentIndex = lastWrap + limit > data.Length ? data.Length : (data.LastIndexOfAny(new[] { ',', '.', '?', '!', ':', ';', '-', '\n', '\r', '\t' }, Math.Min(data.Length - 1, lastWrap + limit)) + 1);
                if (currentIndex <= lastWrap)
                    currentIndex = Math.Min(lastWrap + limit, data.Length);
                list.Add(data.Substring(lastWrap, currentIndex - lastWrap).Trim(whitespace));
                lastWrap = currentIndex;
            } while (currentIndex < data.Length);
            return list;
        }
    }
}