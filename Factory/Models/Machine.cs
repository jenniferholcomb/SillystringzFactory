using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage="Machine type must be filled to setup new machine.")]
    public string Type { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}