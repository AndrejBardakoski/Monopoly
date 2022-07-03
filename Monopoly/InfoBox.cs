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
    // Form used for showing informations for (Tiles (properties or special), Players )
    public partial class InfoBox : Form
    {
        public InfoBox() { InitializeComponent(); }
        public InfoBox(PropertyTile property)
        {
            InitializeComponent();
            tbName.Text = property.Name;
            lblValue.Text = property.Value.ToString();
            tbInfo.Text = property.GetInfo();
            this.BackColor = property.GetColor();
            tbShortName.Text = property.ShortName;
            if (property.Owner == null)
            {
                lblOwner.Text = "For sale";
            }
            else
            {
                lblOwner.Text = "Owner:  " + property.Owner.Name + "  " + property.GetStatusString();

            }
        }
        public InfoBox(SpecialTile specialTile)
        {
            InitializeComponent();
            tbName.Text = specialTile.Name;
            lblValue.Visible = false;
            label1.Visible = false;
            tbInfo.Text = specialTile.GetInfo();
            tbInfo.Location = new Point(tbInfo.Location.X, 60);
            this.BackColor = Color.White;
            lblOwner.Visible = false;
            tbShortName.Visible = false;
        }
        public InfoBox(Player player)
        {
            InitializeComponent();
            tbName.Text = player.Name;
            lblValue.Text = player.Balance.ToString() + "$";
            label1.Text = "Balance:";
            lblOwner.Visible = false;
            tbShortName.Visible = false;
            tbInfo.Location = new Point(tbInfo.Location.X, 80);
            this.BackColor = player.color;
            tbInfo.Text = player.GetInfo();
        }
    }
}
