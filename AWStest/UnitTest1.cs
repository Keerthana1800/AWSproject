using Microsoft.VisualStudio.TestTools.UnitTesting;
using AWSproject.Models;
using AWSproject.Services;

namespace AWStest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IRepo<int, Customer> repo = new CustomerRepo();
            var result = repo.GetAll();
            result.Wait();
            int count = result.Result.Count;
            Assert.AreEqual(1, count);
        }
    }
}
