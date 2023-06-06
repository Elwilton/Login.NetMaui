using System;
using TelaLogin.Models;

namespace TelaLogin.Services
{
    public class LoginService : ILoginRepository
    {
        public Task<UserInfo> Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}

