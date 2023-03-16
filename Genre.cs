using System;
namespace base_genre
{

	public class Genre
    {
        /// <summary>
        /// class Genre
        /// </summary>
        public string titre { get; set; }
        public string description { get; set; }
        public List<Genre> genres { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="titre"></param>
        /// <param name="description"></param>
        public Genre(string titre, string description)
        {
            this.titre = titre;
            this.description = description;
            this.genres = new List<Genre>();
        }

        /// <summary>
        /// Méthode pour ajouter un sous-genre à la liste genre
        /// </summary>
        /// <param name="genre"></param>
        public void AjouterGenre(Genre genre)
        {
            this.genres.Add(genre);
        }

        /// <summary>
        /// Méthode pour afficher les informations sur le genre
        /// </summary>
        public override string ToString()
        {
            return  $"Titre : {titre}\n" +
                    $"Description : {description}";
        }
    }
}

