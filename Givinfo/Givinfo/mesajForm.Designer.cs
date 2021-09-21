namespace Givinfo
{
    partial class mesajForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mesajForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_gelen_mesaj = new System.Windows.Forms.TextBox();
            this.dgv_gelen_kutusu = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.kullanicilar = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_giden_mesaj = new System.Windows.Forms.TextBox();
            this.dgv_giden_kutusu = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gelen_kutusu)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_giden_kutusu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(899, 430);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_gelen_mesaj);
            this.tabPage1.Controls.Add(this.dgv_gelen_kutusu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(891, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gelen Kutusu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(751, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 38);
            this.button3.TabIndex = 14;
            this.button3.Text = "Gönder";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(16, 232);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(849, 119);
            this.textBox1.TabIndex = 13;
            this.textBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(345, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Mesajı Cevapla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(16, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "<<<Mesajlara Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(330, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "GELEN KUTUNUZ BOŞ...";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(137, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "İlgili Mesajı Tam Şekilde Görebilmek İçin Mesajın Bulunduğu Satıra Çift Tıklayın." +
    "..";
            // 
            // txt_gelen_mesaj
            // 
            this.txt_gelen_mesaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_gelen_mesaj.Enabled = false;
            this.txt_gelen_mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_gelen_mesaj.Location = new System.Drawing.Point(16, 26);
            this.txt_gelen_mesaj.Multiline = true;
            this.txt_gelen_mesaj.Name = "txt_gelen_mesaj";
            this.txt_gelen_mesaj.ReadOnly = true;
            this.txt_gelen_mesaj.Size = new System.Drawing.Size(849, 153);
            this.txt_gelen_mesaj.TabIndex = 4;
            this.txt_gelen_mesaj.Visible = false;
            // 
            // dgv_gelen_kutusu
            // 
            this.dgv_gelen_kutusu.AllowUserToAddRows = false;
            this.dgv_gelen_kutusu.AllowUserToDeleteRows = false;
            this.dgv_gelen_kutusu.AllowUserToResizeColumns = false;
            this.dgv_gelen_kutusu.AllowUserToResizeRows = false;
            this.dgv_gelen_kutusu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_gelen_kutusu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gelen_kutusu.Location = new System.Drawing.Point(16, 26);
            this.dgv_gelen_kutusu.Name = "dgv_gelen_kutusu";
            this.dgv_gelen_kutusu.ReadOnly = true;
            this.dgv_gelen_kutusu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_gelen_kutusu.Size = new System.Drawing.Size(849, 153);
            this.dgv_gelen_kutusu.TabIndex = 3;
            this.dgv_gelen_kutusu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gelen_kutusu_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.kullanicilar);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_giden_mesaj);
            this.tabPage2.Controls.Add(this.dgv_giden_kutusu);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(891, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Giden Kutusu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(806, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Gönder";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // kullanicilar
            // 
            this.kullanicilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kullanicilar.FormattingEnabled = true;
            this.kullanicilar.Location = new System.Drawing.Point(9, 26);
            this.kullanicilar.Name = "kullanicilar";
            this.kullanicilar.Size = new System.Drawing.Size(147, 368);
            this.kullanicilar.TabIndex = 17;
            this.kullanicilar.SelectedIndexChanged += new System.EventHandler(this.kullanicilar_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(437, 185);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 41);
            this.button5.TabIndex = 16;
            this.button5.Text = "Mesajı Sil";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(413, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "GİDEN KUTUNUZ BOŞ...";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(135, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(652, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "İlgili Mesajı Tam Şekilde Görebilmek İçin Mesajın Bulunduğu Satıra Çift Tıklayın." +
    "..";
            // 
            // txt_giden_mesaj
            // 
            this.txt_giden_mesaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_giden_mesaj.Enabled = false;
            this.txt_giden_mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_giden_mesaj.ForeColor = System.Drawing.Color.Gray;
            this.txt_giden_mesaj.Location = new System.Drawing.Point(162, 229);
            this.txt_giden_mesaj.Multiline = true;
            this.txt_giden_mesaj.Name = "txt_giden_mesaj";
            this.txt_giden_mesaj.ReadOnly = true;
            this.txt_giden_mesaj.Size = new System.Drawing.Size(719, 165);
            this.txt_giden_mesaj.TabIndex = 7;
            this.txt_giden_mesaj.Text = "GÖNDERECEĞİNİZ MESAJI BURAYA GİRİNİZ...";
            this.txt_giden_mesaj.Enter += new System.EventHandler(this.txt_giden_mesaj_Enter);
            // 
            // dgv_giden_kutusu
            // 
            this.dgv_giden_kutusu.AllowUserToAddRows = false;
            this.dgv_giden_kutusu.AllowUserToDeleteRows = false;
            this.dgv_giden_kutusu.AllowUserToResizeColumns = false;
            this.dgv_giden_kutusu.AllowUserToResizeRows = false;
            this.dgv_giden_kutusu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_giden_kutusu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_giden_kutusu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_giden_kutusu.Location = new System.Drawing.Point(162, 26);
            this.dgv_giden_kutusu.Name = "dgv_giden_kutusu";
            this.dgv_giden_kutusu.ReadOnly = true;
            this.dgv_giden_kutusu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_giden_kutusu.Size = new System.Drawing.Size(719, 153);
            this.dgv_giden_kutusu.TabIndex = 6;
            this.dgv_giden_kutusu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_giden_kutusu_CellDoubleClick);
            // 
            // mesajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 433);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mesajForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MESAJLAR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mesajForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gelen_kutusu)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_giden_kutusu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_gelen_mesaj;
        private System.Windows.Forms.DataGridView dgv_gelen_kutusu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_giden_mesaj;
        private System.Windows.Forms.DataGridView dgv_giden_kutusu;
        private System.Windows.Forms.ListBox kullanicilar;
        private System.Windows.Forms.Button button4;


    }
}