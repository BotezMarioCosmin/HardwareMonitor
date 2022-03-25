using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareMonitor
{
    public partial class Startup : Form
    {
        
        public Startup()
        {
            InitializeComponent();

        }

        private void StartupTimer_Tick(object sender, EventArgs e)
        {
            progressBar1.Step = 1;
            progressBar1.PerformStep();
            if (progressBar1.Value == 100)
            {
                StartupTimer.Stop();
                this.Hide();
            }

        }
    }
}
