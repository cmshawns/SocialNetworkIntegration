using System;
using NUnit.Framework;
using SociaLib;

namespace Test.SocialLib
{
  [TestFixture()]
	public class TestTinyCcShortener
  {
    const string API_KEY = "**PLACEHOLDER**";

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

