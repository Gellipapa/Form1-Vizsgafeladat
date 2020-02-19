using Forma1.myExceptions;
using Forma1.Repository;
using Forma1.service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.controller
{
    class F1Controller
    {
        TeamService teamService;
        /// <summary>
        /// Controller réteg kapcsolatot teremt a GUI és a Service réteg között
        /// Feladata a bemenő adatok vizsgálata
        /// Feladata a megjelenítendő adatok átalakítása a GUI számára
        /// Feldata a programozónak szánt hibaüzenetek megjelenítése
        /// </summary>
        public F1Controller()
        {
            teamService = new TeamService();
        }

        

        public void addTeamToF1(string teamName)
        {
            try
            {
                teamService.addTeam(teamName);
            }
            catch(TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
            }
            
        }
    }
}
