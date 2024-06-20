using System.ComponentModel.DataAnnotations;

namespace SpringPI.Models;

public class Furniture
{
    public int Id { get; set; }
    public string? Room { get; set; }
    public string? Type { get; set; }
    public string? Brand { get; set; }

    public string? Colour { get; set; }
    public decimal Price { get; set; }
}