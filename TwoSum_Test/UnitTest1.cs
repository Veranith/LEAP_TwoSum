using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoSumProject;

namespace TwoSum_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input2_7_11_15_Expects_0_1()
        {
            // Arrange
            int[] input = { 2, 7, 11, 15 };
            int target = 9;
            int[] expected = { 0, 1};
            // Act
            
            var test = TwoSumClass.TwoSum(input, target);

            // Assert
            CollectionAssert.AreEqual(test, expected);
        }

        [TestMethod]
        public void Input3_2_4_Expects_1_2()
        {
            // Arrange
            int[] input = { 3, 2, 4 };
            int target = 6;
            int[] expected = { 1, 2 };
            // Act

            var test = TwoSumClass.TwoSum(input, target);

            // Assert
            CollectionAssert.AreEqual(test, expected);
        }

        [TestMethod]
        public void Input3_3_Expects_0_1()
        {
            // Arrange
            int[] input = { 3, 3 };
            int target = 6;
            int[] expected = { 0, 1 };
            // Act

            var test = TwoSumClass.TwoSum(input, target);

            // Assert
            CollectionAssert.AreEqual(test, expected);
        }
    }
}
