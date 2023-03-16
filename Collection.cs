using System;
namespace base_collection
{
	public class Collection
	{
        /// <summary>
        /// class Collection
        /// </summary>
        public string titre { get; set; }
        public string description { get; set; }
        public List<Collection> collections { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="titre"></param>
        /// <param name="description"></param>
        public Collection(string titre, string description)
            {
                this.titre = titre;
                this.description = description;
                this.collections = new List<Collection>();
        }

        /// <summary>
        /// Méthode d'ajout nouvelle collection à la liste
        /// </summary>
        public void AjouterCollection()
        {
            collections.Add(new Collection(titre,description));
        }
    }
}

