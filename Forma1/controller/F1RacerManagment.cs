using Forma1.model;
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
    partial class F1Controller
    {



        /// <summary>
        /// Controller réteg kapcsolatot teremt a GUI és a Service réteg között
        /// Feladata a bemenő adatok vizsgálata
        /// Feladata a megjelenítendő adatok átalakítása a GUI számára
        /// Feldata a programozónak szánt hibaüzenetek megjelenítése
        /// </summary>


        public void addRacerToTeam(string teamName, string racerName, string racerAge, string racerSalary)
        {
            
                if (teamName == "")
                {
                    throw new ControllerException("Előbb hozza létre a csapatott utána adja hozzá a versenyzőket!");
                }
            int newRacerAge = 0;
            if (!int.TryParse(racerAge, out newRacerAge))
            {
                throw new ControllerException("A versenyző életkora nem megfeleő formátumú!");
            }
            if (newRacerAge <=0)
            {
                throw new ControllerException("A versenyző életkora nem lehet kisebb vagy nulla");
            }

            int newRacerSalary = 0;
            if (!int.TryParse(racerAge, out newRacerSalary))
            {
                throw new ControllerException("A versenyző fizetése nem megfeleő formátumú!");
            }
            if (newRacerSalary <= 0)
            {
                throw new ControllerException("A versenyző fizetése nem lehet negatív vagy nulla!");
            }

            try
            {
                Racer r = new Racer(racerName, newRacerAge, newRacerSalary);
                teamService.addRacerToTeam(teamName,r);
            }
            catch(TeamServiceToGUIException tstge)
            {
                Debug.WriteLine(tstge.Message);
                throw new ControllerException(tstge.Message);
            }
            catch(TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
            }




        }



    }

       
}
