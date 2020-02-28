using Forma1.model;
using Forma1.myExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    /// <summary>
    /// A Forma 1-ben versenyző csapatok
    /// </summary>
    class Team
    {
        /// <summary>
        /// Versenyző neve
        /// </summary>
        private string name;
        /// <summary>
        /// Racer Lista elkészítése
        /// </summary>
        List<Racer> racers;
        /// <summary>
        /// Forma 1 csapat csak névvel jöhet létre
        /// </summary>
        /// <param name="name"></param>
        public Team(string name)
        {
            this.name = name;
            racers = new List<Racer>();
        }
        /// <summary>
        /// Visszaadja a csapat nevet
        /// </summary>
        /// <returns>Csapat nevet</returns>
        public string getTeamName()
        {
            return name;
        }
        /// <summary>
        /// A csapat versenyzőinek száma
        /// </summary>
        /// <returns></returns>
        public int getNumberOfRacers()
        {
            if (racers == null)
                throw new TeamException("Végzetes hiba a races lista nincs pédányosítva.");
            else
                return racers.Count;
        }
    }
}
