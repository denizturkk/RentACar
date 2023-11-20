using Core.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitities;

public class Model:Entity<Guid>
{


    public Guid BrandId { get; set; }
    public Guid FuelId { get; set; }
    public Guid TransmissionId { get; set; }
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    public string ImageUrl { get; set; }

    
    public virtual Brand? Brand { get; set; }
    public virtual Fuel? Fuel { get; set; }
    public virtual Transmission? Transmission { get; set; }
    public virtual ICollection<Car>? Cars { get; set; }

    public Model()
    {
        Cars = new HashSet<Car>();
    }
    public Model(Guid id,Guid brandId,Guid fuelId,Guid transmisionId,string name,decimal dailPrice,string imageUrl):this()
    {
        Id= id;
        BrandId= brandId;
        FuelId= fuelId; 
        TransmissionId= transmisionId;
        Name= name;
        DailyPrice= dailPrice;
        ImageUrl= imageUrl;

    }
}

