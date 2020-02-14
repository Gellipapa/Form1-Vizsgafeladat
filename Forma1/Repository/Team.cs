using Forma1.model;
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


    }
}
