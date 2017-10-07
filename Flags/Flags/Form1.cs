using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random RNG = new Random(); //Apparently Random(); seeds from the current time by default, so this shouldn't cause identical sequences each time you start.
        /*
        private Dictionary<string, Image> Flaglist = new Dictionary<string, Image>();

        private Image F_Afghanistan = Image.FromFile("Afghanistan.png");

        Flaglist.Add("afghanistan", F_Afghanistan);
            */
    }
}
