namespace Givinfo
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("1 Basamaklı");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("2 Basamaklı");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("3 Basamaklı");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("TOPLAMA İŞLEMİ", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("1 Basamaklı");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("2 Basamaklı");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("3 Basamaklı");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("ÇIKARMA İŞLEMİ", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("1 Basamaklı");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("2 Basamaklı");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("3 Basamaklı");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("ÇARPMA İŞLEMİ", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("1 Basamaklı");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("2 Basamaklı");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("3 Basamaklı");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("BÖLME İŞLEMİ", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.ForeColor = System.Drawing.Color.Navy;
            this.treeView1.Location = new System.Drawing.Point(12, 51);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node4";
            treeNode1.Text = "1 Basamaklı";
            treeNode2.Name = "Node5";
            treeNode2.Text = "2 Basamaklı";
            treeNode3.Name = "Node6";
            treeNode3.Text = "3 Basamaklı";
            treeNode4.Name = "Node0";
            treeNode4.Text = "TOPLAMA İŞLEMİ";
            treeNode5.Name = "Node7";
            treeNode5.Text = "1 Basamaklı";
            treeNode6.Name = "Node8";
            treeNode6.Text = "2 Basamaklı";
            treeNode7.Name = "Node9";
            treeNode7.Text = "3 Basamaklı";
            treeNode8.Name = "Node1";
            treeNode8.Text = "ÇIKARMA İŞLEMİ";
            treeNode9.Name = "Node10";
            treeNode9.Text = "1 Basamaklı";
            treeNode10.Name = "Node11";
            treeNode10.Text = "2 Basamaklı";
            treeNode11.Name = "Node12";
            treeNode11.Text = "3 Basamaklı";
            treeNode12.Name = "Node2";
            treeNode12.Text = "ÇARPMA İŞLEMİ";
            treeNode13.Name = "Node13";
            treeNode13.Text = "1 Basamaklı";
            treeNode14.Name = "Node14";
            treeNode14.Text = "2 Basamaklı";
            treeNode15.Name = "Node15";
            treeNode15.Text = "3 Basamaklı";
            treeNode16.Name = "Node3";
            treeNode16.Text = "BÖLME İŞLEMİ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12,
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(142, 267);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(161, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "ÜRET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(160, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "label8";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(160, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 87);
            this.panel2.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(210, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "SONUÇ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(217, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "label11";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(182, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "=";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(202, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(71, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(71, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "+";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(161, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 77);
            this.panel3.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(4, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 50);
            this.button2.TabIndex = 12;
            this.button2.Text = "KONTROL ET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(165, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "label12";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(163, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(54, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "MATEMATİK - DÖRT İŞLEM OYUNU";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
    }
}