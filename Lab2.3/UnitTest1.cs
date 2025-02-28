namespace Lab2._3
{
    [TestFixture]
    public class Tests
    {
        private SachService sachService;

        [SetUp]
        public void Setup()
        {
            sachService = new SachService();
        }

        [Test]
        public void TestThemSach()
        {
            var sach = new Sach("1", "KTNC", 300, "Tran", 1);
            var result = sachService.ThemSach(sach);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestKhongCoSach()
        {
            var result = sachService.ThemSach(null);
            Assert.IsFalse(result);
        }

        [Test]
        public void TestSoLuongSach()
        {
            // Arrange
            var sach1 = new Sach("1", "KTNC", 300, "Tran", 1);
            var sach2 = new Sach("2", "KTCB", 250, "TranLuu", 1);

            // Act
            sachService.ThemSach(sach1);
            sachService.ThemSach(sach2);

            // Assert
            Assert.AreEqual(2, sachService.GetDanhSachSach().Count);
        }

        [TearDown]
        public void TearDown()
        {
            sachService = null;
        }
    }
}