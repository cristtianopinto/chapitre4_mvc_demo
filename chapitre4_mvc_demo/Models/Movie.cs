using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Objet métier Ouvrage
/// </summary>
namespace chapitre4_mvc_demo.Models
{
    public class Movie
    {
        /// <summary>
        /// Par convention, ID a une clé primaire
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Champ Director
        /// </summary>
        public string DirectorName { get; set; }

        /// <summary>
        /// Champ Titre
        /// </summary>
        public string TitreMovie { get; set; }

        /// <summary>
        /// Duration movie
        /// </summary>
        public int Duration { get; set; }

        public DateTime? Ane { get; set; }

        /// <summary>
        /// Constructor d'une movie
        /// </summary>
        public Movie()
        {
            ID = 0;
            DirectorName = "";
            TitreMovie = "";
            Duration = 0;
            Ane = null;
        }

        public Movie(int id,string director, string titre, int duration, DateTime date)
        {
            ID = id;
            DirectorName = director;
            TitreMovie = titre;
            Duration = duration;
            Ane = date;
        }

    }
}