using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.View
{
    public partial class FrmQuan : Form
    {
        public FrmQuan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        int x;
        private void timer1_Tick(object sender, EventArgs e)
        {
            x = label1.Location.X;
            x--;
           label1.Location = new Point(x, label1.Location.Y);
            if (x == 0)
            {
                FrmQuan frm = new FrmQuan();
                x = frm.Size.Width;
                label1.Location = new Point(frm.Size.Width, label1.Location.Y);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
