using Core.Persistence.Repository;

namespace Domain.Entitities;

public class Transmission : Entity<Guid>
{
    public string Name { get; set; }

    public virtual ICollection<Transmission> Transmissions { get; set; }

    public Transmission()
    {
        Transmissions = new HashSet<Transmission>();
    }
    public Transmission(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

}

