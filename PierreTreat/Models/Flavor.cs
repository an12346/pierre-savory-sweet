using System.Collections.Generic;

namespace PierreTreat.Models
{
  public class Flavor 
  {
    public Flavor()
    {
      this.JoinEntitites = new HashSet<TreatFlavor>();
    }

    public int FLavorId { get; set; }
    public int Type { get; set; }

    public virtual ICollection<TreatFlavor> JoinEntities { get; set; }
  }
}