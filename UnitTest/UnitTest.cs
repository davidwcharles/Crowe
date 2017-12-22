using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoggingAPI;

namespace UnitTest
{
	[TestClass]
	public class UnitTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			Logger logger = new Logger();
			//Assert.IsTrue(logger.LogMessage("Hello World", LoggingTarget.Console));
			Assert.IsFalse(logger.LogMessage("Hello World", LoggingTarget.Database));
		}
	}
}
