using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinTPModule4.Models
{
    class Tweet
    {
		private string id;
		private string creationDate;
		private string text;
		private string userName;
		private string userId;
		private string userAlias;

		public string UserAlias
		{
			get { return userAlias; }
			set { userAlias = value; }
		}

		public string UserId
		{
			get { return userId; }
			set { userId = value; }
		}

		public string UserName
		{
			get { return userName; }
			set { userName = value; }
		}

		public string Text
		{
			get { return text; }
			set { text = value; }
		}

		public string CreationDate
		{
			get { return creationDate; }
			set { creationDate = value; }
		}

		public string Id
		{
			get { return id; }
			set { id = value; }
		}

	}
}
