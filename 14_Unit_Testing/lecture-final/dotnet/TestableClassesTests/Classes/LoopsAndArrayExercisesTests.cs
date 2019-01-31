using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class LoopsAndArrayExercisesTests
    {
        //CollectionAssert
        //.AllItemsAreNotNull() - Looks at each item in actual collection for not null
        //.AllItemsAreUnique() - Checks for uniqueness among actual collection
        //.AreEqual() - Checks to see if two collections are equal (same order and quantity)
        //.AreEquilavent() - Checks to see if two collections have same element in same quantity, any order
        //.AreNotEqual() - Opposite of AreEqual
        //.AreNotEquilavent() - Opposite or AreEqualivent
        //.Contains() - Checks to see if collection contains a value/object

        // Arrange
        private LoopsAndArrayExercises _exercises = new LoopsAndArrayExercises();

        [TestMethod()]
        public void MiddleWayTest()
        {
            // Arrange
            var expected = new int[] { 2, 3 };

            // Act
            var actual = _exercises.MiddleWay(new int[] { 1, 2, 6 }, new int[] { 1, 3, 6 });
            
            // Assert
            CollectionAssert.AreEqual(expected, actual, "Test 1: Input was [1, 2, 6] and [1, 3, 6]");

            expected = new int[] { 7, 8 };
            actual = _exercises.MiddleWay(new int[] { 7, 7, 7 }, new int[] { 3, 8, 0 });
            CollectionAssert.AreEqual(expected, actual, "Test 1: Input was [7, 7, 7] and [3, 8, 0]");

            CollectionAssert.AreEqual(new int[] { 2, 4 }, 
                                      _exercises.MiddleWay(new int[] { 5, 2, 9 }, new int[] { 1, 4, 5 }),
                                      "Test 1: Input was [5, 2, 9] and [1, 4, 5]");
        }

        //maxEnd3([1, 2, 3]) → [3, 3, 3]
        //maxEnd3([11, 5, 9]) → [11, 11, 11]
        //maxEnd3([2, 11, 3]) → [3, 3, 3]

        [TestMethod()]
        public void MaxEnd3Test()
        {
            // Arrange
            int[] input1 = { 1, 2, 3 };
            int[] input2 = { 11, 5, 9 };
            int[] input3 = { 2, 11, 3 };

            // Act
            int[] actual1 = _exercises.MaxEnd3(input1);
            int[] actual2 = _exercises.MaxEnd3(input2);
            int[] actual3 = _exercises.MaxEnd3(input3);

            // Assert
            int[] expected1 = { 3, 3, 3 };
            int[] expected2 = { 11, 11, 11 };
            int[] expected3 = { 3, 3, 3 };
            CollectionAssert.AreEqual(expected1, actual1, "Test 1: Input was [1, 2, 3]");
            CollectionAssert.AreEqual(expected2, actual2, "Test 2: Input was [11, 5, 9]");
            CollectionAssert.AreEqual(expected3, actual3, "Test 3: Input was [2, 11, 3]");
        }
    }
}