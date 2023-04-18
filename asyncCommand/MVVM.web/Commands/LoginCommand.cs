using MVVM.web.Services;
using MVVM.web.ViewModels;
using System;
using System.Threading.Tasks;

namespace MVVM.web.Commands
{
    public  class LoginCommand : AsyncCommandBase
    {
        private readonly LoginViewModel _loginViewModel;
        private readonly IAuthenticationService _authenticationService;

        public LoginCommand(LoginViewModel loginViewModel, IAuthenticationService authenticationService, Action<Exception> onException) : base(onException)
        {
            _loginViewModel = loginViewModel;
            _authenticationService = authenticationService;
        }

        protected override async Task ExecuteAsync(object parameter)
        {
            _loginViewModel.StatusMessage = "Logging in...";
            if (_loginViewModel.Username == string.Empty || _loginViewModel.Username == null)
            {
                _loginViewModel.StatusMessage = "Username must be filled in the field!";
            }
            else
            {
                await _authenticationService.Login(_loginViewModel.Username);
                _loginViewModel.StatusMessage = "Successfully logged in.";
            }
        }
    }
}
