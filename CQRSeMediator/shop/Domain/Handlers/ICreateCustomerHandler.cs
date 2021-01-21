using shop.Domain.Commands.Requests;
using shop.Domain.Commands.Responses;

namespace shop.Domain.Handlers
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle (CreateCustomerRequest request);
    }
}