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


        

    }
}
