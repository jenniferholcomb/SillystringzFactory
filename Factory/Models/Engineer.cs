using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage="Name must be added for new Engineer.")]
    [Range]
    public string Name { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}