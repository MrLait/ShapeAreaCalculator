using AutoMapper;
using MsSqlLib.Application.Common.Mappings;
using MsSqlLib.Application.Dto.Vm;
using MsSqlLib.Domain.Entities;
using System.Collections.Generic;

namespace MsSqlLib.Application.Dto
{
    public class ProductDto : IMapWith<Product>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<CategoryVm>? Categories { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Product, ProductDto>();
        }
    }
}
