using System.Collections.Generic;

namespace PierreTreat.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }

    public int TreatId { get; set; }
    public string TreatType { get; set; }

    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<TreatFlavor> JoinEntites { get; set; }
  }
}