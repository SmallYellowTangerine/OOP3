using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab3
{
    class Initialization
    {
        
        public List<Genre> initObjects(List<string> objList, Dictionary<string, string> allProperties)
        {

            //creating a kind of a dictionary of all classes
            Genre someGenre = new Fiction();
            Genre someGenre2 = new NonFiction();
            Genre someGenre3 = new Fantasy();
            Genre someGenre4 = new ScienceFiction();
            Genre someGenre5 = new MagicRealism();
            Genre someGenre6 = new Biography();

            Dictionary<string, Genre> allGenres = new Dictionary<string, Genre>();

            allGenres.Add("Fiction", someGenre);
            allGenres.Add("NonFiction", someGenre2);
            allGenres.Add("Fantasy", someGenre3);
            allGenres.Add("ScienceFiction", someGenre4);
            allGenres.Add("MagicRealism", someGenre5);
            allGenres.Add("Biography", someGenre6);

            //creating the result list
            List<Genre> genres = new List<Genre>();

            //creating the list user decided on by adding genres from genre dictionary to it
            for (int i = 0; i <= objList.Count - 1; i++ )
            {
                genres.Add(allGenres[ objList[i] ]);
            }

            foreach (var item in genres)
            {
                item.SetProperties(allProperties);
            }

            return genres;
        }

        public Dictionary<string, string> initProperties(Dictionary<string, string> properties)
        {
            properties.Add("Fiction", "Twenty Thousand Leagues Under the Sea");
            properties.Add("NonFiction", "Bible");
            properties.Add("Fantasy", "Lord of the Rings");
            properties.Add("ScienceFiction", "The Ship Who Sang");
            properties.Add("MagicRealism", "The Ocean at the End of the Lane");
            properties.Add("Biography", "The Enigma");
            return properties;
        }

    }
}
