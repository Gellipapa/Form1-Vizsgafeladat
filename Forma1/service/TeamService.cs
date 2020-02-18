using Forma1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.service
{
    class TeamService
    {
        /// <summary>
        /// Service réteg feladata az üzleti logika megvalósítása
        /// Kapcsolatott teremt a Controller és a Repository réteg között
        /// </summary>
        F1 f1Repository;


        public TeamService()
        {
            f1Repository=new F1();        }

        internal void addTeam(string teamName)
        {
            throw new NotImplementedException();
        }
    }
}
