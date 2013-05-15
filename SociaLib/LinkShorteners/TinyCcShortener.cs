using System;
using System.Net;

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
        /// <summary>
        ///  Gets or sets the API key. 
        /// </summary>
        /// <value>
        ///  The API key. 
        /// </value>
        public string ApiKey { get; set; }

        /// <summary>
        ///  Gets or sets the original link. 
        /// </summary>
        /// <value>
        ///  The original link. 
        /// </value>
        public Uri OriginalLink { get; set; }

        /// <summary>
        ///  Shorten this instance. 
        /// </summary>
        public Uri Shorten()
        {
            // TODO: Assert OriginalLink is set
            // TODO: Assert ApiKey is set

            Uri url = new Uri(API_ROOT);
            // TODO: Construct the specific REST call

            WebRequest request = HttpWebRequest.Create(url);
            // TODO: Configure request

            if (request != null)
            {
                HttpWebResponse response;
                try
                {
                    response = request.GetResponse();
                    // TODO: Extract the short URL from the response.

                } finally
                {
                    if (response != null)
                    {
                        response.Close();
                    }
                }
            }
            // TODO: notify caller that request is NULL

            throw new NotImplementedException("Code not yet complete.");
        }
  
        /// <summary>
        ///  Shorten the specified originalLink. 
        /// </summary>
        /// <param name='customHash'>
        ///  Original link. 
        /// </param>
        public Uri Shorten(string url)
        {
            throw new NotImplementedException();
        }
    #endregion
    }
}

