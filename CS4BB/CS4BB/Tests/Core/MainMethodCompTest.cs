﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CS4BB.Tests.Core
{
    [TestFixture]
    class MainMethodCompTest
    {
        [Test]
        public void Compile()
        {
            List<String> code = new List<String>();
            code.Add("static void Main(string[] args) {");
            Generator gen = new Generator(code, true);
            gen.Run();
            Assert.IsFalse(gen.HasErrors(), "Not suppose to have errors");
            Assert.AreEqual("public static void main(String[] args) { ", gen.GetAllCode());
        }
    }
}
