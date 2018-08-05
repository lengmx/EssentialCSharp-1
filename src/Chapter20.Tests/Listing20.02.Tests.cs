using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_01.Tests.ProgramTests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_02.Tests
{
    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public void UnsynchronizedIncrementAndDecrement()
        {
            Assert.IsFalse(
                IsIncrementDecrementSynchronized(Program.Main));
        }
    }
}