using CleanArchMvc.Domain.Entities;
using MediatR;

namespace CleanArchMvc.Application.Products.Queries
{
    public class GetProductCategoryByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }
        public GetProductCategoryByIdQuery(int id)
        {
            Id = id;
        }
    }
}
