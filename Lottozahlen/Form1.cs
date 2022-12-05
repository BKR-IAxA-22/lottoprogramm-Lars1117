using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottozahlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_zahlen_Click(object sender, EventArgs e)
        {
            int[] zahlen = new int[6];
            Random r = new Random();
            for(int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = r;
            }

        }
    }
}
