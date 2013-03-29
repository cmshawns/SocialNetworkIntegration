using System;

namespace SociaLib
{
  /// <summary>
  /// I service poster.
  /// </summary>
  public interface IServicePoster
  {
    /// <summary>
    /// Gets or sets the message.
    /// </summary>
    /// <value>
    /// The message.
    /// </value>
    string Message { get; set; }
		
    /// <summary>
    /// Gets or sets the attachment.
    /// </summary>
    /// <value>
    /// The attachment.
    /// </value>
    IPostAttachment Attachment { get; set; }
		
    /// <summary>
    /// Post this instance.
    /// </summary>
    bool Post();
  }
}

