using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage="Machine type must be filled to setup new machine.")]
    [StringLength(60,ErrorMessage="No more than 60 characters")]
    [RegularExpression(@"^[a-zA-Z].*$", ErrorMessage = "Type must start with character.")]
    [Display(Name="Machine Type")]
    public string Type { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}