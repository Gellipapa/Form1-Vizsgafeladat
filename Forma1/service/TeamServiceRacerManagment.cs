using Forma1.model;
using Forma1.myExceptions;
using Forma1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.service
{
    partial class TeamService
    {
        public void addRacerToTeam(string teamName, Racer r)
        {

            try
            {
                if (f1Repository.IsExistRacer(r.getName(), r.getAge())){
                    throw new TeamServiceToGUIException(r.getName() + "nevű és" + r.getAge() + "életkorú versenyző már létezik!");
                    f1Repository.addRacerToTeam(teamName, r);
                }
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }


        }

    }
}
