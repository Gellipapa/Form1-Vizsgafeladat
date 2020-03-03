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
        /// Adott nevű team törlése a listából
        /// Tanár úr szerint van egy bug benne!
        /// 
        /// </summary>
        /// <param name="teamNameToDelete">Törlendő csapat neve</param>
        public void delete(string teamNameToDelete)
        {
            if (teams == null)
            {
                throw new F1Exception("Végzetes hiba,Team lista nincs peldanyositva");
            }
            else
            {
                int index = 0;
                foreach(Team t in teams)
                {
                    if (t.getTeamName() == teamNameToDelete)
                    {
                        teams.RemoveAt(index);
                        return;
                    }
                    index = index + 1;
                        
                }
                throw new F1Exception(teamNameToDelete + "csapat nem létezik így nem lehet törölni!");
                
            }
        }

        public void update(string oldTeamName, string newTeamName)
        {
            if (teams == null)
            {
                throw new F1Exception("Végzetes hiba, team lista nincs példányosítva!");
            }
            else
            {
                foreach(Team t in teams)
                {
                    if (t.getTeamName() == oldTeamName)
                    {
                        t.update(newTeamName);
                        return;
                    }
                    throw new F1Exception(oldTeamName + " csapat nem található nem lehet módosítani!");
                }
            }
        }

        /// <summary>
        /// teamName a csapat versenyzőinek száma
        /// </summary>
        /// <param name="teamName">csapat neve</param>
        /// <returns>Csapat versenyzőinek számát</returns>
        public int getNumberOfRacers(string teamName)
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
                        try
                        {
                            return t.getNumberOfRacers();
                        }
                        catch (TeamException te)
                        {
                            Debug.WriteLine(te.Message);

                            throw new F1Exception(teamName + "csapatott nem lehet törölni!");
                        }
                    }
                }
                throw new F1Exception(teamName+" csapat nem létezik!");

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
