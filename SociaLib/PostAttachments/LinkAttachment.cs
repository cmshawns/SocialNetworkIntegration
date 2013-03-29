using System;

namespace SociaLib
{
  public class LinkAttachment : IPostAttachment
  {
    public LinkAttachment()
    {
    }

    public LinkAttachment(string url)
    {
      Add(url);
    }

    public LinkAttachment(Uri url)
    {
      Add(url);
    }

    /// <summary>
    /// Gets or sets the shortener.
    /// </summary>
    /// <value>
    /// The shortener.
    /// </value>
    ILinkShortener Shortener { get; set; }
		
    /// <summary>
    /// Add the specified url.
    /// </summary>
    /// <param name='url'>
    /// If set to <c>true</c> URL.
    /// </param>
    /// <exception cref='System.NotImplementedException'>
    /// Is thrown when a requested operation is not implemented for a given type.
    /// </exception>
    public bool Add(Uri url)
    {
      throw new System.NotImplementedException();
    }
	
		#region IPostAttachment implementation
    public bool Add(string url)
    {
      throw new System.NotImplementedException();
    }
	
    public bool Remove()
    {
      throw new System.NotImplementedException();
    }
	
    public string Item
    {
      get
      {
        throw new System.NotImplementedException();
      }
      set
      {
        throw new System.NotImplementedException();
      }
    }
		#endregion
  }
}

