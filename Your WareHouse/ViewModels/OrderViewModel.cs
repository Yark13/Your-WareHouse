using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_WareHouse.ViewModels
{
    internal class OrderViewModel
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

        private UnitOfMeasurement _goodType;
        public UnitOfMeasurement GoodType
        {
            get { return _goodType; }
            set
            {
                _goodType = value;
                OnPropertyChanged(nameof(GoodType));
            }
        }

        // Rest of your properties...

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string? CustomerComment { get; set; }

        public string? ManagerComment { get; set; }
    }
}