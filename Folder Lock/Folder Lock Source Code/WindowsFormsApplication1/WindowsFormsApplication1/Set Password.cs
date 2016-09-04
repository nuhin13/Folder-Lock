using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Set_Password : Form
    {
        public string path;

        public Set_Password()
        {
            InitializeComponent();
        }


        
        

        private void Set_Password_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            String p1 = textBox1.Text.ToString();

            String p2 = textBox2.Text.ToString();

            if (p1 == "" || p2   == "")
            {

                MessageBox.Show("Please enter Password", "Error");
            }

            else if (p1 == p2)
            {
                XmlDocument xmldoc = new XmlDocument();
                XmlElement xmlelem;
                XmlNode xmlnode;
                XmlText xmltext;
                xmlnode = xmldoc.CreateNode(XmlNodeType.XmlDeclaration, "", "");
                xmldoc.AppendChild(xmlnode);
                xmlelem = xmldoc.CreateElement("", "ROOT", "");
                xmltext = xmldoc.CreateTextNode(textBox1.Text);
                xmlelem.AppendChild(xmltext);
                xmldoc.AppendChild(xmlelem);
                xmldoc.Save(path + "\\p.xml");
                this.Close();
            }
           
            else
            {
                MessageBox.Show("Two text do not match", "Error");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Folder_Lock_os_ f = new Folder_Lock_os_();
            f.Show();
            this.Close();
        }
    }
}
