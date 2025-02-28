namespace Lab2._2
{
    [TestFixture]
    public class Tests
    {
        private DiemTrungBinh diemTrungBinh;
        [SetUp]
        public void Setup()
        {
            diemTrungBinh = new DiemTrungBinh();
        }
        [TearDown]
        public void TearDown()
        {
            diemTrungBinh = null;
        }
        [Test]
        public void TestDtb()
        {
            Assert.AreEqual(7.0, diemTrungBinh.TinhTrungBinh(7, 7, 7));
            Assert.AreEqual(5.0, diemTrungBinh.TinhTrungBinh(5, 5, 5));
            Assert.AreEqual(6.33, diemTrungBinh.TinhTrungBinh(6, 7, 6),0.01);

        }
        [Test]
        public void TestDtbMinandMax()
        {
            Assert.AreEqual(10.0, diemTrungBinh.TinhTrungBinh(10, 10, 10));  
            Assert.AreEqual(0.0, diemTrungBinh.TinhTrungBinh(0, 0, 0)); 
        }

        [Test]
        public void TestDtbError()
        {
            Assert.Throws<ArgumentException>(() => diemTrungBinh.TinhTrungBinh(-1, 5, 5));  
            Assert.Throws<ArgumentException>(() => diemTrungBinh.TinhTrungBinh(8, 11, 5));  
        }
    }
}