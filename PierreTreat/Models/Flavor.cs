using System.Collections.Generic;

namespace PierreTreat.Models
{
  public class Flavor 
  {
    public Flavor()
    {
      this.JoinEntitites = new HashSet<TreatFlavor>();
    }

    public int FlavorId { get; set; }
    public int FlavorType { get; set; }

    public virtual ICollection<TreatFlavor> JoinEntities { get; set; }
  }
}