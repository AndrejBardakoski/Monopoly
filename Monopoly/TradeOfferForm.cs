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
    //Form used for accepting or denying a trade
    public partial class TradeOfferForm : Form
    {
        public TradeOfferForm(TradeForm trade)
        {
            InitializeComponent();
            Player playerOffered = trade.PlayerOffered;
            Player playerOffering = trade.PlayerOffering;
            List<PropertyTile> propertiesOffered = trade.propertiesPlayerOffered;
            List<PropertyTile> propertiesOffering = trade.propertiesPlayerOffering;
            int balance = trade.BalanceOffer;
            lblTitle.Text = playerOffering.Name + " offered " + playerOffered.Name + " a trade:";
            gbPlayerOffered.Text = playerOffered.Name;
            gbPlayerOffering.Text = playerOffering.Name;
            foreach (PropertyTile property in propertiesOffered)
            {
                lbPlayerOffered.Items.Add(property);
            }
            foreach (PropertyTile property in propertiesOffering)
            {
                lbPlayerOffering.Items.Add(property);
            }
            if (balance > 0) { lblBalancePlayerOffering.Text = balance.ToString(); }
            else { lblBalancePlayerOffered.Text = balance.ToString(); }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
