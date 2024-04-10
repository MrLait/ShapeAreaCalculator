using AutoMapper;
using MsSqlLib.Application.Common.Mappings;
using MsSqlLib.Domain.Entities;
using System.Collections.Generic;

namespace MsSqlLib.Application.Dto
{
    public class CategoryDto : IMapWith<Category>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<ProductDto>? Categories { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Category, CategoryDto>();
        }
    }
}