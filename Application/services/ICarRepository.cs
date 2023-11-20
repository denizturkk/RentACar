using Core.Persistence.Repositories;
using Core.Persistence.Repository;
using Domain.Entities;

namespace Application.services;

public interface ICarRepository : IAsyncRepository<Car, Guid>, IRepository<Car, Guid>
{
}
