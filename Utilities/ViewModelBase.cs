using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace tractorCompany.Utilities
{
    internal class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void onPropertyChanged([CallerMemberName] string propName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
