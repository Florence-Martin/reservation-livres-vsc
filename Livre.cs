using System;

namespace base_livre
{

    public class Livre
    {
        /// <summary>
        /// Class Livre
        /// </summary>
        public string titre { get; set; }
        public string isbn { get; set; }
        public string description { get; set; }
        public DateTime dateParution { get; set; }
        private List<Livre> exemplaires;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="titre"></param>
        /// <param name="isbn"></param>
        /// <param name="description"></param>
        /// <param name="dateParution"></param>
        /// <param name="auteur"></param>
        /// <param name="quantite"></param>
        public Livre(string titre, string isbn, string description, DateTime dateParution, int quantite)
        {
            this.titre = titre;
            this.isbn = isbn;
            this.description = description;
            this.dateParution = dateParution;
            exemplaires = new List<Livre>();
            for (int i = 0; i < quantite; i++)
            {
                exemplaires.Add(this);
            }
        }

        /// <summary>
        /// Métodes Ajouter un/des exemplaire(s) du même livre
        /// </summary>
        /// <param name="quantite"></param>
        public void AjouterExemplaires(int quantite)
        {
            Console.WriteLine($"Ajout de {quantite} exemplaire(s) du livre {titre}");

            for (int i = 0; i < quantite; i++)
            {
                exemplaires.Add(this);
            }
        }


        /// <summary>
        /// Méthode Retirer un exemplaire 1 à 1
        /// </summary>
        /// <param name="quantite"></param>
        public void RetirerExemplaires(int quantite)
        {
            if (quantite <= 0)
            {
                throw new ArgumentException("La quantité d'exemplaires doit être supérieure à zéro.");
            }

            if (exemplaires.Count > 0)
            {
                exemplaires.RemoveAt(0);
            }
        }

        /// <summary>
        /// Méthode afficher caractéristique du livre
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Titre : {titre}\n" +
                   $"ISBN : {isbn}\n" +
                   $"Description : {description}\n" +
                   $"Date de parution : {dateParution}\n" +
                   $"Nombre d'exemplaires : {exemplaires.Count}";
        }
    }
}