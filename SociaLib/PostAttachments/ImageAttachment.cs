using System;

namespace SociaLib
{
  public class ImageAttachment : IPostAttachment
  {
    public ImageAttachment()
    {
    }

		#region IPostAttachment implementation
    public bool Add(string path)
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
		
		
    public LinkAttachment Upload(IMediaService service, ILinkShortener shortener = null)
    {
      throw new NotImplementedException();
    }
  }
}

