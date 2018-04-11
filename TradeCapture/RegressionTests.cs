using System;
using NUnit.Framework;

namespace TradeCapture
{
    [TestFixture]
    class RegressionTests
    {
        [Test]
        public void CheckArgument_Throws_ArgumentException_On_False()
        {
            bool condition = false;
            TestDelegate act = () => Util.CheckArgument(condition, "test");
            Assert.That(act, Throws.ArgumentException);
        }

        [Test]
        public void CheckArgument_Nop_On_True()
        {
            bool condition = true;
            TestDelegate act = () => Util.CheckArgument(condition, "test");
            Assert.DoesNotThrow(act);
        }

        [Test]
        public void ArgumentNotNull_Throws_ArgumentException_On_Null()
        {
            object argument = null;
            TestDelegate act = () => Util.ArgumentNotNull(argument, "test");
            Assert.That(act, Throws.ArgumentNullException);
        }

        [Test]
        public void ArgumentNotNull_Nop_On_Not_Null()
        {
            object argument = new object();
            TestDelegate act = () => Util.ArgumentNotNull(argument, "test");
            Assert.DoesNotThrow(act);
        }

        [Test]
        public void CheckState_Throws_InvalidOperationException_On_False()
        {
            bool condition = false;
            TestDelegate act = () => Util.CheckState(condition, "Error #{0}", 42);
            Assert.That(act, Throws.InvalidOperationException);
        }

        [Test]
        public void CheckState_DoesNotThrow_InvalidOperationException_On_True()
        {
            bool condition = true;
            TestDelegate act = () => Util.CheckState(condition, "Error #{0}", 42);
            Assert.DoesNotThrow(act);
        }

        [Test]
        public void Test_Throw_If()
        {
            Assert.That(() => Util.ThrowIf<InvalidOperationException>(false, "Error #{0}", 42), Throws.InvalidOperationException);
            Assert.That(() => Util.ThrowIf<ArgumentNullException>(false, "Error #{0}", 42), Throws.ArgumentNullException);
            Assert.That(() => Util.ThrowIf<ArgumentException>(false, "Error #{0}", 42), Throws.ArgumentException);
            Assert.That(() => Util.ThrowIf<ArgumentOutOfRangeException>(false, "Error #{0}", 42), Throws.TypeOf(typeof(ArgumentOutOfRangeException)));
        }
    }
}