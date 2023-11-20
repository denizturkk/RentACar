using Core.Persistence.Repositories;
using Core.Persistence.Repository;
using Domain.Entities;

namespace Application.services;

public interface ITransmissionRepository : IAsyncRepository<Transmission, Guid>, IRepository<Transmission, Guid>
{
}
