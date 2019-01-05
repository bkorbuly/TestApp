using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            List<int> goodresultprimeList = new List<int>()
            {
                1, 2,3,5,7, 11,13,17,19, 23,29, 31,37, 41,43,47, 53,59, 61,67, 71,73,79, 83,89, 97
            };

            //Act


            //Assert
            Assert.Equal(goodresultprimeList, TestApp.Program.CheckPrimeNumber());
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            int numberoflist = 26;

            //Act


            //Assert
            Assert.Equal(numberoflist, TestApp.Program.CheckPrimeNumber().Count);
        }
    }
}
