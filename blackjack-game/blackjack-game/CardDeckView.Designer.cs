namespace blackjack_game
{
  partial class PlayerButtonsView
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
      this.btnHit = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnHit
      // 
      this.btnHit.Location = new System.Drawing.Point(59, 44);
      this.btnHit.Name = "btnHit";
      this.btnHit.Size = new System.Drawing.Size(75, 23);
      this.btnHit.TabIndex = 0;
      this.btnHit.Text = "Hit";
      this.btnHit.UseVisualStyleBackColor = true;
      this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
      // 
      // btnStop
      // 
      this.btnStop.Location = new System.Drawing.Point(160, 44);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(75, 23);
      this.btnStop.TabIndex = 1;
      this.btnStop.Text = "Stop";
      this.btnStop.UseVisualStyleBackColor = true;
      // 
      // PlayerButtonsView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btnStop);
      this.Controls.Add(this.btnHit);
      this.Name = "PlayerButtonsView";
      this.Size = new System.Drawing.Size(296, 112);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnHit;
    private System.Windows.Forms.Button btnStop;
  }
}
