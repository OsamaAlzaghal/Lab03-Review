using System;
using Xunit;
using Review_Challenges;

namespace Test_Review_Challenges
{
    public class TestReview
    {
        [Fact]
        public void TestProductOfThree()
        {
            Assert.Equal(480, Review.ProductOfThree("4 8 15"));
            Assert.Equal(480, Review.ProductOfThree("4 8 15 10 50 3 1"));
            Assert.Equal(0, Review.ProductOfThree("4 8 "));
            Assert.Equal(-480, Review.ProductOfThree("-4 -8 -15"));
        }

        [Fact]
        public static void TestNumbersAverage()
        {
            Assert.Equal(2, Review.NumbersAverage(new int[] { 1, 2, 3}));
            Assert.Equal(8, Review.NumbersAverage(new int[] { 2, 5, 7, 10, 18 }));
            Assert.Equal(0, Review.NumbersAverage(new int[] { 0, 0, 0 }));

        }

        [Fact]
        public void TestMostFrequentNum()
        {
            Assert.Equal(4, Review.MostFrequentNum(new int[] { 4, 4, 6, 2, 3, 2, 7, 1, 4 }));
            Assert.Equal(1, Review.MostFrequentNum(new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 }));
            Assert.Equal(3, Review.MostFrequentNum(new int[] { 3, 5, 7, 9, 10, 1 }));
            Assert.Equal(1, Review.MostFrequentNum(new int[] { 1, 1, 2, 2, 3, 3, 4, 4 }));
        }

        [Fact]
        public void TestMaxNumber()
        {
            Assert.Equal(555, Review.MaxNumber(new int[] { 5, 25, 99, 123, 78, 96, 555, 108, 4 }));
            Assert.Equal(-3, Review.MaxNumber(new int[] { -3, -4, -5, -6, -7, -8 }));
            Assert.Equal(4, Review.MaxNumber(new int[] { -3, 3, -5, -4, 2, 1, 4 }));
            Assert.Equal(1, Review.MaxNumber(new int[] { 1, 1, 1, 1, 1, 1 }));
        }

        [Fact]
        public void TestArrCharCounter()
        {
            string sentence1 = "My name is osama";
            Assert.Equal(new string[] { "My: 2", "name: 4", "is: 2", "osama: 5"}, Review.ArrCharCounter(sentence1));

            string sentence2 = "This is a sentance about important things";
            Assert.Equal(new string[] { "This: 4", "is: 2", "a: 1", "sentance: 8", "about: 5", "important: 9", "things: 6" }, Review.ArrCharCounter(sentence2));

            Type arrType = Review.ArrCharCounter(sentence2).GetType();
            Assert.Equal("System.String[]", $"{arrType}");

            string symbols = "My# e-mail is osama.alzaghal@gmail.com";
            Assert.Equal(new string[] { "My#: 3", "e-mail: 6", "is: 2", "osama.alzaghal@gmail.com: 24" }, Review.ArrCharCounter(symbols));

        }
    }
}
