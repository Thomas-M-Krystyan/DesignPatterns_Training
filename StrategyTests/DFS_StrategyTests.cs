using NUnit.Framework;
using Strategy.Exercise.Data;
using Strategy.Exercise.TraverseStrategies;
using System;

namespace StrategyTests
{
    [TestFixture]
    public class DFS_StrategyTests
    {
        private DFS_Strategy _strategy;

        [OneTimeSetUp]
        public void InitializeTests()
        {
            this._strategy = new();
        }

        [TestCase(true)]
        [TestCase(false)]
        public void FindElementA(bool isLeftHanded)
        {
            // Act
            var result = this._strategy.Find("A", isLeftHanded);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsFound);
            Assert.That(result.Path, Is.EqualTo("A"));
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [TestCase(true, "ABDGHIJE", 8)]
        [TestCase(false, "ACFBE", 5)]
        public void FindElementE(bool isLeftHanded, string path, int count)
        {
            // Act
            var result = this._strategy.Find("E", isLeftHanded);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsFound);
            Assert.That(result.Path, Is.EqualTo(path));
            Assert.That(result.Count, Is.EqualTo((ushort)count));
        }

        [TestCase(true, null)]
        [TestCase(true, "")]
        [TestCase(true, " ")]
        [TestCase(false, null)]
        [TestCase(false, "")]
        [TestCase(false, " ")]
        public void FindElement_ForInvalidValue_ReturnsEmptyResult(bool isLeftHanded, string value)
        {
            // Act
            var result = this._strategy.Find(value, isLeftHanded);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsFalse(result.IsFound);
            Assert.That(result.Path, Is.EqualTo(String.Empty));
            Assert.That(result.Count, Is.EqualTo(0));
        }

        [TestCase(true, "Z", "ABDGHIJECF")]
        [TestCase(false, "Z", "ACFBEDHJIG")]
        public void FindElement_ForNotExistingValue_ReturnsEmptyResult(bool isLeftHanded, string value, string path)
        {
            // Act
            var result = this._strategy.Find(value, isLeftHanded);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsFalse(result.IsFound);
            Assert.That(result.Path, Is.EqualTo(path));
            Assert.That(result.Count, Is.EqualTo(Graph.Count));
        }
    }
}
