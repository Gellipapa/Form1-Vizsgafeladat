using Forma1.myExceptions;
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

        public void addTeam(string teamName)
        {
            try
            {
                Team t = new Team(teamName);
                f1Repository.add(t);
            }
            catch(F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
            
        }

        public List<Team> getTeams()
        {
            try
            {
               return f1Repository.getTeams();

            }catch(F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }

        public bool IsExist(string teamNameToDelete)
        {
            try
            {
                if (f1Repository.IsExist(teamNameToDelete))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (F1Exception f1e)
            {

                throw new TeamServiceException(f1e.Message);
            }
        }

        public void deleteTeam(string teamNameToDelete)
        {
            try
            {
                int numberOfTeamRacers = f1Repository.getNumberOfRacers(teamNameToDelete);

                if (numberOfTeamRacers > 0)
                {
                    throw new TeamServiceToGUIException(teamNameToDelete+" nem lehet törölni mert, vannak még versenyzőik!");
                }
                else
                {
                    f1Repository.delete(teamNameToDelete);
                }

            }
            catch (F1Exception f1e)
            {

                throw new TeamServiceException(f1e.Message);
            }
        }

        public void modifyTeamName(string oldTeamName, string newTeamName)
        {
            try
            {
                f1Repository.update(oldTeamName, newTeamName);
            }
            catch(F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
            
        }
    }
}
