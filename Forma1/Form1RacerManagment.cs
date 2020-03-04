using Forma1.controller;
using Forma1.myExceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma1
{
    public partial class Form1Form : Form
    {
        

        private void buttonAddRacer_Click(object sender, EventArgs e)
        {
            try
            {
                string teamName = listBoxTeam.Text;
                string racerName = textBoxRacerName.Text;
                string racerAge = textBoxRacerAge.Text;
                string racerSalary = textBoxF1Salary.Text;
                controller.addRacerToTeam(teamName, racerName, racerAge, racerSalary);
            }
            catch(ControllerException ce)
            {

            }
            


        }

    }
}
