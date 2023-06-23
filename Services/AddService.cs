using DAL;
using Domain;
using Services.Interfaces;

namespace Services
{
    public class AddService : IAddService
    {
        private readonly ApplicationContext _applicationContext;

        public AddService(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public async Task<double> AddAsync(AddDTO model, CancellationToken cancellationToken)
        {
            var entity = new Add
            {
                Num1 = model.Num1,
                Num2 = model.Num2,
                Sum = model.Num2 + model.Num1
            };

            await _applicationContext.Adds.AddAsync(entity, cancellationToken);
            await _applicationContext.SaveChangesAsync(cancellationToken);

            return entity.Sum;
        }
    }
}
