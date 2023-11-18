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
using DataLayer.UnitOfWork;
using DataLayer.Repository;
using DataLayer.Entities;
using DataLayer;
using Your_WareHouse.ViewModels;

namespace Your_WareHouse.Views.NavigationPanel;

/// <summary>
/// Interaction logic for Articles.xaml
/// </summary>
public partial class ArticlesWndow : Window
{
    private readonly IMapper _mapper;

    private readonly IUnitOfWork _unitOfWork;

    private readonly Repository<Article> _repository;

    private List<ArticleViewModel> viewModels;

    private Customer _myCustomer;


    public ArticlesWndow(IMapper mapper, Customer myCustomer, IUnitOfWork unitOfWork)
    {
        InitializeComponent();

        _mapper = mapper;
        
        _unitOfWork = unitOfWork;

        _repository = _unitOfWork.GetRepository<Article>();

        viewModels = _repository.GetAll().Select(el => _mapper.Map<ArticleViewModel>(el)).ToList();

        _myCustomer = myCustomer;

        ListOfArticles.ItemsSource = viewModels;
        
    }

    private void BackToOfficeButtom_Click(object sender, RoutedEventArgs e)
    {
        CustomerOffice customerOffice = new(_mapper, _myCustomer, _unitOfWork);

        WindowHelper.CopyAllProparityAndReplacement(customerOffice, this);
    }
}
