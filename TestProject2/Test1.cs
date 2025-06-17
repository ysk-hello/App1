using App1.Services;

namespace TestProject2
{
    //dotnet tool install -g dotnet-reportgenerator-globaltool

    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new TestService();
            Assert.AreEqual(-1, service.GetCount());
        }
    }
}
