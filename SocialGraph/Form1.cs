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
            if (G.Controls.Contains(Visualizer.ExploreGraph))
                G.Controls.Remove(Visualizer.ExploreGraph);
            if (G.Controls.Contains(Visualizer.NormalGraph))
                G.Controls.Remove(Visualizer.NormalGraph);           
        }
        public void hideAll()
        {
            this.graphgui2.Hide();
            this.creator1.Hide();
            this.boxMasukkanGraf.Hide(); this.boxExploreFriends.Hide(); this.boxFriendsRecomendatition.Hide();
        }
        public GUI_Mukabuku()
        {
            InitializeComponent();
            this.creator1.Show();
            this.creator1.Top = this.panel2.Bottom;
            this.creator1.Height = this.panel1.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonEnter_Clicked(object sender, EventArgs e)
        {
            if (this.textBox1.Text != ""){
                Parser G = new Parser();
                G.readFromFile(this.textBox1.Text);
                Visualizer.visualNormal(Parser.result);
                this.graphgui2.SuspendLayout();
                removeGraphImage(graphgui2);
                this.graphgui2.Controls.Add(Visualizer.NormalGraph);
                this.graphgui2.ResumeLayout();
            } else{
                MessageBox.Show("Anda harus mengisi path filenya");
            }
            

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
            this.boxMasukkanGraf.Show(); 
            this.activeSidebar.Top = this.inputGraph.Top;
            this.activeSidebar.Height = this.inputGraph.Height;
            
        }

        private void creator_Click(object sender, EventArgs e)
        {
            hideAll();
            this.creator1.Show();
            this.creator1.Top = this.panel2.Bottom;
            this.activeSidebar.Top = this.creator.Top;
            this.activeSidebar.Height = this.creator.Height; 
        }

        private void friendsRecomendation_Click(object sender, EventArgs e)
        {
            hideAll();
            this.boxFriendsRecomendatition.Show();
            this.boxFriendsRecomendatition.Top = this.boxExploreFriends.Top;
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
            this.graphgui2.Show();
            this.boxExploreFriends.Show();
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
            Node person1 = Parser.result.persons.Find(p => p.name.Equals(dropdownPerson1.Text));
            Node person2 = Parser.result.persons.Find(p => p.name.Equals(dropdownPerson2.Text));
            bool found;
            if (dropdownPerson1.Text == "" || this.dropdownPerson2.Text == ""){
                MessageBox.Show("Anda harus mengisi semua dropdown");
            } else if (this.dropdownPerson2.Text == this.dropdownPerson1.Text){
                MessageBox.Show("Anda harus memilih dua orang yang berbeda");
            } else if (this.Bfsbutton.Checked){
                List<string> path = BFS.exploreFriend(Parser.result, person1, person2, out found);
                if (found){
                    Visualizer.visualExplore(Parser.result, path);
                    this.graphgui2.SuspendLayout();
                    removeGraphImage(graphgui2);
                    this.graphgui2.Controls.Add(Visualizer.ExploreGraph);
                    this.graphgui2.ResumeLayout();
                    this.pesanEksplore.Text = (path.Count-2)+" degree connection";  
                } else {
                    this.pesanEksplore.Text=("Tidak ada jalur koneksi yang tersedia ");
                }
            } else if (this.Dfsbutton.Checked){
                List<string> path = BFS.exploreFriend(Parser.result, person1, person2, out found);
                if (found)
                {
                    Visualizer.visualExplore(Parser.result, path);
                    this.graphgui2.SuspendLayout();
                    removeGraphImage(graphgui2);
                    this.graphgui2.Controls.Add(Visualizer.ExploreGraph);
                    this.graphgui2.ResumeLayout();
                    this.pesanEksplore.Text = (path.Count - 2) + " degree connection";
                } else{
                    this.pesanEksplore.Text = ("Tidak ada jalur koneksi yang tersedia ");
                }
            }
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void buttonRecomen_Click(object sender, EventArgs e)
        {
            if(dropdownRecommend.Text != ""){
                Node person = Parser.result.persons.Find(p => p.name.Equals(dropdownRecommend.Text));
                string rekomen = BFS.friendRecommendation(Parser.result, person);
                this.textRecomens.Text = rekomen;
            } else{
                MessageBox.Show("Anda harus mengisi dropdown");
            }
            
        }
    }
}
