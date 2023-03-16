using System;
namespace base_auteur
{
    public class Auteur

    {
        /// <summary>
        /// class Auteur
        /// </summary>
        public string nom { get; set; }
        public string prenom { get; set; }
        public string pays { get; set; }
        public List<Auteur> auteurs { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="pays"></param>
        public Auteur(string nom, string prenom, string pays)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.pays = pays;
            this.auteurs = new List<Auteur>();
        }

        /// <summary>
        /// Méthode ajouter un auteur à la liste d'auteurs
        /// </summary>
        public void ajouterAuteur()
        {
            auteurs.Add(new Auteur(nom, prenom, pays));
        }
    }
}

