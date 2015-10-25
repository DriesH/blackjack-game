namespace blackjack_game
{
    partial class PlayerView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblKaarten = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(9, 13);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(45, 13);
            this.lblMoney.TabIndex = 0;
            this.lblMoney.Text = "Money: ";
            // 
            // lblKaarten
            // 
            this.lblKaarten.AutoSize = true;
            this.lblKaarten.Location = new System.Drawing.Point(129, 13);
            this.lblKaarten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKaarten.Name = "lblKaarten";
            this.lblKaarten.Size = new System.Drawing.Size(50, 13);
            this.lblKaarten.TabIndex = 1;
            this.lblKaarten.Text = "Kaarten: ";
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblKaarten);
            this.Controls.Add(this.lblMoney);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlayerView";
            this.Size = new System.Drawing.Size(256, 42);
            this.Load += new System.EventHandler(this.PlayerView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblKaarten;
    }
}
