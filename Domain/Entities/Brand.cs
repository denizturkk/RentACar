using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Core.Persistence.Repository;



namespace Domain.Entities;

public class Brand : Entity<Guid>
{
    public string Name { get; set; }

    public virtual ICollection<Model> Models { get; set; }

    public Brand()
    {
                Models=new HashSet<Model>();
    }
    public Brand(Guid id ,string name):this()
    {
        Id = id;
        Name = name;
    }

}
