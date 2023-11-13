namespace nwap3010
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
            panel1 = new Panel();
            btnspara = new Button();
            btnspsil = new Button();
            btnspnkaydet = new Button();
            nupbirimfiyat = new NumericUpDown();
            cmbtedarik = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            cmbkategori = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txturunad = new TextBox();
            txturunid = new TextBox();
            btnguncel = new Button();
            btnbul = new Button();
            btnsil = new Button();
            btnkaydet = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupbirimfiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnspara);
            panel1.Controls.Add(btnspsil);
            panel1.Controls.Add(btnspnkaydet);
            panel1.Controls.Add(nupbirimfiyat);
            panel1.Controls.Add(cmbtedarik);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbkategori);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txturunad);
            panel1.Controls.Add(txturunid);
            panel1.Controls.Add(btnguncel);
            panel1.Controls.Add(btnbul);
            panel1.Controls.Add(btnsil);
            panel1.Controls.Add(btnkaydet);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1247, 236);
            panel1.TabIndex = 1;
            // 
            // btnspara
            // 
            btnspara.Location = new Point(717, 154);
            btnspara.Margin = new Padding(3, 4, 3, 4);
            btnspara.Name = "btnspara";
            btnspara.Size = new Size(129, 59);
            btnspara.TabIndex = 8;
            btnspara.Text = "Procedure Ara";
            btnspara.UseVisualStyleBackColor = true;
            btnspara.Click += btnspara_Click;
            // 
            // btnspsil
            // 
            btnspsil.Location = new Point(717, 80);
            btnspsil.Margin = new Padding(3, 4, 3, 4);
            btnspsil.Name = "btnspsil";
            btnspsil.Size = new Size(129, 66);
            btnspsil.TabIndex = 7;
            btnspsil.Text = "Procedure Sil";
            btnspsil.UseVisualStyleBackColor = true;
            btnspsil.Click += btnspsil_Click;
            // 
            // btnspnkaydet
            // 
            btnspnkaydet.Location = new Point(717, 15);
            btnspnkaydet.Margin = new Padding(3, 4, 3, 4);
            btnspnkaydet.Name = "btnspnkaydet";
            btnspnkaydet.Size = new Size(129, 61);
            btnspnkaydet.TabIndex = 6;
            btnspnkaydet.Text = "Procedur Kaydet";
            btnspnkaydet.UseVisualStyleBackColor = true;
            btnspnkaydet.Click += btnspnkaydet_Click;
            // 
            // nupbirimfiyat
            // 
            nupbirimfiyat.Location = new Point(117, 184);
            nupbirimfiyat.Margin = new Padding(3, 4, 3, 4);
            nupbirimfiyat.Name = "nupbirimfiyat";
            nupbirimfiyat.Size = new Size(137, 27);
            nupbirimfiyat.TabIndex = 5;
            // 
            // cmbtedarik
            // 
            cmbtedarik.FormattingEnabled = true;
            cmbtedarik.Items.AddRange(new object[] { "Deneme", "deneme1" });
            cmbtedarik.Location = new Point(117, 133);
            cmbtedarik.Margin = new Padding(3, 4, 3, 4);
            cmbtedarik.Name = "cmbtedarik";
            cmbtedarik.Size = new Size(201, 28);
            cmbtedarik.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 180);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 3;
            label5.Text = "Birim Fiyatı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 141);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 3;
            label4.Text = "Tedarikçi Adı";
            // 
            // cmbkategori
            // 
            cmbkategori.FormattingEnabled = true;
            cmbkategori.Location = new Point(117, 95);
            cmbkategori.Margin = new Padding(3, 4, 3, 4);
            cmbkategori.Name = "cmbkategori";
            cmbkategori.Size = new Size(201, 28);
            cmbkategori.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 103);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 3;
            label3.Text = "Kategori Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 56);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 3;
            label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 17);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 3;
            label1.Text = "Ürün ID";
            // 
            // txturunad
            // 
            txturunad.Location = new Point(117, 56);
            txturunad.Margin = new Padding(3, 4, 3, 4);
            txturunad.Name = "txturunad";
            txturunad.Size = new Size(209, 27);
            txturunad.TabIndex = 2;
            // 
            // txturunid
            // 
            txturunid.Location = new Point(117, 17);
            txturunid.Margin = new Padding(3, 4, 3, 4);
            txturunid.Name = "txturunid";
            txturunid.Size = new Size(114, 27);
            txturunid.TabIndex = 2;
            // 
            // btnguncel
            // 
            btnguncel.Location = new Point(586, 148);
            btnguncel.Margin = new Padding(3, 4, 3, 4);
            btnguncel.Name = "btnguncel";
            btnguncel.Size = new Size(86, 31);
            btnguncel.TabIndex = 1;
            btnguncel.Text = "Güncelle";
            btnguncel.UseVisualStyleBackColor = true;
            btnguncel.Click += btnguncel_Click;
            // 
            // btnbul
            // 
            btnbul.Location = new Point(586, 109);
            btnbul.Margin = new Padding(3, 4, 3, 4);
            btnbul.Name = "btnbul";
            btnbul.Size = new Size(86, 31);
            btnbul.TabIndex = 1;
            btnbul.Text = "Bul";
            btnbul.UseVisualStyleBackColor = true;
            btnbul.Click += btnbul_Click;
            // 
            // btnsil
            // 
            btnsil.Location = new Point(449, 60);
            btnsil.Margin = new Padding(3, 4, 3, 4);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(256, 31);
            btnsil.TabIndex = 1;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = true;
            btnsil.Click += btnsil_Click;
            // 
            // btnkaydet
            // 
            btnkaydet.Location = new Point(449, 17);
            btnkaydet.Margin = new Padding(3, 4, 3, 4);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(256, 31);
            btnkaydet.TabIndex = 1;
            btnkaydet.Text = "Kaydet";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 236);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1247, 669);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 905);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Kuzey Yeli VT";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupbirimfiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txturunad;
        private TextBox txturunid;
        private Button btnkaydet;
        private DataGridView dataGridView1;
        private NumericUpDown nupbirimfiyat;
        private ComboBox cmbtedarik;
        private Label label5;
        private Label label4;
        private ComboBox cmbkategori;
        private Label label3;
        private Button btnguncel;
        private Button btnbul;
        private Button btnsil;
        private Button btnspara;
        private Button btnspsil;
        private Button btnspnkaydet;
    }
}