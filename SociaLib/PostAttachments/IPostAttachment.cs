using System;

namespace SociaLib
{
  /// <summary>
  /// I post attachment.
  /// </summary>
  public interface IPostAttachment
  {
    /// <summary>
    /// Gets the path.
    /// </summary>
    /// <value>
    /// The path.
    /// </value>
    string Item { get; set; }
		
    /// <summary>
    /// Add the specified path.
    /// </summary>
    /// <param name='path'>
    /// If set to <c>true</c> path.
    /// </param>
    bool Add(string path);
		
    /// <summary>
    /// Remove this instance.
    /// </summary>
    bool Remove();
  }
}

