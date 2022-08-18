namespace csharp_emlakprojesi_my
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnlistele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnmusteri = new System.Windows.Forms.Button();
            this.btnilan = new System.Windows.Forms.Button();
            this.btnyardım = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategory ID:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(166, 8);
            this.txtid.Margin = new System.Windows.Forms.Padding(6);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(196, 29);
            this.txtid.TabIndex = 1;
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(428, 8);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(134, 39);
            this.btnlistele.TabIndex = 2;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 311);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategory Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Açıklama:";
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(166, 90);
            this.txtdes.Margin = new System.Windows.Forms.Padding(6);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(196, 108);
            this.txtdes.TabIndex = 6;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(166, 49);
            this.txtad.Margin = new System.Windows.Forms.Padding(6);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(196, 29);
            this.txtad.TabIndex = 7;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(428, 53);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(134, 39);
            this.btnekle.TabIndex = 8;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(428, 98);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(134, 39);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(428, 143);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(134, 39);
            this.btnguncelle.TabIndex = 10;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnmusteri
            // 
            this.btnmusteri.Location = new System.Drawing.Point(611, 8);
            this.btnmusteri.Name = "btnmusteri";
            this.btnmusteri.Size = new System.Drawing.Size(134, 39);
            this.btnmusteri.TabIndex = 11;
            this.btnmusteri.Text = "Müşteriler";
            this.btnmusteri.UseVisualStyleBackColor = true;
            // 
            // btnilan
            // 
            this.btnilan.Location = new System.Drawing.Point(611, 52);
            this.btnilan.Name = "btnilan";
            this.btnilan.Size = new System.Drawing.Size(134, 39);
            this.btnilan.TabIndex = 12;
            this.btnilan.Text = "İlanlar";
            this.btnilan.UseVisualStyleBackColor = true;
            // 
            // btnyardım
            // 
            this.btnyardım.Location = new System.Drawing.Point(611, 98);
            this.btnyardım.Name = "btnyardım";
            this.btnyardım.Size = new System.Drawing.Size(134, 39);
            this.btnyardım.TabIndex = 13;
            this.btnyardım.Text = "Yardım";
            this.btnyardım.UseVisualStyleBackColor = true;
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(611, 143);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(134, 39);
            this.btncikis.TabIndex = 14;
            this.btncikis.Text = "Çıkış Yap";
            this.btncikis.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 539);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnyardım);
            this.Controls.Add(this.btnilan);
            this.Controls.Add(this.btnmusteri);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnmusteri;
        private System.Windows.Forms.Button btnilan;
        private System.Windows.Forms.Button btnyardım;
        private System.Windows.Forms.Button btncikis;
    }
}

