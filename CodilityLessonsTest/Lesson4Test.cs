using CodilityLessons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityLessonsTest
{
    [TestClass]
    public class Lesson4Test
    {
        [TestMethod]
        public void MaxCountersTest()
        {
            var lesson = new Lesson4();
            CollectionAssert.AreEqual(new int[] { 1, 1, 2, 1 }, lesson.MaxCounters(4, new int[] { 3, 1, 2, 4, 3 }));
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0 }, lesson.MaxCounters(4, new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }));
        }


        [TestMethod]
        public void FrogRiverOneTest()
        {
            var lesson = new Lesson4();
            Assert.AreEqual(6, lesson.FrogRiverOne(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }));
            Assert.AreEqual(-1, lesson.FrogRiverOne(2, new int[] { 2, 2, 2, 2, 2, 2 }));
        }

        [TestMethod]
        public void MissingIntegerTest()
        {
            var lesson = new Lesson4();
            Assert.AreEqual(6, lesson.MissingInteger(new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }));
            Assert.AreEqual(1, lesson.MissingInteger(new int[] { 2, 2, 2, 2, 2, 2 }));
            Assert.AreEqual(5, lesson.MissingInteger(new int[] { 1, 3, 6, 4, 1, 2 }));
            Assert.AreEqual(4, lesson.MissingInteger(new int[] { 1, 2, 3 }));
            Assert.AreEqual(1, lesson.MissingInteger(new int[] { -1, -3 }));
        }

        [TestMethod]
        public void PermCheckTest()
        {
            var lesson = new Lesson4();
            Assert.AreEqual(1, lesson.PermCheck(new int[] { 4, 1, 3, 2 }));
            Assert.AreEqual(0, lesson.PermCheck(new int[] { 4, 1, 3 }));
        }

    }
}
