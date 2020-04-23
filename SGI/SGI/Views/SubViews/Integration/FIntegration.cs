using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SGI.CEnum;

namespace SGI.Views.SubViews.Integration
{
    public partial class FIntegration : Form
    {
        UCManagementAction ucManagementAction1 = new UCManagementAction();
        State mCurrentState;
        State CurrentState
        {
            get { return mCurrentState; }
            set
            {
                mCurrentState = value;
                switch (mCurrentState)
                {
                    case State.VIEW:
                        ucManagementAction1.btnSave.Enabled = false;
                        ucManagementAction1.btnCancel.Enabled = false;
                        break;
                    case State.UPDATE:
                        ucManagementAction1.btnSave.Enabled = true;
                        ucManagementAction1.btnCancel.Enabled = true;
                        break;
                }
            }
        }
        public FIntegration()
        {
            InitializeComponent();
            Controls.Add(ucManagementAction1);
            ucManagementAction1.Dock = DockStyle.Bottom;
            SetDBConnectionString();
            CurrentState = State.VIEW;
            ucManagementAction1.btnDelete.Visible = false;
            ucManagementAction1.btnNew.Visible = false;
            ucManagementAction1.SaveButtonClicked += UcManagementAction1_SaveButtonClicked;
            ucManagementAction1.CancelButtonClicked += UcManagementAction1_CancelButtonClicked;
        }

        private void UcManagementAction1_CancelButtonClicked()
        {
            SetDBConnectionString();
            CurrentState = State.VIEW;
        }

        private void UcManagementAction1_SaveButtonClicked()
        {
            Cursor.Current = Cursors.WaitCursor;
            Properties.Settings.Default.DataSource = txtConnexionBD.Text;
            Properties.Settings.Default.Save();
            bool connected = CDatabase.ConnectToData();
            if (connected)
                MessageBox.Show("La connexion a la base de données a été changé avec succès.", "Connexion changée avec succès");
            else
                MessageBox.Show("La connexion a la base de données a été changé, mais votre connection au serveur ne semble pas fonctionner, veuillez contacter votre administrateur système.", "Connexion changée sans succès");
            Cursor.Current = Cursors.Default;
        }

        public void SetDBConnectionString()
        {
            string currentConnection = Properties.Settings.Default.DataSource;
            txtConnexionBD.Text = currentConnection;
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            CurrentState = State.UPDATE;
        }
    }
}
