using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphComponent;
using ParserComponent;

namespace SocialGraph
{
    public partial class Coba : Form
    {
        public Coba()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonEscape_Clicked(object sender, EventArgs e){
            MessageBox.Show("HIII");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonEnter_Clicked(object sender, EventArgs e)
        {
            Parser G = new Parser();
            G.readFromFile("1");
            //MessageBox.Show(Parser.files[0]);
            //string coba = "";
            //foreach (string name in Parser.uniqueName)
            //{
            //    coba += name;
            //    coba += " \n";
            //}
            //MessageBox.Show(coba);
            MessageBox.Show(Parser.result.printGraph());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
