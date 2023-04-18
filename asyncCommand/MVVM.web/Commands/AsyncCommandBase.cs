using System;
using System.Threading.Tasks;

namespace MVVM.web.Commands
{
    public abstract class AsyncCommandBase : CommandBase
    {
        private bool _isExecuting;
        private Action<Exception> _onException;

        public AsyncCommandBase(Action<Exception> onException)
        {
            _onException = onException;
        }

        public bool IsExecuting
        {
            get { return _isExecuting; }
            set 
            { 
                _isExecuting = value; 
                OnCanExecutedChanged();
            }
        }

        public Action<Exception> OnException { get; }

        public override bool CanExecute(object? parameter)
        {
            return !IsExecuting && base.CanExecute(parameter);
        }

        public override async void Execute(object? parameter)
        {
            IsExecuting = true;
            try
            {
                await ExecuteAsync(parameter);
            }
            finally
            {
                IsExecuting = false;
            }
        }

        protected abstract Task ExecuteAsync(object parameter);
    }
}
