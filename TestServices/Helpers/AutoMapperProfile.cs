using AutoMapper;
using System;
using TestDAL.Models;
using TestServices.DTO;
using TestServices.Enums;
//using TestDAL.Models;

namespace TestServices.Helpers
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			int counter = 1;
			CreateMap<BookDTO, ProductsDTO>()
				.ForMember(src => src.ProductId, opt => opt.MapFrom(dest => dest.Id))
				.ForMember(src => src.ProductType, opt => opt.MapFrom(dest => Enum.GetName(typeof(ProductTypeEnum), ProductTypeEnum.Books)))
				.AfterMap((src, dest) =>
				{
					dest.Id = counter++;
				});
			CreateMap<Books, BookDTO>()
				.ForMember(src => src.BookType, opt => opt.MapFrom(dest => dest.BookType.BookTypeName));
            CreateMap<BookDTO, Books>();
			CreateMap<DiscDTO, Discs>();
			CreateMap<DiscDTO, ProductsDTO>()
				.ForMember(src => src.ProductId, opt => opt.MapFrom(dest => dest.Id))
				.ForMember(src => src.ProductType, opt => opt.MapFrom(dest => Enum.GetName(typeof(ProductTypeEnum), ProductTypeEnum.Discs)))
				.AfterMap((src, dest) =>
				{
					dest.Id = counter++;
				}); ;
			CreateMap<Discs, DiscDTO>()
				.ForMember(src => src.DiscContent, opt => opt.MapFrom(dest => dest.DiscContent.DiscContentName))
				.ForMember(src => src.DiscType, opt => opt.MapFrom(dest => dest.DiscType.DiscTypeName));
		}
    }
}
