﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vendas.Models.Messaging
{
	public class LoginRequest
	{
		public string Email { get; set; }

		public string Senha { get; set; }
	}
}
