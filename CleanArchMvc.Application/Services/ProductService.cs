﻿using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Application.Products.Commands;
using CleanArchMvc.Application.Products.Queries;
using MediatR;

namespace CleanArchMvc.Application.Services
{
    public class ProductService : IProductService
    {
        private IMapper _mapper;
        private IMediator _mediator;
        //private IProductRepository _productRepository;

        public ProductService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task Add(ProductDTO productDTO)
        {
            var productCreateCommand = _mapper.Map<ProductCreateCommand>(productDTO);
            await _mediator.Send(productCreateCommand);
        }

        public async Task<ProductDTO> GetById(int? id)
        {
            var productByIdQuery = new GetProductByIdQuery(id.Value);
            
            if (productByIdQuery == null) throw new Exception($"Nenhum produto foi encontrado");

            var result = await _mediator.Send(productByIdQuery);
            
            return _mapper.Map<ProductDTO>(result);
        }

        public async Task<ProductDTO> GetProductCategory(int? id)
        {
            var productCategoryByIdQuery = new GetProductCategoryByIdQuery(id.Value);

            if (productCategoryByIdQuery == null) throw new Exception($"Nenhum produto foi encontrado");

            var result = await _mediator.Send(productCategoryByIdQuery);

            return _mapper.Map<ProductDTO>(result);
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productsQuery = new GetProductsQuery();

            if (productsQuery == null) throw new Exception($"Não foram encontrados produtos");

            var result = _mediator.Send(productsQuery);

            return _mapper.Map<IEnumerable<ProductDTO>>(result);
        }

        public async Task Remove(ProductDTO productDTO)
        {
            var productRemoveCommand = new ProductRemoveCommand(productDTO.Id);
            if (productRemoveCommand == null) throw new Exception($"Produto não encontrado");
            await _mediator.Send(productRemoveCommand);
        }

        public async Task Update(ProductDTO productDTO)
        {
            var productUpdateCommand = _mapper.Map<ProductUpdateCommand>(productDTO);
            await _mediator.Send(productUpdateCommand);
        }
    }
}
