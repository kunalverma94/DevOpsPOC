﻿using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program program = new Program();
            var  r=program.GetString();

            Assert.IsNotNull(r);
        }
    }
}
