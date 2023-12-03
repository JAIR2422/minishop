using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proy_u4
{
    public partial class frmPresentacion : Form
    {
        public frmPresentacion()
        {
            InitializeComponent();
        }

        private void timersrbTimer_Tick(object sender, EventArgs e)
        {
            pbarsrbBarra.Increment(5);
            if (pbarsrbBarra.Value >= pbarsrbBarra.Maximum)
            {
                timersrbTimer.Stop();
                Program.F1 = new frmLogin();
                this.Hide();
                Program.F1.Show();
        }
        }


        private void frmPresentacion_Load(object sender, EventArgs e)
        {
            timersrbTimer.Start();

        }
    }
}
