
namespace SocialGraph
{
    partial class GUI_Mukabuku
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.graphgui2 = new SocialGraph.GraphGUI();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.activeSidebar = new System.Windows.Forms.Panel();
            this.exploreFriend = new System.Windows.Forms.Button();
            this.friendsRecomendation = new System.Windows.Forms.Button();
            this.inputGraph = new System.Windows.Forms.Button();
            this.creator = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.alertMasukkanGraf = new System.Windows.Forms.Label();
            this.dropdownPerson1 = new System.Windows.Forms.ComboBox();
            this.dropdownPerson2 = new System.Windows.Forms.ComboBox();
            this.person1Text = new System.Windows.Forms.Label();
            this.person2Text = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dfsbutton = new System.Windows.Forms.RadioButton();
            this.Bfsbutton = new System.Windows.Forms.RadioButton();
            this.buttonSubmitExplore = new System.Windows.Forms.Button();
            this.personText = new System.Windows.Forms.Label();
            this.dropdownRecommend = new System.Windows.Forms.ComboBox();
            this.buttonRecomen = new System.Windows.Forms.Button();
            this.alertExplore = new System.Windows.Forms.Label();
            this.alertRecomen = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(325, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(638, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(229, 97);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(90, 23);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Visible = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // graphgui2
            // 
            this.graphgui2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphgui2.AutoSize = true;
            this.graphgui2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.graphgui2.Location = new System.Drawing.Point(470, 165);
            this.graphgui2.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.graphgui2.Name = "graphgui2";
            this.graphgui2.Size = new System.Drawing.Size(520, 323);
            this.graphgui2.TabIndex = 5;
            this.graphgui2.Visible = false;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnter.Location = new System.Drawing.Point(544, 129);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(145, 23);
            this.buttonEnter.TabIndex = 6;
            this.buttonEnter.Text = "Visualisasi graf input";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Visible = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Clicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.activeSidebar);
            this.panel1.Controls.Add(this.exploreFriend);
            this.panel1.Controls.Add(this.friendsRecomendation);
            this.panel1.Controls.Add(this.inputGraph);
            this.panel1.Controls.Add(this.creator);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 507);
            this.panel1.TabIndex = 8;
            // 
            // activeSidebar
            // 
            this.activeSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.activeSidebar.Location = new System.Drawing.Point(4, 114);
            this.activeSidebar.Name = "activeSidebar";
            this.activeSidebar.Size = new System.Drawing.Size(10, 33);
            this.activeSidebar.TabIndex = 11;
            // 
            // exploreFriend
            // 
            this.exploreFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.exploreFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exploreFriend.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exploreFriend.FlatAppearance.BorderSize = 0;
            this.exploreFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exploreFriend.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.exploreFriend.ForeColor = System.Drawing.Color.White;
            this.exploreFriend.Location = new System.Drawing.Point(27, 267);
            this.exploreFriend.Name = "exploreFriend";
            this.exploreFriend.Size = new System.Drawing.Size(166, 60);
            this.exploreFriend.TabIndex = 13;
            this.exploreFriend.Text = "Explore Friends \r\n";
            this.exploreFriend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exploreFriend.UseVisualStyleBackColor = false;
            this.exploreFriend.Click += new System.EventHandler(this.exploreFriend_Click);
            // 
            // friendsRecomendation
            // 
            this.friendsRecomendation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.friendsRecomendation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.friendsRecomendation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.friendsRecomendation.FlatAppearance.BorderSize = 0;
            this.friendsRecomendation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friendsRecomendation.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.friendsRecomendation.ForeColor = System.Drawing.Color.White;
            this.friendsRecomendation.Location = new System.Drawing.Point(27, 201);
            this.friendsRecomendation.Name = "friendsRecomendation";
            this.friendsRecomendation.Size = new System.Drawing.Size(166, 60);
            this.friendsRecomendation.TabIndex = 12;
            this.friendsRecomendation.Text = "Friends \r\nRecomendation";
            this.friendsRecomendation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.friendsRecomendation.UseVisualStyleBackColor = false;
            this.friendsRecomendation.Click += new System.EventHandler(this.friendsRecomendation_Click);
            // 
            // inputGraph
            // 
            this.inputGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.inputGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputGraph.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.inputGraph.FlatAppearance.BorderSize = 0;
            this.inputGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputGraph.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.inputGraph.ForeColor = System.Drawing.Color.White;
            this.inputGraph.Location = new System.Drawing.Point(27, 162);
            this.inputGraph.Name = "inputGraph";
            this.inputGraph.Size = new System.Drawing.Size(166, 33);
            this.inputGraph.TabIndex = 11;
            this.inputGraph.Text = "Masukkan Graf";
            this.inputGraph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inputGraph.UseVisualStyleBackColor = false;
            this.inputGraph.Click += new System.EventHandler(this.inputGraph_Click);
            // 
            // creator
            // 
            this.creator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.creator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creator.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.creator.FlatAppearance.BorderSize = 0;
            this.creator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creator.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.creator.ForeColor = System.Drawing.Color.White;
            this.creator.Location = new System.Drawing.Point(27, 114);
            this.creator.Name = "creator";
            this.creator.Size = new System.Drawing.Size(166, 33);
            this.creator.TabIndex = 10;
            this.creator.Text = "Creator";
            this.creator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.creator.UseVisualStyleBackColor = false;
            this.creator.Click += new System.EventHandler(this.creator_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 63);
            this.label2.TabIndex = 10;
            this.label2.Text = "MukaBuku";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(197, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 25);
            this.panel2.TabIndex = 10;
            // 
            // alertMasukkanGraf
            // 
            this.alertMasukkanGraf.AutoSize = true;
            this.alertMasukkanGraf.BackColor = System.Drawing.SystemColors.Info;
            this.alertMasukkanGraf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alertMasukkanGraf.Location = new System.Drawing.Point(229, 43);
            this.alertMasukkanGraf.Name = "alertMasukkanGraf";
            this.alertMasukkanGraf.Size = new System.Drawing.Size(667, 46);
            this.alertMasukkanGraf.TabIndex = 11;
            this.alertMasukkanGraf.Text = "Masukkan file graf yang ingin diproses.\r\nPastikan anda juga menekan tombol visual" +
    "isasi agar graf dapat terproses dengan baik.";
            this.alertMasukkanGraf.Visible = false;
            // 
            // dropdownPerson1
            // 
            this.dropdownPerson1.FormattingEnabled = true;
            this.dropdownPerson1.Location = new System.Drawing.Point(305, 196);
            this.dropdownPerson1.Name = "dropdownPerson1";
            this.dropdownPerson1.Size = new System.Drawing.Size(121, 28);
            this.dropdownPerson1.TabIndex = 12;
            this.dropdownPerson1.Visible = false;
            // 
            // dropdownPerson2
            // 
            this.dropdownPerson2.FormattingEnabled = true;
            this.dropdownPerson2.Location = new System.Drawing.Point(305, 238);
            this.dropdownPerson2.Name = "dropdownPerson2";
            this.dropdownPerson2.Size = new System.Drawing.Size(121, 28);
            this.dropdownPerson2.TabIndex = 13;
            this.dropdownPerson2.Visible = false;
            // 
            // person1Text
            // 
            this.person1Text.AutoSize = true;
            this.person1Text.Location = new System.Drawing.Point(204, 199);
            this.person1Text.Name = "person1Text";
            this.person1Text.Size = new System.Drawing.Size(116, 20);
            this.person1Text.TabIndex = 14;
            this.person1Text.Text = "Choose Account";
            this.person1Text.Visible = false;
            this.person1Text.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // person2Text
            // 
            this.person2Text.AutoSize = true;
            this.person2Text.Location = new System.Drawing.Point(204, 241);
            this.person2Text.Name = "person2Text";
            this.person2Text.Size = new System.Drawing.Size(102, 20);
            this.person2Text.TabIndex = 15;
            this.person2Text.Text = "Explore friend";
            this.person2Text.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dfsbutton);
            this.groupBox1.Controls.Add(this.Bfsbutton);
            this.groupBox1.Location = new System.Drawing.Point(204, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 56);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilih algoritma pencarian";
            this.groupBox1.Visible = false;
            // 
            // Dfsbutton
            // 
            this.Dfsbutton.AutoSize = true;
            this.Dfsbutton.Location = new System.Drawing.Point(70, 22);
            this.Dfsbutton.Name = "Dfsbutton";
            this.Dfsbutton.Size = new System.Drawing.Size(56, 24);
            this.Dfsbutton.TabIndex = 1;
            this.Dfsbutton.TabStop = true;
            this.Dfsbutton.Text = "DFS";
            this.Dfsbutton.UseVisualStyleBackColor = true;
            // 
            // Bfsbutton
            // 
            this.Bfsbutton.AutoSize = true;
            this.Bfsbutton.Location = new System.Drawing.Point(6, 22);
            this.Bfsbutton.Name = "Bfsbutton";
            this.Bfsbutton.Size = new System.Drawing.Size(54, 24);
            this.Bfsbutton.TabIndex = 0;
            this.Bfsbutton.TabStop = true;
            this.Bfsbutton.Text = "BFS";
            this.Bfsbutton.UseVisualStyleBackColor = true;
            // 
            // buttonSubmitExplore
            // 
            this.buttonSubmitExplore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSubmitExplore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmitExplore.Location = new System.Drawing.Point(255, 343);
            this.buttonSubmitExplore.Name = "buttonSubmitExplore";
            this.buttonSubmitExplore.Size = new System.Drawing.Size(145, 23);
            this.buttonSubmitExplore.TabIndex = 17;
            this.buttonSubmitExplore.Text = "Explore friend";
            this.buttonSubmitExplore.UseVisualStyleBackColor = true;
            this.buttonSubmitExplore.Visible = false;
            this.buttonSubmitExplore.Click += new System.EventHandler(this.buttonSubmitExplore_Click);
            // 
            // personText
            // 
            this.personText.AutoSize = true;
            this.personText.Location = new System.Drawing.Point(204, 446);
            this.personText.Name = "personText";
            this.personText.Size = new System.Drawing.Size(105, 20);
            this.personText.TabIndex = 18;
            this.personText.Text = "Choose Person";
            this.personText.Visible = false;
            this.personText.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // dropdownRecommend
            // 
            this.dropdownRecommend.FormattingEnabled = true;
            this.dropdownRecommend.Location = new System.Drawing.Point(305, 443);
            this.dropdownRecommend.Name = "dropdownRecommend";
            this.dropdownRecommend.Size = new System.Drawing.Size(121, 28);
            this.dropdownRecommend.TabIndex = 19;
            this.dropdownRecommend.Visible = false;
            // 
            // buttonRecomen
            // 
            this.buttonRecomen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonRecomen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRecomen.Location = new System.Drawing.Point(264, 472);
            this.buttonRecomen.Name = "buttonRecomen";
            this.buttonRecomen.Size = new System.Drawing.Size(145, 23);
            this.buttonRecomen.TabIndex = 20;
            this.buttonRecomen.Text = "Get recomendation";
            this.buttonRecomen.UseVisualStyleBackColor = true;
            this.buttonRecomen.Visible = false;
            this.buttonRecomen.Click += new System.EventHandler(this.buttonRecomen_Click);
            // 
            // alertExplore
            // 
            this.alertExplore.AutoSize = true;
            this.alertExplore.BackColor = System.Drawing.SystemColors.Info;
            this.alertExplore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alertExplore.Location = new System.Drawing.Point(204, 141);
            this.alertExplore.Name = "alertExplore";
            this.alertExplore.Size = new System.Drawing.Size(306, 46);
            this.alertExplore.TabIndex = 21;
            this.alertExplore.Text = "Masukkan orang yang akan dieksplor\r\nPastikan anda sudah memasukkan graf";
            this.alertExplore.Visible = false;
            this.alertExplore.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // alertRecomen
            // 
            this.alertRecomen.AutoSize = true;
            this.alertRecomen.BackColor = System.Drawing.SystemColors.Info;
            this.alertRecomen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alertRecomen.Location = new System.Drawing.Point(204, 379);
            this.alertRecomen.Name = "alertRecomen";
            this.alertRecomen.Size = new System.Drawing.Size(268, 69);
            this.alertRecomen.TabIndex = 22;
            this.alertRecomen.Text = "Masukkan orang yang akan \r\ndicari rekomendasi Pastikan anda \r\nsudah memasukkan gr" +
    "af.";
            this.alertRecomen.Visible = false;
            // 
            // GUI_Mukabuku
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1021, 507);
            this.Controls.Add(this.alertRecomen);
            this.Controls.Add(this.alertExplore);
            this.Controls.Add(this.buttonRecomen);
            this.Controls.Add(this.dropdownRecommend);
            this.Controls.Add(this.personText);
            this.Controls.Add(this.buttonSubmitExplore);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.person2Text);
            this.Controls.Add(this.person1Text);
            this.Controls.Add(this.dropdownPerson2);
            this.Controls.Add(this.dropdownPerson1);
            this.Controls.Add(this.alertMasukkanGraf);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.graphgui2);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBox1);
            this.Name = "GUI_Mukabuku";
            this.Text = "Halo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBrowse;
        private GraphGUI graphgui2;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button creator;
        private System.Windows.Forms.Button exploreFriend;
        private System.Windows.Forms.Button friendsRecomendation;
        private System.Windows.Forms.Button inputGraph;
        private System.Windows.Forms.Panel activeSidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label alertMasukkanGraf;
        private System.Windows.Forms.ComboBox dropdownPerson1;
        private System.Windows.Forms.ComboBox dropdownPerson2;
        private System.Windows.Forms.Label person1Text;
        private System.Windows.Forms.Label person2Text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Dfsbutton;
        private System.Windows.Forms.RadioButton Bfsbutton;
        private System.Windows.Forms.Button buttonSubmitExplore;
        private System.Windows.Forms.Label personText;
        private System.Windows.Forms.ComboBox dropdownRecommend;
        private System.Windows.Forms.Button buttonRecomen;
        private System.Windows.Forms.Label alertExplore;
        private System.Windows.Forms.Label alertRecomen;
    }
}

