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
    public partial class Match_Password : Form
    {

        public string pass;
        public bool status;

        public Match_Password()
        {

            status = false;
            InitializeComponent();
        }

       

      
        private void Match_Password_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(pass))
            {
                status = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
