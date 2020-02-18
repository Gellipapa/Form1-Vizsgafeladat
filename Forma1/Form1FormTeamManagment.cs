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
            string teamName = textBoxTeamName.Text;
            controller.addTeamToF1(teamName);
            
        }
    }
}
