using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CRUD.Model
{
    public class Users : INotifyPropertyChanged
    {
		private int _Id;
		public int Id
		{
			get { return _Id; }
			set { 
				_Id = value;
				OnPropertyChanged();
			}
		}

		private string _FirstName;
		public string FirstName
		{
			get { return _FirstName; }
			set { 
				_FirstName = value;
                OnPropertyChanged();
            }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { 
				_LastName = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
