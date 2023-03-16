using System;
namespace base_historique
{
	public class Historique 
	{
        /// <summary>
        /// class Historique
        /// </summary>
        public DateTime dateEntree { get; set; }
        public DateTime dateSortie { get; set; }
        public string? emprunteur { get; set; }
        public int retardDeRestitution{ get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="date_entree"></param>
        /// <param name="date_sortie"></param>
        /// <param name="emprunteur"></param>
        /// <param name="retardDeRestitution"></param>
        public Historique(DateTime dateEntree, DateTime dateSortie, string emprunteur, int retardDeRestitution)
        {
            this.dateEntree = dateEntree;
            this.dateSortie = dateSortie;
            this.emprunteur = emprunteur;
            this.retardDeRestitution = retardDeRestitution;
        }

        /// <summary>
        /// Méthode pour afficher l'historique de l'emprunt
        /// </summary>
        public string afficherHistorique()
        {
            string historique = $"Date d'entrée : {dateEntree}\n";
            historique += $"Date de sortie : {dateSortie}\n";
            historique += $"Nom de l'emprunteur : {emprunteur}\n";
            historique += $"Retard de restitution : {retardDeRestitution} jours\n";
            return historique;
        }
    }  
}

