using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    //a class representing a player
    public class Player
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        public List<PropertyTile> PropertiesOwned { get; set; } = new List<PropertyTile>();
        public int Location { get; set; } = 0;
        public bool IsCPU { get; set; }
        public Color color { get; set; }
        public Image Icon { get; set; }
        public Image IconSamll { get; set; }
        public int SkipedTurns { get; set; } = 0;
        public int PlayerID { get; set; }
        public bool InJail { get; set; } = false;
        public int NextLocation = -1;
        public bool RollAgain = false;
        public bool Bankrupt = false;
        public Player(string name, int balance, bool isCPU, Color color,
            Image image, Image imageSmall, int playerID)
        {
            Name = name;
            Balance = balance;
            IsCPU = isCPU;
            this.color = color;
            Icon = image;
            IconSamll = imageSmall;
            PlayerID = playerID;
        }
        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Properties owned:");
            for (int i = 0; i < PropertiesOwned.Count; i++)
            {
                if (i % 2 == 0) { sb.AppendLine(); }
                sb.Append(PropertiesOwned[i].Name).Append(";  ");
            }
            return sb.ToString();
        }
        public bool BuyProperty(PropertyTile tile)
        {
            if (Balance < tile.Value) { return false; }
            DialogResult result;
            if (IsCPU)
            {
                if (Balance > tile.Value + 35000) { result = DialogResult.OK; }
                else { result = DialogResult.No; }
            }
            else { result = new BuyProperty(tile).ShowDialog(); }
            if (result == DialogResult.OK)
            {
                Balance -= tile.Value;
                tile.Owner = this;
                tile.State = 1;
                PropertiesOwned.Add(tile);
                if (tile is PropertySpecial)
                {
                    UpdateStateSpecial((tile as PropertySpecial).Type);
                }
                return true;
            }
            return false;
        }
        //Update the state of special tiles owned
        public void UpdateStateSpecial(int type)
        {
            List<PropertyTile> properties = GetPropertyByGrop(-1, type);
            if (properties.Count == 0) { return; }
            foreach (PropertyTile propertyTile in PropertiesOwned)
            {
                if (propertyTile is PropertySpecial)
                {
                    if ((propertyTile as PropertySpecial).Type == type && propertyTile.State > 0)
                    {
                        propertyTile.State = properties.Count;
                    }
                }
            }
        }
        //return properties owned by group or type 
        //getMortaged -> include mortaged properties
        public List<PropertyTile> GetPropertyByGrop(int group, Nullable<int> typeSpecialTile = null,
            bool getMortgaged = false)
        {
            List<PropertyTile> result = new List<PropertyTile>();
            foreach (PropertyTile propertyTile in PropertiesOwned)
            {
                if (propertyTile is PropertyCity && typeSpecialTile == null)
                {
                    PropertyCity propertyCity = (PropertyCity)propertyTile;
                    if (propertyCity.Group == group && (propertyCity.State > 0 || getMortgaged))
                    {
                        result.Add(propertyCity);
                    }
                }
                else if (propertyTile is PropertySpecial && typeSpecialTile != null)
                {
                    PropertySpecial propertySpecial = (PropertySpecial)propertyTile;
                    if (propertySpecial.Type == typeSpecialTile
                        && (propertySpecial.State > 0 || getMortgaged))
                    {
                        result.Add(propertySpecial);
                    }
                }
            }
            return result;
        }
        public void Draw(Graphics g)
        {
            if (Bankrupt) { return; }
            Point loc = Tile.GetPointLocation(Location);
            int OffsetX, OffsetY;
            if (Location / 10 % 2 == 0)
            {
                OffsetX = Location % 10 == 0 ? 5 + PlayerID * 20 : 5;
                OffsetY = 25 + PlayerID * 15;
            }
            else
            {
                OffsetX = 25 + PlayerID * 15;
                OffsetY = Location % 10 == 0 ? 5 + PlayerID * 20 : 5;
            }
            g.DrawImageUnscaled(Icon, loc.X + OffsetX, loc.Y + OffsetY);
        }
        // move to the next tile
        public void Move()
        {
            Location++;
            if (Location >= 40) // start passed
            {
                Location %= 40;
                Balance += 20000;
            }
        }
        public void DeclareBankruptcy()
        {
            foreach (PropertyTile preperty in PropertiesOwned)
            {
                preperty.State = 0;
                preperty.Owner = null;
            }
            Bankrupt = true;
        }
        // select properties that player can mortgage
        // properties that have buildings can't be mortgaged
        // properties that are in the same group with properties that have buildings can't be mortgaged
        public void SelectCanMortgage()
        {
            foreach (PropertyTile prop in PropertiesOwned)
            {
                if (prop is PropertyCity)
                {
                    if (prop.State == 1) { prop.Selected = true; }
                    else { prop.Selected = false; }
                }
                else
                {
                    if (prop.State > 0) { prop.Selected = true; }
                    else { prop.Selected = false; }
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                DeselectCanMortgage(i);
            }
        }
        // deselect the properties that don't have buildings, but other properties from same group have
        private void DeselectCanMortgage(int group)
        {
            List<PropertyTile> properties = GetPropertyByGrop(group);
            int count = properties.Count;
            if (count >= 3 || (count >= 2 && (group == 1 || group == 8))) //group 1 and 8 have only 2 properties
            {
                int maxState, minState;
                GetMinMaxState(properties, out minState, out maxState);
                if (maxState > 1)
                {
                    foreach (PropertyCity prop in properties)
                    {
                        prop.Selected = false;
                    }
                }
            }
        }
        // return the min and max state of the properties passed as argument
        private void GetMinMaxState(List<PropertyTile> properties, out int min, out int max)
        {
            min = int.MaxValue;
            max = int.MinValue;
            foreach (PropertyCity prop in properties)
            {
                if (prop.State < min)
                {
                    min = prop.State;
                }
                if (prop.State > max)
                {
                    max = prop.State;
                }
            }
        }
        //mortgage a property  gives the player half it's value
        public void Mortgage(PropertyTile property)
        {
            Balance += property.Value / 2;
            property.State = -1;
            this.UpdateStateSpecial(0);
            this.UpdateStateSpecial(1);
        }
        //select properties that can be redeem 
        //only mortgaged properties can be redeem
        public void SelectCanRedeem()
        {
            foreach (PropertyTile prop in PropertiesOwned)
            {
                if (prop.State == -1)
                {
                    prop.Selected = true;
                }
                else
                {
                    prop.Selected = false;
                }
            }
        }
        // to redeem a property the player needs to pay half the prop value + 5000$
        public void Redeem(PropertyTile property)
        {
            if (Balance < property.Value / 2 + 5000) { return; }
            Balance -= property.Value / 2 + 5000;
            property.State = 1;
            this.UpdateStateSpecial(0);
            this.UpdateStateSpecial(1);
        }
        // select properties where buildings can be build
        // buildings can be build only if you own all properties from same group
        // buildings must be build equaly dispributed
        public void SelectCanBuild()
        {
            foreach (PropertyTile propertyTile in PropertiesOwned) { propertyTile.Selected = false; }
            for (int i = 1; i <= 8; i++)
            {
                SelectCanBuild(i);
            }
        }
        private void SelectCanBuild(int group)
        {
            List<PropertyTile> properties = GetPropertyByGrop(group);
            int count = properties.Count;
            if (count >= 3 || (count >= 2 && (group == 1 || group == 8)))//group 1 and 8 have only 2 properties
            {
                int minState, maxState;
                GetMinMaxState(properties, out minState, out maxState);
                if (minState == 6) { return; }//Hotel
                foreach (PropertyCity prop in properties)
                {
                    if (prop.State == minState) // make sure the buildings are equaly distributed
                    {
                        prop.Selected = true;
                    }
                }
            }
        }
        // player needs to pay the price of the building to build it  
        public void Build(PropertyCity property)
        {
            if (property.State < 5) //build a house
            {
                if (Balance < property.HousePrice) { return; }
                Balance -= property.HousePrice;
            }
            else //build a hotel
            {
                if (Balance < property.HotelPrice) { return; }
                Balance -= property.HotelPrice;
            }
            property.State += 1;
        }
        // select properties where buildings can be sold
        // to sell a building, a player must own a building
        // buildings must be sold equaly dispributed
        public void SelectCanSell()
        {
            foreach (PropertyTile propertyTile in PropertiesOwned) { propertyTile.Selected = false; }
            for (int i = 1; i <= 8; i++)
            {
                SelectCanSell(i);
            }
        }
        private void SelectCanSell(int group)
        {
            List<PropertyTile> properties = GetPropertyByGrop(group);
            int count = properties.Count;
            if (count >= 3 || (count >= 2 && (group == 1 || group == 8)))//group 1 and 8 have only 2 properties
            {
                int minState, maxState;
                GetMinMaxState(properties, out minState, out maxState);
                if (maxState == 1) { return; }//no houses
                foreach (PropertyCity prop in properties)
                {
                    if (prop.State == maxState)
                    {
                        prop.Selected = true;
                    }
                }
            }
        }
        // player recive half the price of the building for selling it  
        public void Sell(PropertyCity property)
        {
            if (property.State < 6)
            {
                Balance += property.HousePrice / 2;
            }
            else
            {
                Balance += property.HotelPrice / 2;
            }
            property.State -= 1;
        }
        public PropertyTile GetFirstSelected()
        {
            foreach (PropertyTile property in PropertiesOwned)
            {
                if (property.Selected) { return property; }
            }
            return null;
        }
        public void Trade(TradeForm trade)
        {
            Player playerOffered = trade.PlayerOffered;
            List<PropertyTile> propertiesPlayerOffering = trade.propertiesPlayerOffering;
            List<PropertyTile> propertiesPlayerOffered = trade.propertiesPlayerOffered;
            int balancePlayerOffering = trade.BalanceOffer;
            Trade(playerOffered, propertiesPlayerOffering, propertiesPlayerOffered, balancePlayerOffering);
        }
        public void Trade(Player playerOffered, List<PropertyTile> propertiesPlayerOffering
            , List<PropertyTile> propertiesPlayerOffered, int balancePlayerOffering)
        {
            foreach (PropertyTile property in propertiesPlayerOffering)
            {
                property.Owner = playerOffered;
                playerOffered.PropertiesOwned.Add(property);
                this.PropertiesOwned.Remove(property);
            }
            foreach (PropertyTile property in propertiesPlayerOffered)
            {
                property.Owner = this;
                this.PropertiesOwned.Add(property);
                playerOffered.PropertiesOwned.Remove(property);
            }
            this.Balance -= balancePlayerOffering;
            playerOffered.Balance += balancePlayerOffering;
            this.UpdateStateSpecial(0);
            this.UpdateStateSpecial(1);
            playerOffered.UpdateStateSpecial(0);
            playerOffered.UpdateStateSpecial(1);
            MessageBox.Show(Name + " Made a trade with " + playerOffered.Name, "Trade Completed");
        }
        // function that makes a CPU player decide if he accpets the offered trade 
        public bool TradeDecision(TradeForm trade)
        {
            List<PropertyTile> propertiesPlayerOffering = trade.propertiesPlayerOffering;
            List<PropertyTile> propertiesPlayerOffered = trade.propertiesPlayerOffered;
            int balanceOffer = trade.BalanceOffer;

            int ValuePlayerOffering = 0;
            int ValuePlayerOffered = 0;
            int BalancePlayerOffering = 0;
            int BalancePlayerOffered = 0;
            foreach (PropertyTile property in propertiesPlayerOffering)
            {
                ValuePlayerOffering += property.Value / (property.State == -1 ? 2 : 1);
            }
            foreach (PropertyTile property in propertiesPlayerOffered)
            {
                ValuePlayerOffered += property.Value / (property.State == -1 ? 2 : 1);
            }
            if (balanceOffer > 0) { BalancePlayerOffering += balanceOffer; }
            else { BalancePlayerOffered -= balanceOffer; }
            if (ValuePlayerOffered + BalancePlayerOffered == 0) { return true; }//CPU give neither money or property
            if (BalancePlayerOffered == 0 && ValuePlayerOffering == 0) //CPU don't give money (selling property)
            {
                if (BalancePlayerOffering - ValuePlayerOffered >= 100000) { return true; }
                if (BalancePlayerOffering >= ValuePlayerOffered * 2 + 25000) { return true; }
                return false;
            }
            if (BalancePlayerOffered == 0) //CPU don't give money (trading prop)
            {
                if (BalancePlayerOffering + ValuePlayerOffering - ValuePlayerOffered >= 70000) { return true; }
                if (BalancePlayerOffering + ValuePlayerOffering >= ValuePlayerOffered * 2) { return true; }
                return false;
            }
            if (ValuePlayerOffered == 0) //CPU don't give property
            {
                if (this.Balance < BalancePlayerOffered + 50000) { return false; }
                if (BalancePlayerOffered <= ValuePlayerOffering) { return true; }
                return false;
            }
            else
            {
                if (this.Balance < BalancePlayerOffered + 40000) { return false; }
                if (ValuePlayerOffering - ValuePlayerOffered + BalancePlayerOffered >= 50000) { return true; }
                if (ValuePlayerOffering >= ValuePlayerOffered * 2 + BalancePlayerOffered) { return true; }
            }
            return false;
        }
        // trade offer between 2 CPU players
        // returns true if a trade is made
        public bool TradeCPU(List<Tile> Map)
        {
            if (Balance > 150000)
            {
                for (int i = 1; i <= 10; i++)
                {
                    PropertyTile propertyPlayerOffered;
                    if (i >= 9) { propertyPlayerOffered = GetValuableProperty(-1, Map, i - 9); }
                    else { propertyPlayerOffered = GetValuableProperty(i, Map); }
                    if (propertyPlayerOffered != null && propertyPlayerOffered.Owner
                        != null && propertyPlayerOffered.Owner.IsCPU)
                    {
                        List<PropertyTile> propertiesPlayerOffered = new List<PropertyTile>();
                        List<PropertyTile> propertiesPlayerOffering = new List<PropertyTile>();
                        int balancePlayerOffering = 0;
                        propertiesPlayerOffered.Add(propertyPlayerOffered);

                        int group;
                        if (i >= 9) { group = (propertyPlayerOffered as PropertySpecial).Type; }
                        else { group = (propertyPlayerOffered as PropertyCity).Group; }
                        Player playerOffered = propertyPlayerOffered.Owner;
                        if (Balance >= 300000 && playerOffered.Balance < 150000)
                        {
                            balancePlayerOffering = propertyPlayerOffered.Value + 100000;
                            this.Trade(playerOffered, propertiesPlayerOffering
                                , propertiesPlayerOffered, balancePlayerOffering);
                            return true;
                        }
                        if (playerOffered.Balance < 100000) { continue; }
                        PropertyTile propertyPlayerOffering =
                            playerOffered.GetValuableProperty(Map, this, group);
                        if (propertyPlayerOffering != null)
                        {
                            balancePlayerOffering = propertyPlayerOffered.Value - propertyPlayerOffering.Value;
                            balancePlayerOffering *= 2;
                            propertiesPlayerOffering.Add(propertyPlayerOffering);
                            this.Trade(playerOffered, propertiesPlayerOffering
                                , propertiesPlayerOffered, balancePlayerOffering);
                            return true;
                        }
                        propertyPlayerOffering = GetNotValuabeProperty();
                        if (propertyPlayerOffering != null)
                        {
                            balancePlayerOffering = propertyPlayerOffered.Value * 2 - propertyPlayerOffering.Value + 50000;
                            propertiesPlayerOffering.Add(propertyPlayerOffering);
                            this.Trade(playerOffered, propertiesPlayerOffering
                                , propertiesPlayerOffered, balancePlayerOffering);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        // Returns a property the player don't own but is of big value (same group)
        private PropertyTile GetValuableProperty(List<Tile> Map, Player owner = null, int excludeGroup = -1)
        {
            PropertyTile property = null;
            for (int i = 1; i <= 8; i++)
            {
                if (i == excludeGroup) { continue; }
                property = GetValuableProperty(i, Map, null, owner);
                if (property != null) { return property; }
            }
            if (excludeGroup != 0)
            {
                property = GetValuableProperty(-1, Map, 0, owner);
                if (property != null) { return property; }
            }
            if (excludeGroup != 1)
                property = GetValuableProperty(-1, Map, 1, owner);
            return property;
        }
        private PropertyTile GetValuableProperty(int group, List<Tile> Map
            , Nullable<int> typeSpecial = null, Player owner = null)
        {
            List<PropertyTile> properties;
            properties = GetPropertyByGrop(group, typeSpecial, true);
            int count = properties.Count;
            if (typeSpecial == null && (count == 2 || (count == 1 && (group == 1 || group == 8))))
            {
                foreach (Tile tile in Map)
                {
                    if (tile is PropertyCity)
                    {
                        PropertyCity propertyCity = (PropertyCity)tile;
                        if (owner != null)
                        {
                            if (propertyCity.Group == group && propertyCity.Owner != null && propertyCity.Owner.Equals(owner))
                            {
                                return propertyCity;
                            }
                        }
                        else if (propertyCity.Group == group && propertyCity.Owner != null && !propertyCity.Owner.Equals(this))
                        {
                            return propertyCity;
                        }
                    }
                }
            }
            else if (typeSpecial != null && ((count == 1 && typeSpecial == 1) || count == 2 || count == 3))
            {
                foreach (Tile tile in Map)
                {
                    if (tile is PropertySpecial)
                    {
                        PropertySpecial propertySpecial = (PropertySpecial)tile;
                        if (owner != null)
                        {
                            if (propertySpecial.Type == typeSpecial && propertySpecial.Owner != null
                                && propertySpecial.Owner.Equals(owner))
                            {
                                return propertySpecial;
                            }
                        }
                        else if (propertySpecial.Type == typeSpecial && propertySpecial.Owner != null
                            && !propertySpecial.Owner.Equals(this))
                        {
                            return propertySpecial;
                        }
                    }
                }
            }
            return null;
        }
        // Returns a property the player own, but it isn't of big value (same group)
        public PropertyTile GetNotValuabeProperty()
        {
            for (int i = 2; i <= 8; i++)// 2-7 ->check the groups that have 3 cities or 8-> airlines  
            {
                List<PropertyTile> properties;
                if (i == 8) { properties = GetPropertyByGrop(-1, 0, true); }
                else { properties = GetPropertyByGrop(i, null, true); }
                if (properties.Count == 1)
                {
                    return properties[0];
                }
            }
            return null;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
