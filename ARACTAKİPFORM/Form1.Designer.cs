namespace ARACTAKİPFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxSaseno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxPlaka = new System.Windows.Forms.TextBox();
            this.chbxOnayliyorum = new System.Windows.Forms.CheckBox();
            this.bttnGiris = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volvoHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hataAyıklamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazılımHakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şase No:";
            // 
            // txtbxSaseno
            // 
            this.txtbxSaseno.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxSaseno.Location = new System.Drawing.Point(132, 172);
            this.txtbxSaseno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxSaseno.Name = "txtbxSaseno";
            this.txtbxSaseno.Size = new System.Drawing.Size(132, 22);
            this.txtbxSaseno.TabIndex = 1;
            this.txtbxSaseno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Plaka:";
            // 
            // txtbxPlaka
            // 
            this.txtbxPlaka.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxPlaka.Location = new System.Drawing.Point(132, 102);
            this.txtbxPlaka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxPlaka.Name = "txtbxPlaka";
            this.txtbxPlaka.Size = new System.Drawing.Size(132, 22);
            this.txtbxPlaka.TabIndex = 1;
            this.txtbxPlaka.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chbxOnayliyorum
            // 
            this.chbxOnayliyorum.AutoSize = true;
            this.chbxOnayliyorum.BackColor = System.Drawing.Color.Silver;
            this.chbxOnayliyorum.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbxOnayliyorum.Location = new System.Drawing.Point(33, 224);
            this.chbxOnayliyorum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbxOnayliyorum.Name = "chbxOnayliyorum";
            this.chbxOnayliyorum.Size = new System.Drawing.Size(106, 20);
            this.chbxOnayliyorum.TabIndex = 2;
            this.chbxOnayliyorum.Text = "Onayliyorum";
            this.chbxOnayliyorum.UseVisualStyleBackColor = false;
            this.chbxOnayliyorum.CheckedChanged += new System.EventHandler(this.chbxOnayliyorum_CheckedChanged);
            // 
            // bttnGiris
            // 
            this.bttnGiris.BackColor = System.Drawing.Color.Silver;
            this.bttnGiris.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnGiris.Location = new System.Drawing.Point(33, 293);
            this.bttnGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnGiris.Name = "bttnGiris";
            this.bttnGiris.Size = new System.Drawing.Size(100, 28);
            this.bttnGiris.TabIndex = 3;
            this.bttnGiris.Text = "Giriş";
            this.bttnGiris.UseVisualStyleBackColor = false;
            this.bttnGiris.Click += new System.EventHandler(this.bttnGiris_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volvoHakkındaToolStripMenuItem,
            this.hataAyıklamaToolStripMenuItem,
            this.yeniSorgulamaToolStripMenuItem,
            this.yazılımHakkindaToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volvoHakkındaToolStripMenuItem
            // 
            this.volvoHakkındaToolStripMenuItem.Name = "volvoHakkındaToolStripMenuItem";
            this.volvoHakkındaToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.volvoHakkındaToolStripMenuItem.Text = "Volvo Hakkında";
            // 
            // hataAyıklamaToolStripMenuItem
            // 
            this.hataAyıklamaToolStripMenuItem.Name = "hataAyıklamaToolStripMenuItem";
            this.hataAyıklamaToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.hataAyıklamaToolStripMenuItem.Text = "Hata ayıklama";
            this.hataAyıklamaToolStripMenuItem.Click += new System.EventHandler(this.hataAyıklamaToolStripMenuItem_Click);
            // 
            // yeniSorgulamaToolStripMenuItem
            // 
            this.yeniSorgulamaToolStripMenuItem.Name = "yeniSorgulamaToolStripMenuItem";
            this.yeniSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.yeniSorgulamaToolStripMenuItem.Text = "Yeni sorgulama";
            this.yeniSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.yeniSorgulamaToolStripMenuItem_Click);
            // 
            // yazılımHakkindaToolStripMenuItem
            // 
            this.yazılımHakkindaToolStripMenuItem.Name = "yazılımHakkindaToolStripMenuItem";
            this.yazılımHakkindaToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.yazılımHakkindaToolStripMenuItem.Text = "Yazılım Hakkinda";
            this.yazılımHakkindaToolStripMenuItem.Click += new System.EventHandler(this.yazılımHakkindaToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bttnGiris);
            this.Controls.Add(this.chbxOnayliyorum);
            this.Controls.Add(this.txtbxPlaka);
            this.Controls.Add(this.txtbxSaseno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxSaseno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxPlaka;
        private System.Windows.Forms.CheckBox chbxOnayliyorum;
        private System.Windows.Forms.Button bttnGiris;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volvoHakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hataAyıklamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazılımHakkindaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
    }
}

