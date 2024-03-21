using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using News_API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Tests
{

    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void NewsTest()
        {
            // Test the News API
            var news = new News_API.Controllers.News(null);
            var result = news.Get();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void NewsEverythingTest()
        {
            // Test the News GetEverything API
            var news = new News_API.Controllers.News(null);
            var result = news.GetEverything();
            Assert.IsNotNull(result);
        }
    }
}