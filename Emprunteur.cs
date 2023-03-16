using System;
using base_emprunt;

namespace base_emprunteur
{
	/// <summary>
	/// Class Emprunteur avec 3 attributs
	/// </summary>
	public class Emprunteur
	{
			public string prenom { get; set; }
			public string nom { get; set; }
			public DateTime dateDeNaissance { get; set; }
			public Emprunt emprunt { get; set; }

		/// <summary>
		/// Constructeur
		/// </summary>
		/// <param name="prenom"></param>
		/// <param name="nom"></param>
		/// <param name="dateDeNaissance"></param>
		/// <param name="emprunt"></param>
		public Emprunteur(string prenom, string nom, DateTime dateDeNaissance, Emprunt emprunt)
		{
			this.prenom = prenom;
			this.nom = nom;
			this.dateDeNaissance = dateDeNaissance;	
			this.emprunt = emprunt	;											
		}

		/// <summary>
		/// Méthode consultation de l'emprunteur
		/// </summary>
        public string consulterEmprunt()
        {
			return $"Emprunts de {prenom} {nom}  {emprunt.dateEmprunt} ";            
        }
    }
}

