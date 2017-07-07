using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhoGoesThere.Data;

namespace WhoGoesThere.UnitTests
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void CreateDB()
        {
            var db = new ApplicationDbContext();
        }
    }
}
