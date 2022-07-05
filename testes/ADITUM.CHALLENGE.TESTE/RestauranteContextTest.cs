using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ADITUM.CHALLENGE.Base;
using ADITUM.CHALLENGE.Controllers;
using System.IO;

namespace ADITUM.CHALLENGE.TESTE
{
    public class RestauranteContextTest
    {
        [Fact]
        public void Read_Csv_Return_RowsCount()
        {
            //Arrange
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent+@"\base-teste.csv";
            int expectedValue = 9;
            int result;
            var clsRc = new RestauranteContext();

            //Act
            result=clsRc.ReadCsv(path).Count;

            //Assert
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("10:00", 2)]
        [InlineData("12:00", 9)]
        [InlineData("08:50", 0)]
        [InlineData("21:30", 5)]
        [InlineData("22:40", 2)]
        [InlineData("00:00", 0)]
        public void Search_hour_return_NumberOfRestaurants(string refHour, int expectedValue)
        {
            //Arrange
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent + @"\base-teste.csv";
            int result;
            var clsRc = new RestauranteContext();

            //Act
            if (clsRc.Search(path, TimeSpan.Parse(refHour)) == null)
            {
                result = 0;
            }
            else
            {
                result = clsRc.Search(path, TimeSpan.Parse(refHour)).Count;
            }
            //Assert
            Assert.Equal(expectedValue, result);
        }

    }
}
