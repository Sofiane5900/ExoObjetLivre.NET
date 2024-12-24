using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoObjetLivre.NET
{
    internal class Livre
    {
        private string _titre;
        private string _auteur;
        private int _publication;
        private bool _estEmprunter;

        public string Titre { get => _titre;  set => _titre = value; }

        [DefaultValue("inconnu")]
        public string Auteur { get => _auteur; set => _auteur = value; }

        [DefaultValue("inconnu")]
        public int Publication { get => _publication; set => _publication = value; }
        public bool estEmprunter {  get => _estEmprunter; set => _estEmprunter = value;}


        public Livre(string Titre, string Auteur, int Publication, bool estEmprunter)
        {
            _titre = Titre;
            _auteur = Auteur;
            _publication = Publication;
            _estEmprunter = estEmprunter;
        }
        public void Emprunter()
        {
            _estEmprunter = true;
            Console.WriteLine("Disponible.");
        }

        public void Rendre()
        {
            estEmprunter = false;
            Console.WriteLine("Indisponible.");
        }

        //public void AfficherDetails()
        //{
        //    // Opération ternaire pour choisir définir que false ou true = un string conrrespondant
        //    string disponibilite = estEmprunter ? "indisponible" : "disponible";
        //    Console.WriteLine($"Le livre {Titre}, écrit par {Auteur} en {Publication} est {disponibilite}");
        //}
    }
}
