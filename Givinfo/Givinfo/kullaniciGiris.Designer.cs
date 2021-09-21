namespace Givinfo
{
    partial class kullaniciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullaniciGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.videoButton = new System.Windows.Forms.Button();
            this.bilgiButton = new System.Windows.Forms.Button();
            this.oyunButton = new System.Windows.Forms.Button();
            this.kitapButton = new System.Windows.Forms.Button();
            this.mesajButton = new System.Windows.Forms.Button();
            this.profilButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOŞGELDİNİZ";
            // 
            // videoButton
            // 
            this.videoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.videoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.videoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.videoButton.Image = ((System.Drawing.Image)(resources.GetObject("videoButton.Image")));
            this.videoButton.Location = new System.Drawing.Point(93, 45);
            this.videoButton.Name = "videoButton";
            this.videoButton.Size = new System.Drawing.Size(201, 140);
            this.videoButton.TabIndex = 1;
            this.videoButton.Text = "VİDEOLAR";
            this.videoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.videoButton.UseVisualStyleBackColor = false;
            this.videoButton.Click += new System.EventHandler(this.videoButton_Click);
            // 
            // bilgiButton
            // 
            this.bilgiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bilgiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bilgiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bilgiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiButton.ForeColor = System.Drawing.Color.Black;
            this.bilgiButton.Image = ((System.Drawing.Image)(resources.GetObject("bilgiButton.Image")));
            this.bilgiButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bilgiButton.Location = new System.Drawing.Point(343, 45);
            this.bilgiButton.Name = "bilgiButton";
            this.bilgiButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bilgiButton.Size = new System.Drawing.Size(208, 140);
            this.bilgiButton.TabIndex = 2;
            this.bilgiButton.Text = "BİLGİLER";
            this.bilgiButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bilgiButton.UseVisualStyleBackColor = false;
            this.bilgiButton.Click += new System.EventHandler(this.bilgiButton_Click);
            // 
            // oyunButton
            // 
            this.oyunButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.oyunButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oyunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyunButton.Image = ((System.Drawing.Image)(resources.GetObject("oyunButton.Image")));
            this.oyunButton.Location = new System.Drawing.Point(602, 45);
            this.oyunButton.Name = "oyunButton";
            this.oyunButton.Size = new System.Drawing.Size(207, 140);
            this.oyunButton.TabIndex = 3;
            this.oyunButton.Text = "OYUNLAR";
            this.oyunButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.oyunButton.UseVisualStyleBackColor = false;
            this.oyunButton.Click += new System.EventHandler(this.oyunButton_Click);
            // 
            // kitapButton
            // 
            this.kitapButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kitapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapButton.Image = ((System.Drawing.Image)(resources.GetObject("kitapButton.Image")));
            this.kitapButton.Location = new System.Drawing.Point(207, 219);
            this.kitapButton.Name = "kitapButton";
            this.kitapButton.Size = new System.Drawing.Size(201, 140);
            this.kitapButton.TabIndex = 4;
            this.kitapButton.Text = "KİTAPLAR";
            this.kitapButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.kitapButton.UseVisualStyleBackColor = false;
            this.kitapButton.Click += new System.EventHandler(this.kitapButton_Click);
            // 
            // mesajButton
            // 
            this.mesajButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mesajButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mesajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesajButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mesajButton.Image = ((System.Drawing.Image)(resources.GetObject("mesajButton.Image")));
            this.mesajButton.Location = new System.Drawing.Point(464, 219);
            this.mesajButton.Name = "mesajButton";
            this.mesajButton.Size = new System.Drawing.Size(201, 140);
            this.mesajButton.TabIndex = 5;
            this.mesajButton.Text = "MESAJLAŞMA";
            this.mesajButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mesajButton.UseVisualStyleBackColor = false;
            this.mesajButton.Click += new System.EventHandler(this.mesajButton_Click);
            // 
            // profilButton
            // 
            this.profilButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.profilButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profilButton.Image = ((System.Drawing.Image)(resources.GetObject("profilButton.Image")));
            this.profilButton.Location = new System.Drawing.Point(694, 362);
            this.profilButton.Name = "profilButton";
            this.profilButton.Size = new System.Drawing.Size(201, 140);
            this.profilButton.TabIndex = 6;
            this.profilButton.Text = "PROFİL BİLGİLERİ";
            this.profilButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.profilButton.UseVisualStyleBackColor = false;
            this.profilButton.Click += new System.EventHandler(this.profilButton_Click);
            // 
            // kullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 514);
            this.Controls.Add(this.profilButton);
            this.Controls.Add(this.mesajButton);
            this.Controls.Add(this.kitapButton);
            this.Controls.Add(this.oyunButton);
            this.Controls.Add(this.bilgiButton);
            this.Controls.Add(this.videoButton);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "kullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kullaniciGiris_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button videoButton;
        private System.Windows.Forms.Button bilgiButton;
        private System.Windows.Forms.Button oyunButton;
        private System.Windows.Forms.Button kitapButton;
        private System.Windows.Forms.Button mesajButton;
        private System.Windows.Forms.Button profilButton;
    }
}