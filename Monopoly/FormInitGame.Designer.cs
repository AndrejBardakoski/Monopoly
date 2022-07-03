namespace Monopoly
{
    partial class FormInitGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInitGame));
            this.tbName1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMode1 = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.tBarBalance = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMode2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbName3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMode3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbName4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbMode4 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbDice = new System.Windows.Forms.ComboBox();
            this.btnColor4 = new System.Windows.Forms.Button();
            this.btnColor3 = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.btnIcon4 = new System.Windows.Forms.Button();
            this.btnIcon3 = new System.Windows.Forms.Button();
            this.btnIcon2 = new System.Windows.Forms.Button();
            this.BtnIcon1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tBarBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName1
            // 
            this.tbName1.BackColor = System.Drawing.Color.Red;
            this.tbName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbName1.Location = new System.Drawing.Point(462, 78);
            this.tbName1.MaxLength = 10;
            this.tbName1.Name = "tbName1";
            this.tbName1.Size = new System.Drawing.Size(152, 30);
            this.tbName1.TabIndex = 5;
            this.tbName1.Text = "IronMan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(458, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // cbMode1
            // 
            this.cbMode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbMode1.FormattingEnabled = true;
            this.cbMode1.Items.AddRange(new object[] {
            "Human"});
            this.cbMode1.Location = new System.Drawing.Point(639, 78);
            this.cbMode1.Name = "cbMode1";
            this.cbMode1.Size = new System.Drawing.Size(99, 26);
            this.cbMode1.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "batMan.png");
            this.imageList1.Images.SetKeyName(1, "IronMan.png");
            // 
            // btnStart
            // 
            this.btnStart.ImageList = this.imageList1;
            this.btnStart.Location = new System.Drawing.Point(82, 399);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(161, 47);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tBarBalance
            // 
            this.tBarBalance.LargeChange = 50000;
            this.tBarBalance.Location = new System.Drawing.Point(46, 90);
            this.tBarBalance.Maximum = 700000;
            this.tBarBalance.Minimum = 50000;
            this.tBarBalance.Name = "tBarBalance";
            this.tBarBalance.Size = new System.Drawing.Size(252, 56);
            this.tBarBalance.SmallChange = 10000;
            this.tBarBalance.TabIndex = 6;
            this.tBarBalance.Value = 300000;
            this.tBarBalance.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(635, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "PlayerMode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(765, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(371, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Icon";
            // 
            // tbName2
            // 
            this.tbName2.BackColor = System.Drawing.Color.Lime;
            this.tbName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbName2.Location = new System.Drawing.Point(462, 191);
            this.tbName2.MaxLength = 10;
            this.tbName2.Name = "tbName2";
            this.tbName2.Size = new System.Drawing.Size(152, 30);
            this.tbName2.TabIndex = 0;
            this.tbName2.Text = "Ultron";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(458, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // cbMode2
            // 
            this.cbMode2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbMode2.FormattingEnabled = true;
            this.cbMode2.Items.AddRange(new object[] {
            "Human",
            "CPU"});
            this.cbMode2.Location = new System.Drawing.Point(639, 191);
            this.cbMode2.Name = "cbMode2";
            this.cbMode2.Size = new System.Drawing.Size(99, 26);
            this.cbMode2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(635, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "PlayerMode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(765, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(371, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Icon";
            // 
            // tbName3
            // 
            this.tbName3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbName3.Location = new System.Drawing.Point(462, 304);
            this.tbName3.MaxLength = 10;
            this.tbName3.Name = "tbName3";
            this.tbName3.Size = new System.Drawing.Size(152, 30);
            this.tbName3.TabIndex = 0;
            this.tbName3.Text = "Turtle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(458, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name";
            // 
            // cbMode3
            // 
            this.cbMode3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbMode3.FormattingEnabled = true;
            this.cbMode3.Items.AddRange(new object[] {
            "Human",
            "CPU",
            "(none)"});
            this.cbMode3.Location = new System.Drawing.Point(639, 304);
            this.cbMode3.Name = "cbMode3";
            this.cbMode3.Size = new System.Drawing.Size(99, 26);
            this.cbMode3.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(635, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "PlayerMode";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(765, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Color";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(371, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Icon";
            // 
            // tbName4
            // 
            this.tbName4.BackColor = System.Drawing.Color.Cyan;
            this.tbName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbName4.Location = new System.Drawing.Point(462, 412);
            this.tbName4.MaxLength = 10;
            this.tbName4.Name = "tbName4";
            this.tbName4.Size = new System.Drawing.Size(152, 30);
            this.tbName4.TabIndex = 0;
            this.tbName4.Text = "WonderW";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(458, 371);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Name";
            // 
            // cbMode4
            // 
            this.cbMode4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbMode4.FormattingEnabled = true;
            this.cbMode4.Items.AddRange(new object[] {
            "Human",
            "CPU",
            "(none)"});
            this.cbMode4.Location = new System.Drawing.Point(639, 412);
            this.cbMode4.Name = "cbMode4";
            this.cbMode4.Size = new System.Drawing.Size(99, 26);
            this.cbMode4.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(635, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "PlayerMode";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(765, 371);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 20);
            this.label15.TabIndex = 8;
            this.label15.Text = "Color";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.Location = new System.Drawing.Point(371, 371);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 20);
            this.label16.TabIndex = 9;
            this.label16.Text = "Icon";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label17.Location = new System.Drawing.Point(33, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 29);
            this.label17.TabIndex = 11;
            this.label17.Text = "Balance:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBalance.Location = new System.Drawing.Point(187, 46);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(97, 29);
            this.lblBalance.TabIndex = 12;
            this.lblBalance.Text = "300000";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.Location = new System.Drawing.Point(34, 173);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 20);
            this.label18.TabIndex = 13;
            this.label18.Text = "Choose Dice";
            // 
            // cbDice
            // 
            this.cbDice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbDice.FormattingEnabled = true;
            this.cbDice.Items.AddRange(new object[] {
            "One Dice",
            "Two DIce",
            "2+1 Special Dice"});
            this.cbDice.Location = new System.Drawing.Point(178, 171);
            this.cbDice.Name = "cbDice";
            this.cbDice.Size = new System.Drawing.Size(120, 26);
            this.cbDice.TabIndex = 14;
            // 
            // btnColor4
            // 
            this.btnColor4.BackColor = System.Drawing.Color.Cyan;
            this.btnColor4.Image = global::Monopoly.Properties.Resources.WonderWomanSmall;
            this.btnColor4.Location = new System.Drawing.Point(769, 405);
            this.btnColor4.Name = "btnColor4";
            this.btnColor4.Size = new System.Drawing.Size(45, 41);
            this.btnColor4.TabIndex = 10;
            this.btnColor4.UseVisualStyleBackColor = false;
            this.btnColor4.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnColor3
            // 
            this.btnColor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnColor3.Image = global::Monopoly.Properties.Resources.ninjaTuttleSmall;
            this.btnColor3.Location = new System.Drawing.Point(769, 297);
            this.btnColor3.Name = "btnColor3";
            this.btnColor3.Size = new System.Drawing.Size(45, 41);
            this.btnColor3.TabIndex = 10;
            this.btnColor3.UseVisualStyleBackColor = false;
            this.btnColor3.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnColor2
            // 
            this.btnColor2.BackColor = System.Drawing.Color.Lime;
            this.btnColor2.Image = global::Monopoly.Properties.Resources.UltronSmall;
            this.btnColor2.Location = new System.Drawing.Point(769, 184);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(45, 41);
            this.btnColor2.TabIndex = 10;
            this.btnColor2.UseVisualStyleBackColor = false;
            this.btnColor2.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnColor1
            // 
            this.btnColor1.BackColor = System.Drawing.Color.Red;
            this.btnColor1.Image = global::Monopoly.Properties.Resources.IronManSmall;
            this.btnColor1.Location = new System.Drawing.Point(769, 71);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(45, 41);
            this.btnColor1.TabIndex = 10;
            this.btnColor1.UseVisualStyleBackColor = false;
            this.btnColor1.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnIcon4
            // 
            this.btnIcon4.Image = global::Monopoly.Properties.Resources.WonderWoman;
            this.btnIcon4.Location = new System.Drawing.Point(375, 394);
            this.btnIcon4.Name = "btnIcon4";
            this.btnIcon4.Size = new System.Drawing.Size(72, 70);
            this.btnIcon4.TabIndex = 3;
            this.btnIcon4.UseVisualStyleBackColor = true;
            this.btnIcon4.Click += new System.EventHandler(this.btnIcon4_Click);
            // 
            // btnIcon3
            // 
            this.btnIcon3.Image = global::Monopoly.Properties.Resources.ninjaTuttle;
            this.btnIcon3.Location = new System.Drawing.Point(375, 286);
            this.btnIcon3.Name = "btnIcon3";
            this.btnIcon3.Size = new System.Drawing.Size(72, 70);
            this.btnIcon3.TabIndex = 3;
            this.btnIcon3.UseVisualStyleBackColor = true;
            this.btnIcon3.Click += new System.EventHandler(this.btnIcon3_Click);
            // 
            // btnIcon2
            // 
            this.btnIcon2.Image = global::Monopoly.Properties.Resources.Ultron;
            this.btnIcon2.Location = new System.Drawing.Point(375, 173);
            this.btnIcon2.Name = "btnIcon2";
            this.btnIcon2.Size = new System.Drawing.Size(72, 70);
            this.btnIcon2.TabIndex = 3;
            this.btnIcon2.UseVisualStyleBackColor = true;
            this.btnIcon2.Click += new System.EventHandler(this.btnIcon2_Click);
            // 
            // BtnIcon1
            // 
            this.BtnIcon1.Image = global::Monopoly.Properties.Resources.IronMan;
            this.BtnIcon1.Location = new System.Drawing.Point(375, 60);
            this.BtnIcon1.Name = "BtnIcon1";
            this.BtnIcon1.Size = new System.Drawing.Size(72, 70);
            this.BtnIcon1.TabIndex = 3;
            this.BtnIcon1.UseVisualStyleBackColor = true;
            this.BtnIcon1.Click += new System.EventHandler(this.BtnIcon1_Click);
            // 
            // FormInitGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(893, 495);
            this.Controls.Add(this.cbDice);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnColor4);
            this.Controls.Add(this.btnColor3);
            this.Controls.Add(this.btnColor2);
            this.Controls.Add(this.btnColor1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBarBalance);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnIcon4);
            this.Controls.Add(this.btnIcon3);
            this.Controls.Add(this.btnIcon2);
            this.Controls.Add(this.BtnIcon1);
            this.Controls.Add(this.cbMode4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbMode3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbMode2);
            this.Controls.Add(this.tbName4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbName3);
            this.Controls.Add(this.cbMode1);
            this.Controls.Add(this.tbName2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName1);
            this.Name = "FormInitGame";
            this.Text = "FormInitGame";
            ((System.ComponentModel.ISupportInitialize)(this.tBarBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMode1;
        private System.Windows.Forms.Button BtnIcon1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TrackBar tBarBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.TextBox tbName2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMode2;
        private System.Windows.Forms.Button btnIcon2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.TextBox tbName3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbMode3;
        private System.Windows.Forms.Button btnIcon3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnColor3;
        private System.Windows.Forms.TextBox tbName4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbMode4;
        private System.Windows.Forms.Button btnIcon4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnColor4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbDice;
    }
}