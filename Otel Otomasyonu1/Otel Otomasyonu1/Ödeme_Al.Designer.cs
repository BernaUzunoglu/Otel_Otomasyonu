namespace Otel_Otomasyonu1
{
    partial class Odeme_Al
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odeme_Al));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ıd = new System.Windows.Forms.TextBox();
            this.txt_odnn = new System.Windows.Forms.TextBox();
            this.txt_Kln_Brc = new System.Windows.Forms.TextBox();
            this.dataGridViewodeme = new System.Windows.Forms.DataGridView();
            this.btn_Odeme_Al = new System.Windows.Forms.Button();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.otel_OtomasyonuDataSetBorclar = new Otel_Otomasyonu1.Otel_OtomasyonuDataSetBorclar();
            this.borclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borclarTableAdapter = new Otel_Otomasyonu1.Otel_OtomasyonuDataSetBorclarTableAdapters.BorclarTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewodeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otel_OtomasyonuDataSetBorclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ödenen ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kalan Borç";
            // 
            // txt_ıd
            // 
            this.txt_ıd.Location = new System.Drawing.Point(153, 43);
            this.txt_ıd.Name = "txt_ıd";
            this.txt_ıd.Size = new System.Drawing.Size(122, 20);
            this.txt_ıd.TabIndex = 3;
            // 
            // txt_odnn
            // 
            this.txt_odnn.Location = new System.Drawing.Point(153, 104);
            this.txt_odnn.Name = "txt_odnn";
            this.txt_odnn.Size = new System.Drawing.Size(122, 20);
            this.txt_odnn.TabIndex = 4;
            // 
            // txt_Kln_Brc
            // 
            this.txt_Kln_Brc.Location = new System.Drawing.Point(153, 140);
            this.txt_Kln_Brc.Name = "txt_Kln_Brc";
            this.txt_Kln_Brc.Size = new System.Drawing.Size(122, 20);
            this.txt_Kln_Brc.TabIndex = 5;
            // 
            // dataGridViewodeme
            // 
            this.dataGridViewodeme.AutoGenerateColumns = false;
            this.dataGridViewodeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewodeme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewodeme.DataSource = this.borclarBindingSource;
            this.dataGridViewodeme.Location = new System.Drawing.Point(313, 43);
            this.dataGridViewodeme.Name = "dataGridViewodeme";
            this.dataGridViewodeme.Size = new System.Drawing.Size(441, 150);
            this.dataGridViewodeme.TabIndex = 6;
            this.dataGridViewodeme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Odeme_Al
            // 
            this.btn_Odeme_Al.Location = new System.Drawing.Point(170, 177);
            this.btn_Odeme_Al.Name = "btn_Odeme_Al";
            this.btn_Odeme_Al.Size = new System.Drawing.Size(78, 23);
            this.btn_Odeme_Al.TabIndex = 7;
            this.btn_Odeme_Al.Text = "Ödeme AL";
            this.btn_Odeme_Al.UseVisualStyleBackColor = true;
            this.btn_Odeme_Al.Click += new System.EventHandler(this.btn_Odeme_Al_Click);
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(153, 78);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(122, 20);
            this.txt_AdSoyad.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adı Soyadı";
            // 
            // otel_OtomasyonuDataSetBorclar
            // 
            this.otel_OtomasyonuDataSetBorclar.DataSetName = "Otel_OtomasyonuDataSetBorclar";
            this.otel_OtomasyonuDataSetBorclar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borclarBindingSource
            // 
            this.borclarBindingSource.DataMember = "Borclar";
            this.borclarBindingSource.DataSource = this.otel_OtomasyonuDataSetBorclar;
            // 
            // borclarTableAdapter
            // 
            this.borclarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Musteri_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Musteri_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Adı_Soyadı";
            this.dataGridViewTextBoxColumn2.HeaderText = "Adı_Soyadı";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ucret";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ucret";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Kalan_Borc";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kalan_Borc";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Odeme_Al
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 276);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Odeme_Al);
            this.Controls.Add(this.dataGridViewodeme);
            this.Controls.Add(this.txt_Kln_Brc);
            this.Controls.Add(this.txt_odnn);
            this.Controls.Add(this.txt_ıd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Odeme_Al";
            this.Text = "Ödeme_Al";
            this.Load += new System.EventHandler(this.Ödeme_Al_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewodeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otel_OtomasyonuDataSetBorclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ıd;
        private System.Windows.Forms.TextBox txt_odnn;
        private System.Windows.Forms.TextBox txt_Kln_Brc;
        private System.Windows.Forms.DataGridView dataGridViewodeme;
        private System.Windows.Forms.Button btn_Odeme_Al;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adıSoyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalanBorcDataGridViewTextBoxColumn;
        private Otel_OtomasyonuDataSetBorclar otel_OtomasyonuDataSetBorclar;
        private System.Windows.Forms.BindingSource borclarBindingSource;
        private Otel_OtomasyonuDataSetBorclarTableAdapters.BorclarTableAdapter borclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}