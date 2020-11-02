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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.moviesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // genreNameComboBox
            // 
            this.genreNameComboBox.FormattingEnabled = true;
            this.genreNameComboBox.Location = new System.Drawing.Point(133, 47);
            this.genreNameComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.genreNameComboBox.Name = "genreNameComboBox";
            this.genreNameComboBox.Size = new System.Drawing.Size(110, 21);
            this.genreNameComboBox.TabIndex = 186;
            this.genreNameComboBox.SelectedIndexChanged += new System.EventHandler(this.genreNameComboBox_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(50, 75);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 185;
            this.label18.Text = "genre code";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(47, 53);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 184;
            this.label17.Text = "genre name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 98);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 183;
            this.label16.Text = "genre description";
            // 
            // genreCodeTextBox
            // 
            this.genreCodeTextBox.Location = new System.Drawing.Point(133, 71);
            this.genreCodeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.genreCodeTextBox.Name = "genreCodeTextBox";
            this.genreCodeTextBox.Size = new System.Drawing.Size(110, 20);
            this.genreCodeTextBox.TabIndex = 182;
            // 
            // genreDescriptionTextBox
            // 
            this.genreDescriptionTextBox.Location = new System.Drawing.Point(133, 93);
            this.genreDescriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.genreDescriptionTextBox.Name = "genreDescriptionTextBox";
            this.genreDescriptionTextBox.Size = new System.Drawing.Size(110, 20);
            this.genreDescriptionTextBox.TabIndex = 181;
            // 
            // deleteGenreButton
            // 
            this.deleteGenreButton.Location = new System.Drawing.Point(242, 124);
            this.deleteGenreButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteGenreButton.Name = "deleteGenreButton";
            this.deleteGenreButton.Size = new System.Drawing.Size(110, 25);
            this.deleteGenreButton.TabIndex = 180;
            this.deleteGenreButton.Text = "Delete genre";
            this.deleteGenreButton.UseVisualStyleBackColor = true;
            // 
            // modifyGenreButton
            // 
            this.modifyGenreButton.Location = new System.Drawing.Point(128, 124);
            this.modifyGenreButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyGenreButton.Name = "modifyGenreButton";
            this.modifyGenreButton.Size = new System.Drawing.Size(110, 25);
            this.modifyGenreButton.TabIndex = 179;
            this.modifyGenreButton.Text = "Modify genre";
            this.modifyGenreButton.UseVisualStyleBackColor = true;
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(15, 124);
            this.addGenreButton.Margin = new System.Windows.Forms.Padding(2);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(110, 25);
            this.addGenreButton.TabIndex = 178;
            this.addGenreButton.Text = "Add genre";
            this.addGenreButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 177;
            this.label7.Text = "genre info";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(690, 11);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 176;
            this.label19.Text = "Picture";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 448);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 175;
            this.label15.Text = "members DOB";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 427);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 174;
            this.label14.Text = "members ID";
            // 
            // memberDOBTextBox
            // 
            this.memberDOBTextBox.Location = new System.Drawing.Point(133, 444);
            this.memberDOBTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.memberDOBTextBox.Name = "memberDOBTextBox";
            this.memberDOBTextBox.Size = new System.Drawing.Size(110, 20);
            this.memberDOBTextBox.TabIndex = 173;
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.Location = new System.Drawing.Point(133, 421);
            this.memberIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(110, 20);
            this.memberIDTextBox.TabIndex = 172;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(130, 358);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 171;
            this.label13.Text = "member info";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(130, 161);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 170;
            this.label12.Text = "Movies info";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(132, 177);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(110, 20);
            this.idTextBox.TabIndex = 169;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 181);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 168;
            this.label11.Text = "Movies ID";
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.Location = new System.Drawing.Point(242, 477);
            this.deleteMemberButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(110, 25);
            this.deleteMemberButton.TabIndex = 167;
            this.deleteMemberButton.Text = "Delete member";
            this.deleteMemberButton.UseVisualStyleBackColor = true;
            // 
            // modifyMemberButton
            // 
            this.modifyMemberButton.Location = new System.Drawing.Point(128, 477);
            this.modifyMemberButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyMemberButton.Name = "modifyMemberButton";
            this.modifyMemberButton.Size = new System.Drawing.Size(110, 25);
            this.modifyMemberButton.TabIndex = 166;
            this.modifyMemberButton.Text = "Modify members";
            this.modifyMemberButton.UseVisualStyleBackColor = true;
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(14, 477);
            this.addMemberButton.Margin = new System.Windows.Forms.Padding(2);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(110, 25);
            this.addMemberButton.TabIndex = 165;
            this.addMemberButton.Text = "Add Members";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 378);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 164;
            this.label10.Text = "members name";
            // 
            // moviesListView
            // 
            this.moviesListView.HideSelection = false;
            this.moviesListView.Location = new System.Drawing.Point(370, 37);
            this.moviesListView.Margin = new System.Windows.Forms.Padding(2);
            this.moviesListView.Name = "moviesListView";
            this.moviesListView.Size = new System.Drawing.Size(204, 487);
            this.moviesListView.TabIndex = 160;
            this.moviesListView.UseCompatibleStateImageBehavior = false;
            // 
            // imageTextBox
            // 
            this.imageTextBox.Location = new System.Drawing.Point(132, 291);
            this.imageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(110, 20);
            this.imageTextBox.TabIndex = 159;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 158;
            this.label6.Text = "Movies image path";
            // 
            // moviesPictureBox
            // 
            this.moviesPictureBox.Location = new System.Drawing.Point(577, 37);
            this.moviesPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.moviesPictureBox.Name = "moviesPictureBox";
            this.moviesPictureBox.Size = new System.Drawing.Size(280, 487);
            this.moviesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviesPictureBox.TabIndex = 157;
            this.moviesPictureBox.TabStop = false;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(132, 268);
            this.ratingTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(110, 20);
            this.ratingTextBox.TabIndex = 156;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(132, 247);
            this.lengthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(110, 20);
            this.lengthTextBox.TabIndex = 154;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(132, 224);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(110, 20);
            this.yearTextBox.TabIndex = 153;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(132, 202);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(110, 20);
            this.nameTextBox.TabIndex = 152;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 151;
            this.label8.Text = "Movies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 150;
            this.label5.Text = "Movies rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 402);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 149;
            this.label4.Text = "members type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 148;
            this.label3.Text = "Movies length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 147;
            this.label2.Text = "Movies year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 146;
            this.label1.Text = "Movies title";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(66, 507);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(110, 25);
            this.ExitButton.TabIndex = 145;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // deleteMovieButton
            // 
            this.deleteMovieButton.Location = new System.Drawing.Point(242, 321);
            this.deleteMovieButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteMovieButton.Name = "deleteMovieButton";
            this.deleteMovieButton.Size = new System.Drawing.Size(110, 25);
            this.deleteMovieButton.TabIndex = 144;
            this.deleteMovieButton.Text = "Delete movie";
            this.deleteMovieButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(180, 507);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(110, 25);
            this.clearButton.TabIndex = 143;
            this.clearButton.Text = "Clear ";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // modifyMovieButton
            // 
            this.modifyMovieButton.Location = new System.Drawing.Point(128, 321);
            this.modifyMovieButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyMovieButton.Name = "modifyMovieButton";
            this.modifyMovieButton.Size = new System.Drawing.Size(110, 25);
            this.modifyMovieButton.TabIndex = 142;
            this.modifyMovieButton.Text = "Modify movies";
            this.modifyMovieButton.UseVisualStyleBackColor = true;
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(14, 321);
            this.addMovieButton.Margin = new System.Windows.Forms.Padding(2);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(110, 25);
            this.addMovieButton.TabIndex = 141;
            this.addMovieButton.Text = "Add Movies";
            this.addMovieButton.UseVisualStyleBackColor = true;
            // 
            // memberNameComboBox
            // 
            this.memberNameComboBox.FormattingEnabled = true;
            this.memberNameComboBox.Location = new System.Drawing.Point(133, 372);
            this.memberNameComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.memberNameComboBox.Name = "memberNameComboBox";
            this.memberNameComboBox.Size = new System.Drawing.Size(110, 21);
            this.memberNameComboBox.TabIndex = 187;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 155);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 190;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 161);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 189;
            this.label9.Text = "genre name";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(133, 396);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(110, 21);
            this.comboBox2.TabIndex = 191;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 544);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

