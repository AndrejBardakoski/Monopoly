namespace Monopoly
{
    partial class InfoBox
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbShortName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Control;
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.tbName.Location = new System.Drawing.Point(12, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(291, 40);
            this.tbName.TabIndex = 2;
            this.tbName.Text = "Name";
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tbInfo.Enabled = false;
            this.tbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInfo.Location = new System.Drawing.Point(12, 125);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(291, 215);
            this.tbInfo.TabIndex = 4;
            this.tbInfo.Text = "Rent:\r\nOnly land:       20000\r\nOne house:     30000\r\nTwo houses:   40000\r\nThree h" +
    "ouses: 50000\r\nFour houses:   60000\r\nHotel:             20353\r\n\r\nHouse price:  20" +
    "000\r\nHotel price:    30000";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.BackColor = System.Drawing.Color.Transparent;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblValue.Location = new System.Drawing.Point(122, 58);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(66, 24);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "label1";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.BackColor = System.Drawing.Color.Transparent;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(18, 98);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(64, 24);
            this.lblOwner.TabIndex = 3;
            this.lblOwner.Text = "Value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Value:";
            // 
            // tbShortName
            // 
            this.tbShortName.Font = new System.Drawing.Font("Courier New", 25F, System.Drawing.FontStyle.Bold);
            this.tbShortName.ForeColor = System.Drawing.Color.Lime;
            this.tbShortName.Location = new System.Drawing.Point(203, 58);
            this.tbShortName.MaxLength = 3;
            this.tbShortName.Multiline = true;
            this.tbShortName.Name = "tbShortName";
            this.tbShortName.ReadOnly = true;
            this.tbShortName.Size = new System.Drawing.Size(100, 50);
            this.tbShortName.TabIndex = 5;
            this.tbShortName.TabStop = false;
            this.tbShortName.Text = "OTW";
            this.tbShortName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InfoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(315, 352);
            this.Controls.Add(this.tbShortName);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblValue);
            this.Name = "InfoBox";
            this.Text = "TileInfoBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbShortName;
    }
}