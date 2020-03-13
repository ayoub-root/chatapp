using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chatapp
{
    public partial class Form1 : Form
    {
        public delegate void AddListItem(String myString);
        public AddListItem myDelegate;

        public delegate void getmsg(String myString);
        public getmsg myDelegatemsg;
        public Form1()
        {
            InitializeComponent();
            //listView1.Items.Add("google");
            myDelegate = new AddListItem(AddListItemMethod);
            myDelegatemsg = new getmsg(getnewmsg);
        }
        List<TabPage> tabs = new List<TabPage>();
        public void AddListItemMethod(string myString)
        {
            listView1.Items.Add(myString);
            TabPage p = new TabPage(myString);
            p.Controls.Add(new chat());
            tabControl1.Controls.Add(p); 
            tabs.Add(p);
            
           
        }

        public void getnewmsg(string myString)
        {
          Console.WriteLine(myString + " sssqqqdddddddd");
          //  tabControl1.Controls.Add(p);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
