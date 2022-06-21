namespace fongy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFull = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Image = global::fongy.Properties.Resources.start;
            this.btnStart.Location = new System.Drawing.Point(213, 225);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(390, 100);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnFull
            // 
            this.btnFull.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFull.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFull.Image = global::fongy.Properties.Resources.fullscreen;
            this.btnFull.Location = new System.Drawing.Point(213, 331);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(390, 100);
            this.btnFull.TabIndex = 1;
            this.btnFull.UseVisualStyleBackColor = true;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Image = global::fongy.Properties.Resources.quit;
            this.btnQuit.Location = new System.Drawing.Point(213, 437);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(390, 100);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::fongy.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(97, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 203);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnFull);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnStart;
        private Button btnFull;
        private Button btnQuit;
        private PictureBox pictureBox1;
    }
}