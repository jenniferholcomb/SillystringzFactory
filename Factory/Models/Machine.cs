using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

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

    public string Status { get; set; } = "Operational";

    [DataType(DataType.Date)] 
    [Required(ErrorMessage="Please enter a valid date.")] 
    [Range(typeof(DateTime), "1/1/2000", "1/1/2024", ErrorMessage = "Please enter a valid date.")]  
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name="Last Serviced")]
    public DateTime Service { get; set; }
    
    public List<EngineerMachine> JoinEntities { get; }
  }
}