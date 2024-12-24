using ExoObjetLivre.NET;

Livre harryPoter =  new Livre("Harry Poter", "J.K Rowling", 1997, true);
Livre lesMisérables = new Livre("Les Misérables", "Victor Hugo", 1862, false);
Livre leSeigneurDesAnneaux = new Livre("Le Seigneur des Anneaux", "J.R.R. Tolkien", 1954, true);
List<Livre> livres = new List<Livre>();
AfficherDetails(harryPoter);
AfficherDetails(lesMisérables);
AfficherDetails(leSeigneurDesAnneaux);

void AfficherDetails(Livre livre)
{
    string disponibilite = livre.estEmprunter ? "indisponible" : "disponible";
    Console.WriteLine($"Le livre {livre.Titre}, écrit par {livre.Auteur} en {livre.Publication} est {disponibilite}");

}