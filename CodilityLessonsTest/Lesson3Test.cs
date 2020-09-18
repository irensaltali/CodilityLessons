﻿using CodilityLessons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityLessonsTest
{
    [TestClass]
    public class Lesson3Test
    {
        [TestMethod]
        public void FrogJmpTest()
        {
            var lesson = new Lesson3();
            Assert.AreEqual(3, lesson.FrogJmp(10, 85, 30));
        }

        [TestMethod]
        public void PermMissingElemTest()
        {
            var lesson = new Lesson3();
            Assert.AreEqual(4, lesson.PermMissingElem(new int[] { 2, 3, 1, 5 }));
        }

    }
}
