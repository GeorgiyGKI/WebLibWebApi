using AutoMapper;
using Shared.DataTransferObject;
using WebLibMVC.ViewModels;

namespace WebLibMVC.Mapping
{
    public  class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AuthorViewModel, AuthorDto>().ReverseMap();
            CreateMap<BookViewModel, BookDto>().ReverseMap();
            CreateMap<GenreViewModel, GenreDto>().ReverseMap();
            CreateMap<ReaderViewModel, ReaderDto>().ReverseMap();
            CreateMap<TransactionViewModel, TransactionDto>().ReverseMap();
            CreateMap<TransactionStatusViewModel, TransactionStatusDto>().ReverseMap();
            CreateMap<AuthorizeViewModel, AuthorizeDto>().ReverseMap();

            CreateMap<BookViewModel, BookDto>();

            CreateMap<BookDto, BookViewModel>()
                     .ForMember(dest => dest.Image, opt => opt.MapFrom(src => MappingMethods.ConvertBytesToFormFile(src.ImageData)));
        }
    }
}
