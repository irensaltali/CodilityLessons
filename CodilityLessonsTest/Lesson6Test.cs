using CodilityLessons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityLessonsTest
{
    [TestClass]
    public class Lesson6Test
    {
        [TestMethod]
        public void DistinctTest()
        {
            var lesson = new Lesson6();
            Assert.AreEqual(3, lesson.Distinct(new int[] { 2, 1, 1, 2, 3, 1 }));
            Assert.AreEqual(3, lesson.Distinct2(new int[] { 2, 1, 1, 2, 3, 1 }));
        }

        [TestMethod]
        public void MaxProductOfThreeTest()
        {
            var lesson = new Lesson6();
            Assert.AreEqual(60, lesson.MaxProductOfThree(new int[] { -3, 1, 2, -2, 5, 6 }));
            Assert.AreEqual(105, lesson.MaxProductOfThree(new int[] { 4, 7, 3, 2, 1, -3, -5 }));
        }

        [TestMethod]
        public void NumberOfDiscIntersectionsTest()
        {
            var lesson = new Lesson6();
            Assert.AreEqual(11, lesson.NumberOfDiscIntersections(new int[] { 1, 5, 2, 1, 4, 0 }));
            Assert.AreEqual(2, lesson.NumberOfDiscIntersections(new int[] { 1, 2147483647, 0 }));
        }




    }
}
