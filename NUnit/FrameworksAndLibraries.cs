using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Api;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.IO;

namespace NUnitExamples
{
    // Basic Assertions Example
    [TestFixture]
    public class AssertionsExample
    {
        [Test]
        public void BasicAssertions()
        {
            Assert.That(2 + 2, Is.EqualTo(4));
            Assert.AreEqual(4, 2 + 2);
            Assert.IsTrue(true);
            Assert.IsFalse(false);
        }
    }

    // Constraint Based Testing Example
    [TestFixture]
    public class ConstraintExample
    {
        [Test]
        public void ConstraintTests()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Assert.That(numbers, Has.Length.EqualTo(5));
            Assert.That(numbers, Is.All.GreaterThan(0));
        }
    }

    // Async Testing Example
    [TestFixture]
    public class AsyncExample
    {
        [Test]
        public async Task AsyncTest()
        {
            var result = await Task.FromResult(42);
            Assert.That(result, Is.EqualTo(42));
        }
    }

    // Setup and Teardown Example
    [TestFixture]
    public class SetupTeardownExample
    {
        [SetUp]
        public void Setup()
        {
            // Setup code
        }

        [TearDown]
        public void Teardown()
        {
            // Cleanup code
        }

        [Test]
        public void TestMethod()
        {
            Assert.Pass();
        }
    }

    // Parameterized Testing Example
    [TestFixture]
    public class ParameterizedExample
    {
        [TestCase(1, 2, 3)]
        [TestCase(10, 20, 30)]
        public void AddNumbers(int a, int b, int expected)
        {
            Assert.That(a + b, Is.EqualTo(expected));
        }
    }

    // Category Example
    [TestFixture]
    public class CategoryExample
    {
        [Test]
        [Category("Integration")]
        public void IntegrationTest()
        {
            Assert.Pass();
        }
    }

    // Exception Testing Example
    [TestFixture]
    public class ExceptionExample
    {
        [Test]
        public void ExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => throw new ArgumentException());
        }
    }

    // Collection Testing Example
    [TestFixture]
    public class CollectionExample
    {
        [Test]
        public void CollectionTest()
        {
            var list = new List<int> { 1, 2, 3 };
            Assert.That(list, Contains.Item(2));
            Assert.That(list, Is.Ordered);
        }
    }

    // Range Testing Example
    [TestFixture]
    public class RangeExample
    {
        [Test]
        public void RangeTest()
        {
            Assert.That(5, Is.InRange(1, 10));
        }
    }

    // String Testing Example
    [TestFixture]
    public class StringExample
    {
        [Test]
        public void StringTest()
        {
            Assert.That("Hello World", Does.Contain("World"));
            Assert.That("Hello", Is.Not.Empty);
        }
    }

    // Timeout Example
    [TestFixture]
    public class TimeoutExample
    {
        [Test, Timeout(1000)]
        public void TimeoutTest()
        {
            // Test with timeout
            System.Threading.Thread.Sleep(500);
        }
    }

    // Combinatorial Testing Example
    [TestFixture]
    public class CombinatorialExample
    {
        [Test]
        public void CombinatorialTest(
            [Values(1, 2)] int x,
            [Values("A", "B")] string y)
        {
            Assert.Pass();
        }
    }

    // Ignore Example
    [TestFixture]
    public class IgnoreExample
    {
        [Test]
        [Ignore("Reason for ignoring")]
        public void IgnoredTest()
        {
            Assert.Pass();
        }
    }

    // Repeat Example
    [TestFixture]
    public class RepeatExample
    {
        [Test]
        [Repeat(3)]
        public void RepeatedTest()
        {
            Assert.Pass();
        }
    }

    // Random Testing Example
    [TestFixture]
    public class RandomExample
    {
        [Test]
        public void RandomTest()
        {
            var random = TestContext.CurrentContext.Random;
            var number = random.Next(1, 100);
            Assert.That(number, Is.InRange(1, 100));
        }
    }

    // File Testing Example
    [TestFixture]
    public class FileExample
    {
        [Test]
        public void FileTest()
        {
            var path = "test.txt";
            Assert.That(File.Exists(path));
        }
    }

    // Parallel Testing Example
    [TestFixture]
    public class ParallelExample
    {
        [Test, Parallelizable]
        public void ParallelTest1()
        {
            Assert.Pass();
        }

        [Test, Parallelizable]
        public void ParallelTest2()
        {
            Assert.Pass();
        }
    }

    // Theory Example
    [TestFixture]
    public class TheoryExample
    {
        [Theory]
        public void TheoryTest(
            [Range(1, 3)] int x,
            [Range(4, 6)] int y)
        {
            Assert.That(x + y, Is.GreaterThan(0));
        }
    }

    // Custom Constraint Example
    [TestFixture]
    public class CustomConstraintExample
    {
        public class EvenConstraint : Constraint
        {
            public override ConstraintResult ApplyTo<TActual>(TActual actual)
            {
                if (actual is int number)
                {
                    return new ConstraintResult(this, actual, number % 2 == 0);
                }
                return new ConstraintResult(this, actual, false);
            }
        }

        [Test]
        public void CustomConstraintTest()
        {
            Assert.That(2, new EvenConstraint());
        }
    }

    // Data Driven Testing Example
    [TestFixture]
    public class DataDrivenExample
    {
        public static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(1, 2).Returns(3);
                yield return new TestCaseData(10, 20).Returns(30);
            }
        }

        [Test, TestCaseSource("TestCases")]
        public int DataDrivenTest(int a, int b)
        {
            return a + b;
        }
    }

    // Ordered Test Example
    [TestFixture, Order(1)]
    public class OrderedTestExample
    {
        [Test, Order(1)]
        public void FirstTest()
        {
            Assert.Pass();
        }

        [Test, Order(2)]
        public void SecondTest()
        {
            Assert.Pass();
        }
    }

    // Platform Specific Example
    [TestFixture]
    public class PlatformSpecificExample
    {
        [Test]
        [Platform(Include = "Win")]
        public void WindowsOnlyTest()
        {
            Assert.Pass();
        }
    }

    // Explicit Test Example
    [TestFixture]
    public class ExplicitExample
    {
        [Test, Explicit]
        public void ExplicitTest()
        {
            Assert.Pass();
        }
    }

    // Culture Specific Example
    [TestFixture]
    public class CultureSpecificExample
    {
        [Test]
        [Culture("en-US")]
        public void CultureSpecificTest()
        {
            Assert.Pass();
        }
    }

    // MaxTime Example
    [TestFixture]
    public class MaxTimeExample
    {
        [Test]
        [MaxTime(1000)]
        public void MaxTimeTest()
        {
            System.Threading.Thread.Sleep(500);
            Assert.Pass();
        }
    }
}
