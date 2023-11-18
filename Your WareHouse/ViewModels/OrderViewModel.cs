using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

// Додайте простір імен для використання EnumDescription та UnitOfMeasurement
using DataLayer.Entities;

namespace Your_WareHouse.ViewModels
{
    internal class OrderViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime StartReservation { get; set; }
        public DateTime EndReservation { get; set; }
        public StatusOrder OrderStatus { get; set; }
        public string? GoodName { get; set; }
        public int GoodNumber { get; set; }
        public UnitOfMeasurement GoodType { get; set; }

        public string? CustomerComment { get; set; }

        public string? ManagerComment { get; set; }
        // Додайте нову властивість для утримання колекції UnitOfMeasurement
        private ObservableCollection<EnumDescription> _unitOfMeasurementValues;
        public ObservableCollection<EnumDescription> UnitOfMeasurementValues
        {
            get { return _unitOfMeasurementValues; }
            set
            {
                _unitOfMeasurementValues = value;
                OnPropertyChanged(nameof(UnitOfMeasurementValues));
            }
        }

        // Ваші інші властивості...

        public OrderViewModel()
        {
            // Ініціалізуйте колекцію UnitOfMeasurementValues при створенні OrderViewModel
            UnitOfMeasurementValues = new ObservableCollection<EnumDescription>(
                Enum.GetValues(typeof(UnitOfMeasurement))
                    .Cast<UnitOfMeasurement>()
                    .Select(value => new EnumDescription
                    {
                        Value = value,
                        Description = value.GetDescription()
                    })
            );
        }

        // Додайте метод OnPropertyChanged для сповіщення про зміни властивостей
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
