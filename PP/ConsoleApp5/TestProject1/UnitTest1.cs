using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double weerstandsWaarde = Program.BerekenWeerstand(Kleur.Bruin, Kleur.Bruin, Kluir.Bruin);

            Assert.AreEqual(1101, weerstandsWaarde);
        }
    }
}