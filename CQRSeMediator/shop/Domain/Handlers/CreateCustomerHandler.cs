using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using shop.Domain.Commands.Requests;
using shop.Domain.Commands.Responses;

namespace shop.Domain.Handlers
{
    public class CreateCustomerHandler : 
            IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {

        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateCustomerResponse {
                    Id = Guid.NewGuid(),
                    Name ="Pedro Lima",
                    Email ="pedro@mail.com",
                    Date = DateTime.Now
            };  
            return Task.FromResult(result);
            throw new NotImplementedException();
        }
    }
}