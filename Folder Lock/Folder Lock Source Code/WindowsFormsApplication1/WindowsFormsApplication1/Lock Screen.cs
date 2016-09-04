using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Lock_Screen : Form
    {
        public Lock_Screen()
        {
            InitializeComponent();
             
        
        }

        System_Lock sl = new System_Lock();
        

        private void ok_Click(object sender, EventArgs e)
        {
          /*  System_Lock sl = new System_Lock();
            String pas = sl.password_create();

            String mainps = password.Text;

            if (password.Text.ToString() == pas) {
                
                sl.Show();
                this.Close();
            }
            else{
                MessageBox.Show(pas);
            }*/


            if (screen_p.Text == sl.password_create()) {
                MessageBox.Show("correct");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ok_Click_1(object sender, EventArgs e)
        {

        }
    }
}
