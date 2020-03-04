using Forma1.controller;
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

        F1Controller controller;

        public Form1Form()
        {
            controller = new F1Controller();
            InitializeComponent();
        }


    }
}
