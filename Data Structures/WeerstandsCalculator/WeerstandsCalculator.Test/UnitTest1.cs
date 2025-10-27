using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace WeerstandsCalculator.Test
{
    [TestClass]
    public class TestBerekenWeerstand
    {
        [DataTestMethod]
        [DataRow(Kleur.Rood, Kleur.Oranje, Kleur.Geel, 230000)]
        [DataRow(Kleur.Zwart, Kleur.Zwart, Kleur.Zwart, 0)]
        [DataRow(Kleur.Bruin, Kleur.Bruin, Kleur.Bruin, 110)]
        [DataRow(Kleur.Rood, Kleur.Rood, Kleur.Rood, 2200)]
        //etc.
        public void Test3Kleuren(Kleur kleur1, Kleur kleur2, Kleur kleur3, double verwachteWaarde)
        {
            //Arrange
            //Kleur kleur1 = Kleur.Rood;
            //Kleur kleur2 = Kleur.Oranje;
            //Kleur kleur3 = Kleur.Geel;
            //double verwachteWaarde = 230000;

            //Act: weerstandscalculator aanroepen
            double weerstandsWaarde = Program.BerekenWeerstand(kleur1, kleur2, kleur3);

            //Assert
            Assert.AreEqual(verwachteWaarde, weerstandsWaarde);
        }

        //[TestMethod]
        //public void TestRoodGroenBlauw()
        //{
        //Arrange
        //Kleur kleur1 = Kleur.Rood;
        //Kleur kleur4 = Kleur.Groen;
        //Kleur kleur5 = Kleur.Blauw;
        //double verwachteWaarde = 25000000;

        //Act: weerstandscalculator aanroepen
        //double weerstandsWaarde = Program.BerekenWeerstand(kleur1, kleur4, kleur5);

        //Assert
        //Assert.AreEqual(verwachteWaarde, weerstandsWaarde);
        //}
    }
}