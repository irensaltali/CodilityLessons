using System;
using CodilityLessons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityLessonsTest
{
    [TestClass]
    public class Lesson1Test
    {
        [TestMethod]
        public void BinaryGapTest()
        {
            var lesson = new Lesson1();
            Assert.AreEqual(5, lesson.BinaryGap(1041));
            Assert.AreEqual(0, lesson.BinaryGap(15));
            Assert.AreEqual(0, lesson.BinaryGap(32));
        }
    }
}
