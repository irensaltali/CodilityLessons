﻿using CodilityLessons;
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

    }
}
