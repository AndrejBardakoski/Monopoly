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
    public partial class GameOverForm : Form
    {
        public GameOverForm()
        {
            InitializeComponent();
        }
        public GameOverForm(String name)
        {
            InitializeComponent();
            lblName.Text = name;
            this.Height = 560;
            this.Width = 715;
        }
    }
}
