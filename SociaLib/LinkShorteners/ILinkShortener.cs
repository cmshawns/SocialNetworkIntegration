using System;

namespace SociaLib
{
  public interface ILinkShortener
  {
    /// <summary>
    /// Gets or sets the API key.
    /// </summary>
    /// <value>
    /// The API key.
    /// </value>
    string ApiKey { get; set; }

    /// <summary>
    /// Gets or sets the original link.
    /// </summary>
    /// <value>
    /// The original link.
    /// </value>
    Uri OriginalLink { get; set; }

    /// <summary>
    /// Shorten this instance.
    /// </summary>
    Uri Shorten();
		
    /// <summary>
    /// Shorten the specified originalLink.
    /// </summary>
    /// <param name='customHash'>
    /// Original link.
    /// </param>
    Uri Shorten(string customHash);
  }
}

