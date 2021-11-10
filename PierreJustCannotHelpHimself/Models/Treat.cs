using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreJustCannotHelpHimself.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }
    public int TreatId { get; set; }
    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }
    public virtual ICollection<TreatFlavor> JoinEntities { get; set; }
  }
}