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

    private readonly IUnitOfWork _unitOfWork;

    private readonly Customer _myCustomer;

    private readonly Repository<Order> _repository;

    private List<OrderViewModel> viewModels;

    //private OrderViewModel viewModel;

    public OrdersWindow(IMapper mapper, Customer myCustomer, IUnitOfWork unitOfWork)
    {
        InitializeComponent();

        _mapper = mapper;

        _myCustomer = myCustomer;

        _unitOfWork = unitOfWork;

        _repository = _unitOfWork.GetRepository<Order>();
        // var t = _repository.GetAll().Where(Or => Or.CustomerId == _myCustomer.Id).Select(Or => _mapper.Map<OrderViewModel>(Or)).ToList();
        viewModels = _repository.GetAll().Where(Or => Or.CustomerId == _myCustomer.Id).Select(Or => _mapper.Map<OrderViewModel>(Or)).ToList();

        ListOfOrders.ItemsSource = viewModels;

        //  DataContext = viewModel;
    }

    private void Back_Click(object sender, RoutedEventArgs e)
    {
        CustomerOffice office = new(_mapper, _myCustomer, _unitOfWork);

        WindowHelper.CopyAllProparityAndReplacement(office, this);
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        // Отримати вибраний елемент у ListBox (якщо є вибраний)
        Button button = sender as Button;
        OrderViewModel selectedOrder = new();
        if (button != null)
        {
            // Отримання батьківського елемента (може знадобитися приведення до відповідного типу)
            FrameworkElement parent = button.Parent as FrameworkElement;

            // Отримання контексту елемента списку (якщо кнопка знаходиться в елементі списку ListBox)
            selectedOrder = parent?.DataContext as OrderViewModel;

            
        }

        if (selectedOrder != null)
        {
            // Отримати вашу логіку скасування замовлення та оновлення статусу тут
            if (selectedOrder.OrderStatus == StatusOrder.InQueue)
            {
                selectedOrder.OrderStatus = StatusOrder.Canceled;
                _repository.Update(_mapper.Map<Order>(selectedOrder));
                _repository.Save(); // Змінилося з _repository.Save() на _unitOfWork.Save()

                MessageBox.Show($"Canceled successfully order for GoodName: {selectedOrder.GoodName} {selectedOrder.GoodNumber} {selectedOrder.GoodType} from {selectedOrder.StartReservation} to {selectedOrder.EndReservation}");
            }
            else
            {
                MessageBox.Show($"Sorry, but canceling the order is not possible at the moment - the order has moved from the status \"{selectedOrder.OrderStatus}\"");
            }
        }
        else
        {
            MessageBox.Show("Please select an order to cancel.");
        }
    }

    // Аналогічні зміни для GetManagerCommentButton_Click та GetMyCommentButton_Click



    private void GetManagerCommentButton_Click(object sender, RoutedEventArgs e)
    {
        Button button = sender as Button;
        OrderViewModel selectedOrder = new();
        if (button != null)
        {
            // Отримання батьківського елемента (може знадобитися приведення до відповідного типу)
            FrameworkElement parent = button.Parent as FrameworkElement;

            // Отримання контексту елемента списку (якщо кнопка знаходиться в елементі списку ListBox)
            selectedOrder = parent?.DataContext as OrderViewModel;

            MessageBox.Show($"Managers` comment: {selectedOrder.ManagerComment}");
        }
    }

    private void GetMyCommentButton_Click(object sender, RoutedEventArgs e)
    {
        Button button = sender as Button;
        OrderViewModel selectedOrder = new();
        if (button != null)
        {
            // Отримання батьківського елемента (може знадобитися приведення до відповідного типу)
            FrameworkElement parent = button.Parent as FrameworkElement;

            // Отримання контексту елемента списку (якщо кнопка знаходиться в елементі списку ListBox)
            selectedOrder = parent?.DataContext as OrderViewModel;

            MessageBox.Show($"Your comment: {selectedOrder.CustomerComment}");

        }
    }

    private void CreateOrderButton_Click(object sender, RoutedEventArgs e)
    {
        CreatingOrderWindow creatingWindow = new(_mapper, _myCustomer, _unitOfWork);

        WindowHelper.CopyAllProparityAndReplacement(creatingWindow, this);
    }

    private void UpdatePageButton_Click(object sender, RoutedEventArgs e)
    {
        OrdersWindow ordersWindow =  new(_mapper, _myCustomer, _unitOfWork);
        WindowHelper.CopyAllProparityAndReplacement(ordersWindow, this);
    }
}
