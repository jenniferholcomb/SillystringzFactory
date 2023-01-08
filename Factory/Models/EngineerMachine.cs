using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class EngineerMachine
  {
    public int EngineerMachineId { get; set; }
    public int EngineerId { get; set; }
    public Engineer Engineer { get; set; }
    public int MachineId { get; set; }
    public Machine Machine { get; set; }
    [DataType(DataType.Date)] 
    [Required(ErrorMessage="Please enter a valid date.")] 
    [Range(typeof(DateTime), "1/1/2000", "1/1/2024", ErrorMessage = "Please enter a valid date.")]  
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name="License Renewal")]
    public DateTime? License { get; set; }
  }
}