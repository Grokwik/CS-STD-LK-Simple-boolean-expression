﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace SimpleBooleanExpression
{
    [TestClass]
    public class Tests
    {
        [TestCategory("Language Knowledge"), TestMethod]
        public void LanguageKnowledge1()
        {
            Check.That(Solution.Test(1, 5)).IsTrue();
        }

        [TestCategory("Language Knowledge"), TestMethod]
        public void LanguageKnowledge2()
        {
            Check.That(Solution.Test(5, 1)).IsTrue();
        }

        [TestCategory("Reliability"), TestMethod]
        public void Reliability1()
        {
            Check.That(Solution.Test(2, 3)).IsFalse();
        }

        [TestCategory("Reliability"), TestMethod]
        public void Reliability2()
        {
            Check.That(Solution.Test(3, 2)).IsFalse();
        }

        [TestCategory("Language Knowledge"), TestMethod]
        public void LanguageKnowledge3()
        {
            Check.That(Solution.Test(-3, 4)).IsTrue();
        }

        [TestCategory("Language Knowledge"), TestMethod]
        public void LanguageKnowledge4()
        {
            Check.That(Solution.Test(4, -3)).IsTrue();
        }

        [TestCategory("Reliability"), TestMethod]
        public void Reliability3()
        {
            Check.That(Solution.Test(0, 0)).IsFalse();
        }
    }
}