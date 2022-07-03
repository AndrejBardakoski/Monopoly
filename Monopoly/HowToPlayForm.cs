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
    public partial class HowToPlayForm : Form
    {
        List<string> pages = new List<string>();
        int pageNum = 0;
        public HowToPlayForm()
        {
            InitializeComponent();
            GeneratePages();
            UpdateAvailability();
            UpdateLabel();
            tbText.Text = pages[0];
        }
        private void GeneratePages()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("WELCOME TO MONOPOLY").AppendLine();
            sb.Append("Monopoly is a popular board game. In the game, players roll dice to move around the game board, buying and trading properties, and developing them with houses and hotels. Players collect rent from their opponents, with the goal being to drive them into bankruptcy.");
            sb.AppendLine().AppendLine().Append("BEGINING").AppendLine();
            sb.Append("Choose the players name, icon , color, and mode (Human, CPU – CPU controlled player, none). Then choose the starting balance 300.000$ is recommended. Then choose the number of dice (one, two, or 2+1 special). Click on the button “Start Game” to start ");
            pages.Add(sb.ToString());
            sb.Clear();
            sb.Append("MAP").AppendLine();
            sb.Append("The map is made of 40 tiles which 22 are city properties divided into 8 groups, 4 airline properties and 2 utility properties, 1 Start tile, 1 Jail tile, 1 Parking tile, 1 go to jail tile, 1bingo tile, 1 tax tile, and 6 surprises tiles");
            sb.AppendLine().AppendLine().Append("PROPERTIES").AppendLine();
            sb.Append("When the player steps on a property that is not owned, he has an option to buy it for a certain price.If the property is owned, the player must pay a certain rent to the owner.Exception of this rule is if the owner is in jail rent is not paid, also if the property is mortgaged rent is not paid");
            sb.AppendLine().Append("To get property information like name, value, owner, rent price, etc. Just click on the property on the map");
            pages.Add(sb.ToString());
            sb.Clear();
            sb.Append("SPECIAL PROPERTIES:").AppendLine();
            sb.Append("AIRLINES").AppendLine();
            sb.Append("There are four airline properties, the more airlines the player own the higher rent it gets from them.");
            sb.AppendLine().AppendLine().Append("UTILITIES").AppendLine();
            sb.Append("There are two utilities. If the player owns both of them the rent is higher.");
            sb.AppendLine().AppendLine().Append("DICE ROLL").AppendLine();
            sb.Append("To roll the dice click on the button dice roll.The player token(icon) will automatically move forward on the map as many tiles as the dice indicates.");
            pages.Add(sb.ToString());
            sb.Clear();
            sb.Append("SPECIAL TILES:").AppendLine();
            sb.Append("START").AppendLine();
            sb.Append("When a player passes this tile it gets 20.000$").AppendLine().AppendLine();
            sb.Append("JAIL").AppendLine();
            sb.Append("When a player step on this tile must pay 50.000$ to get out of Jail or miss 3 turns");
            sb.AppendLine().AppendLine().Append("GO TO JAIL").AppendLine();
            sb.Append("When a player step on this tile must go to jail").AppendLine().AppendLine();
            sb.Append("PARKING").AppendLine();
            sb.Append("When a player step on this tile must skip one turn");
            pages.Add(sb.ToString());
            sb.Clear();
            sb.Append("SPECIAL TILES:").AppendLine();
            sb.Append("BINGO").AppendLine().AppendLine();
            sb.Append("When a player step on this tile receives 50.000$").AppendLine().AppendLine();
            sb.Append("TAX").AppendLine();
            sb.Append("When a player step on this tile must pay 25.000$").AppendLine().AppendLine();
            sb.Append("SUPRISE").AppendLine();
            sb.Append("When a player step on this tile either lose / win random amount of money, or move forward/ backward random number of tiles, or skip random number of turns, or can roll again.");
            pages.Add(sb.ToString());
            sb.Clear();
            sb.Append("BUILDING HOUSES/HOTELS").AppendLine().AppendLine();
            sb.Append("Houses can only be built if the player is owner of all properties of the same group(color). Building a house / hotel cost a certain price. Houses must be built evenly distributed. There can be maximum four houses on a property after that, hotel can be built. Hotel can be built only if all properties of the same group have four houses built.");
            sb.AppendLine().AppendLine();
            sb.Append("To build a house click on the build button then all the properties where you can build buildings will be marked on the map then just click on a marked property to build a house / hotel");
            pages.Add(sb.ToString());
            sb.Clear();
            sb.Append("SELLING HOUSES/HOTELS").AppendLine().AppendLine();
            sb.Append("Houses / hotels are sold for half the build price. Houses / hotels must be sold evenly distributed.");
            sb.AppendLine().AppendLine();
            sb.Append("To sell a house click on the sell button then all the properties where you can sell a building will be marked on the map then just click on a marked property to sell a house / hotel.");
            pages.Add(sb.ToString());
            sb.Clear();
            sb.Append("MORTGAGE").AppendLine().AppendLine();
            sb.Append("A property can be mortgaged only if there are no buildings built on any of the properties of the same group.When a player mortgage a property he receives half its value.The player can’t receive rent from mortgaged properties. Also, if a special property is mortgaged the player receive rents from the other special properties without counting the mortgaged ones.");
            sb.AppendLine().AppendLine();
            sb.Append("To mortgage a property, click on the mortgage button then all the properties that can be mortgaged will be marked on the map just click on a marked property to mortgage it.");
            pages.Add(sb.ToString());
            sb.Clear();
            sb.Append("REDEEM").AppendLine().AppendLine();
            sb.Append("Redeem a mortgaged property will cost the player half the property value + 5000$");
            sb.AppendLine().AppendLine();
            sb.Append("To redeem a mortgaged property click on the redeem button then all the properties the can be redeem will be marked on the map just click on a marked property to redeem it.");
            pages.Add(sb.ToString());
            sb.Clear();
            sb.Append("TRADE:").AppendLine().AppendLine();
            sb.Append("A trade can be made between two players.Players can trade properties and/or money. Properties can be trade only if there are not built houses on them.");
            sb.AppendLine().AppendLine();
            sb.Append("To offer a trade click on the trade button. A trade form will open where you can choose the player you want to trade with. Also in this form you can check(select) all the properties you want to give or receive and the amount of money. Then click offer trade button to make the offer.After this a form will open where the other player can decide if he accepts your offer or no.");
            pages.Add(sb.ToString());
            sb.Clear();
            sb.Append("BANKRUPT").AppendLine().AppendLine();
            sb.Append("When a player’s balance goes negative, he must either sell building, or mortgage properties, or make trade in order to make his balance positive again.If a player fails to make his balance positive, he must declare bankruptcy all his properties will be returned to the bank(marked as not owned) and the game is over for that player.");
            sb.AppendLine().AppendLine();
            sb.Append("GAME OVER").AppendLine();
            sb.Append("The game ends when all players but one declares bankruptcy. And the remaining player is the winner.");
            pages.Add(sb.ToString());
            sb.Clear();
            sb.Append("CPU").AppendLine().AppendLine();
            sb.Append("If the player mode is CPU, then it is CPU controlled player.The CPU player will automatically roll the dice, end its turn, building/ selling houses, mortgaging / redeeming properties, making trades, making decisions like buying a property paying money to get out or jail and more.");
            pages.Add(sb.ToString());
            sb.Clear();
            sb.Append("SPECIAL DIE:").AppendLine().AppendLine();
            sb.Append("The special die has 6 sides: Stop, roll again, go to next, surprise, multiply and minimum.");
            sb.AppendLine().AppendLine();
            sb.Append("STOP - the player loses its turn").AppendLine();
            sb.Append("ROLL AGAIN – the player can roll again").AppendLine();
            sb.Append("GO TO NEXT – the player go to next unoccupied property").AppendLine();
            sb.Append("SURPRISE - the player does the same action like stepping on surprise tile").AppendLine();
            sb.Append("MULTIPLY – the value of the other 2 dice is multiplied").AppendLine();
            sb.Append("MINIMUM – the minimal value of the 2 dice is taken into calculations").AppendLine();
            pages.Add(sb.ToString());
            sb.Clear();
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            tbText.Text = pages[--pageNum];
            UpdateAvailability();
            UpdateLabel();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            tbText.Text = pages[++pageNum];
            UpdateAvailability();
            UpdateLabel();
        }
        private void UpdateAvailability()
        {
            if (pageNum == 0) { btnPrev.Enabled = false; } else { btnPrev.Enabled = true; }
            if (pageNum == pages.Count - 1) { btnNext.Enabled = false; } else { btnNext.Enabled = true; }
        }
        public void UpdateLabel()
        {
            lblPageNum.Text = "Page: " + (pageNum + 1) + "/" + pages.Count;
        }
    }
}
