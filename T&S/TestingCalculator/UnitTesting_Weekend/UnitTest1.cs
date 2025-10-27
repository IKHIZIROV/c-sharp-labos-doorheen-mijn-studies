using Oefening_Weekend;
namespace UnitTesting_Weekend
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetMessage()
        {
            // Arrange
            DateTime day = new DateTime(2025, 5, 13);
            DateGetterMock mock = new DateGetterMock(day);
            Greeter greeter = new Greeter(mock);

            // Act
            var result = greeter.GetMessage();
        }
    }
}