using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopManagementSystem
{
    public partial class Emon : Form_1
    {
        public Emon()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Firstprogressbar.Value = startpoint;
            if (Firstprogressbar.Value == 100 )
            {
                Firstprogressbar.Value = 0;
                timer1.Stop();
                Form_1 log = new Form_1();
                this.Hide();
                log.Show();
            }
        }

        private void Hide()
        {
            throw new NotImplementedException();
        }

        private void Emon_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
