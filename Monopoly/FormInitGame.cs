using Monopoly.Properties;
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
    // Form used for initialization a new game
    public partial class FormInitGame : Form
    {
        int ImageIndex = 0;
        List<Image> Icons = new List<Image>();
        List<Image> IconsSmall = new List<Image>();
        public List<Player> players = new List<Player>();
        public int numDice = 1;
        public FormInitGame()
        {
            InitializeComponent();
            cbMode1.SelectedIndex = 0; // Human
            cbMode2.SelectedIndex = 1; // CPU
            cbMode3.SelectedIndex = 2; // none
            cbMode4.SelectedIndex = 2; // none
            cbDice.SelectedIndex = 0;  // 1 dice

            Icons.Add(Resources.IronMan);
            IconsSmall.Add(Resources.IronManSmall);
            Icons.Add(Resources.spiderman);
            IconsSmall.Add(Resources.spidermanSmall);
            Icons.Add(Resources.Ultron);
            IconsSmall.Add(Resources.UltronSmall);
            Icons.Add(Resources.wolverine);
            IconsSmall.Add(Resources.wolverineSmall);
            Icons.Add(Resources.WonderWoman);
            IconsSmall.Add(Resources.WonderWomanSmall);
            Icons.Add(Resources.ninjaTuttle);
            IconsSmall.Add(Resources.ninjaTuttleSmall);
            Icons.Add(Resources.batMan);
            IconsSmall.Add(Resources.batManSmall);

            BtnIcon1.Image = Icons[0];
            btnIcon2.Image = Icons[2];
            btnIcon3.Image = Icons[5];
            btnIcon4.Image = Icons[4];
        }
        private void UpdatePlayers()
        {
            players.Clear();
            players.Add(new Player(tbName1.Text, tBarBalance.Value, cbMode1.Text.Equals("CPU"),
                btnColor1.BackColor, BtnIcon1.Image, btnColor1.Image, players.Count));
            players.Add(new Player(tbName2.Text, tBarBalance.Value, cbMode2.Text.Equals("CPU"),
                btnColor2.BackColor, btnIcon2.Image, btnColor2.Image, players.Count));
            if (!cbMode3.Text.Equals("(none)"))
            {
                players.Add(new Player(tbName3.Text, tBarBalance.Value, cbMode3.Text.Equals("CPU"),
                    btnColor3.BackColor, btnIcon3.Image, btnColor3.Image, players.Count));
            }
            if (!cbMode4.Text.Equals("(none)"))
            {

                players.Add(new Player(tbName4.Text, tBarBalance.Value, cbMode4.Text.Equals("CPU"),
                btnColor4.BackColor, btnIcon4.Image, btnColor4.Image, players.Count));
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblBalance.Text = tBarBalance.Value.ToString();
        }
        private void BtnIcon1_Click(object sender, EventArgs e)
        {
            btnColor1.Image = BtnIcon_Click(sender, e);
        }
        private void btnIcon2_Click(object sender, EventArgs e)
        {
            btnColor2.Image = BtnIcon_Click(sender, e);
        }

        private void btnIcon3_Click(object sender, EventArgs e)
        {
            btnColor3.Image = BtnIcon_Click(sender, e);
        }

        private void btnIcon4_Click(object sender, EventArgs e)
        {
            btnColor4.Image = BtnIcon_Click(sender, e);
        }
        // recursive function used for changing icons on click without duplication
        private Image BtnIcon_Click(object sender, EventArgs e)
        {
            ImageIndex++;
            ImageIndex %= Icons.Count;
            Image icon = Icons[ImageIndex];
            Image iconSmall = IconsSmall[ImageIndex];
            if (UsedIcon(icon))
            {
                return BtnIcon_Click(sender, e);
            }
            (sender as Button).Image = icon;
            return iconSmall;
        }
        private bool UsedIcon(Image icon)
        {
            if (icon.Equals(BtnIcon1.Image)) { return true; }
            if (icon.Equals(btnIcon2.Image)) { return true; }
            if (icon.Equals(btnIcon3.Image)) { return true; }
            if (icon.Equals(btnIcon4.Image)) { return true; }
            return false;
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog.Color;
                (sender as Button).BackColor = color;
                UpdateTbColor();
            }
        }
        private void UpdateTbColor()
        {
            tbName1.BackColor = btnColor1.BackColor;
            tbName2.BackColor = btnColor2.BackColor;
            tbName3.BackColor = btnColor3.BackColor;
            tbName4.BackColor = btnColor4.BackColor;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            UpdatePlayers();
            numDice = cbDice.SelectedIndex + 1;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
