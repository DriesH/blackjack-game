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
            this.lblMoney.Location = new System.Drawing.Point(12, 16);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(58, 17);
            this.lblMoney.TabIndex = 0;
            this.lblMoney.Text = "Money: ";
            // 
            // lblKaarten
            // 
            this.lblKaarten.AutoSize = true;
            this.lblKaarten.Location = new System.Drawing.Point(172, 16);
            this.lblKaarten.Name = "lblKaarten";
            this.lblKaarten.Size = new System.Drawing.Size(66, 17);
            this.lblKaarten.TabIndex = 1;
            this.lblKaarten.Text = "Kaarten: ";
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblKaarten);
            this.Controls.Add(this.lblMoney);
            this.Name = "PlayerView";
            this.Size = new System.Drawing.Size(286, 52);
            this.Load += new System.EventHandler(this.PlayerView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblKaarten;
    }
}
