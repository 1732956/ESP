using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI
{
    public partial class FMain : Form
    {
        public FMain(bool pDatabaseConnected)
        {
            InitializeComponent();
            if (!pDatabaseConnected)
                MessageBox.Show("Votre connection au serveur ne semble pas fonctionner, veuillez contacter votre administarteur système.", "Erreur connection", MessageBoxButtons.OK);
        }
    }
}
