﻿// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDKata
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void SimpleTest()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("2,2");
            Assert.That(value, Is.EqualTo(4), "Wrong actual value");
        }
        [Test]
        public void EmptyValueTest()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("");
            Assert.That(value, Is.EqualTo(0), "Wrong result. Should be zero.");
        }
        [Test]
        public void NegativeValueTest()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("abc");
            Assert.That(value, Is.EqualTo(expected: typeof(ArgumentException)), "Wrong argument.");
        }
    }
}
