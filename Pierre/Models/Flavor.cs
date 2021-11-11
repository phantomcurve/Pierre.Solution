using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pierre.Models
{
    public class Flavor
    {
      public Flavor(){
        this.JoinEntities = new HashSet <TreatFlavor> ();
      }
      public int FlavorId { get; set; }

      [StringLength(50)]
      public string Name { get; set; }

      [StringLength(200)]
      public string Description { get; set; }
      public virtual ApplicationUser User { get; set; }

      public virtual ICollection <TreatFlavor> JoinEntities { get; }
  }
}