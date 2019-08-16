using System;
using NUnit.Framework;
using ImpromptuInterface;
using Dynamitey;

namespace TradeCapture
{
    [TestFixture]
    //[SetUpFixture]
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
        public void Test_ThrowIf()
        {
            Assert.That(() => Util.ThrowIf<InvalidOperationException>(false, "Error #{0}", 42), Throws.InvalidOperationException);
            Assert.That(() => Util.ThrowIf<ArgumentNullException>(false, "Error #{0}", 42), Throws.ArgumentNullException);
            Assert.That(() => Util.ThrowIf<ArgumentException>(false, "Error #{0}", 42), Throws.ArgumentException);
            Assert.That(() => Util.ThrowIf<ArgumentOutOfRangeException>(false, "Error #{0}", 42), Throws.TypeOf(typeof(ArgumentOutOfRangeException)));
        }

        private static Fund fund;
        private static Portfolio highYield;
        private static Portfolio highGrade;
        private static Desk usTreasuryDesk;
        private static Desk ukDistressedDesk;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            fund = new Fund("HedgeFund01");
            highYield = new Portfolio("HighYield", fund);
            highGrade = new Portfolio("HighGrade", fund);
            usTreasuryDesk = new Desk("US Treasury Sales at BigBank");
            ukDistressedDesk = new Desk("UK Distressed Debt Sales at Her Majesty's Bank");
        }

        [Test]
        public void Test_Create_Entity()
        {
            Console.WriteLine(fund.Name);
        }
    }
}