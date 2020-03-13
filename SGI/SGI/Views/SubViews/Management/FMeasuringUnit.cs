using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGI.Controller;
using SGI.Model.Classes;
using static SGI.CEnum;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace SGI.Views.SubViews
{
    public partial class FMeasuringUnit : Form
    {
        MeasuringUnitController MeasuringUnitController;
        MeasuringUnit mCurrentMU;
        public MeasuringUnit currentMU
        {
            get { return mCurrentMU; }
            set
            {
                mCurrentMU = value;
                if (mCurrentMU != null)
                {
                    RefreshMeasuringUnitData();
                }
            }
        }
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
                        ucManagementAction1.btnNew.Enabled = true;
                        ucManagementAction1.btnDelete.Enabled = true;
                        LBMeasuringUnits.Enabled = true;
                        break;
                    case State.ADD:
                        ucManagementAction1.btnSave.Enabled = true;
                        ucManagementAction1.btnCancel.Enabled = true;
                        ucManagementAction1.btnNew.Enabled = false;
                        ucManagementAction1.btnDelete.Enabled = false;
                        LBMeasuringUnits.Enabled = false;
                        break;
                    case State.UPDATE:
                        ucManagementAction1.btnSave.Enabled = true;
                        ucManagementAction1.btnCancel.Enabled = true;
                        ucManagementAction1.btnNew.Enabled = false;
                        ucManagementAction1.btnDelete.Enabled = false;
                        LBMeasuringUnits.Enabled = true;
                        break;
                }
            }
        }
        public FMeasuringUnit()
        {
            InitializeComponent();
            MeasuringUnitController = new MeasuringUnitController();
            CBFilter.Items.Add("Actifs");
            CBFilter.Items.Add("Inactifs");
            CBFilter.Items.Add("Tous");
            CBFilter.SelectedItem = "Actifs";
            GetAllActiveMeasuringUnits();
            CurrentState = State.VIEW;
            ucManagementAction1.btnDelete.Visible = false;
            ucManagementAction1.SaveButtonClicked += UcManagementAction1_SaveButtonClicked;
            ucManagementAction1.NewButtonClicked += UcManagementAction1_NewButtonClicked;
            ucManagementAction1.CancelButtonClicked += UcManagementAction1_CancelButtonClicked;
            CBFilter.SelectedIndexChanged += CBFilter_SelectedIndexChanged;
            ChangeFormEditStatus(true);
        }

        private void CBFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<MeasuringUnit> dataSource = new List<MeasuringUnit>();
            if (CBFilter.Text == "Tous")
                dataSource = MeasuringUnitController.GetAllMeasuringUnits();
            else if (CBFilter.Text == "Actifs")
                dataSource = MeasuringUnitController.GetAllActiveMeasuringUnits();
            else if (CBFilter.Text == "Inactifs")
                dataSource = MeasuringUnitController.GetAllInactiveMeasuringUnits();
            LBMeasuringUnits.DataBindings.Clear();
            var MUs = dataSource;
            LBMeasuringUnits.DataSource = MUs;
            if (MUs.Count > 0)
                LBMeasuringUnits.SelectedIndex = 0;
        }

        private void UcManagementAction1_CancelButtonClicked()
        {
            switch (CurrentState)
            {
                case State.ADD:
                    LBMeasuringUnits.DataBindings.Clear();
                    List<MeasuringUnit> tempoMUs = MeasuringUnitController.GetAllMeasuringUnits();
                    LBMeasuringUnits.DataSource = tempoMUs;
                    if (tempoMUs.Count > 0)
                        LBMeasuringUnits.SelectedIndex = 0;
                    CurrentState = State.VIEW;
                    break;
                case State.UPDATE:
                    RefreshMeasuringUnitData();
                    CurrentState = State.VIEW;
                    break;
            }
        }

        private void UcManagementAction1_NewButtonClicked()
        {
            List<MeasuringUnit> tempoMeasuringUnits = MeasuringUnitController.GetAllMeasuringUnits();
            tempoMeasuringUnits.Add(new MeasuringUnit());
            LBMeasuringUnits.DataBindings.Clear();
            LBMeasuringUnits.DataSource = tempoMeasuringUnits;
            LBMeasuringUnits.SelectedIndex = LBMeasuringUnits.Items.Count - 1;
            ChangeFormEditStatus(false);
            CurrentState = State.ADD;
        }

        private void UcManagementAction1_SaveButtonClicked()
        {
            switch (CurrentState)
            {
                case State.ADD:
                    Save("add", 0, true);
                    break;
                case State.UPDATE:
                    Save("update", currentMU.UnitId, false);
                    break;
            }
        }

        private void Save(string Action, int UnitId, bool last)
        {
            string errorMessage = CanSave();
            if (errorMessage != "")
                MessageBox.Show(errorMessage, "Impossible de sauvegarder");
            else
            {
                SetDepartmentData(UnitId);
                bool newMUWorked = MeasuringUnitController.EditSingleMeasuringUnit(currentMU, Action);
                if (newMUWorked)
                {
                    MessageBox.Show("Enregistrement effectué");
                    string currentFilter = CBFilter.Text;
                    List<MeasuringUnit> tempoMU = new List<MeasuringUnit>();
                    if (currentFilter == "Actifs")
                        tempoMU = MeasuringUnitController.GetAllActiveMeasuringUnits();
                    else if (currentFilter == "Inactifs")
                        tempoMU = MeasuringUnitController.GetAllInactiveMeasuringUnits();
                    else
                        tempoMU = MeasuringUnitController.GetAllMeasuringUnits();
                    if (tempoMU.Count <= 0)
                    {
                        tempoMU = MeasuringUnitController.GetAllMeasuringUnits();
                        CBFilter.SelectedIndex = 0;
                    }
                    LBMeasuringUnits.DataBindings.Clear();
                    LBMeasuringUnits.DataSource = tempoMU;
                    LBMeasuringUnits.SelectedIndex = last == true ? LBMeasuringUnits.Items.Count - 1 : 0;
                    ChangeFormEditStatus(true);
                    CurrentState = State.VIEW;
                }
                else
                    MessageBox.Show("Une erreur est survenue, veuillez réessayer.");
            }
        }

        private string CanSave()
        {
            string returnMessage = "";
            if (TxtName.Text == "")
                returnMessage += "Le nom ne peut pas être nul." + Environment.NewLine;
            if (txtCode.Text == "")
                returnMessage += "La description ne peut pas être nulle." + Environment.NewLine;
            return returnMessage;
        }

        private void SetDepartmentData(int UnitId)
        {
            currentMU.UnitId = UnitId;
            currentMU.Description = TxtName.Text;
            currentMU.UnitCode = txtCode.Text;
            currentMU.Active = cbActive.Checked;
        }

        private void GetAllActiveMeasuringUnits()
        {
            LBMeasuringUnits.DisplayMember = "Description";
            LBMeasuringUnits.ValueMember = "UnitId";
            var MUs = MeasuringUnitController.GetAllActiveMeasuringUnits();
            LBMeasuringUnits.DataSource = MUs;
            if (MUs.Count > 0)
                LBMeasuringUnits.SelectedIndex = 0;
        }

        private void ChangeFormEditStatus(bool Editing)
        {
            if (Editing)
            {
                TxtName.TextChanged += PutInEditMode;
                txtCode.TextChanged += PutInEditMode;
                cbActive.CheckedChanged += PutInEditMode;
            }
            else
            {
                TxtName.TextChanged -= PutInEditMode;
                txtCode.TextChanged -= PutInEditMode;
                cbActive.CheckedChanged -= PutInEditMode;
                CurrentState = State.VIEW;
            }
        }

        private void PutInEditMode(object sender, EventArgs e)
        {
            CurrentState = State.UPDATE;
        }

        private void RefreshMeasuringUnitData()
        {
            TxtName.Text = currentMU.Description;
            txtCode.Text = currentMU.UnitCode;
            cbActive.Checked = currentMU.Active;
        }

        private void LBMeasuringUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMU = (MeasuringUnit)LBMeasuringUnits.SelectedItem;
            CurrentState = State.VIEW;
        }
    }
}
