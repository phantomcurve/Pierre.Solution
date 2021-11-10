using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreJustCannotHelpHimself.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }
    
    public virtual ICollection<TreatFlavor> JoinEntities { get; }
  }
}