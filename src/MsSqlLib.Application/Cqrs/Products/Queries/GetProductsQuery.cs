using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MsSqlLib.Application.Common.Interfaces;
using MsSqlLib.Application.Common.Models;
using MsSqlLib.Application.Dto;
using MsSqlLib.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MsSqlLib.Application.Cqrs.Products.Queries
{
    public sealed record GetProductsQuery() : IRequest<ServiceResult<List<ProductDto>>>
    {
    }

    public class GetBooksQueryHandler : IRequestHandler<GetProductsQuery, ServiceResult<List<ProductDto>>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetBooksQueryHandler(IApplicationDbContext context, IMapper mapper) => 
            (_context, _mapper) = (context, mapper);

        public async Task<ServiceResult<List<ProductDto>>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var query = await _context.Products
                .FromSql($@"Select * From Products")
                .Include(x => x.Categories)
                .ProjectTo<ProductDto>(_mapper.ConfigurationProvider)
                .ToListAsync();

            //var testt = this.Categories.FromSql(
            //@$"
            //    SELECT 
            //        Categories.id, 
            //        Categories.Name,
            //    FROM Categories
            //    LEFT JOIN CategoryProducts 
            //        ON CategoryProducts.CategoryId = Categories.id
            //    LEFT JOIN Products 
            //        ON Products.Id = CategoryProducts.ProductId
            //    ").Include(p => p.Products);


            return query.Any() ? ServiceResult.Success(query) : ServiceResult.Failed(query, ServiceError.NotFound);
        }
    }

}
