using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RName_ReMake.Models
{
    public class NameInfo(String name): INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void onPrppertyChanged([CallerMemberName]String? property=null)
        {
            var _event = PropertyChanged;
            _event?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        private String _name = name;
        public String Name
        {
            get { return _name; }
        }
        private Boolean _isEnabled = true;
        public Boolean IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                onPrppertyChanged(nameof(IsEnabled));
            }
        }
        private Int32 _weight = 100;
        public Int32 Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                onPrppertyChanged(nameof(Weight));
            }
        }
        private class _command(Action? action) : ICommand
        {
            private readonly Action? _action = action;
            public event EventHandler? CanExecuteChanged;

            public bool CanExecute(object? parameter)
            {
                return _action != null;
            }

            public void Execute(object? parameter)
            {
                _action?.Invoke();
            }
        }
    }
}
