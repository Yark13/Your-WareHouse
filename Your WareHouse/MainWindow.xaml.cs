using AutoMapper;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Your_WareHouse.Views.Logging;

namespace Your_WareHouse;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly IMapper _mapper;

    private readonly IUnitOfWork _unitOfWork;

    public MainWindow(IMapper mapper, IUnitOfWork unitOfWork)
    {
        InitializeComponent();

        WindowHelper.SetDefaultWindowBackground(this);

        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    private void Manager_Click(object sender, RoutedEventArgs e)
    {
        ManagerLogging managerLogging = new(_mapper, _unitOfWork);

        WindowHelper.CopyAllProparityAndReplacement(managerLogging, this);
    }

    private void Customer_Click(object sender, RoutedEventArgs e)
    {
        CustomerLogging customerLogging = new(_mapper, _unitOfWork);

        WindowHelper.CopyAllProparityAndReplacement(customerLogging, this);
    }

    private void Exit_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }
}
