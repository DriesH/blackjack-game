using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_game
{
    public partial class StartResetView : UserControl
    {
        StartResetController _startResetController;

        public StartResetView(StartResetController _controller)
        {
            _startResetController = _controller;

            InitializeComponent();
        }

        private void StartResetView_Load(object sender, EventArgs e)
        {

        }
    }
}
