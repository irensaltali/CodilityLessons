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




    }
}
