using ExoObjetLivre.NET;

Livre harryPoter =  new Livre("Harry Potter", "J.K Rowling", 1997, true);
Livre lesMisérables = new Livre("Les Misérables", "Victor Hugo", 1862, false);
Livre leSeigneurDesAnneaux = new Livre("Le Seigneur des Anneaux", "J.R.R. Tolkien", 1954, true);
List<Livre> listeLivres = new List<Livre>();
listeLivres.Add(harryPoter);
listeLivres.Add(lesMisérables);
listeLivres.Add(leSeigneurDesAnneaux);
Livre nouveauLivre;
AjoutLivre();

//while (true)
//{

foreach (Livre l in listeLivres)
{
    AfficherDetails(l);
}

void AjoutLivre()
{
    while (true)
    {
        Console.Write("Veuillez écrire le titre du livre : ");
        string nouveauTitre = Console.ReadLine();
        Console.Write("Veuillez écrire l'auteur du livre : ");
        string nouveauAuteur = Console.ReadLine();
        Console.Write("Veuillez écrire la date de publication du livre : ");
        int nouveauPublication;
        bool successPublication = int.TryParse(Console.ReadLine(), out nouveauPublication);
        if (!successPublication)
        {
            Console.WriteLine("Veuillez écrire une date valide.");
        }
        Console.Write("Voulez vous empruntez ce livre ? : ");
        bool nouveauEmprunter;
        bool sucessEmprunter = bool.TryParse(Console.ReadLine(), out nouveauEmprunter);
        if (!sucessEmprunter)
        {
            Console.WriteLine("Veuillez écrire oui ou non.");
            break;
        } 
        else
        {
            nouveauLivre = new Livre(nouveauTitre, nouveauAuteur, nouveauPublication, nouveauEmprunter);
            string disponibilite = nouveauLivre.estEmprunter ? "indisponible" : "disponible";
            listeLivres.Add(nouveauLivre);
            break;
        }
    }
}
void AfficherDetails(Livre livre)
{
    string disponibilite = livre.estEmprunter ? "indisponible" : "disponible";
    Console.WriteLine($"Le livre {livre.Titre}, écrit par {livre.Auteur} en {livre.Publication} est {disponibilite}");

}

