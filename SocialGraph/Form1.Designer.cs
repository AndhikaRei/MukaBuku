
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
            this.boxExploreFriends = new System.Windows.Forms.GroupBox();
            this.pesanEksplore = new System.Windows.Forms.RichTextBox();
            this.buttonExplore = new System.Windows.Forms.Button();
            this.textPilihMenu = new System.Windows.Forms.Label();
            this.Dfsbutton = new System.Windows.Forms.RadioButton();
            this.Bfsbutton = new System.Windows.Forms.RadioButton();
            this.buttonSubmitExplore = new System.Windows.Forms.Button();
            this.alertExplore = new System.Windows.Forms.Label();
            this.boxFriendsRecomendatition = new System.Windows.Forms.GroupBox();
            this.textPilihMenuRekomen = new System.Windows.Forms.Label();
            this.BFSbuttonRekomen = new System.Windows.Forms.RadioButton();
            this.DFSbuttonRekomen = new System.Windows.Forms.RadioButton();
            this.textRecomens = new System.Windows.Forms.RichTextBox();
            this.buttonRecommen = new System.Windows.Forms.Button();
            this.alertRecomen = new System.Windows.Forms.Label();
            this.personText = new System.Windows.Forms.Label();
            this.dropdownRecommend = new System.Windows.Forms.ComboBox();
            this.boxMasukkanGraf = new System.Windows.Forms.GroupBox();
            this.creator1 = new SocialGraph.Creator();
            this.graphgui2 = new SocialGraph.GraphGUI();
            this.panel1.SuspendLayout();
            this.boxExploreFriends.SuspendLayout();
            this.boxFriendsRecomendatition.SuspendLayout();
            this.boxMasukkanGraf.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(117, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(657, 23);
            this.textBox1.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(10, 58);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(90, 23);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnter.Location = new System.Drawing.Point(319, 88);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(145, 23);
            this.buttonEnter.TabIndex = 6;
            this.buttonEnter.Text = "Visualisasi graf input";
            this.buttonEnter.UseVisualStyleBackColor = true;
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
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 53);
            this.label2.TabIndex = 10;
            this.label2.Text = "MukaBuku";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(197, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 27);
            this.panel2.TabIndex = 10;
            // 
            // alertMasukkanGraf
            // 
            this.alertMasukkanGraf.AutoSize = true;
            this.alertMasukkanGraf.BackColor = System.Drawing.SystemColors.Info;
            this.alertMasukkanGraf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alertMasukkanGraf.Location = new System.Drawing.Point(10, 18);
            this.alertMasukkanGraf.Name = "alertMasukkanGraf";
            this.alertMasukkanGraf.Size = new System.Drawing.Size(516, 34);
            this.alertMasukkanGraf.TabIndex = 11;
            this.alertMasukkanGraf.Text = "Masukkan file graf yang ingin diproses.\r\nPastikan anda juga menekan tombol visual" +
    "isasi agar graf dapat terproses dengan baik.";
            // 
            // dropdownPerson1
            // 
            this.dropdownPerson1.FormattingEnabled = true;
            this.dropdownPerson1.Location = new System.Drawing.Point(638, 18);
            this.dropdownPerson1.Name = "dropdownPerson1";
            this.dropdownPerson1.Size = new System.Drawing.Size(121, 23);
            this.dropdownPerson1.TabIndex = 12;
            // 
            // dropdownPerson2
            // 
            this.dropdownPerson2.FormattingEnabled = true;
            this.dropdownPerson2.Location = new System.Drawing.Point(638, 49);
            this.dropdownPerson2.Name = "dropdownPerson2";
            this.dropdownPerson2.Size = new System.Drawing.Size(121, 23);
            this.dropdownPerson2.TabIndex = 13;
            // 
            // person1Text
            // 
            this.person1Text.AutoSize = true;
            this.person1Text.Location = new System.Drawing.Point(525, 21);
            this.person1Text.Name = "person1Text";
            this.person1Text.Size = new System.Drawing.Size(95, 15);
            this.person1Text.TabIndex = 14;
            this.person1Text.Text = "Choose Account";
            // 
            // person2Text
            // 
            this.person2Text.AutoSize = true;
            this.person2Text.Location = new System.Drawing.Point(540, 52);
            this.person2Text.Name = "person2Text";
            this.person2Text.Size = new System.Drawing.Size(80, 15);
            this.person2Text.TabIndex = 15;
            this.person2Text.Text = "Explore friend";
            // 
            // boxExploreFriends
            // 
            this.boxExploreFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxExploreFriends.Controls.Add(this.pesanEksplore);
            this.boxExploreFriends.Controls.Add(this.buttonExplore);
            this.boxExploreFriends.Controls.Add(this.textPilihMenu);
            this.boxExploreFriends.Controls.Add(this.Dfsbutton);
            this.boxExploreFriends.Controls.Add(this.Bfsbutton);
            this.boxExploreFriends.Controls.Add(this.buttonSubmitExplore);
            this.boxExploreFriends.Controls.Add(this.person1Text);
            this.boxExploreFriends.Controls.Add(this.alertExplore);
            this.boxExploreFriends.Controls.Add(this.dropdownPerson1);
            this.boxExploreFriends.Controls.Add(this.person2Text);
            this.boxExploreFriends.Controls.Add(this.dropdownPerson2);
            this.boxExploreFriends.Location = new System.Drawing.Point(202, 80);
            this.boxExploreFriends.Name = "boxExploreFriends";
            this.boxExploreFriends.Size = new System.Drawing.Size(786, 115);
            this.boxExploreFriends.TabIndex = 16;
            this.boxExploreFriends.TabStop = false;
            this.boxExploreFriends.Text = "Explore Friends";
            this.boxExploreFriends.Visible = false;
            
            // 
            // pesanEksplore
            // 
            this.pesanEksplore.Location = new System.Drawing.Point(6, 68);
            this.pesanEksplore.Name = "pesanEksplore";
            this.pesanEksplore.Size = new System.Drawing.Size(498, 42);
            this.pesanEksplore.TabIndex = 26;
            this.pesanEksplore.Text = "<Hasil Eksplore Pertemanan>";
            // 
            // buttonExplore
            // 
            this.buttonExplore.Location = new System.Drawing.Point(638, 85);
            this.buttonExplore.Name = "buttonExplore";
            this.buttonExplore.Size = new System.Drawing.Size(121, 23);
            this.buttonExplore.TabIndex = 25;
            this.buttonExplore.Text = "Explore friend";
            this.buttonExplore.UseVisualStyleBackColor = true;
            this.buttonExplore.Click += new System.EventHandler(this.buttonSubmitExplore_Click);
            // 
            // textPilihMenu
            // 
            this.textPilihMenu.AutoSize = true;
            this.textPilihMenu.BackColor = System.Drawing.SystemColors.Info;
            this.textPilihMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPilihMenu.Location = new System.Drawing.Point(285, 19);
            this.textPilihMenu.Name = "textPilihMenu";
            this.textPilihMenu.Size = new System.Drawing.Size(219, 17);
            this.textPilihMenu.TabIndex = 24;
            this.textPilihMenu.Text = "Pilih algoritma yang ingin digunakan";
            // 
            // Dfsbutton
            // 
            this.Dfsbutton.AutoSize = true;
            this.Dfsbutton.Location = new System.Drawing.Point(285, 45);
            this.Dfsbutton.Name = "Dfsbutton";
            this.Dfsbutton.Size = new System.Drawing.Size(45, 19);
            this.Dfsbutton.TabIndex = 1;
            this.Dfsbutton.TabStop = true;
            this.Dfsbutton.Text = "DFS";
            this.Dfsbutton.UseVisualStyleBackColor = true;
            // 
            // Bfsbutton
            // 
            this.Bfsbutton.AutoSize = true;
            this.Bfsbutton.Location = new System.Drawing.Point(336, 45);
            this.Bfsbutton.Name = "Bfsbutton";
            this.Bfsbutton.Size = new System.Drawing.Size(44, 19);
            this.Bfsbutton.TabIndex = 0;
            this.Bfsbutton.TabStop = true;
            this.Bfsbutton.Text = "BFS";
            this.Bfsbutton.UseVisualStyleBackColor = true;
            // 
            // buttonSubmitExplore
            // 
            this.buttonSubmitExplore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmitExplore.Location = new System.Drawing.Point(288, -463);
            this.buttonSubmitExplore.Name = "buttonSubmitExplore";
            this.buttonSubmitExplore.Size = new System.Drawing.Size(145, 23);
            this.buttonSubmitExplore.TabIndex = 17;
            this.buttonSubmitExplore.Text = "Explore friend";
            this.buttonSubmitExplore.UseVisualStyleBackColor = true;
            this.buttonSubmitExplore.Click += new System.EventHandler(this.buttonSubmitExplore_Click);
            // 
            // alertExplore
            // 
            this.alertExplore.AutoSize = true;
            this.alertExplore.BackColor = System.Drawing.SystemColors.Info;
            this.alertExplore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alertExplore.Location = new System.Drawing.Point(6, 19);
            this.alertExplore.Name = "alertExplore";
            this.alertExplore.Size = new System.Drawing.Size(234, 34);
            this.alertExplore.TabIndex = 21;
            this.alertExplore.Text = "Masukkan orang yang akan dieksplor\r\nPastikan anda sudah memasukkan graf";
            // 
            // boxFriendsRecomendatition
            // 
            this.boxFriendsRecomendatition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxFriendsRecomendatition.Controls.Add(this.textPilihMenuRekomen);
            this.boxFriendsRecomendatition.Controls.Add(this.BFSbuttonRekomen);
            this.boxFriendsRecomendatition.Controls.Add(this.DFSbuttonRekomen);
            this.boxFriendsRecomendatition.Controls.Add(this.textRecomens);
            this.boxFriendsRecomendatition.Controls.Add(this.buttonRecommen);
            this.boxFriendsRecomendatition.Controls.Add(this.alertRecomen);
            this.boxFriendsRecomendatition.Controls.Add(this.personText);
            this.boxFriendsRecomendatition.Controls.Add(this.dropdownRecommend);
            this.boxFriendsRecomendatition.Location = new System.Drawing.Point(203, 148);
            this.boxFriendsRecomendatition.Name = "boxFriendsRecomendatition";
            this.boxFriendsRecomendatition.Size = new System.Drawing.Size(724, 348);
            this.boxFriendsRecomendatition.TabIndex = 27;
            this.boxFriendsRecomendatition.TabStop = false;
            this.boxFriendsRecomendatition.Text = "Friends Recomendation";
            this.boxFriendsRecomendatition.Visible = false;
            // 
            // textPilihMenuRekomen
            // 
            this.textPilihMenuRekomen.AutoSize = true;
            this.textPilihMenuRekomen.BackColor = System.Drawing.SystemColors.Info;
            this.textPilihMenuRekomen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPilihMenuRekomen.Location = new System.Drawing.Point(4, 126);
            this.textPilihMenuRekomen.Name = "textPilihMenuRekomen";
            this.textPilihMenuRekomen.Size = new System.Drawing.Size(219, 17);
            this.textPilihMenuRekomen.TabIndex = 26;
            this.textPilihMenuRekomen.Text = "Pilih algoritma yang ingin digunakan";
            // 
            // BFSbuttonRekomen
            // 
            this.BFSbuttonRekomen.AutoSize = true;
            this.BFSbuttonRekomen.Location = new System.Drawing.Point(5, 150);
            this.BFSbuttonRekomen.Name = "BFSbuttonRekomen";
            this.BFSbuttonRekomen.Size = new System.Drawing.Size(44, 19);
            this.BFSbuttonRekomen.TabIndex = 26;
            this.BFSbuttonRekomen.TabStop = true;
            this.BFSbuttonRekomen.Text = "BFS";
            this.BFSbuttonRekomen.UseVisualStyleBackColor = true;
            // 
            // DFSbuttonRekomen
            // 
            this.DFSbuttonRekomen.AutoSize = true;
            this.DFSbuttonRekomen.Location = new System.Drawing.Point(55, 150);
            this.DFSbuttonRekomen.Name = "DFSbuttonRekomen";
            this.DFSbuttonRekomen.Size = new System.Drawing.Size(45, 19);
            this.DFSbuttonRekomen.TabIndex = 26;
            this.DFSbuttonRekomen.TabStop = true;
            this.DFSbuttonRekomen.Text = "DFS";
            this.DFSbuttonRekomen.UseVisualStyleBackColor = true;
            // 
            // textRecomens
            // 
            this.textRecomens.Location = new System.Drawing.Point(229, 18);
            this.textRecomens.Name = "textRecomens";
            this.textRecomens.Size = new System.Drawing.Size(474, 313);
            this.textRecomens.TabIndex = 25;
            this.textRecomens.Text = "";
            // 
            // buttonRecommen
            // 
            this.buttonRecommen.Location = new System.Drawing.Point(42, 184);
            this.buttonRecommen.Name = "buttonRecommen";
            this.buttonRecommen.Size = new System.Drawing.Size(140, 23);
            this.buttonRecommen.TabIndex = 23;
            this.buttonRecommen.Text = "Get Recomendation";
            this.buttonRecommen.UseVisualStyleBackColor = true;
            this.buttonRecommen.Click += new System.EventHandler(this.buttonRecomen_Click);
            // 
            // alertRecomen
            // 
            this.alertRecomen.AutoSize = true;
            this.alertRecomen.BackColor = System.Drawing.SystemColors.Info;
            this.alertRecomen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alertRecomen.Location = new System.Drawing.Point(1, 19);
            this.alertRecomen.Name = "alertRecomen";
            this.alertRecomen.Size = new System.Drawing.Size(207, 51);
            this.alertRecomen.TabIndex = 22;
            this.alertRecomen.Text = "Masukkan orang yang akan \r\ndicari rekomendasi Pastikan anda \r\nsudah memasukkan gr" +
    "af";
            // 
            // personText
            // 
            this.personText.AutoSize = true;
            this.personText.Location = new System.Drawing.Point(0, 88);
            this.personText.Name = "personText";
            this.personText.Size = new System.Drawing.Size(86, 15);
            this.personText.TabIndex = 18;
            this.personText.Text = "Choose Person";
            // 
            // dropdownRecommend
            // 
            this.dropdownRecommend.FormattingEnabled = true;
            this.dropdownRecommend.Location = new System.Drawing.Point(93, 88);
            this.dropdownRecommend.Name = "dropdownRecommend";
            this.dropdownRecommend.Size = new System.Drawing.Size(121, 23);
            this.dropdownRecommend.TabIndex = 19;
            // 
            // boxMasukkanGraf
            // 
            this.boxMasukkanGraf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxMasukkanGraf.Controls.Add(this.buttonEnter);
            this.boxMasukkanGraf.Controls.Add(this.alertMasukkanGraf);
            this.boxMasukkanGraf.Controls.Add(this.textBox1);
            this.boxMasukkanGraf.Controls.Add(this.buttonBrowse);
            this.boxMasukkanGraf.Location = new System.Drawing.Point(202, 33);
            this.boxMasukkanGraf.Name = "boxMasukkanGraf";
            this.boxMasukkanGraf.Size = new System.Drawing.Size(809, 114);
            this.boxMasukkanGraf.TabIndex = 26;
            this.boxMasukkanGraf.TabStop = false;
            this.boxMasukkanGraf.Text = "Masukkan Graf";
            this.boxMasukkanGraf.Visible = false;
            // 
            // creator1
            // 
            this.creator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creator1.Location = new System.Drawing.Point(197, 487);
            this.creator1.Name = "creator1";
            this.creator1.Size = new System.Drawing.Size(823, 442);
            this.creator1.TabIndex = 14;
            this.creator1.Visible = false;
            // 
            // graphgui2
            // 
            this.graphgui2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphgui2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.graphgui2.Location = new System.Drawing.Point(204, 150);
            this.graphgui2.Name = "graphgui2";
            this.graphgui2.Size = new System.Drawing.Size(805, 357);
            this.graphgui2.TabIndex = 26;
            // 
            // GUI_Mukabuku
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1021, 507);
            this.Controls.Add(this.boxExploreFriends);
            this.Controls.Add(this.creator1);
            this.Controls.Add(this.boxFriendsRecomendatition);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.boxMasukkanGraf);
            this.Controls.Add(this.graphgui2);
            this.Name = "GUI_Mukabuku";
            this.Text = "GUI Mukabuku";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.boxExploreFriends.ResumeLayout(false);
            this.boxExploreFriends.PerformLayout();
            this.boxFriendsRecomendatition.ResumeLayout(false);
            this.boxFriendsRecomendatition.PerformLayout();
            this.boxMasukkanGraf.ResumeLayout(false);
            this.boxMasukkanGraf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBrowse;
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
        private System.Windows.Forms.GroupBox boxExploreFriends;
        private System.Windows.Forms.RadioButton Dfsbutton;
        private System.Windows.Forms.RadioButton Bfsbutton;
        private System.Windows.Forms.Button buttonSubmitExplore;
        private System.Windows.Forms.Label personText;
        private System.Windows.Forms.ComboBox dropdownRecommend;
        private System.Windows.Forms.Label alertExplore;
        private System.Windows.Forms.Label alertRecomen;
        private System.Windows.Forms.GroupBox boxMasukkanGraf;
        private System.Windows.Forms.Label textPilihMenu;
        private System.Windows.Forms.GroupBox boxFriendsRecomendatition;
        private System.Windows.Forms.Button buttonRecommen;
        private System.Windows.Forms.RichTextBox textRecomens;
        private Creator creator1;
        private System.Windows.Forms.Button buttonExplore;
        private GraphGUI graphgui2;
        private System.Windows.Forms.Label textPilihMenuRekomen;
        private System.Windows.Forms.RadioButton BFSbuttonRekomen;
        private System.Windows.Forms.RadioButton DFSbuttonRekomen;
        private System.Windows.Forms.RichTextBox pesanEksplore;
    }
}

