using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using minesweeper.Properties;

namespace minesweeper
{
    public partial class ScoresForm : Form
    {
        public ScoresForm()
        {
            InitializeComponent();
            DIsplayScores();
        }
        public void DIsplayScores()
        {
            foreach (var entry in Settings.Default.ListOfScores)
            {

            }
        }
    }
}
