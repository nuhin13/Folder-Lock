using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class System_Lock : Form
    {

      
  
        public System_Lock()
        {
            InitializeComponent();
           
           
        }

        private void Lock_Click(object sender, EventArgs e)
        {
        }
        
       
       
        

        public String password_create()
        {
            String pass= password.Text;
            return pass;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lock_Click_1(object sender, EventArgs e)
        {

            if (password.Text == confirm_password.Text)
            {

                // create a writer and open the file
                TextWriter tw = new StreamWriter("data.txt");

                // write a line of text to the file
                tw.WriteLine(password.Text);

                // close the stream
                tw.Close();

                Lock_Screen ls = new Lock_Screen();
                ls.Show();

               

            }
            else
            {
                MessageBox.Show("Please Enter the same password...!!!!");
                // MessageBox.Show(password_create());
            }
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
           // Form1 fm = new Form1();
            //fm.Show();
        }

    }
}
