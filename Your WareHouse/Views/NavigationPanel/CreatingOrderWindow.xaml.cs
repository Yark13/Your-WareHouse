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

        private readonly Repository<Order> _repository;

        private OrderViewModel viewModel;

        public CreatingOrderWindow(IMapper mapper, Customer myCustomer)
        {
            InitializeComponent();

            _mapper = mapper;

            _myCustomer = myCustomer;

            _repository = new UnitOfWork(new StateDbContext()).GetRepository<Order>();

            viewModel = new();

            DataContext = viewModel;
        }

        private void ToBack_Click(object sender, RoutedEventArgs e)
        {
            OrdersWindow window = new(_mapper, _myCustomer);

            WindowHelper.CopyAllProparityAndReplacement(window, this);
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.StartReservation == null || viewModel.StartReservation == null || viewModel.GoodNumber == null || string.IsNullOrEmpty(viewModel.GoodName))
            {
                MessageBox.Show("Please, fill all the fields(comment is optional)", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                return;
            }

            if(viewModel.EndReservation <= viewModel.StartReservation)
            {
                MessageBox.Show("The end of the reservation cannot be sooner than the beginning", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                return;
            }

            try
            {
                _repository.Insert(_mapper.Map<Order>(viewModel));
                _repository.Save();
            }
            catch (Exception)
            {
                MessageBox.Show($"Exceprtion!!");
            }
            
        }
    }
}
