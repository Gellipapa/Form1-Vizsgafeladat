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


        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            try
            {
                string teamName = textBoxTeamName.Text;
                controller.addTeamToF1(teamName);
                listBoxTeam.DataSource = null;
                listBoxTeam.DataSource = controller.getTeamNames();
                textBoxTeamName.Text = "";
            }
            catch(ControllerException ce)
            {

            }
            

            
        }

        private void buttonDeleteTeam_Click(object sender, EventArgs e)
        {
            errorProviderDeleteTeam.Clear();
            try
            {
                
                if (listBoxTeam.SelectedIndex < 0)
                {
                    return;
                }
                string teamNameToDelete = listBoxTeam.Text;
                controller.deleteTeam(teamNameToDelete);
                listBoxTeam.DataSource = null;
                listBoxTeam.DataSource = controller.getTeamNames();
            }
            catch(ControllerException ce)
            {
                errorProviderDeleteTeam.SetError(buttonDeleteTeam, ce.Message);
            }

        }

        private void buttonUpdateTeam_Click(object sender, EventArgs e)
        {
            errorProviderModify.Clear();
            try
            {
                string oldTeamName = listBoxTeam.Text;
                string newTeamName = textBoxTeamName.Text;

                controller.modifyTeamName(oldTeamName, newTeamName);
                listBoxTeam.DataSource = null;
                listBoxTeam.DataSource = controller.getTeamNames();
            }
            catch(ControllerException ce)
            {
                errorProviderModify.SetError(buttonUpdateTeam, ce.Message);
            }
            
        }


    }
}
