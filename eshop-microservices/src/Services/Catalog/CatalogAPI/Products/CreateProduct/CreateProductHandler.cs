using BuildingBlocks.CQRS;
using CatalogAPI.Models;
using MediatR;

namespace CatalogAPI.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
        :ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {

        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            // logic create product entity command object

            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImaegeFile = command.ImageFile,
                Price = command.Price
            };

            // save to db (skip dulu, langsung result)

            // return CreateProductResult result
            return new CreateProductResult(Guid.NewGuid());
        }
    }
}
