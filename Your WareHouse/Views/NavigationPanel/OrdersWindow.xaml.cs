using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AutoMapper;
using DataLayer;
using DataLayer.Entities;
using DataLayer.UnitOfWork;
using DataLayer.Repository;
using Your_WareHouse.ViewModels;

namespace Your_WareHouse.Views.NavigationPanel;

/// <summary>
/// Interaction logic for OrdersWindow.xaml
/// </summary>
public partial class OrdersWindow : Window
{
    private readonly IMapper _mapper;

    private readonly Customer _myCustomer;

    private readonly UnitOfWork _unitOfWork;

    private readonly Repository<Order> _repository;

    private List<OrderViewModel> viewModels;

    //private OrderViewModel viewModel;

    public OrdersWindow(IMapper mapper, Customer myCustomer)
    {
        InitializeComponent();

        _mapper = mapper;

        _myCustomer = myCustomer;

        _unitOfWork = new(new StateDbContext());

        _repository = _unitOfWork.GetRepository<Order>();
       // var t = _repository.GetAll().Where(Or => Or.CustomerId == _myCustomer.Id).Select(Or => _mapper.Map<OrderViewModel>(Or)).ToList();
        viewModels = _repository.GetAll().Where(Or => Or.CustomerId == _myCustomer.Id).Select(Or => _mapper.Map<OrderViewModel>(Or)).ToList();

        ListOfOrders.ItemsSource = viewModels;

      //  DataContext = viewModel;
    }

    private void Back_Click(object sender, RoutedEventArgs e)
    {
        CustomerOffice office = new(_mapper, _myCustomer);

        WindowHelper.CopyAllProparityAndReplacement(office, this);
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        OrderViewModel selectedOrder = new();

        if (selectedOrder != null && selectedOrder.OrderStatus == StatusOrder.InQueue)
        {
            selectedOrder.OrderStatus = StatusOrder.Canceled;
        
            _repository.Update(_mapper.Map<Order>(selectedOrder));
            _repository.Save();
        
            MessageBox.Show($"Canceled successfully order for GoodName: {selectedOrder.GoodName} {selectedOrder.GoodNumber} {selectedOrder.GoodType} from {selectedOrder.StartReservation} to {selectedOrder.EndReservation}");
        }
        
        if (selectedOrder.OrderStatus != StatusOrder.InQueue)
        {
            MessageBox.Show($"Sorry, but canceling the order is not possible at the moment - the order has moved from the status \"In the queue\"");
        }

        return;
    }

    private void GetManagerCommentButton_Click(object sender, RoutedEventArgs e)
    {
        // Отримати вибраний елемент у ListBox (якщо є вибраний)
        OrderViewModel selectedOrder = ListOfOrders.SelectedItem as OrderViewModel;

        MessageBox.Show($"Managers` comment: {selectedOrder.ManagerComment}");
    }

    private void GetMyCommentButton_Click(object sender, RoutedEventArgs e)
    {
        // Отримати вибраний елемент у ListBox (якщо є вибраний)
        OrderViewModel selectedOrder = ListOfOrders.SelectedItem as OrderViewModel;

        MessageBox.Show($"Your comment: {selectedOrder.CustomerComment}");
    }

    private void CreateOrderButton_Click(object sender, RoutedEventArgs e)
    {
        CreatingOrderWindow creatingWindow = new(_mapper, _myCustomer);

        WindowHelper.CopyAllProparityAndReplacement(creatingWindow, this);
    }
}
