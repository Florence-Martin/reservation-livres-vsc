using System;
namespace base_stockLivre
{
    public class StockLivre
    {
        /// <summary>
        /// class StockLivre
        /// </summary>
        public int nombreExemplaire { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nombreExemplaire"></param>
        public StockLivre(int nombreExemplaire)
        {
            this.nombreExemplaire = nombreExemplaire;
        }

        /// <summary>
        /// Méthode d'ajout en nombre d'exemplaires
        /// </summary>
        /// <param name="nombre"></param>
        public void ajouterDesExemplaires(int nombre)
        {
            this.nombreExemplaire += nombre;
        }

        /// <summary>
        /// Méthode de consultation du stock
        /// </summary>
        /// <returns></returns>
        public string consulterStock()
        {
            return $"Nombre d'exemplaires en stock : {nombreExemplaire}";
        }
    }
}

