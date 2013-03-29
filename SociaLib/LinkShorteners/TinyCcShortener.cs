using System;

namespace SociaLib
{
  /// <summary>
  /// Tiny cc shortener.
  /// </summary>
  /// <remarks>
  /// API documentation: http://tiny.cc/api-docs
  /// </remarks>
  /// <exception cref='System.NotImplementedException'>
  /// Is thrown when a requested operation is not implemented for a given type.
  /// </exception>
  public class TinyCcShortener : ILinkShortener
  {
    const string API_ROOT = "http://tiny.cc/?c=rest_api";
    
    #region Constructor(s)
    public TinyCcShortener(string apiKey)
    {
      ApiKey = apiKey;
    }
    #endregion

    #region ILinkShortener implementation
    public string ApiKey
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

    public System.Uri OriginalLink
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

    public System.Uri Shorten()
    {
      throw new System.NotImplementedException();
    }
  
    public System.Uri Shorten(string customHash)
    {
      throw new System.NotImplementedException();
    }
  
    #endregion
  }
}

