namespace Givinfo
{
    partial class kullaniciForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullaniciForm));
            this.btn_yetkiDusur = new System.Windows.Forms.Button();
            this.btn_kullaniciYetki = new System.Windows.Forms.Button();
            this.btn_kullaniciSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_yetkiDusur
            // 
            this.btn_yetkiDusur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_yetkiDusur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yetkiDusur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_yetkiDusur.Location = new System.Drawing.Point(656, 431);
            this.btn_yetkiDusur.Name = "btn_yetkiDusur";
            this.btn_yetkiDusur.Size = new System.Drawing.Size(121, 35);
            this.btn_yetkiDusur.TabIndex = 13;
            this.btn_yetkiDusur.Text = "Kullanıcı Yetki Düşür";
            this.btn_yetkiDusur.UseVisualStyleBackColor = false;
            this.btn_yetkiDusur.Click += new System.EventHandler(this.btn_yetkiDusur_Click);
            // 
            // btn_kullaniciYetki
            // 
            this.btn_kullaniciYetki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_kullaniciYetki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kullaniciYetki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kullaniciYetki.Location = new System.Drawing.Point(400, 431);
            this.btn_kullaniciYetki.Name = "btn_kullaniciYetki";
            this.btn_kullaniciYetki.Size = new System.Drawing.Size(121, 35);
            this.btn_kullaniciYetki.TabIndex = 12;
            this.btn_kullaniciYetki.Text = "Kullanıcı Yetkilendir";
            this.btn_kullaniciYetki.UseVisualStyleBackColor = false;
            this.btn_kullaniciYetki.Click += new System.EventHandler(this.btn_kullaniciYetki_Click);
            // 
            // btn_kullaniciSil
            // 
            this.btn_kullaniciSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_kullaniciSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kullaniciSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kullaniciSil.Location = new System.Drawing.Point(136, 431);
            this.btn_kullaniciSil.Name = "btn_kullaniciSil";
            this.btn_kullaniciSil.Size = new System.Drawing.Size(121, 35);
            this.btn_kullaniciSil.TabIndex = 10;
            this.btn_kullaniciSil.Text = "Kullanıcı Sil";
            this.btn_kullaniciSil.UseVisualStyleBackColor = false;
            this.btn_kullaniciSil.Click += new System.EventHandler(this.btn_kullaniciSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(894, 394);
            this.dataGridView1.TabIndex = 9;
            // 
            // kullaniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 503);
            this.Controls.Add(this.btn_yetkiDusur);
            this.Controls.Add(this.btn_kullaniciYetki);
            this.Controls.Add(this.btn_kullaniciSil);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "kullaniciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KULLANICI DENETİM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kullaniciForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_yetkiDusur;
        private System.Windows.Forms.Button btn_kullaniciYetki;
        private System.Windows.Forms.Button btn_kullaniciSil;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}