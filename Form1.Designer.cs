namespace flappy_bird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.boruUst = new System.Windows.Forms.PictureBox();
            this.boruAlt = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(71, 123);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(77, 64);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // boruUst
            // 
            this.boruUst.Image = ((System.Drawing.Image)(resources.GetObject("boruUst.Image")));
            this.boruUst.Location = new System.Drawing.Point(520, 3);
            this.boruUst.Name = "boruUst";
            this.boruUst.Size = new System.Drawing.Size(86, 184);
            this.boruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruUst.TabIndex = 1;
            this.boruUst.TabStop = false;
            this.boruUst.Click += new System.EventHandler(this.boruUst_Click);
            // 
            // boruAlt
            // 
            this.boruAlt.Image = ((System.Drawing.Image)(resources.GetObject("boruAlt.Image")));
            this.boruAlt.Location = new System.Drawing.Point(453, 408);
            this.boruAlt.Name = "boruAlt";
            this.boruAlt.Size = new System.Drawing.Size(86, 150);
            this.boruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruAlt.TabIndex = 2;
            this.boruAlt.TabStop = false;
            this.boruAlt.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // zemin
            // 
            this.zemin.Image = ((System.Drawing.Image)(resources.GetObject("zemin.Image")));
            this.zemin.Location = new System.Drawing.Point(-6, 550);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(664, 100);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 3;
            this.zemin.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.SystemColors.Control;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText.Location = new System.Drawing.Point(12, 594);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(147, 38);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(658, 643);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.boruAlt);
            this.Controls.Add(this.boruUst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox boruUst;
        private System.Windows.Forms.PictureBox boruAlt;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

