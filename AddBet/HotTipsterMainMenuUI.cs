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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddBet
{

    public partial class HotTipsterMainMenuUI : Form
    {

        public HotTipsterMainMenuUI()
        {
            
            InitializeComponent();
        }

        private void btnCreateBet_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBetUI addBetUI = new AddBetUI();
            addBetUI.ShowDialog();
            this.Close();
        }

        private void btnListBets_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListBetsUI listBetsUI = new ListBetsUI();
            listBetsUI.UpdateList();
            listBetsUI.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
