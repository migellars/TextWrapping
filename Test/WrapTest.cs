using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextWrapping.Test
{
    [TestClass]
    public class WrapTest
    {
        public static List<string> DataWrap(string data, int limit)
        {
            int currentIndex;
            var lastWrap = 0;
            var whitespace = new[] { ' ', '\r', '\n', '\t' };
            var list = new List<string>();

            do
            {
                currentIndex = lastWrap + limit > data.Length ? data.Length : (data.LastIndexOfAny(new[] { ' ', ',', '.', '?', '!', ':', ';', '-', '\n', '\r', '\t' }, Math.Min(data.Length - 1, lastWrap + limit)) + 1);
                if (currentIndex <= lastWrap)
                    currentIndex = Math.Min(lastWrap + limit, data.Length);
                list.Add(data.Substring(lastWrap, currentIndex - lastWrap).Trim(whitespace));
                lastWrap = currentIndex;
            } while (currentIndex < data.Length);
            return list;
        }


        [TestMethod]
        public void TextWrap_SplitsTextIntoAllowableLengthsAndAvoidsBreakingWords()
        {
            var rows = DataWrap( "12345 abcd 1234", 7 );
            Assert.AreEqual(3, rows.Count);
            Assert.AreEqual("12345", rows[0] );
            Assert.AreEqual("abcd", rows[1] );
            Assert.AreEqual("1234", rows[2] );
        }

        [TestMethod]
        public void TextWrap_BreaksWordExceedingLineLimit()
        {
            var rows = DataWrap( "foobarhello", 7 );
            Assert.AreEqual(2, rows.Count );
            Assert.AreEqual("foobarh", rows[0] );
            Assert.AreEqual("ello", rows[1] );
        }

        [TestMethod]
        public void TextWrap_BreaksWordExceedingLimitOfSeveralLines()
        {
            var rows = DataWrap( "foobar_line_foobar", 6 );
            Assert.AreEqual(3, rows.Count );
            Assert.AreEqual( "foobar", rows[0] );
            Assert.AreEqual( "_line_", rows[1] );
            Assert.AreEqual( "foobar", rows[2] );
        }

        [TestMethod]
        public void TextWrap_BreaksWordsExceedingLineLimitAndBreaksBetweenWordThatFitsWithinLimit()
        {
            var rows = DataWrap( "lorem ipsum testing7890xyz 12345 abc", 12 );
            Assert.AreEqual( 4, rows.Count );
            Assert.AreEqual( "lorem ipsum", rows[0] );
            Assert.AreEqual( "testing7890x", rows[1]);
            Assert.AreEqual( "yz 12345", rows[2] );
            Assert.AreEqual( "abc", rows[3] );
        }
    }
}