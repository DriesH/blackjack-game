namespace blackjack_game
{
    partial class Gameform
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
            this.buttonDries = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDries
            // 
            this.buttonDries.Location = new System.Drawing.Point(50, 43);
            this.buttonDries.Name = "buttonDries";
            this.buttonDries.Size = new System.Drawing.Size(156, 95);
            this.buttonDries.TabIndex = 0;
            this.buttonDries.Text = "dries";
            this.buttonDries.UseVisualStyleBackColor = true;
            // 
            // Gameform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 229);
            this.Controls.Add(this.buttonDries);
            this.Name = "Gameform";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDries;
    }
}

