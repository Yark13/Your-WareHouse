using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using DataLayer;
using DataLayer.UnitOfWork;
using DataLayer.Repository;
using DataLayer.Entities;
using Your_WareHouse.ViewModels;

namespace Your_WareHouse.Views.NavigationPanel
{
    public partial class FeedBackOrComplainsWindow : Window
    {
        private readonly IMapper _mapper;
        private readonly UnitOfWork _unitOfWork;
        private readonly Repository<FeedbackOrComplains> _repository;
        private readonly Repository<Customer> _repositoryCustomers;
        private Customer _myCustomer;
        private List<FeedbackOrComplainsViewModel> viewModels;

        public FeedBackOrComplainsWindow(IMapper mapper, Customer myCustomer)
        {
            InitializeComponent();

            _mapper = mapper;
            _unitOfWork = new UnitOfWork(new StateDbContext());
            _repository = _unitOfWork.GetRepository<FeedbackOrComplains>();
            _repositoryCustomers = _unitOfWork.GetRepository<Customer>();
            _myCustomer = myCustomer;

            // Retrieve all feedbacks and complaints
            var feedbacksAndComplaints = _repository.GetAll();

            // Initialize the viewModels list
            viewModels = new List<FeedbackOrComplainsViewModel>();

            // Iterate through each feedback or complaint
            foreach (var feedbackOrComplaint in feedbacksAndComplaints)
            {
                // Find the customer for each feedback or complaint
                var customer = _repositoryCustomers.Find(feedbackOrComplaint.CustomerId);

                // Create a view model for the feedback or complaint
                var viewModel = _mapper.Map<FeedbackOrComplainsViewModel>(feedbackOrComplaint);

                // Assign the customer information to the view model
                viewModel.Customer = customer; // Assuming there's a property CustomerName in FeedbackOrComplaintViewModel

                // Add the view model to the list
                viewModels.Add(viewModel);
            }

            // Set the items source of the ListOfFeedbackOrComplaints
            ListOfFeedbackOrComplaints.ItemsSource = viewModels;
        }

        private void BackToOfficeButton_Click(object sender, RoutedEventArgs e)
        {
            CustomerOffice customerOffice = new CustomerOffice(_mapper, _myCustomer); // Assuming CustomerOffice is a valid class.
            // Assuming WindowHelper.CopyAllProparityAndReplacement is a valid method.
            WindowHelper.CopyAllProparityAndReplacement(customerOffice, this);
        }

        private void AddFeedbackButton_Click(object sender, RoutedEventArgs e)
        {
            AddingNewFeedbackOrComplainsWindow addingWindow = new(_mapper, _myCustomer);

            WindowHelper.CopyAllProparityAndReplacement(addingWindow, this);
        }
    }
}
