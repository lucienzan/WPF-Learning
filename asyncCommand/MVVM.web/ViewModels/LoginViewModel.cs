
using MVVM.web.Commands;
using MVVM.web.Services;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.web.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
		private string _username;

		public string Username
		{
			get { return _username; }
			set { 
				_username = value; 
				OnPropertyChanged(nameof(Username));
				}
		}

		private string _statusMessage;

		public string StatusMessage
		{
			get { return _statusMessage; }
			set { 
				_statusMessage = value; 
				OnPropertyChanged(nameof(StatusMessage));
				OnPropertyChanged(nameof(HasStatusMessage));
				}
		}
		public bool HasStatusMessage => !string.IsNullOrEmpty(StatusMessage);
		public ICommand LoginCommand { get; }
		public LoginViewModel()
		{
			LoginCommand = new LoginCommand(this, new AuthenticationService(), (ex) => StatusMessage = ex.Message);
		}

        private async Task Login()
		{
			StatusMessage = "Logging in...";
            await new AuthenticationService().Login(Username);
            StatusMessage = "Successfully logged in.";
		}
	}
}
