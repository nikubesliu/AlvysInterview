using System.Collections.Generic;
using Xunit;

namespace AlvysInterview.Tests
{
    public class HelperUnitTests
    {
        [Fact]
        public void MapListOfIntsShouldSucceed()
        {
            //Arrange
            var list = new List<int>() { 1, 2, 3 };

            //Act
            var result = Helper.Map(list, x => x + 1);

            //Assert
            Assert.Equal(result[0], 2);
            Assert.Equal(result[1], 3);
            Assert.Equal(result[2], 4);
        }

        [Fact]
        public void MapListOfStringShouldSucceed()
        {
            //Arrange
            var list = new List<string>() { "1", "2", "3" };

            //Act
            var result = Helper.Map(list, x => x.ToString());

            //Assert
            Assert.Equal(result[0], "1");
            Assert.Equal(result[1], "2");
            Assert.Equal(result[2], "3");
        }

        [Fact]
        public void FoldShouldSucceedWithFunc1()
        {
            //Arrange
            var list = new List<int>() { 1, 2, 3 };

            //Act
            var result = Helper.Fold(list, 0, (sum, x) => sum + x);

            //Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void FoldShouldSucceedWithFunc2()
        {
            //Arrange
            var list = new List<int>() { 1, 2, 3 };

            //Act
            var result = Helper.Fold(list, "", (str, x) => str + x.ToString());

            //Assert
            Assert.Equal("123", result);
        }

        [Fact]
        public void Map2ShouldReturnSameResultAsMap()
        {
            //Arrange
            var list = new List<int>() { 1, 2, 3 };

            //Act
            var resultMap = Helper.Map(list, x => x + 1);
            var resultMap2 = Helper.Map2(list, x => x + 1);

            //Assert
            Assert.Equal(resultMap, resultMap2);
        }
    }
}
