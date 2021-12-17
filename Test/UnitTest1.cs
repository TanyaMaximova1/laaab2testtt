using System;
using NUnit.Framework;
using lab2;
using static lab2.MathMod;
using static lab2.SystemFunction;

namespace Test
{
    [TestFixture]
    public class UnitTest1
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sin()
        {
            for (double i = -10; i < 10; i += 0.01)
            {
                Assert.AreEqual(Math.Sin(i), MathMod.Sin(i), 0.0001);
            }
        }

        [Test]
        public void Cos()
        {
            for (double i = -10; i < 4; i += 0.01)
            {
                Assert.AreEqual(Math.Cos(i), MathMod.Cos(i), 0.0001);
            }
        }
        
        [Test]
        public void Sec()
        {
            for (double i = -10; i < 10; i += 0.01)
            {
                Assert.AreEqual(1 / Math.Cos(i), MathMod.Sec(i), 0.0001);
            }
        }

        [Test]
        public void Csc()
        {
            for (double i = -10; i < 10; i += 0.01)
            {
                Assert.AreEqual(1 / Math.Sin(i), MathMod.Csc(i), 0.0001);
            }
        }

        [Test]
        public void Log()
        {
            for (int newBase = -10; newBase < 10; newBase++)
            {
                if (newBase == 1) continue;

                for (double i = -10; i < 10; i += 0.01)
                {
                    Assert.AreEqual(Math.Log(i, newBase), MathMod.Log(i, newBase), 0.1);
                }
            }
        }

        [Test]
        public void Exp()
        {
            for (double i = -10; i < 10; i += 0.01)
            {
                Assert.AreEqual(Math.Exp(i), MathMod.Exp(i), 0.001);
            }
        }

        [Test]
        public void Power()
        {
            for (int radix = -5; radix < 5; radix += 1)
            {
                for (double i = -10; i < 10; i += 0.01)
                {
                    Assert.AreEqual(Math.Pow(i, radix), MathMod.Power(i, radix), 0.001);
                }
            }
        }

        [Test]
        public void Abs()
        {
            for (double i = -10; i < 10; i += 0.01)
            {
                Assert.AreEqual(Math.Abs(i), MathMod.Abs(i));
                Assert.IsTrue(MathMod.Abs(i) >= 0);
            }
        }

        [Test]
        public void Function()
        {
            for (double x = -0.01; x < 0.01; x += 0.01)
            {
                Assert.AreEqual(CalculateByDefaultMethods(x), Calculate(x), 10);
            }
        }
    }
}
