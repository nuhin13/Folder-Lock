using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Folder_Lock : Form
    {
        public Folder_Lock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            

            if (txtFilePath.Text.Length > 0)
            {
                //this.timer1.Start();
                try
                {
                    string folderPath = txtFilePath.Text;
                    string adminUserName = Environment.UserName;
                   // MessageBox.Show(adminUserName, "Lock System",
                     //                       MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                    FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.AddAccessRule(fsa);
                    Directory.SetAccessControl(folderPath, ds);
                    
                   

                    MessageBox.Show("Locked", "Lock System",
                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }

                catch
                {
                    MessageBox.Show("Please Input Some Valid Folder Path", "Lock System",
                                       MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            else {
                MessageBox.Show("Please Input Some Valid Folder Path", "Lock System",
                                       MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text.Length > 0)
            {
                try
                {
                    string folderPath = txtFilePath.Text;
                    string adminUserName = Environment.UserName;
                    DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                    FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.RemoveAccessRule(fsa);
                    Directory.SetAccessControl(folderPath, ds);
                    //this.timer1.Start();
                    MessageBox.Show("Unlocked", "Lock System",
                                             MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Please Input Some Valid Folder Path", "Lock System",
                                       MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Input Some Valid Folder Path", "Lock System",
                                       MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
           // Form1 fm = new Form1();
            //fm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(4);
           
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
