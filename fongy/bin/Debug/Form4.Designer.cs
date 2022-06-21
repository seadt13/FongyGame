namespace fongy.bin.Debug
{
    partial class Form4
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnReplay = new System.Windows.Forms.Button();
            this.lblEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(134)))));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(510, 465);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(344, 179);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnReplay
            // 
            this.btnReplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(134)))));
            this.btnReplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReplay.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReplay.ForeColor = System.Drawing.Color.White;
            this.btnReplay.Location = new System.Drawing.Point(121, 465);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(344, 179);
            this.btnReplay.TabIndex = 4;
            this.btnReplay.Text = "REPLAY";
            this.btnReplay.UseVisualStyleBackColor = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnd.ForeColor = System.Drawing.Color.White;
            this.lblEnd.Location = new System.Drawing.Point(270, 291);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(440, 106);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "You Lost!!!";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.lblEnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "You Lost!!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnQuit;
        private Button btnReplay;
        private Label lblEnd;
    }
}