using RName_ReMake.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RName_ReMake.ModelViews
{
    public class SettingsBinding : INotifyPropertyChanged
    {
        public SettingsBinding() { }
        private ObservableCollection<NameInfo> _nameInfos = new ObservableCollection<NameInfo>();

        public event PropertyChangedEventHandler? PropertyChanged;
        private void onPropertyChanged([CallerMemberName]String? propertyName = null)
        {
            var ev = this.PropertyChanged;
            ev?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private ObservableCollection<NameInfo> NameInfos
        {
            get {  return _nameInfos; }
            set
            {
                _nameInfos = value;
                onPropertyChanged();
            }
        }
        internal void AddName(String name)
        {
            foreach (NameInfo info in _nameInfos)
            {
                if (info.Name == name)
                {
                    return;
                }
            }
            _nameInfos.Add(new NameInfo(name));
        }
    }
}
