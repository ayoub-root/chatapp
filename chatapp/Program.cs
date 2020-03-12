using System;
using System.Windows.Forms;

namespace chatapp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
           // Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false); 
            Form1 fr = new Form1();
           
           connection c1 = new connection(fr);
            c1.connect("rootq");

            string a =  "list" ;
            c1.wait_msg(a);
            c1.send_msg(a,"root");
            Application.Run(fr);
         
           
        }
       
    }
}
