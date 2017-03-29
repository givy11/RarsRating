using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarsCore;

namespace RarsTest
{
    [TestClass]
    public class UnitTest1
    {
		RarsRating rating;
		public UnitTest1()
		{
			rating = new RarsRating();
		}

        [TestMethod]
        public void TestMethod1()
        {
			Assert.AreEqual(rating.Questions.Count, 6);
        }
    }
}
