using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{   /// <summary>
/// A csapat neve
/// </summary>
    class F1
    {
        /// <summary>
        /// Az F1 csapatok
        /// </summary>
        List<Team> teams;
        /// <summary>
        /// Konstruktor
        /// </summary>
        public F1()
        {
            teams = new List<Team>();
        }
        /// <summary>
        /// Létrehozz egy új csapatott az F1-ben
        /// </summary>
        /// <param name="name"> Új csapat neve</param>
        public void add(string name)
        {
            Team t = new Team(name);
            teams.Add(t);
        }




    }
}
