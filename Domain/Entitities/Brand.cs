using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Core.Persistence.Repository;



namespace Domain.Entitities;

public class Brand : Entity<Guid>
{
    public string Name { get; set; }
   

    public Brand()
    {
            
    }
    public Brand(Guid id ,string name)
    {
        Id = id;
        Name = name;
    }

}
