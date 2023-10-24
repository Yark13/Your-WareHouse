using System.ComponentModel;

namespace Your_WareHouse.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyCnaged(string propartyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propartyName));
        }
    }
}
