using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms2
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value<100)
            {
                progressBar1.Value += progressBar1.Step;
            }
            else 
            {
                form1 form1 = new form1();
                form1.Show();
                this.Hide();
                timer1.Stop();

            }
        }

        private void loading_Load(object sender, EventArgs e)
        {

        }
    }
}
