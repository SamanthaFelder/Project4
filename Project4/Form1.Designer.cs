namespace Project4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.genreNameComboBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.genreCodeTextBox = new System.Windows.Forms.TextBox();
            this.genreDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.deleteGenreButton = new System.Windows.Forms.Button();
            this.modifyGenreButton = new System.Windows.Forms.Button();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.memberDOBTextBox = new System.Windows.Forms.TextBox();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.deleteMemberButton = new System.Windows.Forms.Button();
            this.modifyMemberButton = new System.Windows.Forms.Button();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.moviesListView = new System.Windows.Forms.ListView();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.moviesPictureBox = new System.Windows.Forms.PictureBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.deleteMovieButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.modifyMovieButton = new System.Windows.Forms.Button();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.memberNameComboBox = new System.Windows.Forms.ComboBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.memberTypeComboBox = new System.Windows.Forms.ComboBox();
            this.memberListBox = new System.Windows.Forms.ListBox();
            this.movieMemberListBox = new System.Windows.Forms.ListBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.addMemberToMovieButton = new System.Windows.Forms.Button();
            this.removeMemberButton = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.memberFieldTextBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.memberDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.moviesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // genreNameComboBox
            // 
            this.genreNameComboBox.FormattingEnabled = true;
            this.genreNameComboBox.Location = new System.Drawing.Point(166, 26);
            this.genreNameComboBox.Name = "genreNameComboBox";
            this.genreNameComboBox.Size = new System.Drawing.Size(147, 21);
            this.genreNameComboBox.TabIndex = 186;
            this.genreNameComboBox.SelectedIndexChanged += new System.EventHandler(this.genreNameComboBox_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(57, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 185;
            this.label18.Text = "genre code";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 184;
            this.label17.Text = "genre name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 183;
            this.label16.Text = "genre description";
            // 
            // genreCodeTextBox
            // 
            this.genreCodeTextBox.Location = new System.Drawing.Point(166, 55);
            this.genreCodeTextBox.Name = "genreCodeTextBox";
            this.genreCodeTextBox.Size = new System.Drawing.Size(147, 20);
            this.genreCodeTextBox.TabIndex = 182;
            // 
            // genreDescriptionTextBox
            // 
            this.genreDescriptionTextBox.Location = new System.Drawing.Point(166, 83);
            this.genreDescriptionTextBox.Name = "genreDescriptionTextBox";
            this.genreDescriptionTextBox.Size = new System.Drawing.Size(147, 20);
            this.genreDescriptionTextBox.TabIndex = 181;
            // 
            // deleteGenreButton
            // 
            this.deleteGenreButton.Location = new System.Drawing.Point(242, 121);
            this.deleteGenreButton.Name = "deleteGenreButton";
            this.deleteGenreButton.Size = new System.Drawing.Size(110, 25);
            this.deleteGenreButton.TabIndex = 180;
            this.deleteGenreButton.Text = "Delete genre";
            this.deleteGenreButton.UseVisualStyleBackColor = true;
            this.deleteGenreButton.Click += new System.EventHandler(this.deleteGenreButton_Click);
            // 
            // modifyGenreButton
            // 
            this.modifyGenreButton.Location = new System.Drawing.Point(126, 121);
            this.modifyGenreButton.Name = "modifyGenreButton";
            this.modifyGenreButton.Size = new System.Drawing.Size(110, 25);
            this.modifyGenreButton.TabIndex = 179;
            this.modifyGenreButton.Text = "Modify genre";
            this.modifyGenreButton.UseVisualStyleBackColor = true;
            this.modifyGenreButton.Click += new System.EventHandler(this.modifyGenreButton_Click);
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(10, 121);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(110, 25);
            this.addGenreButton.TabIndex = 178;
            this.addGenreButton.Text = "Add genre";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 177;
            this.label7.Text = "genre info";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(979, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 176;
            this.label19.Text = "Picture";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 545);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 175;
            this.label15.Text = "members DOB";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 517);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 174;
            this.label14.Text = "members ID";
            // 
            // memberDOBTextBox
            // 
            this.memberDOBTextBox.Location = new System.Drawing.Point(168, 541);
            this.memberDOBTextBox.Name = "memberDOBTextBox";
            this.memberDOBTextBox.Size = new System.Drawing.Size(144, 20);
            this.memberDOBTextBox.TabIndex = 173;
            this.memberDOBTextBox.Tag = "";
            this.memberDOBTextBox.Text = "YYYY-MM-DD";
            this.memberDOBTextBox.Enter += new System.EventHandler(this.memberDOBTextBox_Enter);
            this.memberDOBTextBox.Leave += new System.EventHandler(this.memberDOBTextBox_Leave);
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.Location = new System.Drawing.Point(168, 513);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(144, 20);
            this.memberIDTextBox.TabIndex = 172;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(164, 435);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 171;
            this.label13.Text = "member info";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(165, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 170;
            this.label12.Text = "Movies info";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(166, 213);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(146, 20);
            this.idTextBox.TabIndex = 169;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 168;
            this.label11.Text = "Movies ID";
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.Location = new System.Drawing.Point(243, 656);
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(110, 25);
            this.deleteMemberButton.TabIndex = 167;
            this.deleteMemberButton.Text = "Delete member";
            this.deleteMemberButton.UseVisualStyleBackColor = true;
            this.deleteMemberButton.Click += new System.EventHandler(this.deleteMemberButton_Click);
            // 
            // modifyMemberButton
            // 
            this.modifyMemberButton.Location = new System.Drawing.Point(127, 656);
            this.modifyMemberButton.Name = "modifyMemberButton";
            this.modifyMemberButton.Size = new System.Drawing.Size(110, 25);
            this.modifyMemberButton.TabIndex = 166;
            this.modifyMemberButton.Text = "Modify members";
            this.modifyMemberButton.UseVisualStyleBackColor = true;
            this.modifyMemberButton.Click += new System.EventHandler(this.modifyMemberButton_Click);
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(10, 656);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(110, 25);
            this.addMemberButton.TabIndex = 165;
            this.addMemberButton.Text = "Add Members";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 460);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 164;
            this.label10.Text = "members name";
            // 
            // moviesListView
            // 
            this.moviesListView.HideSelection = false;
            this.moviesListView.Location = new System.Drawing.Point(356, 26);
            this.moviesListView.Name = "moviesListView";
            this.moviesListView.Size = new System.Drawing.Size(240, 599);
            this.moviesListView.TabIndex = 160;
            this.moviesListView.UseCompatibleStateImageBehavior = false;
            this.moviesListView.SelectedIndexChanged += new System.EventHandler(this.moviesListView_SelectedIndexChanged);
            // 
            // imageTextBox
            // 
            this.imageTextBox.Location = new System.Drawing.Point(166, 353);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(146, 20);
            this.imageTextBox.TabIndex = 159;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 158;
            this.label6.Text = "Movies image path";
            // 
            // moviesPictureBox
            // 
            this.moviesPictureBox.Location = new System.Drawing.Point(872, 26);
            this.moviesPictureBox.Name = "moviesPictureBox";
            this.moviesPictureBox.Size = new System.Drawing.Size(269, 598);
            this.moviesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviesPictureBox.TabIndex = 157;
            this.moviesPictureBox.TabStop = false;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(166, 325);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(146, 20);
            this.ratingTextBox.TabIndex = 156;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(166, 299);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(146, 20);
            this.lengthTextBox.TabIndex = 154;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(166, 271);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(146, 20);
            this.yearTextBox.TabIndex = 153;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(166, 243);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(146, 20);
            this.nameTextBox.TabIndex = 152;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 151;
            this.label8.Text = "Movies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 150;
            this.label5.Text = "Movies rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 149;
            this.label4.Text = "members type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 148;
            this.label3.Text = "Movies length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 147;
            this.label2.Text = "Movies year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 146;
            this.label1.Text = "Movies title";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(359, 656);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(110, 25);
            this.ExitButton.TabIndex = 145;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // deleteMovieButton
            // 
            this.deleteMovieButton.Location = new System.Drawing.Point(242, 390);
            this.deleteMovieButton.Name = "deleteMovieButton";
            this.deleteMovieButton.Size = new System.Drawing.Size(110, 25);
            this.deleteMovieButton.TabIndex = 144;
            this.deleteMovieButton.Text = "Delete movie";
            this.deleteMovieButton.UseVisualStyleBackColor = true;
            this.deleteMovieButton.Click += new System.EventHandler(this.deleteMovieButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(476, 656);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(110, 25);
            this.clearButton.TabIndex = 143;
            this.clearButton.Text = "Clear ";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // modifyMovieButton
            // 
            this.modifyMovieButton.Location = new System.Drawing.Point(125, 390);
            this.modifyMovieButton.Name = "modifyMovieButton";
            this.modifyMovieButton.Size = new System.Drawing.Size(110, 25);
            this.modifyMovieButton.TabIndex = 142;
            this.modifyMovieButton.Text = "Modify movies";
            this.modifyMovieButton.UseVisualStyleBackColor = true;
            this.modifyMovieButton.Click += new System.EventHandler(this.modifyMovieButton_Click);
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(9, 390);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(110, 25);
            this.addMovieButton.TabIndex = 141;
            this.addMovieButton.Text = "Add Movies";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // memberNameComboBox
            // 
            this.memberNameComboBox.FormattingEnabled = true;
            this.memberNameComboBox.Location = new System.Drawing.Point(168, 453);
            this.memberNameComboBox.Name = "memberNameComboBox";
            this.memberNameComboBox.Size = new System.Drawing.Size(144, 21);
            this.memberNameComboBox.TabIndex = 187;
            this.memberNameComboBox.SelectedIndexChanged += new System.EventHandler(this.memberNameComboBox_SelectedIndexChanged);
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(166, 183);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(146, 21);
            this.genreComboBox.TabIndex = 190;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 189;
            this.label9.Text = "Movie genre";
            // 
            // memberTypeComboBox
            // 
            this.memberTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memberTypeComboBox.FormattingEnabled = true;
            this.memberTypeComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.memberTypeComboBox.Location = new System.Drawing.Point(168, 483);
            this.memberTypeComboBox.Name = "memberTypeComboBox";
            this.memberTypeComboBox.Size = new System.Drawing.Size(146, 21);
            this.memberTypeComboBox.TabIndex = 191;
            // 
            // memberListBox
            // 
            this.memberListBox.FormattingEnabled = true;
            this.memberListBox.Location = new System.Drawing.Point(602, 339);
            this.memberListBox.Name = "memberListBox";
            this.memberListBox.Size = new System.Drawing.Size(264, 238);
            this.memberListBox.TabIndex = 192;
            this.memberListBox.SelectedIndexChanged += new System.EventHandler(this.memberListBox_SelectedIndexChanged);
            // 
            // movieMemberListBox
            // 
            this.movieMemberListBox.FormattingEnabled = true;
            this.movieMemberListBox.Location = new System.Drawing.Point(602, 26);
            this.movieMemberListBox.Name = "movieMemberListBox";
            this.movieMemberListBox.Size = new System.Drawing.Size(264, 238);
            this.movieMemberListBox.TabIndex = 193;
            this.movieMemberListBox.SelectedIndexChanged += new System.EventHandler(this.movieMemberListBox_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(662, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 13);
            this.label20.TabIndex = 194;
            this.label20.Text = "Members in movie";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(701, 318);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 13);
            this.label21.TabIndex = 195;
            this.label21.Text = "Members ";
            // 
            // addMemberToMovieButton
            // 
            this.addMemberToMovieButton.Location = new System.Drawing.Point(602, 589);
            this.addMemberToMovieButton.Name = "addMemberToMovieButton";
            this.addMemberToMovieButton.Size = new System.Drawing.Size(264, 35);
            this.addMemberToMovieButton.TabIndex = 197;
            this.addMemberToMovieButton.Text = "Add member to movie";
            this.addMemberToMovieButton.UseVisualStyleBackColor = true;
            this.addMemberToMovieButton.Click += new System.EventHandler(this.addMemberToMovieButton_Click);
            // 
            // removeMemberButton
            // 
            this.removeMemberButton.Location = new System.Drawing.Point(602, 275);
            this.removeMemberButton.Name = "removeMemberButton";
            this.removeMemberButton.Size = new System.Drawing.Size(264, 35);
            this.removeMemberButton.TabIndex = 198;
            this.removeMemberButton.Text = "Remove member from movie";
            this.removeMemberButton.UseVisualStyleBackColor = true;
            this.removeMemberButton.Click += new System.EventHandler(this.removeMemberButton_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(34, 570);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 13);
            this.label22.TabIndex = 200;
            this.label22.Text = "members field";
            // 
            // memberFieldTextBox
            // 
            this.memberFieldTextBox.Location = new System.Drawing.Point(167, 566);
            this.memberFieldTextBox.Name = "memberFieldTextBox";
            this.memberFieldTextBox.ReadOnly = true;
            this.memberFieldTextBox.Size = new System.Drawing.Size(144, 20);
            this.memberFieldTextBox.TabIndex = 199;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(35, 594);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 13);
            this.label23.TabIndex = 202;
            this.label23.Text = "members description";
            // 
            // memberDescriptionRichTextBox
            // 
            this.memberDescriptionRichTextBox.Location = new System.Drawing.Point(167, 594);
            this.memberDescriptionRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memberDescriptionRichTextBox.Name = "memberDescriptionRichTextBox";
            this.memberDescriptionRichTextBox.ReadOnly = true;
            this.memberDescriptionRichTextBox.Size = new System.Drawing.Size(147, 58);
            this.memberDescriptionRichTextBox.TabIndex = 203;
            this.memberDescriptionRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 700);
            this.Controls.Add(this.memberDescriptionRichTextBox);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.memberFieldTextBox);
            this.Controls.Add(this.removeMemberButton);
            this.Controls.Add(this.addMemberToMovieButton);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.movieMemberListBox);
            this.Controls.Add(this.memberListBox);
            this.Controls.Add(this.memberTypeComboBox);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.memberNameComboBox);
            this.Controls.Add(this.genreNameComboBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.genreCodeTextBox);
            this.Controls.Add(this.genreDescriptionTextBox);
            this.Controls.Add(this.deleteGenreButton);
            this.Controls.Add(this.modifyGenreButton);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.memberDOBTextBox);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.deleteMemberButton);
            this.Controls.Add(this.modifyMemberButton);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.moviesListView);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.moviesPictureBox);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.deleteMovieButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.modifyMovieButton);
            this.Controls.Add(this.addMovieButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Movies";
            ((System.ComponentModel.ISupportInitialize)(this.moviesPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox genreNameComboBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox genreCodeTextBox;
        private System.Windows.Forms.TextBox genreDescriptionTextBox;
        private System.Windows.Forms.Button deleteGenreButton;
        private System.Windows.Forms.Button modifyGenreButton;
        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox memberDOBTextBox;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button deleteMemberButton;
        private System.Windows.Forms.Button modifyMemberButton;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView moviesListView;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox moviesPictureBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button deleteMovieButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button modifyMovieButton;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.ComboBox memberNameComboBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox memberTypeComboBox;
        private System.Windows.Forms.ListBox memberListBox;
        private System.Windows.Forms.ListBox movieMemberListBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button addMemberToMovieButton;
        private System.Windows.Forms.Button removeMemberButton;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox memberFieldTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.RichTextBox memberDescriptionRichTextBox;
    }
}

