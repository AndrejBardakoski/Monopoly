namespace Monopoly
{
    partial class TradeForm
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
            this.gbPlayerOffering = new System.Windows.Forms.GroupBox();
            this.lblBalancePlayerOffering = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBalancePlayerOffering = new System.Windows.Forms.TrackBar();
            this.cblPlayerOffering = new System.Windows.Forms.CheckedListBox();
            this.gbPlayerOffered = new System.Windows.Forms.GroupBox();
            this.lblBalancePlayerOffered = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBalancePlayerOffered = new System.Windows.Forms.TrackBar();
            this.cblPlayerOffered = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlayers = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOffer = new System.Windows.Forms.Button();
            this.gbPlayerOffering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBalancePlayerOffering)).BeginInit();
            this.gbPlayerOffered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBalancePlayerOffered)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPlayerOffering
            // 
            this.gbPlayerOffering.Controls.Add(this.lblBalancePlayerOffering);
            this.gbPlayerOffering.Controls.Add(this.label3);
            this.gbPlayerOffering.Controls.Add(this.tbBalancePlayerOffering);
            this.gbPlayerOffering.Controls.Add(this.cblPlayerOffering);
            this.gbPlayerOffering.Location = new System.Drawing.Point(12, 32);
            this.gbPlayerOffering.Name = "gbPlayerOffering";
            this.gbPlayerOffering.Size = new System.Drawing.Size(363, 383);
            this.gbPlayerOffering.TabIndex = 1;
            this.gbPlayerOffering.TabStop = false;
            this.gbPlayerOffering.Text = "groupBox1";
            // 
            // lblBalancePlayerOffering
            // 
            this.lblBalancePlayerOffering.AutoSize = true;
            this.lblBalancePlayerOffering.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBalancePlayerOffering.Location = new System.Drawing.Point(218, 315);
            this.lblBalancePlayerOffering.Name = "lblBalancePlayerOffering";
            this.lblBalancePlayerOffering.Size = new System.Drawing.Size(30, 24);
            this.lblBalancePlayerOffering.TabIndex = 3;
            this.lblBalancePlayerOffering.Text = "0$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(215, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Give:";
            // 
            // tbBalancePlayerOffering
            // 
            this.tbBalancePlayerOffering.LargeChange = 20000;
            this.tbBalancePlayerOffering.Location = new System.Drawing.Point(16, 303);
            this.tbBalancePlayerOffering.Maximum = 100000;
            this.tbBalancePlayerOffering.Name = "tbBalancePlayerOffering";
            this.tbBalancePlayerOffering.Size = new System.Drawing.Size(192, 56);
            this.tbBalancePlayerOffering.SmallChange = 5000;
            this.tbBalancePlayerOffering.TabIndex = 1;
            this.tbBalancePlayerOffering.Scroll += new System.EventHandler(this.tbBalancePlayerOffering_Scroll);
            // 
            // cblPlayerOffering
            // 
            this.cblPlayerOffering.CheckOnClick = true;
            this.cblPlayerOffering.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblPlayerOffering.FormattingEnabled = true;
            this.cblPlayerOffering.Items.AddRange(new object[] {
            "Electric Utility:  50000$"});
            this.cblPlayerOffering.Location = new System.Drawing.Point(16, 27);
            this.cblPlayerOffering.Name = "cblPlayerOffering";
            this.cblPlayerOffering.Size = new System.Drawing.Size(341, 235);
            this.cblPlayerOffering.TabIndex = 0;
            // 
            // gbPlayerOffered
            // 
            this.gbPlayerOffered.Controls.Add(this.lblBalancePlayerOffered);
            this.gbPlayerOffered.Controls.Add(this.label5);
            this.gbPlayerOffered.Controls.Add(this.tbBalancePlayerOffered);
            this.gbPlayerOffered.Controls.Add(this.cblPlayerOffered);
            this.gbPlayerOffered.Location = new System.Drawing.Point(436, 59);
            this.gbPlayerOffered.Name = "gbPlayerOffered";
            this.gbPlayerOffered.Size = new System.Drawing.Size(352, 379);
            this.gbPlayerOffered.TabIndex = 2;
            this.gbPlayerOffered.TabStop = false;
            this.gbPlayerOffered.Text = "groupBox2";
            // 
            // lblBalancePlayerOffered
            // 
            this.lblBalancePlayerOffered.AutoSize = true;
            this.lblBalancePlayerOffered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBalancePlayerOffered.Location = new System.Drawing.Point(222, 308);
            this.lblBalancePlayerOffered.Name = "lblBalancePlayerOffered";
            this.lblBalancePlayerOffered.Size = new System.Drawing.Size(30, 24);
            this.lblBalancePlayerOffered.TabIndex = 4;
            this.lblBalancePlayerOffered.Text = "0$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(222, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Recive:";
            // 
            // tbBalancePlayerOffered
            // 
            this.tbBalancePlayerOffered.LargeChange = 20000;
            this.tbBalancePlayerOffered.Location = new System.Drawing.Point(24, 300);
            this.tbBalancePlayerOffered.Maximum = 100000;
            this.tbBalancePlayerOffered.Name = "tbBalancePlayerOffered";
            this.tbBalancePlayerOffered.Size = new System.Drawing.Size(192, 56);
            this.tbBalancePlayerOffered.SmallChange = 5000;
            this.tbBalancePlayerOffered.TabIndex = 2;
            this.tbBalancePlayerOffered.Scroll += new System.EventHandler(this.tbBalancePlayerOffered_Scroll);
            // 
            // cblPlayerOffered
            // 
            this.cblPlayerOffered.CheckOnClick = true;
            this.cblPlayerOffered.Font = new System.Drawing.Font("Courier New", 10F);
            this.cblPlayerOffered.FormattingEnabled = true;
            this.cblPlayerOffered.Items.AddRange(new object[] {
            "Electric Utility:  50000$"});
            this.cblPlayerOffered.Location = new System.Drawing.Point(24, 21);
            this.cblPlayerOffered.Name = "cblPlayerOffered";
            this.cblPlayerOffered.Size = new System.Drawing.Size(311, 235);
            this.cblPlayerOffered.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(381, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose player to trade with";
            // 
            // cbPlayers
            // 
            this.cbPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlayers.FormattingEnabled = true;
            this.cbPlayers.Location = new System.Drawing.Point(650, 20);
            this.cbPlayers.Name = "cbPlayers";
            this.cbPlayers.Size = new System.Drawing.Size(121, 24);
            this.cbPlayers.TabIndex = 3;
            this.cbPlayers.SelectedIndexChanged += new System.EventHandler(this.cbPlayers_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCancel.Location = new System.Drawing.Point(436, 453);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 46);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel Trade";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOffer
            // 
            this.btnOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnOffer.Location = new System.Drawing.Point(189, 453);
            this.btnOffer.Name = "btnOffer";
            this.btnOffer.Size = new System.Drawing.Size(158, 46);
            this.btnOffer.TabIndex = 5;
            this.btnOffer.Text = "Offer Trade";
            this.btnOffer.UseVisualStyleBackColor = true;
            this.btnOffer.Click += new System.EventHandler(this.btnOffer_Click);
            // 
            // TradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.btnOffer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbPlayers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbPlayerOffered);
            this.Controls.Add(this.gbPlayerOffering);
            this.Name = "TradeForm";
            this.Text = "s";
            this.gbPlayerOffering.ResumeLayout(false);
            this.gbPlayerOffering.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBalancePlayerOffering)).EndInit();
            this.gbPlayerOffered.ResumeLayout(false);
            this.gbPlayerOffered.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBalancePlayerOffered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayerOffering;
        private System.Windows.Forms.GroupBox gbPlayerOffered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPlayers;
        private System.Windows.Forms.Label lblBalancePlayerOffering;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbBalancePlayerOffering;
        private System.Windows.Forms.CheckedListBox cblPlayerOffering;
        private System.Windows.Forms.Label lblBalancePlayerOffered;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbBalancePlayerOffered;
        private System.Windows.Forms.CheckedListBox cblPlayerOffered;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOffer;
    }
}