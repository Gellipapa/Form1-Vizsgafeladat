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
    partial class Team
    {
       

        public bool isExistRacer(string racerName, int racerAge)
        {
            if (racers == null)
            
                throw new F1Exception("Végzetes hiba,Team lista nincs peldanyositva");

            foreach(Racer r in racers)
                {
                    if(r.getName()==racerName && r.getAge() == racerAge)
                    return true;
                
                
                }
            return false;

        }

      
    }
}
