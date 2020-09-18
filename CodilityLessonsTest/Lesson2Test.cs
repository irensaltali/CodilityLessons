using CodilityLessons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityLessonsTest
{
    [TestClass]
    public class Lesson2Test
    {
        [TestMethod]
        public void BinaryGapTest()
        {
            var lesson = new Lesson2();
            CollectionAssert.AreEqual(new int[] { 9, 7, 6, 3, 8 }, lesson.CyclicRotation(new int[] { 3, 8, 9, 7, 6 }, 3));
            CollectionAssert.AreEqual(new int[] { 6, 7, 1, 2, 3, 4, 5 }, lesson.CyclicRotation(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 2));
        }
    }
}
