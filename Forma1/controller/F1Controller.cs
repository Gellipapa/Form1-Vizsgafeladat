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

        public void deleteTeam(string teamNameToDelete)
        {
            try
            {

                if (!teamService.IsExist(teamNameToDelete))
                {
                    throw new ControllerException(teamNameToDelete+"csapat nem létezik! Nem lehet törölni!");
                }

                else
                {
                    try
                    {
                        teamService.deleteTeam(teamNameToDelete);
                    }
                    catch (TeamServiceException tse)
                    {

                    }
                    {

                    }
                    
                }


            }catch(TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
            }
        }

        public List<string> getTeamNames()
        {
            try
            {
                List<Team> teams = teamService.getTeams();
                return TeamListToTeamNameList(teams);

            }
            catch (TeamServiceException tse)
            {

                Debug.WriteLine(tse.Message);
                List<string> teamNames = new List<string>();
                return null;
            }
        }

        private List<string> TeamListToTeamNameList(List<Team> teams)
        {
            List<string> teamNames = new List<string>();
            foreach(Team t in teams)
            {
                teamNames.Add(t.getTeamName());
            }
            return teamNames;
        }
    }
}
