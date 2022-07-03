namespace Monopoly
{
    partial class TradeOfferForm
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
            this.gbPlayerOffered = new System.Windows.Forms.GroupBox();
            this.lblBalancePlayerOffered = new System.Windows.Forms.Label();
            this.lbPlayerOffered = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBalancePlayerOffering = new System.Windows.Forms.Label();
            this.gbPlayerOffering = new System.Windows.Forms.GroupBox();
            this.lbPlayerOffering = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbPlayerOffered.SuspendLayout();
            this.gbPlayerOffering.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPlayerOffered
            // 
            this.gbPlayerOffered.Controls.Add(this.lblBalancePlayerOffered);
            this.gbPlayerOffered.Controls.Add(this.lbPlayerOffered);
            this.gbPlayerOffered.Controls.Add(this.label3);
            this.gbPlayerOffered.Location = new System.Drawing.Point(29, 69);
            this.gbPlayerOffered.Name = "gbPlayerOffered";
            this.gbPlayerOffered.Size = new System.Drawing.Size(363, 364);
            this.gbPlayerOffered.TabIndex = 7;
            this.gbPlayerOffered.TabStop = false;
            this.gbPlayerOffered.Text = "groupBox1";
            // 
            // lblBalancePlayerOffered
            // 
            this.lblBalancePlayerOffered.AutoSize = true;
            this.lblBalancePlayerOffered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBalancePlayerOffered.Location = new System.Drawing.Point(192, 312);
            this.lblBalancePlayerOffered.Name = "lblBalancePlayerOffered";
            this.lblBalancePlayerOffered.Size = new System.Drawing.Size(30, 24);
            this.lblBalancePlayerOffered.TabIndex = 4;
            this.lblBalancePlayerOffered.Text = "0$";
            // 
            // lbPlayerOffered
            // 
            this.lbPlayerOffered.Font = new System.Drawing.Font("Courier New", 10F);
            this.lbPlayerOffered.FormattingEnabled = true;
            this.lbPlayerOffered.ItemHeight = 20;
            this.lbPlayerOffered.Location = new System.Drawing.Point(15, 34);
            this.lbPlayerOffered.Name = "lbPlayerOffered";
            this.lbPlayerOffered.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbPlayerOffered.Size = new System.Drawing.Size(330, 244);
            this.lbPlayerOffered.TabIndex = 4;
            this.lbPlayerOffered.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(54, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Give:";
            // 
            // lblBalancePlayerOffering
            // 
            this.lblBalancePlayerOffering.AutoSize = true;
            this.lblBalancePlayerOffering.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBalancePlayerOffering.Location = new System.Drawing.Point(209, 308);
            this.lblBalancePlayerOffering.Name = "lblBalancePlayerOffering";
            this.lblBalancePlayerOffering.Size = new System.Drawing.Size(30, 24);
            this.lblBalancePlayerOffering.TabIndex = 3;
            this.lblBalancePlayerOffering.Text = "0$";
            // 
            // gbPlayerOffering
            // 
            this.gbPlayerOffering.Controls.Add(this.lbPlayerOffering);
            this.gbPlayerOffering.Controls.Add(this.label5);
            this.gbPlayerOffering.Controls.Add(this.lblBalancePlayerOffering);
            this.gbPlayerOffering.Location = new System.Drawing.Point(462, 73);
            this.gbPlayerOffering.Name = "gbPlayerOffering";
            this.gbPlayerOffering.Size = new System.Drawing.Size(366, 360);
            this.gbPlayerOffering.TabIndex = 8;
            this.gbPlayerOffering.TabStop = false;
            this.gbPlayerOffering.Text = "groupBox2";
            // 
            // lbPlayerOffering
            // 
            this.lbPlayerOffering.Font = new System.Drawing.Font("Courier New", 10F);
            this.lbPlayerOffering.FormattingEnabled = true;
            this.lbPlayerOffering.ItemHeight = 20;
            this.lbPlayerOffering.Location = new System.Drawing.Point(16, 30);
            this.lbPlayerOffering.Name = "lbPlayerOffering";
            this.lbPlayerOffering.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbPlayerOffering.Size = new System.Drawing.Size(330, 244);
            this.lbPlayerOffering.TabIndex = 5;
            this.lbPlayerOffering.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(53, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Recive:";
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAccept.Location = new System.Drawing.Point(216, 467);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(158, 46);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "Accept Trade";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCancel.Location = new System.Drawing.Point(492, 467);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 46);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel Trade";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTitle.Location = new System.Drawing.Point(281, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 26);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Player1 offered player2 a trade";
            // 
            // TradeOfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 546);
            this.Controls.Add(this.gbPlayerOffered);
            this.Controls.Add(this.gbPlayerOffering);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTitle);
            this.Name = "TradeOfferForm";
            this.Text = "TradeOfferForm";
            this.gbPlayerOffered.ResumeLayout(false);
            this.gbPlayerOffered.PerformLayout();
            this.gbPlayerOffering.ResumeLayout(false);
            this.gbPlayerOffering.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayerOffered;
        private System.Windows.Forms.Label lblBalancePlayerOffering;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPlayerOffering;
        private System.Windows.Forms.Label lblBalancePlayerOffered;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lbPlayerOffered;
        private System.Windows.Forms.ListBox lbPlayerOffering;
    }
}