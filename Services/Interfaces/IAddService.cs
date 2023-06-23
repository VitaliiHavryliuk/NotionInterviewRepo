using Domain;

namespace Services.Interfaces
{
    public interface IAddService
    {
        Task<double> AddAsync(AddDTO model, CancellationToken cancellationToken);
    }
}