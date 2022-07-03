using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    // Form used for offering a trade
    public partial class TradeForm : Form
    {
        //PlayerOffering -> the player making the trading offer
        //PlayerOffered -> the player that recive the trading offer
        public Player PlayerOffering;
        public List<PropertyTile> propertiesPlayerOffering = new List<PropertyTile>();
        public Player PlayerOffered;
        public List<PropertyTile> propertiesPlayerOffered = new List<PropertyTile>();
        // BalanceOffer>0 -> PlayerOffering gives money 
        // BalanceOffer<0 -> PlayerOffered gives money
        public int BalanceOffer = 0;
        // Players-> list of players with who PlayerOffering can trade
        List<Player> Players;
        public TradeForm()
        {
            InitializeComponent();
        }
        public TradeForm(Player playerOffering, List<Player> players)
        {
            InitializeComponent();
            this.PlayerOffering = playerOffering;
            this.Players = players;
            this.PlayerOffered = Players[0];
            foreach (Player player in Players)
            {
                cbPlayers.Items.Add(player);
            }
            cbPlayers.SelectedIndex = 0;

            gbPlayerOffering.Text = PlayerOffering.Name;
            tbBalancePlayerOffering.Maximum = Math.Max(PlayerOffering.Balance, 0);
            List<PropertyTile> properties = GetPropertyList(PlayerOffering);
            cblPlayerOffering.Items.Clear();
            foreach (PropertyTile property in properties)
            {
                cblPlayerOffering.Items.Add(property);
            }
            UpdateGbPlayerOffered();
        }
        private void UpdateGbPlayerOffered()
        {
            PlayerOffered = cbPlayers.SelectedItem as Player;
            gbPlayerOffered.Text = PlayerOffered.Name;
            tbBalancePlayerOffered.Maximum = PlayerOffered.Balance;
            tbBalancePlayerOffered.Value = 0;
            lblBalancePlayerOffered.Text = "0$";
            tbBalancePlayerOffering.Enabled = true;
            List<PropertyTile> properties = GetPropertyList(PlayerOffered);
            cblPlayerOffered.Items.Clear();
            foreach (PropertyTile property in properties)
            {
                cblPlayerOffered.Items.Add(property);
            }
        }
        // returns all properties the player passed as arguments own thet can be traded
        // properties that have buildings(hotels or houses) can't be traded
        private List<PropertyTile> GetPropertyList(Player player)
        {
            List<PropertyTile> properties = new List<PropertyTile>();
            foreach (PropertyTile property in player.PropertiesOwned)
            {
                if (property is PropertyCity)
                {
                    if (property.State == 1 || property.State == -1)
                    {
                        properties.Add(property);
                    }
                }
                else { properties.Add(property); }
            }
            return properties;
        }
        private void tbBalancePlayerOffering_Scroll(object sender, EventArgs e)
        {
            lblBalancePlayerOffering.Text = tbBalancePlayerOffering.Value.ToString() + "$";
            //make sure only one player is trading money
            tbBalancePlayerOffered.Enabled = tbBalancePlayerOffering.Value == 0;
        }
        private void tbBalancePlayerOffered_Scroll(object sender, EventArgs e)
        {
            lblBalancePlayerOffered.Text = tbBalancePlayerOffered.Value.ToString() + "$";
            //make sure only one player is trading money
            tbBalancePlayerOffering.Enabled = tbBalancePlayerOffered.Value == 0;
        }

        private void cbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGbPlayerOffered();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnOffer_Click(object sender, EventArgs e)
        {
            BalanceOffer = tbBalancePlayerOffering.Value;
            BalanceOffer -= tbBalancePlayerOffered.Value;
            foreach (PropertyTile property in cblPlayerOffering.CheckedItems)
            {
                propertiesPlayerOffering.Add(property);
            }
            foreach (PropertyTile property in cblPlayerOffered.CheckedItems)
            {
                propertiesPlayerOffered.Add(property);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
