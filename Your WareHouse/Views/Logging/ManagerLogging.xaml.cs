using AutoMapper;
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
using DataLayer;
using DataLayer.Entities;
using DataLayer.UnitOfWork;
using DataLayer.Repository;
using Your_WareHouse.ViewModels;

namespace Your_WareHouse.Views.Logging
{
    /// <summary>
    /// Interaction logic for ManagerEntrance.xaml
    /// </summary>
    public partial class ManagerLogging : Window
    {
        private readonly IMapper _mapper;

        private readonly IUnitOfWork _unitOfWork;

        private readonly Repository<Manager> _repository;

        private ManagerViewModel viewModel;

        public ManagerLogging(IMapper mapper, IUnitOfWork unitOfWork)
        {
            InitializeComponent();

            _mapper = mapper;

            _unitOfWork = unitOfWork;

            _repository = unitOfWork.GetRepository<Manager>();

            viewModel = new();

            this.DataContext = viewModel;
        }

        private void BackToStart_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new(_mapper, _unitOfWork);

            WindowHelper.CopyAllProparityAndReplacement(mainWindow, this);
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

            MessageBox.Show("Authentication successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            MainWindow mainWindow = new(_mapper, _unitOfWork);

            WindowHelper.CopyAllProparityAndReplacement(mainWindow, this);
        }
    }
}
