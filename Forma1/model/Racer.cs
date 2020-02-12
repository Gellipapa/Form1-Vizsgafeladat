using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.model
{
    /// <summary>
    /// Versenyző osztály
    /// </summary>
    class Racer
    {
        /// <summary>
        /// Versenyző osztály adat tagjai
        /// </summary>
        private string name;
        private int age;
        private int salery;

        /// <summary>
        /// Üres konstruktor lehetetlen adatokal
        /// </summary>
        public Racer()
        {
            name = "";
            age = -1;
            salery = -1;


        }
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="salery"></param>
        public Racer(string name, int age, int salery)
        {
            this.name = name;
            this.age = age;
            this.salery = salery;
        }
        /// <summary>
        /// Set Name érték beállítása
        /// </summary>
        /// <param name="name">Név érték</param>
        public void setName(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Set Age érétk beállítása
        /// </summary>
        /// <param name="age">Életkor érték</param>
        public void setAge(int age)
        {
            this.age = age;
        }
        /// <summary>
        /// Set salery érték beállítása
        /// </summary>
        /// <param name="salery">Fizetés érték</param>
        public void setSalery(int salery)
        {
            this.salery = salery;
        }

        /// <summary>
        /// Visszadja a Name értéket
        /// </summary>
        /// <param name="name">Név érték</param>
        /// <returns></returns>
        public string getName()
        {
            return name;
        }
        /// <summary>
        /// Visszadja a Age értéket
        /// </summary>
        /// <param name="age">Életkor értéke</param>
        /// <returns></returns>
        public int getAge()
        {
            return age;
        }
        /// <summary>
        /// Visszadja a Salery értéket
        /// </summary>
        /// <param name="salery">Fizetés értéke</param>
        /// <returns></returns>
        public int getSalery()
        {
            return salery;
        }
        
    }
}
