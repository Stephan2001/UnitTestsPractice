using BasicOOP;

namespace TestOOP
{
    [TestClass]
    public class ChickenBurgerTest
    {
        ChickenBurger cb = new ChickenBurger();
        [TestMethod]
        public void TestCHicken()
        {
            string expected = "Chicken...REAL CHICKEN";
            Assert.AreEqual(expected, cb.getPatty());
        }
    }
}