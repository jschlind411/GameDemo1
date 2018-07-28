using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMSWindowApp
{
    public partial class Form1 : Form
    {
        Player player;

        public Form1()
        {
            InitializeComponent();
            updateTimer.Start();

            player = loadGame();

            txbPlayName.Text = player.GetName + "      Level: " + player.GetLVL;
            picbxPlayerAvatar.Image = player.GetAvatar;
        }

        #region main form updates

        private void update_Tick(object sender, EventArgs e)
        {
            updateGui();
        }

        private void updateGui()
        {
            btnTroops.Text = player.GetTotalTroops().ToString();
        }
        #endregion

        #region game buttons


        private void btnOfficers_Click(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnQuests_Click(object sender, EventArgs e)
        {

        }

        private void btnMail_Click(object sender, EventArgs e)
        {

        }

        private void btnTroops_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region game loading

        private Player loadGame()
        {
            bool canFindPlayer = false;

            if (canFindPlayer)
            {
                return new Player();
            }
            else
            {
                return new Player();
            }
        }

        #endregion
    }
}
