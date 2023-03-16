using System;
using base_emprunteur;

namespace base_emprunt
{
    /// <summary>
    /// class Emprunt
    /// </summary>
	public class Emprunt 
	{
        public DateTime dateEmprunt { get; set; }
        public DateTime dateRetourEmprunt { get; set; }
        public DateTime dateRetourEffectif { get; set; }
        public Emprunteur emprunteur { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="dateEmprunt"></param>
        /// <param name="date_retour_emprunt"></param>
        /// <param name="emprunteur"></param>
        public Emprunt(DateTime dateEmprunt, DateTime dateRetourEmprunt,DateTime dateRetourEffectif, Emprunteur emprunteur)
        {
            this.dateEmprunt = dateEmprunt;
            this.dateRetourEmprunt = dateRetourEmprunt;
            this.dateRetourEffectif = dateRetourEffectif;
            this.emprunteur = emprunteur;
        }

        /// <summary>
        /// Méthode pour afficher caractéristiques de l'emprunteur
        /// </summary>
        public string consulterEmprunteur() 
        {
        return $"Nom de l'emprunteur : {emprunteur.nom}";
    }

        /// <summary>
        /// Méthode pour vérifier si l'emprunt est restitué en retard
        /// </summary>
        /// <returns></returns>
        public bool restituerEnRetard()
        {
            if (dateRetourEffectif > dateRetourEmprunt)
            {
                TimeSpan differenceDate = dateRetourEffectif.Subtract(dateRetourEmprunt);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Méthode pour enregistrer la date de restitution effective
        /// enregistre la date de restitution entrée
        /// </summary>
        public void enregistrerDateRetourEffectif()
        {
            DateTime date = DateTime.MinValue;
            
            bool dateValide = false;
            while (!dateValide)
            {
                string? input = Console.ReadLine();
                if (DateTime.TryParse(input, out date))
                {
                    dateValide = true;
                }
                else
                {
                    Console.WriteLine("Date invalide. Veuillez entrer une date au format valide.");
                }
            }
            dateRetourEffectif = date;
        }
    }
}

