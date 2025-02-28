namespace Lab2
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test] 
        public void Test_Add()
        {
            Assert.AreEqual(5, calculator.Cong(2, 3)); 
            Assert.AreEqual(0, calculator.Cong(-2, 2));
            Assert.AreEqual(-5, calculator.Cong(-2, -3)); 
        }

        [Test] 
        public void Test_Subtract()
        {
            Assert.AreEqual(1, calculator.Tru(3, 2)); 
            Assert.AreEqual(-4, calculator.Tru(-2, 2));
            Assert.AreEqual(1, calculator.Tru(-2, -3)); 
        }

        [Test]
        public void Test_Multiply()
        {
            Assert.AreEqual(6, calculator.Nhan(2, 3)); 
            Assert.AreEqual(-4, calculator.Nhan(-2, 2)); 
            Assert.AreEqual(6, calculator.Nhan(-2, -3));
            Assert.AreEqual(0, calculator.Nhan(0, 5));
        }

        [Test] 
        public void Test_Divide()
        {
            Assert.AreEqual(2, calculator.Chia(6, 3));
            Assert.AreEqual(-2, calculator.Chia(-6, 3)); 
            Assert.AreEqual(2, calculator.Chia(-6, -3));
        }

        [Test] 
        public void Test_DivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Chia(3, 0));
        }

        [TearDown] 
        public void TearDown()
        {
            calculator = null; 
        }
    }
}