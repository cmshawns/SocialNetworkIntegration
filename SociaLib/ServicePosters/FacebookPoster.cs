using System;

namespace SociaLib
{
	public class FacebookPoster : IServicePoster
	{
		public FacebookPoster()
		{
		}

		#region IServicePoster implementation
		public bool Post()
		{
			throw new System.NotImplementedException();
		}
	
		public string Message
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
	
		public SociaLib.IPostAttachment Attachment
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

