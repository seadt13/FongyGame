namespace fongy
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.cpu = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.scorePlayer = new System.Windows.Forms.Label();
            this.scoreCPU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // player
            // 
            this.player.Image = global::fongy.Properties.Resources.red;
            this.player.Location = new System.Drawing.Point(50, 406);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(48, 168);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // cpu
            // 
            this.cpu.Image = global::fongy.Properties.Resources.blue;
            this.cpu.Location = new System.Drawing.Point(1820, 406);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(48, 174);
            this.cpu.TabIndex = 1;
            this.cpu.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(950, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 1080);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pbBall
            // 
            this.pbBall.Image = ((System.Drawing.Image)(resources.GetObject("pbBall.Image")));
            this.pbBall.Location = new System.Drawing.Point(940, 445);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(30, 30);
            this.pbBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBall.TabIndex = 3;
            this.pbBall.TabStop = false;
            // 
            // scorePlayer
            // 
            this.scorePlayer.AutoSize = true;
            this.scorePlayer.Font = new System.Drawing.Font("Unispace", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scorePlayer.ForeColor = System.Drawing.Color.White;
            this.scorePlayer.Location = new System.Drawing.Point(855, 0);
            this.scorePlayer.Name = "scorePlayer";
            this.scorePlayer.Size = new System.Drawing.Size(89, 96);
            this.scorePlayer.TabIndex = 4;
            this.scorePlayer.Text = "0";
            // 
            // scoreCPU
            // 
            this.scoreCPU.AutoSize = true;
            this.scoreCPU.Font = new System.Drawing.Font("Unispace", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreCPU.ForeColor = System.Drawing.Color.White;
            this.scoreCPU.Location = new System.Drawing.Point(976, 0);
            this.scoreCPU.Name = "scoreCPU";
            this.scoreCPU.Size = new System.Drawing.Size(89, 96);
            this.scoreCPU.TabIndex = 5;
            this.scoreCPU.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.pbBall);
            this.Controls.Add(this.scoreCPU);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.scorePlayer);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private PictureBox player;
        private PictureBox cpu;
        private PictureBox pictureBox3;
        private PictureBox pbBall;
        private Label scorePlayer;
        private Label scoreCPU;
    }
}