using AutoMapper;
using MsSqlLib.Application.Common.Mappings;
using MsSqlLib.Domain.Entities;

namespace MsSqlLib.Application.Dto
{
    public class ProductDto : IMapWith<Product>
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Product, ProductDto>();
        }
    }
}
