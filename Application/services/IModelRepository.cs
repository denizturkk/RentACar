using Core.Persistence.Repositories;
using Core.Persistence.Repository;
using Domain.Entities;

namespace Application.services;

public interface IModelRepository : IAsyncRepository<Model, Guid>, IRepository<Model, Guid>
{
}
