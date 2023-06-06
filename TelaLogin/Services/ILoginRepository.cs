using System;
using TelaLogin.Models;

namespace TelaLogin.Services
{
	public interface ILoginRepository
	{
		Task<UserInfo> Login(string username, string password);
	}
}

