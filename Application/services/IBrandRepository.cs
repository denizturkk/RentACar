using Core.Persistence.Repositories;
using Core.Persistence.Repository;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.services;

public interface IBrandRepository : IAsyncRepository<Brand, Guid>, IRepository<Brand,Guid>
{
}
