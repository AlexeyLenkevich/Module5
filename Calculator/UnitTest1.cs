namespace Calculator
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize]
        public void ClassInit() => Console.WriteLine("Starting Unit tests (MSTest)");

        [ClassCleanup]
        public void ClassClean() => Console.WriteLine("Unit tests(MSTest) are finished");

        [TestMethod]
        public void OneCanSumPositiveIntegers() => Assert.AreEqual(new CSharpCalculator.Calculator().Add(5, 5), 10);

        [TestMethod]
        public void OneCanSumNegativeIntegers() => Assert.AreEqual(new CSharpCalculator.Calculator().Add(-5, -5), -10);

        [TestMethod]
        public void OneCanSubstractPositiveIntegers() => Assert.AreEqual(new CSharpCalculator.Calculator().Sub(5, 5), 0);

        [TestMethod]
        public void OneCanSubstractNegativeIntegers() => Assert.AreEqual(new CSharpCalculator.Calculator().Sub(-5, -5), 0);

        [TestMethod]
        public void OneCanSubstractPositiveIntegerFromZero() => Assert.AreEqual(new CSharpCalculator.Calculator().Sub(0, 100), -100);

        [TestMethod]
        public void OneCanSubstractNegativeIntegerFromZero() => Assert.AreEqual(new CSharpCalculator.Calculator().Sub(0, -100), 99);

        [TestMethod]
        public void OneCanDevideByZero() => Assert.AreEqual(new CSharpCalculator.Calculator().Divide(1, 0), 0);
        
        [TestMethod]
        public void OneCanMultiplyPositiveIntegers() => Assert.AreEqual(new CSharpCalculator.Calculator().Multiply(2, 2), 4);

        [TestMethod]
        public void OneCanMultiplyNegativeIntegers() => Assert.AreEqual(new CSharpCalculator.Calculator().Multiply(3, -2), -6);

        [TestMethod]
        public void OneCanSquareRootInteger() => Assert.AreEqual(new CSharpCalculator.Calculator().Sqrt(4), 2);

        
    }
}