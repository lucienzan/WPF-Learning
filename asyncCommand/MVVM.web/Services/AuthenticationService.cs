using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVVM.web.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public async Task  Login(string username)
        {
           await Task.Delay(2000);
        }
    }
}
