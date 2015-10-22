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
            this.moneylabel = new System.Windows.Forms.Label();
            this.kaartenlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moneylabel
            // 
            this.moneylabel.AutoSize = true;
            this.moneylabel.Location = new System.Drawing.Point(12, 16);
            this.moneylabel.Name = "moneylabel";
            this.moneylabel.Size = new System.Drawing.Size(58, 17);
            this.moneylabel.TabIndex = 0;
            this.moneylabel.Text = "Money: ";
            // 
            // kaartenlabel
            // 
            this.kaartenlabel.AutoSize = true;
            this.kaartenlabel.Location = new System.Drawing.Point(172, 16);
            this.kaartenlabel.Name = "kaartenlabel";
            this.kaartenlabel.Size = new System.Drawing.Size(66, 17);
            this.kaartenlabel.TabIndex = 1;
            this.kaartenlabel.Text = "Kaarten: ";
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kaartenlabel);
            this.Controls.Add(this.moneylabel);
            this.Name = "PlayerView";
            this.Size = new System.Drawing.Size(286, 52);
            this.Load += new System.EventHandler(this.PlayerView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moneylabel;
        private System.Windows.Forms.Label kaartenlabel;
    }
}
