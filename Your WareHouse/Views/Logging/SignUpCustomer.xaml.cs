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
using DataLayer.UnitOfWork;
using DataLayer.Repository;
using DataLayer.Entities;
using DataLayer;
using AutoMapper;
using Your_WareHouse;
using Your_WareHouse.Views.NavigationPanel;

namespace Your_WareHouse.Views.Logging;

/// <summary>
/// Interaction logic for SignUpCustomer.xaml
/// </summary>
public partial class SignUpCustomer : Window
{
    private CustomerViewModel viewModel;

    private readonly IUnitOfWork _unitOfWork;

    private Repository<Customer> _repository;

    private readonly IMapper _mapper;

    public SignUpCustomer(IMapper mapper, IUnitOfWork unitOfWork)
    {
        InitializeComponent();

        _unitOfWork = unitOfWork;

        _repository = _unitOfWork.GetRepository<Customer>();

        _mapper = mapper;

        viewModel = new();

        this.DataContext = viewModel;
    }

    private void BackToStart_Click(object sender, RoutedEventArgs e)
    {
        CustomerLogging customerLogging = new(_mapper, _unitOfWork);

        WindowHelper.CopySizeAndLocationAndBackground(customerLogging, this);

        customerLogging.Show();

        this.Close();
    }

    private void SugningUp_Click(object sender, RoutedEventArgs e)
    {
        if (PasswordNameBox.Password.Trim() != AgainPasswordNameBox.Password.Trim())
        {
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }
        viewModel.Password = new MyCoder().ComputeSHA256Hash(PasswordNameBox.Password.Trim());
        viewModel.RepeatedPassword = new MyCoder().ComputeSHA256Hash(PasswordNameBox.Password.Trim());

        if (string.IsNullOrEmpty(viewModel.LastName) || string.IsNullOrEmpty(viewModel.FirstName) ||
        string.IsNullOrEmpty(viewModel.Login) || string.IsNullOrEmpty(PasswordNameBox.Password) ||
        string.IsNullOrEmpty(AgainPasswordNameBox.Password))
        {
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        if (_repository.EntityExists(viewModel.Login))
        {
            MessageBox.Show("A user with this login already exists.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        _repository.Insert(_mapper.Map<Customer>(viewModel));
        _repository.Save();

        MessageBox.Show("You registered successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

        CustomerOffice office = new(_mapper, _mapper.Map<Customer>(viewModel), _unitOfWork);

        WindowHelper.CopyAllProparityAndReplacement(office, this);
    }
}
