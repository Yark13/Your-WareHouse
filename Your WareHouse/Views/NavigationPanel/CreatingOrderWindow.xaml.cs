using System;
using System.Windows;
using AutoMapper;
using DataLayer;
using DataLayer.Entities;
using DataLayer.Repository;
using DataLayer.UnitOfWork;
using Your_WareHouse.ViewModels;

namespace Your_WareHouse.Views.NavigationPanel
{
    /// <summary>
    /// Interaction logic for CreatingOrder.xaml
    /// </summary>
    public partial class CreatingOrderWindow : Window
    {
        private readonly IMapper _mapper;

        private Customer _myCustomer;

        private readonly IUnitOfWork _unitOfWork;

        private readonly Repository<Order> _repository;

        private OrderViewModel viewModel;

        public CreatingOrderWindow(IMapper mapper, Customer myCustomer, IUnitOfWork unitOfWork)
        {
            InitializeComponent();

            _mapper = mapper;

            _myCustomer = myCustomer;

            _unitOfWork = unitOfWork;

            _repository = _unitOfWork.GetRepository<Order>();

            viewModel = new();
            
            viewModel.StartReservation = DateTime.Now.AddDays(2);

            viewModel.EndReservation = DateTime.Now.AddDays(3);

            viewModel.Customer = myCustomer;

            viewModel.CustomerId = myCustomer.Id;

            DataContext = viewModel;
        }

        private void ToBack_Click(object sender, RoutedEventArgs e)
        {
            OrdersWindow window = new OrdersWindow(_mapper, _myCustomer, _unitOfWork);
            WindowHelper.CopyAllProparityAndReplacement(window, this);
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.StartReservation == null || viewModel.StartReservation == null || viewModel.GoodNumber == 0 || string.IsNullOrEmpty(viewModel.GoodName))
            {
                MessageBox.Show("Please, fill all the fields (comment is optional)", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (viewModel.StartReservation <= DateTime.Now)
            {
                MessageBox.Show("The start of the reservation cannot be sooner than two day after ordering", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (viewModel.EndReservation <= viewModel.StartReservation)
            {
                MessageBox.Show("The end of the reservation cannot be sooner than the beginning", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                viewModel.OrderStatus = StatusOrder.InQueue;
                _repository.Insert(_mapper.Map<Order>(viewModel));
                _repository.Save();
                OrdersWindow window = new OrdersWindow(_mapper, _myCustomer, _unitOfWork);
                WindowHelper.CopyAllProparityAndReplacement(window, this);
            }
            catch (Exception)
            {
                MessageBox.Show($"Exception!!");
            }
        }
    }
}
