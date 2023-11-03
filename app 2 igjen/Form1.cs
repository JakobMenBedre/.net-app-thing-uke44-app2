using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_2_igjen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void blåknapp_Click(object sender, EventArgs e)
        {
            colorChangeBox.BackColor = Color.Blue; //når button1 blir trykket på bytter den farge på ett objekt jeg har til blå
        }

        private void grønnknapp_Click(object sender, EventArgs e)
        {
            colorChangeBox.BackColor = Color.Green; //annen knapp, samme objekt, nye farge(grønn)
        }

        private void resetknapp_Click(object sender, EventArgs e)
        {
            colorChangeBox.BackColor = DefaultBackColor; //annen knapp, samme objekt, default farge
        }

        private void exitknapp_Click(object sender, EventArgs e)
        {
           this.Close(); // annen knapp, lukker programmet
        }
    }
}
