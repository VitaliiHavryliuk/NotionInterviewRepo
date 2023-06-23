using Domain;
using Services.Interfaces;

namespace Services
{
    public class AddService : IAddService
    {
        public Task<double> AddAsync(AddDTO model, CancellationToken cancellationToken)
        {
            return Task.FromResult(model.Num1 + model.Num2);
        }
    }
}
