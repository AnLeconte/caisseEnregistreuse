using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Categorie
{
    public int Id { get; set; }

    [Required]
    public string Nom { get; set; }

    public ICollection<Produit> Produits { get; set; }
}
