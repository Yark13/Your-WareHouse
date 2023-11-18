using AutoMapper;
using DataLayer;
using DataLayer.Entities;
using DataLayer.Repository;
using DataLayer.UnitOfWork;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Your_WareHouse.ViewModels;
using Your_WareHouse.Views.NavigationPanel;


namespace Your_WareHouse.Views.Logging
{
    /// <summary>
    /// Interaction logic for CustomerEntrance.xaml
    /// </summary>
    public partial class CustomerLogging : Window
    {
        private readonly IMapper _mapper;

        private readonly IUnitOfWork _unitOfWork;

        private readonly Repository<Customer> _repository;

        private CustomerViewModel viewModel;

        public CustomerLogging(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;

            viewModel = new();
            
            _unitOfWork = unitOfWork;

            _repository = _unitOfWork.GetRepository<Customer>();

            InitializeComponent();

            this.DataContext = viewModel;
            
        }

        private void BackToStart_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new(_mapper, _unitOfWork);

            WindowHelper.CopyAllProparityAndReplacement(mainWindow, this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SignUpCustomer signUp = new(_mapper, _unitOfWork);

            WindowHelper.CopyAllProparityAndReplacement(signUp, this);
        }

        private void Logging_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Password = new MyCoder().ComputeSHA256Hash(PasswordBox.Password.Trim());
            if (string.IsNullOrEmpty(viewModel.Login) || string.IsNullOrEmpty(PasswordBox.Password))
            {
                MessageBox.Show("Please enter both login and password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!_repository.EntityExists(viewModel.Login) || _repository.Find(viewModel.Login).PasswordHash != viewModel.Password)
            {
                MessageBox.Show("Invalid login or password. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            CustomerOffice office = new(_mapper, _mapper.Map<Customer>(_repository.Find(viewModel.Login)), _unitOfWork);

            WindowHelper.CopyAllProparityAndReplacement(office, this);
        }
    }
}
