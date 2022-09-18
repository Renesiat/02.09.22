using CalcProject.App;
namespace TestCalc
{
    [TestClass]
    public class AppTest
    {
        [TestMethod]
        public void TestCalc()
        {
            CalcProject.App.Calc calc = new();
            Assert.IsNotNull(calc);
        }
        [TestMethod]
        public void RomanNumberParse()
        {
            Assert.AreEqual(RomanNumber.Parse("II"), 2);
            Assert.AreEqual(RomanNumber.Parse("IV"), 4);
            Assert.AreEqual(RomanNumber.Parse("IX"), 9);
            Assert.AreEqual(RomanNumber.Parse("XV"), 15);
            Assert.AreEqual(RomanNumber.Parse("XX"), 20);
            Assert.AreEqual(RomanNumber.Parse("XL"), 40);
            Assert.AreEqual(RomanNumber.Parse("XC"), 90);
            Assert.AreEqual(RomanNumber.Parse("CX"), 110);
            Assert.AreEqual(RomanNumber.Parse("CD"), 400);
            Assert.AreEqual(RomanNumber.Parse("CM"), 900);
            Assert.AreEqual(RomanNumber.Parse("MM"), 2000);


            Assert.AreEqual(RomanNumber.Parse("I"), 1);
            Assert.AreEqual(RomanNumber.Parse("IV"), 4, "IV == 4");
            Assert.AreEqual(RomanNumber.Parse("XV"), 15);
            Assert.AreEqual(RomanNumber.Parse("XXX"), 30);
            Assert.AreEqual(RomanNumber.Parse("CM"), 900);
            Assert.AreEqual(RomanNumber.Parse("MCMXCIX"), 1999);
            Assert.AreEqual(RomanNumber.Parse("CD"), 400);
            Assert.AreEqual(RomanNumber.Parse("CDI"), 401);
            Assert.AreEqual(RomanNumber.Parse("LV"), 55);
            Assert.AreEqual(RomanNumber.Parse("XL"), 40);
        }
        //[TestMethod]
        //public void AddStaticTest()
        //{
        //    RomanNumber rn5 = RomanNumber.Add(2, 3);
        //    RomanNumber rn8 = RomanNumber.Add(rn5, 3);
        //    RomanNumber rn10 = RomanNumber.Add("I", "IX");
        //    RomanNumber rn9 = RomanNumber.Add(rn5, "IV");
        //    RomanNumber rn13 = RomanNumber.Add(rn5, rn8);

        //}
    }

}