using Microsoft.AspNetCore.Mvc;

public class PanierController : Controller
{
    public IActionResult Index()
    {
        var panier = HttpContext.Session.ObtenirDuPanier<List<Produit>>("Panier") ?? new List<Produit>();
        return View(panier);
    }

    public IActionResult Ajouter(int id)
    {
        var db = HttpContext.RequestServices.GetService<ApplicationDbContext>();
        var produit = db.Produits.Find(id);

        var panier = HttpContext.Session.ObtenirDuPanier<List<Produit>>("Panier") ?? new List<Produit>();
        panier.Add(produit);

        HttpContext.Session.AjouterAuPanier("Panier", panier);
        return RedirectToAction("Index");
    }

    public IActionResult Vider()
    {
        HttpContext.Session.Remove("Panier");
        return RedirectToAction("Index");
    }
}

