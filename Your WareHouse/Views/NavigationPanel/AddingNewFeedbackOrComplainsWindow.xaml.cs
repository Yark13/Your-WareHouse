using AutoMapper;
using DataLayer;
using DataLayer.Entities;
using DataLayer.UnitOfWork;
using DataLayer.Repository;
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
using Your_WareHouse.ViewModels;

namespace Your_WareHouse.Views.NavigationPanel
{
    /// <summary>
    /// Interaction logic for AddingNewFeedbackOrComplainsxaml.xaml
    /// </summary>
    public partial class AddingNewFeedbackOrComplainsWindow : Window
    {
        private readonly IMapper _mapper;
        private Customer _customer;
        private readonly UnitOfWork _unitOfWork;
        private readonly Repository<FeedbackOrComplains> _repository;
        private FeedbackOrComplainsViewModel viewModel;

        public AddingNewFeedbackOrComplainsWindow(IMapper mapper, Customer myCustomer)
        {
            InitializeComponent();
            _mapper = mapper;
            _customer = myCustomer;
            _unitOfWork = new UnitOfWork(new StateDbContext());
            _repository = _unitOfWork.GetRepository<FeedbackOrComplains>();

            viewModel = new();

            DataContext = viewModel;
        }

        private void ToBack_Click(object sender, RoutedEventArgs e)
        {
            FeedBackOrComplainsWindow feedBackWindow = new(_mapper, _customer);

            WindowHelper.CopyAllProparityAndReplacement(feedBackWindow, this);
        }

        private void CreateFeedbake_Click(object sender, RoutedEventArgs e)
        {
            if( string.IsNullOrEmpty(viewModel.Title) || string.IsNullOrEmpty(viewModel.Content))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            viewModel.CustomerId = _customer.Id;
            viewModel.DatePublication = DateTime.Now;

            _repository.Insert(_mapper.Map<FeedbackOrComplains>(viewModel));
            _repository.Save();

            FeedBackOrComplainsWindow feedBackWindow = new(_mapper, _customer);

            WindowHelper.CopyAllProparityAndReplacement(feedBackWindow, this);
        }
    }
}
