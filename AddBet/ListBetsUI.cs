using HorseTipRepository;
using ServiceLayer.HorseTipServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AddBet
{
    public partial class ListBetsUI : Form
    {
        IFileProcessor fileProcessor;
        //The UI for listing bets and viewing the data in a number of different ways.
        public ListBetsUI()
        {
            fileProcessor = new FileEncryptor();
            InitializeComponent();
        }
        /// <summary>
        /// Displays data in the rich text box.
        /// </summary>
        /// <param name="list"></param>
        private void DisplayText(List<string> list)
        {
            rtbDisplay.Clear();
            List<string> Bets = list;
            foreach (var tip in Bets)
            {
                rtbDisplay.AppendText(tip);
            }
        }
        
        private void btnReadFile_Click(object sender, EventArgs e)
        {            
            try
            {
                if (HorseTipDataValidator.ValidateReadData(fileProcessor.ReadFromFile()))
                {
                    HotTips.horseTips = fileProcessor.ReadFromFile();
                    rtbDisplay.Clear();
                    UpdateList();
                }
                else 
                {
                    MessageBox.Show("No data in file.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }
        
        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            if (HotTips.horseTips.Any())
            {
                try
                {
                    fileProcessor.WriteToFile(HotTips.horseTips);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No data in memory to write.", "No Data!");
            }
            
        }

        private void btnPopCourse_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListEnquirer.MostPopularCourse(HotTips.horseTips),"Most Popular Course");
        }

        private void btnDateOrder_Click(object sender, EventArgs e)
        {
            DisplayText(ListEnquirer.TipsInDateOrder(HotTips.horseTips));
        }

        private void btnHighestAmountBet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListEnquirer.GetHighestAmountsWonAndLost(HotTips.horseTips), "Highest Amounts Won/Lost");
        }

        private void btnTotalWinLossPA_Click(object sender, EventArgs e)
        {
            DisplayText(ListEnquirer.GetAmountTotalsByYear(HotTips.horseTips));
        }

        private void btnSuccRate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListEnquirer.GetSuccessRate(HotTips.horseTips), "HotTipster Success Rate");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HotTipsterMainMenuUI hotTipsterMainMenuUI = new HotTipsterMainMenuUI();
            hotTipsterMainMenuUI.ShowDialog();
            this.Close();
        }
        public void UpdateList()
        {
            
            foreach (var bet in HorseTipDataValidator.HandleNullHorseTipList(HotTips.horseTips))
            {
                rtbDisplay.AppendText(bet.ToString());
            }
        }
    }
}
