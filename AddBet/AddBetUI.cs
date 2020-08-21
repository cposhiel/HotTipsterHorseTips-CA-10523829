using HorseTipRepository;
using HotTipster_Model_Layer.HotTipster_Horse_Tip_Model;
using ServiceLayer.HorseTipServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddBet
{
    public partial class AddBetUI : Form
    {
        private static HorseTipDataValidator TipValidator;
        bool hasCheckedBox = false;

        public AddBetUI()
        {
            InitializeComponent();
            lstRaceCourses.Items.AddRange(typeof(RaceCourses).GetEnumNames());
            lstRaceCourses.SelectedIndex = -1;
            tbDateofRace.Click += TbDateClicked;
        }

        private void btnAddBet_Click(object sender, EventArgs e)
        {
            HorseTip horseTip = new HorseTip(TipValidator.ValidHorseName, TipValidator.ValidRacecourse, 
                                                TipValidator.ValidDateOfRace , TipValidator.ValidAmountWonOrLost, cbRaceIsWon.Checked);
            MessageBox.Show($"Bet Created!! {Environment.NewLine}" +
                                $"{horseTip.ToStringInDetail()}", "Bet Created!");
            HotTips.horseTips.Add(horseTip);
            ToggleButtonsEnabled(true, false);
            lstRaceCourses.SelectionMode = SelectionMode.One;
            MakeFieldsReadOnly(false);
            hasCheckedBox = false;
            ClearTbs();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            TipValidator = new HorseTipDataValidator(tbHorseName.Text, (RaceCourses)lstRaceCourses.SelectedIndex, 
                                                        tbDateofRace.Text, tbAmount.Text);
            if (TipValidator.Error == error.none)
            {
                if (hasCheckedBox == true)
                {
                    MakeFieldsReadOnly(true);
                    ToggleButtonsEnabled(false, true);
                    lstRaceCourses.SelectionMode = SelectionMode.None;
                }
                else
                {
                    RemindCheckBox();
                    hasCheckedBox = true;
                }
            }
            else
            {
                MessageBox.Show($"Please enter a valid {TipValidator.Error}.", $"Valid {TipValidator.Error} required.");
            }
                       
        }
        public void TbDateClicked(object sender, EventArgs e)
        {
            Regex regex = new Regex("[a-zA-Z]");
            if (regex.IsMatch(tbDateofRace.Text))
            {
                tbDateofRace.Clear();
            }
        }
        private void RemindCheckBox()
        {
                MessageBox.Show("Don't forget to check the box if the race was won.", "Wait!");
                btnSelect.Enabled = false;
                btnAddBet.Enabled = true;
           
        }
        public void ClearTbs()
        {
            tbHorseName.Clear();
            tbDateofRace.Clear();
            tbAmount.Clear();
            tbOutcome.Clear();
            lstRaceCourses.ClearSelected();
            cbRaceIsWon.Checked = false;
        }
        private void ToggleButtonsEnabled(bool select, bool add)
        {
            btnSelect.Enabled = select;
            btnAddBet.Enabled = add;                   
        }
        private void MakeFieldsReadOnly(bool isEnabled)
        {
            tbHorseName.ReadOnly = isEnabled;            
            tbDateofRace.ReadOnly = isEnabled;
            tbAmount.ReadOnly = isEnabled;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (btnSelect.Enabled == false)
            {
                MakeFieldsReadOnly(false);
                ToggleButtonsEnabled(true, false);
                lstRaceCourses.SelectionMode = SelectionMode.One;
            }
            else 
            {
                this.Hide();
                HotTipsterMainMenuUI hotTipsterMainMenuUI = new HotTipsterMainMenuUI();
                hotTipsterMainMenuUI.ShowDialog();
                this.Close();
            }
        }

        private void cbRaceIsWon_CheckedChanged(object sender, EventArgs e)
        {
            tbOutcome.Text = cbRaceIsWon.Checked ? "Won." : "Lost.";
            hasCheckedBox = true;
        }
    }
}
