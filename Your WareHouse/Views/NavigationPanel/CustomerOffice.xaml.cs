using AutoMapper;
using DataLayer.Entities;
using DataLayer.UnitOfWork;
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

namespace Your_WareHouse.Views.NavigationPanel
{
    /// <summary>
    /// Interaction logic for CustomerOffice.xaml
    /// </summary>
    public partial class CustomerOffice : Window
    {
        private readonly IMapper _mapper;

        private readonly IUnitOfWork _unitOfWork;

        private Customer _myCustomer;

        public CustomerOffice(IMapper mapper, Customer myCustomer, IUnitOfWork unitOfWork)
        {
            InitializeComponent();

            _myCustomer = myCustomer;

            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        private void ExitAccountButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new(_mapper, _unitOfWork);

            WindowHelper.CopyAllProparityAndReplacement(mainWindow, this);
        }

        private void NewsButton_Click(object sender, RoutedEventArgs e)
        {
            ArticlesWndow articles = new(_mapper, _myCustomer, _unitOfWork);

            WindowHelper.CopyAllProparityAndReplacement(articles, this);
        }

        private void OrdersButton_Click(object sender, RoutedEventArgs e)
        {
            OrdersWindow ordersWindow = new(_mapper, _myCustomer, _unitOfWork);

            WindowHelper.CopyAllProparityAndReplacement(ordersWindow, this);
        }

        private void FeedbackAndComplains_Click(object sender, RoutedEventArgs e)
        {
            FeedBackOrComplainsWindow feedbackAndComplains = new(_mapper, _myCustomer, _unitOfWork);

            WindowHelper.CopyAllProparityAndReplacement(feedbackAndComplains, this);
        }
    }
}
