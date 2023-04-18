using System;

using System.Threading.Tasks;

namespace MVVM.web.Services
{
    public interface  IAuthenticationService
    {
         Task Login(string username);
    }
}
