using CodilityLessons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityLessonsTest
{
    [TestClass]
    public class Lesson5Test
    {
        [TestMethod]
        public void CountDivTest()
        {
            var lesson = new Lesson5();
            Assert.AreEqual(3, lesson.CountDiv(6,11,2));
            Assert.AreEqual(20, lesson.CountDiv(11,345,17));
            Assert.AreEqual(1, lesson.CountDiv(0,0,11));
            Assert.AreEqual(1, lesson.CountDiv(10,10,5));
        }


        [TestMethod]
        public void GenomicRangeQueryTest()
        {
            var lesson = new Lesson5();
            CollectionAssert.AreEqual(new int[] { 2, 4, 1 }, lesson.GenomicRangeQuery("CAGCCTA", new int[] { 2,5,0 }, new int[] { 4,5,6 }));
            CollectionAssert.AreEqual(new int[] { 2, 4, 1 }, lesson.GenomicRangeQuery2("CAGCCTA", new int[] { 2,5,0 }, new int[] { 4,5,6 }));
            CollectionAssert.AreEqual(new int[] { 2, 4, 1 }, lesson.GenomicRangeQuery3("CAGCCTA", new int[] { 2,5,0 }, new int[] { 4,5,6 }));
        }

    }
}
