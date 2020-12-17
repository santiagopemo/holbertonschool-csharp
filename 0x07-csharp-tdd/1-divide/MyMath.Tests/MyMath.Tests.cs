using NUnit.Framework;

namespace MyMath.Tests
{
    public class MyMath_Matrix_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Matrix_Divided_By_Positive()
        {
            int[,] matrix = new int[,]
            {
                {2, 3, 1},
                {10, 20, 30},
                {5, 10, 15}
            };
            int num = 3;
            int[,] result = Matrix.Divide(matrix, num);
            Assert.AreEqual(result, new int[,]{{0, 1, 0},{3, 6, 10},{1, 3, 5}});
        }

        [Test]
        public void Matrix_Is_Null()
        {
            int[,] matrix = null;
            int num = 3;
            int[,] result = Matrix.Divide(matrix, num);
            Assert.IsNull(result);
        }
        [Test]
        public void Num_is_0()
        {
            int[,] matrix = new int[,]
            {
                {2, 3, 1},
                {10, 20, 30},
                {5, 10, 15}
            };
            int num = 0;
            int[,] result = Matrix.Divide(matrix, num);
            Assert.IsNull(result);
        }
    }
}