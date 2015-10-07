using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistAdmin.TransferObjects
{
	public class LoginTO
	{
		private string _usuario;
		private string _password;
		private string _token;

		public long userId { get; set; }

		public string token
		{
			set
			{
				this._token = value;
			}
			get
			{
				return this._token;
			}
		}

		public string password
		{
			set
			{
				this._password = value;
			}
			get
			{
				return this._password;
			}
		}

		public string usuario
		{
			set
			{
				this._usuario = value;
			}
			get
			{
				return this._usuario;
			}
		}
	}
}