
namespace ProjeGeliştirme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnekle1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.tboxetek = new System.Windows.Forms.TextBox();
            this.btnekle4 = new System.Windows.Forms.Button();
            this.btnekle3 = new System.Windows.Forms.Button();
            this.btnekle2 = new System.Windows.Forms.Button();
            this.tboxkazak = new System.Windows.Forms.TextBox();
            this.tboxelb = new System.Windows.Forms.TextBox();
            this.tboxceket = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "LUMBERJACK";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(311, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "U.S. POLO";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(645, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "ADİDAS";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(923, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "NİKE";
            // 
            // btnekle1
            // 
            this.btnekle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnekle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle1.Location = new System.Drawing.Point(12, 492);
            this.btnekle1.Name = "btnekle1";
            this.btnekle1.Size = new System.Drawing.Size(114, 60);
            this.btnekle1.TabIndex = 4;
            this.btnekle1.Text = "Ekle";
            this.btnekle1.UseVisualStyleBackColor = false;
            this.btnekle1.Click += new System.EventHandler(this.btnekle1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 324);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(304, 54);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(235, 324);
            this.listBox2.TabIndex = 6;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.CadetBlue;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(634, 54);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(231, 324);
            this.listBox3.TabIndex = 7;
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.CadetBlue;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(908, 54);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(194, 324);
            this.listBox4.TabIndex = 8;
            // 
            // tboxetek
            // 
            this.tboxetek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxetek.Location = new System.Drawing.Point(12, 388);
            this.tboxetek.Multiline = true;
            this.tboxetek.Name = "tboxetek";
            this.tboxetek.Size = new System.Drawing.Size(234, 98);
            this.tboxetek.TabIndex = 16;
            // 
            // btnekle4
            // 
            this.btnekle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnekle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle4.Location = new System.Drawing.Point(908, 491);
            this.btnekle4.Name = "btnekle4";
            this.btnekle4.Size = new System.Drawing.Size(114, 60);
            this.btnekle4.TabIndex = 16;
            this.btnekle4.Text = "Ekle";
            this.btnekle4.UseVisualStyleBackColor = false;
            this.btnekle4.Click += new System.EventHandler(this.btnekle4_Click);
            // 
            // btnekle3
            // 
            this.btnekle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnekle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle3.Location = new System.Drawing.Point(634, 491);
            this.btnekle3.Name = "btnekle3";
            this.btnekle3.Size = new System.Drawing.Size(114, 60);
            this.btnekle3.TabIndex = 17;
            this.btnekle3.Text = "Ekle";
            this.btnekle3.UseVisualStyleBackColor = false;
            this.btnekle3.Click += new System.EventHandler(this.btnekle3_Click);
            // 
            // btnekle2
            // 
            this.btnekle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnekle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle2.Location = new System.Drawing.Point(304, 492);
            this.btnekle2.Name = "btnekle2";
            this.btnekle2.Size = new System.Drawing.Size(114, 60);
            this.btnekle2.TabIndex = 18;
            this.btnekle2.Text = "Ekle";
            this.btnekle2.UseVisualStyleBackColor = false;
            this.btnekle2.Click += new System.EventHandler(this.btnekle2_Click);
            // 
            // tboxkazak
            // 
            this.tboxkazak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxkazak.Location = new System.Drawing.Point(304, 389);
            this.tboxkazak.Multiline = true;
            this.tboxkazak.Name = "tboxkazak";
            this.tboxkazak.Size = new System.Drawing.Size(235, 97);
            this.tboxkazak.TabIndex = 19;
            // 
            // tboxelb
            // 
            this.tboxelb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxelb.Location = new System.Drawing.Point(634, 388);
            this.tboxelb.Multiline = true;
            this.tboxelb.Name = "tboxelb";
            this.tboxelb.Size = new System.Drawing.Size(213, 97);
            this.tboxelb.TabIndex = 20;
            // 
            // tboxceket
            // 
            this.tboxceket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxceket.Location = new System.Drawing.Point(908, 388);
            this.tboxceket.Multiline = true;
            this.tboxceket.Name = "tboxceket";
            this.tboxceket.Size = new System.Drawing.Size(185, 97);
            this.tboxceket.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 564);
            this.Controls.Add(this.tboxceket);
            this.Controls.Add(this.tboxelb);
            this.Controls.Add(this.tboxkazak);
            this.Controls.Add(this.btnekle2);
            this.Controls.Add(this.btnekle3);
            this.Controls.Add(this.btnekle4);
            this.Controls.Add(this.tboxetek);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnekle1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MAĞAZA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnekle1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.TextBox tboxetek;
        private System.Windows.Forms.Button btnekle4;
        private System.Windows.Forms.Button btnekle3;
        private System.Windows.Forms.Button btnekle2;
        private System.Windows.Forms.TextBox tboxkazak;
        private System.Windows.Forms.TextBox tboxelb;
        private System.Windows.Forms.TextBox tboxceket;
    }
}

