using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPizza.Models;

[Table("PIZZA")]
public class Pizza
{
    [Column("ID")]
    public int Id{get;set;}
    [Column("NAME_PIZZA")]
    public string? Name{get;set;}

}