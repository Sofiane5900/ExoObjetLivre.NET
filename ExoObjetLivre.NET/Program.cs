using ExoObjetLivre.NET;

Livre harryPoter =  new Livre("Harry Poter", "J.K Rowling", 1997, true);
Livre lesMisérables = new Livre("Les Misérables", "Victor Hugo", 1862, false);
Livre leSeigneurDesAnneaux = new Livre("Le Seigneur des Anneaux", "J.R.R. Tolkien", 1954, true);
List<Livre> listeLivres = new List<Livre>();
listeLivres.Add(harryPoter);
listeLivres.Add(lesMisérables);
listeLivres.Add(leSeigneurDesAnneaux);

foreach (Livre l in listeLivres)
{
    AfficherDetails(l);
}


//AfficherDetails(lesMisérables);
//AfficherDetails(leSeigneurDesAnneaux);

void AfficherDetails(Livre livre)
{
    string disponibilite = livre.estEmprunter ? "indisponible" : "disponible";
    Console.WriteLine($"Le livre {livre.Titre}, écrit par {livre.Auteur} en {livre.Publication} est {disponibilite}");

}