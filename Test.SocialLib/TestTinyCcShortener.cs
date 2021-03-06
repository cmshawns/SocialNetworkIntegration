using System;
using System.Configuration;
using NUnit.Framework;
using SociaLib;


namespace Test.SocialLib
{
    [TestFixture()]
    public class TestTinyCcShortener
    {
        // TODO: Store API key in a workstation-specific config file - BEFORE GITHUB
        private readonly string API_KEY = ConfigurationManager.AppSettings["API_tiny.cc"];

        [Test()]
        public void NewShortLink_Random()
        {
            ILinkShortener tinycc = new TinyCcShortener(API_KEY);
            tinycc.OriginalLink = new Uri("http://www.codemastershawn.com/blog");

            Assert.IsNotNull(tinycc);

            Uri shortUrl = tinycc.Shorten();

            Assert.IsNotNull(shortUrl);
            Assert.AreEqual("http", shortUrl.Scheme);
            Assert.AreEqual("tiny.cc", shortUrl.Host);
        }
    }
}

