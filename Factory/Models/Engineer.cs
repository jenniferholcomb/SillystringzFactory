using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage="Name must be added for new Engineer.")]
    [StringLength(60,ErrorMessage="No more than 60 characters")]
    [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Name must only include characters.")]
    [Display(Name="Engineer Name")]
    public string Name { get; set; }
    public string Status { get; set; } = "Idle";
    public List<EngineerMachine> JoinEntities { get; }
  }
}