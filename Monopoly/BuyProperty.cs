using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Monopoly
{
    // Form used for buying properties
    public partial class BuyProperty : Monopoly.InfoBox
    {
        public BuyProperty()
        {
            InitializeComponent();
        }
        public BuyProperty(PropertyTile property) : base(property)
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
