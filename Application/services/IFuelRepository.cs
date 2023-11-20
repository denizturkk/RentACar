using Core.Persistence.Repositories;
using Core.Persistence.Repository;
using Domain.Entities;

namespace Application.services;

public interface IFuelRepository : IAsyncRepository<Fuel, Guid>, IRepository<Fuel, Guid>
{
}
