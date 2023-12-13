using Activitats;

namespace Ex23Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AreaRectanguloTest()
        {
            //ARANGE
            double Base = 5;
            double Altura = 10;
            bool Figure = false;

            //ACT
            double result = Program.Area(Base, Altura, Figure);

            //ASSERT
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void AreaPentagonoTest()
        {
            //ARANGE
            double Apotema = 4;
            double Longitud = 4;
            bool Figure = true;

            //ACT
            double result = Program.Area(Apotema, Longitud, Figure);

            //ASSERT
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void AreaCirculoTest()
        {
            //ARANGE
            double Radi = 3;

            //ACT
            double result = Program.Area(Radi);

            //ASSERT
            Assert.AreEqual(18.84955592153876, result);
        }
    }
}