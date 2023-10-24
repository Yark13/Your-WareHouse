using AutoMapper;
using DataLayer.Entities;
using Your_WareHouse.ViewModels;

namespace Your_WareHouse;

public class AppMappingProfile : Profile
{
    public AppMappingProfile()
    {
        CreateMap<ManagerViewModel, Manager>().ReverseMap();

        CreateMap<Customer, CustomerViewModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
            .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.PasswordHash));

        CreateMap<CustomerViewModel, Customer>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
            .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.Password));

        CreateMap<ArticleViewModel, Article>().ReverseMap();
        CreateMap<OrderViewModel, Order>().ReverseMap();
        CreateMap<FeedbackOrComplainsViewModel, FeedbackOrComplains>().ReverseMap();

        CreateMap<Human, Customer>().ReverseMap();
        CreateMap<Human, Manager>().ReverseMap();
    }
}
