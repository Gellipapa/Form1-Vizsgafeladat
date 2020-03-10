using Forma1.model;
using Forma1.myExceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
    

{   /// <summary>
/// A  F1 nyilvántartó osztály
/// Szolgáltatást nyújt a Service rétegnek
/// </summary>
    partial class F1
    {


        public void addRacerToTeam(string teamName, Racer r)
        {
            
        }

        public bool IsExistRacer(string racerName, int racerAge)
        {
            if (teams == null)
            {
                throw new F1Exception("Végzetes hiba,Team lista nincs peldanyositva");
            }
            else
            {
                foreach(Team t in teams)
                {
                    try
                    {
                        if (t.isExistRacer(racerName, racerAge))
                            return true;
                    }
                    catch(TeamException te)
                    {
                        throw new F1Exception(te.Message);
                    }
                    
                    
                }
            }
            return false;
        }
        
    }
}
