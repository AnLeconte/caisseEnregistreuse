using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Produit
{
    public int Id { get; set; }

    [Required]
    public string Nom { get; set; }

    public string Description { get; set; }

    [Range(0, double.MaxValue)]
    public decimal Prix { get; set; }

    [Range(0, int.MaxValue)]
    public int QuantiteEnStock { get; set; }

    public string ImageUrl { get; set; }

    [ForeignKey("Categorie")]
    public int CategorieId { get; set; }
    public Categorie Categorie { get; set; }
}
