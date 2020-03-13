using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatapp
{
    public partial class chat : UserControl
    {
      public  Form1 f;
        public chat( Form1 ff)
        {
            this.f = ff;
            
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection c1 = new connection(f);
            c1.connect("rootq");
            c1.send_msg("chat/dddd",textBox1.Text );
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
