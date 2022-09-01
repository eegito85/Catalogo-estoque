using CleanArchMvc.Application.Products.Queries;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Products.Handlers
{
    public class GetProductCategoryByIdQueryHandler : IRequestHandler<GetProductCategoryByIdQuery, Product>
    {
        private IProductRepository _productRepository;

        public GetProductCategoryByIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Handle(GetProductCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductCategoryAsync(request.Id);
        }
    }
}
