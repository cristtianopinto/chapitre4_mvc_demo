using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chapitre4_mvc_demo.Models
{
    /// <summary>
    /// Classe de service pour Movie
    /// </summary>
    public class MovieService
    {


        public List<Movie> Select()
        {
            List<Movie> l = new List<Movie>();
            l.Add(new Movie(0, "Spock Lee", "Des nuqges", 129, new DateTime(1998, 07, 01)));
            l.Add(new Movie(0, "Jay Jonson", "La mer", 101, new DateTime(1999, 07, 01)));
            l.Add(new Movie(0, "May Adams", "Voila!", 156, new DateTime(2003, 07, 01)));
            l.Add(new Movie(0, "Kurt Brun", "Tourne de page", 134, new DateTime(2017, 07, 01)));
            return l;
        }

        /// <summary>
        /// Recherche un movie à partir de sa clé primaire
        /// </summary>
        /// <param name="id">Clé primaire de recherche</param>
        /// <returns></returns>
        public Movie Select(int id)
        {
            var q = from obj in Select() where obj.ID == id select obj;
            return q.ToArray()[0];
        }

        public void Insert(Movie movie)
        {

        }

        public void Update(Movie movie)
        {

        }
        public void Delete(Movie movie)
        {

        }
    }
}