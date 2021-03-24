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
    // Kelas yang merepresentasikan GUI
    {
        
        public void removeGraphImage(GraphGUI G)
        // Mengosongkan graf yang sudah dibuat (menghilangkan gambarnya)
        {
            if (G.Controls.Contains(Visualizer.ExploreGraph))
                G.Controls.Remove(Visualizer.ExploreGraph);
            if (G.Controls.Contains(Visualizer.NormalGraph))
                G.Controls.Remove(Visualizer.NormalGraph);           
        }
        public void hideAll()
        // Menyembunyikan komponen GUI, berguna untuk transisi sub menu
        {
            this.graphgui2.Hide();
            this.creator1.Hide();
            this.boxMasukkanGraf.Hide(); this.boxExploreFriends.Hide(); this.boxFriendsRecomendatition.Hide();
            this.BackColor = Color.FromArgb(245, 245, 245);
        }
        public GUI_Mukabuku()
        // Inisialisasi GUI
        {
            InitializeComponent();
            this.creator1.Show();
            this.creator1.Top = this.panel2.Bottom;
            this.creator1.Size = this.Size;
            this.BackColor = Color.FromArgb(178, 8, 55);
        }

        private void buttonEnter_Clicked(object sender, EventArgs e)
        // Algoritma yang berisi apa yang harus dilakukan jika tombol browse ditekan
        {
            if (this.textBox1.Text != "")
            // Validasi input nama file, input tidak boleh kosong
            {
                // Baca filenya, ubah ke graf, lalu tampilkan di layar
                bool found;
                Parser G = new Parser();
                G.readFromFile(this.textBox1.Text, out found);
                if (found)
                {
                    Visualizer.visualNormal(Parser.result);
                    this.graphgui2.SuspendLayout();
                    removeGraphImage(graphgui2);
                    this.graphgui2.Controls.Add(Visualizer.NormalGraph);
                    this.graphgui2.ResumeLayout();
                } 
                else
                {
                    MessageBox.Show("Tidak ada file dengan nama tersebut");
                }
                
            } 
            else
            // atau tampilkan pesan kesalahan
            {
                MessageBox.Show("Anda harus mengisi path filenya");
            }
            

        }
        
        private void buttonBrowse_Click(object sender, EventArgs e)
        // Membuka file explorer jika tombol browse ditekan
        {
            OpenFileDialog browse = new OpenFileDialog();
            DialogResult browseDialog = browse.ShowDialog();
            if (browseDialog == DialogResult.OK)
            {
                this.textBox1.Text = browse.FileName;
            }

            
        }


        private void inputGraph_Click(object sender, EventArgs e)
        // Berpindah ke menu masukkan graf jika menu sidebar "Masukkan graf" ditekan
        {
            // Munculkan komponen terkait
            hideAll();
            this.graphgui2.Show();
            this.boxMasukkanGraf.Show(); 
            this.activeSidebar.Top = this.inputGraph.Top;
            this.activeSidebar.Height = this.inputGraph.Height;
            
        }

        private void creator_Click(object sender, EventArgs e)
        // Berpindah ke menu masukkan creator jika menu sidebar "creator" ditekan
        {
            // Munculkan komponen terkait
            hideAll();
            this.creator1.Show();
            this.creator1.Top = this.panel2.Bottom;
            this.activeSidebar.Top = this.creator.Top;
            this.activeSidebar.Height = this.creator.Height;
            this.creator1.Size = this.Size;
            this.BackColor = Color.FromArgb(178,8,55);
        }

        private void friendsRecomendation_Click(object sender, EventArgs e)
        // Berpindah ke menu masukkan rekomendasi teman jika menu sidebar "friend recomendation" ditekan
        {
            // Munculkan komponen terkait
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
        // Berpindah ke menu masukkan explore teman jika menu sidebar "explore friend" ditekan
        {
            hideAll();
            this.graphgui2.Show();
            this.boxExploreFriends.Show();
            removeGraphImage(graphgui2);
            this.boxExploreFriends.Top = this.boxMasukkanGraf.Top;
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

        private void buttonSubmitExplore_Click(object sender, EventArgs e)
        {
            Node person1 = Parser.result.persons.Find(p => p.name.Equals(dropdownPerson1.Text));
            Node person2 = Parser.result.persons.Find(p => p.name.Equals(dropdownPerson2.Text));
            bool found;
            if (dropdownPerson1.Text == "" || this.dropdownPerson2.Text == ""){
                MessageBox.Show("Anda harus mengisi semua dropdown");
            } 
            else if (this.dropdownPerson2.Text == this.dropdownPerson1.Text)
            {
                MessageBox.Show("Anda harus memilih dua orang yang berbeda");
            } 
            else if (this.Bfsbutton.Checked)
            {
                List<string> path = BFS.exploreFriend(Parser.result, person1, person2, out found);
                if (found)
                {
                    Visualizer.visualExplore(Parser.result, path);
                    this.graphgui2.SuspendLayout();
                    removeGraphImage(graphgui2);
                    this.graphgui2.Controls.Add(Visualizer.ExploreGraph);
                    this.graphgui2.ResumeLayout();
                    string pathJoin = string.Join(" =>", path);
                    this.pesanEksplore.Text = (path.Count-2)+" degree connection"+'\n' +pathJoin;
                  
                } 
                else 
                {
                    this.pesanEksplore.Text = ("Tidak ada jalur koneksi yang tersedia ");
                    removeGraphImage(graphgui2);
                     
                }
            } else if (this.Dfsbutton.Checked){
                List<string> path = DFS.exploreFriend(Parser.result, person1, person2, out found);
                if (found)
                {
                    Visualizer.visualExplore(Parser.result, path);
                    this.graphgui2.SuspendLayout();
                    removeGraphImage(graphgui2);
                    this.graphgui2.Controls.Add(Visualizer.ExploreGraph);
                    this.graphgui2.ResumeLayout();
                    string pathJoin = string.Join(" =>", path);
                    this.pesanEksplore.Text = (path.Count - 2) + " degree connection" + '\n' + pathJoin;
                    
                } 
                else
                {
                    this.pesanEksplore.Text = ("Tidak ada jalur koneksi yang tersedia ");
                    removeGraphImage(graphgui2);
                }
            } 
            else
            {
                MessageBox.Show("Anda harus memilih algoritma pencarian");
            }
        }


        private void buttonRecomen_Click(object sender, EventArgs e)
        {
            if(dropdownRecommend.Text != "")
            {
                Node person = Parser.result.persons.Find(p => p.name.Equals(dropdownRecommend.Text));
                if (this.DFSbuttonRekomen.Checked)
                {
                    string rekomen = DFS.friendRecommendation(Parser.result, person);
                    this.textRecomens.Text = rekomen;
                } 
                else if (this.BFSbuttonRekomen.Checked)
                {
                    string rekomen = BFS.friendRecommendation(Parser.result, person);
                    this.textRecomens.Text = rekomen;
                } 
                else
                {
                    this.textRecomens.Text = "";
                    MessageBox.Show("Anda harus memilih algoritma pencarian");
                }
                
            } 
            else
            {
                MessageBox.Show("Anda harus mengisi dropdown");
            }
            
        }

    }
}
