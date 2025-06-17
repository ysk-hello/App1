using App1.Services;

namespace TestProject1
{
    //https://learn.microsoft.com/ja-jp/windows/apps/winui/winui3/testing/

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
