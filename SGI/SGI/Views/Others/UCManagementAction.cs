using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI.Views
{
    public partial class UCManagementAction : UserControl
    {
        public UCManagementAction()
        {
            InitializeComponent();
        }

        public delegate void New();
        public event New NewButtonClicked;
        public delegate void Save();
        public event Save SaveButtonClicked;
        public delegate void Cancel();
        public event Cancel CancelButtonClicked;
        public delegate void Delete();
        public event Delete DeleteButtonClicked;

        public void btnNew_Click(object sender, EventArgs e)
        {
            NewButtonClicked();
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            SaveButtonClicked();
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            CancelButtonClicked();
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteButtonClicked();
        }
    }
}
