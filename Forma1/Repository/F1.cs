using Forma1.myExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
    

{   /// <summary>
/// A  F1 nyilvántartó osztály
/// Szolgáltatást nyújt a Service rétegnek
/// </summary>
    class F1
    {
        /// <summary>
        /// Az F1 csapatok
        /// </summary>
        List<Team> teams;
        /// <summary>
        /// Konstruktor
        /// </summary>
        public F1()
        {
            teams = new List<Team>();
        }


        public List<Team> getTeams()
        {
            if (teams == null)
            {
                throw new F1Exception("Végzetes hiba,Team lista nincs peldanyositva");
            }
            else
            {
                return teams;
            }
        }

        /// <summary>
        /// Létrehozz egy új csapatott az F1-ben
        /// </summary>
        /// <param name="name"> Új csapat neve</param>
        public void add(string name)
        {
            if (teams == null)
            {
                throw new F1Exception("Végzetes hiba,Team lista nincs peldanyositva");
            }
            else
            {
                Team t = new Team(name);
                teams.Add(t);
            }
        }
        /// <summary>
        /// Ellenőrzi a hogy a csapat neve létezik e a listában
        /// </summary>
        /// <param name="teamName">keresett csapat neve</param>
        /// <returns>true ha igen, false ha nem talált</returns>
        public bool IsExist(string teamName)
        {
            if (teams == null)
            {
                throw new F1Exception("Végzetes hiba,Team lista nincs peldanyositva");
            }
            else
            {
                foreach(Team t in teams)
                {
                    if (t.getTeamName() == teamName)
                    {
                        return true;
                    }
                   
                }
                return false;
            }
        }



        /// <summary>
        /// A teamet hozzáadja a teamek listájához
        /// </summary>
        /// <param name="t">A csapat listához hozzáadott csapat</param>
        public void add(Team t)
        {
            if (teams == null)

            {
                throw new F1Exception("Végzetes hiba, team lista nincs példányosítva!");
                
            }
            else
            {
                teams.Add(t);
            }
            
        }




    }
}
