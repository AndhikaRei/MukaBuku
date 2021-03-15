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
    public partial class GUI_Mukabuku : Form
    {
        
        
        public void removeGraphImage(GraphGUI G)
        {
            if (G.Controls.Contains(Visualizer.viewer))
                G.Controls.Remove(Visualizer.viewer);
            if (G.Controls.Contains(Visualizer.NormalGraph))
                G.Controls.Remove(Visualizer.NormalGraph);
        }
        public void hideAll()
        {
            this.graphgui2.Hide();
            this.textBox1.Hide(); this.buttonEnter.Hide(); this.buttonBrowse.Hide(); this.alertMasukkanGraf.Hide();
            this.dropdownPerson1.Hide(); this.dropdownPerson2.Hide(); this.groupBox1.Hide(); this.buttonSubmitExplore.Hide();
            this.person1Text.Hide(); this.person2Text.Hide(); this.alertExplore.Hide();
            this.dropdownRecommend.Hide(); this.alertRecomen.Hide();this.personText.Hide(); this.buttonRecomen.Hide();
        }
        public GUI_Mukabuku()
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
            Visualizer.visualTest();
            this.graphgui2.SuspendLayout();
            removeGraphImage(graphgui2);
            this.graphgui2.Controls.Add(Visualizer.viewer);
            this.graphgui2.ResumeLayout();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonEnter_Clicked(object sender, EventArgs e)
        {
            Parser G = new Parser();
            G.readFromFile(this.textBox1.Text);
            Visualizer.visualNormal(Parser.result);
            this.graphgui2.SuspendLayout();
            removeGraphImage(graphgui2);
            this.graphgui2.Controls.Add(Visualizer.NormalGraph);
            this.graphgui2.ResumeLayout();

        }
        
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            DialogResult browseDialog = browse.ShowDialog();
            if (browseDialog == DialogResult.OK)
            {
                this.textBox1.Text = browse.FileName;
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inputGraph_Click(object sender, EventArgs e)
        {
            hideAll();
            this.graphgui2.Show();
            this.textBox1.Show(); this.buttonEnter.Show(); this.buttonBrowse.Show(); this.alertMasukkanGraf.Show();

            this.activeSidebar.Top = this.inputGraph.Top;
            this.activeSidebar.Height = this.inputGraph.Height;
            
        }

        private void creator_Click(object sender, EventArgs e)
        {
            hideAll();
            this.activeSidebar.Top = this.creator.Top;
            this.activeSidebar.Height = this.creator.Height; 
        }

        private void friendsRecomendation_Click(object sender, EventArgs e)
        {
            hideAll();
            this.dropdownRecommend.Show(); this.alertRecomen.Show(); this.personText.Show(); this.buttonRecomen.Show();
            removeGraphImage(graphgui2);
            this.activeSidebar.Top = this.friendsRecomendation.Top;
            this.activeSidebar.Height = this.friendsRecomendation.Height;
            foreach (Node person in Parser.result.persons)
            {
                if(!this.dropdownRecommend.Items.Contains(person.name))
                    this.dropdownRecommend.Items.Add(person.name);
            }
        }

        private void exploreFriend_Click(object sender, EventArgs e)
        {
            hideAll();
            this.dropdownPerson1.Show(); this.dropdownPerson2.Show(); this.groupBox1.Show(); this.buttonSubmitExplore.Show();
            this.person1Text.Show(); this.person2Text.Show(); this.alertExplore.Show(); this.graphgui2.Show();
            removeGraphImage(graphgui2);
            this.activeSidebar.Top = this.exploreFriend.Top;
            this.activeSidebar.Height = this.exploreFriend.Height;
            foreach(Node person in Parser.result.persons)
            {
                if (!this.dropdownPerson1.Items.Contains(person.name))
                    this.dropdownPerson1.Items.Add(person.name);
                if (!this.dropdownPerson2.Items.Contains(person.name))
                    this.dropdownPerson2.Items.Add(person.name);
            }

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void buttonSubmitExplore_Click(object sender, EventArgs e)
        {
            string algo = (this.Bfsbutton.Checked) ? "BFS" : "DFS";
            MessageBox.Show("Melakukan pencarian dari " + this.dropdownPerson1.Text+" ke "+this.dropdownPerson2.Text+" dengan algoritma "+algo);
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void buttonRecomen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mencari rekomendari dari " + this.dropdownRecommend.Text);
        }
    }
}
