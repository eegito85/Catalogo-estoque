using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Validation;
using FluentAssertions;
using System;
using Xunit;

namespace CleanArchMvc.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact(DisplayName = "Create Product With Valid Parameters")]
        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(1, "mousepad", "mousepad description", 14.00m, 45, "mousepad.jpeg");
            action.Should()
                .NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Invalid Id")]
        public void CreateProduct_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Product(-1, "mousepad", "mousepad description", 14.00m, 45, "mousepad.jpeg");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Invalid Id value");
        }

        [Fact(DisplayName = "Create Product With Short Name")]
        public void CreateProduct_WithShortName_DomainExceptionInvalidName()
        {
            Action action = () => new Product(1, "mo", "mousepad description", 14.00m, 45, "mousepad.jpeg");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Name is too short. Minimum 3 charecters");
        }

        [Fact(DisplayName = "Create Product With Missing Name")]
        public void CreateProduct_WithMissingName_DomainExceptionInvalidName()
        {
            Action action = () => new Product(1, "", "mousepad description", 14.00m, 45, "mousepad.jpeg");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Invalid name. Name is required");
        }

        [Fact(DisplayName = "Create Product With Null Name")]
        public void CreateProduct_WithNullName_DomainExceptionInvalidName()
        {
            Action action = () => new Product(1, null, "mousepad description", 14.00m, 45, "mousepad.jpeg");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Invalid name. Name is required");
        }

        [Fact(DisplayName = "Create Product With Short Description")]
        public void CreateProduct_WithShortDescription_DomainExceptionInvalidDescription()
        {
            Action action = () => new Product(1, "mousepad", "mous", 14.00m, 45, "mousepad.jpeg");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Description is too short. Minimum 5 charecters");
        }

        [Fact(DisplayName = "Create Product With Missing Description")]
        public void CreateProduct_WithMissingDescription_DomainExceptionInvalidDescription()
        {
            Action action = () => new Product(1, "mousepad", "", 14.00m, 45, "mousepad.jpeg");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Invalid description. Description is required");
        }

        [Fact(DisplayName = "Create Product With Null Description")]
        public void CreateProduct_WithNullDescription_DomainExceptionInvalidDescription()
        {
            Action action = () => new Product(1, "mousepad", null, 14.00m, 45, "mousepad.jpeg");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Invalid description. Description is required");
        }

        [Fact(DisplayName = "Create Product With Invalid Price")]
        public void CreateProduct_WithNegativePrice_DomainExceptionInvalidPrice()
        {
            Action action = () => new Product(1, "mousepad", "mousepad", -14.00m, 45, "mousepad.jpeg");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Invalid price value");
        }

        [Fact(DisplayName = "Create Product With Invalid Stock")]
        public void CreateProduct_WithNegativeStock_DomainExceptionInvalidStock()
        {
            Action action = () => new Product(1, "mousepad", "mousepad", 14.00m, -45, "mousepad.jpeg");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Invalid stock value");
        }

        [Fact(DisplayName = "Create Product With Long Url Image")]
        public void CreateProduct_WithLongUrlImage_DomainExceptionInvalidUrlImage()
        {
            Action action = () => new Product(1, "mousepad", "mousepad", 14.00m, 45, "tooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooolooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooog!!!!!!!");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Image url is too long");
        }

        [Fact(DisplayName = "Create Product With Null Url Image")]
        public void CreateProduct_WithNullUrlImage_NoNullReferenceException()
        {
            Action action = () => new Product(1, "mousepad", "mousepad", 14.00m, 45, null);
            action.Should()
                .NotThrow<NullReferenceException>();
        }

    }
}
