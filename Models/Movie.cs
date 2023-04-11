using System.ComponentModel.DataAnnotations;
namespace ClaseCuatroHerramientas.Models;

public class Movie{
    [Display(Name="Codigo")] [Required]
    public string Code {get; set;}
    [Display(Name="Minutos")] [Required]
    public int Minutes {get; set;}
    [Display(Name="Nombre")] [Required]
    public string Name {get; set;}
    [Display(Name="Categoria")] [Required]
    public string Category {get; set;}
    [Display(Name="Resumen")] [Required]
    public string Review {get; set;}
}