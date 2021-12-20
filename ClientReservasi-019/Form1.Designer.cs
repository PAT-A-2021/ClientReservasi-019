
namespace ClientReservasi_019
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNoTlf = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxIDLokasi = new System.Windows.Forms.TextBox();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.dtPemesanan = new System.Windows.Forms.DataGridView();
            this.wCFReservasiDataSet = new ClientReservasi_019.WCFReservasiDataSet();
            this.pemesananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pemesananTableAdapter = new ClientReservasi_019.WCFReservasiDataSetTableAdapters.PemesananTableAdapter();
            this.iDreservasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namacustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notelponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahpemesananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDlokasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCFReservasiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Reservasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "No Telfon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah Pemesanan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Lokasi";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(150, 62);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(286, 22);
            this.textBoxID.TabIndex = 5;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(150, 108);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(286, 22);
            this.textBoxNama.TabIndex = 6;
            // 
            // textBoxNoTlf
            // 
            this.textBoxNoTlf.Location = new System.Drawing.Point(150, 159);
            this.textBoxNoTlf.Name = "textBoxNoTlf";
            this.textBoxNoTlf.Size = new System.Drawing.Size(286, 22);
            this.textBoxNoTlf.TabIndex = 7;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Location = new System.Drawing.Point(150, 211);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(286, 22);
            this.textBoxJumlah.TabIndex = 8;
            // 
            // textBoxIDLokasi
            // 
            this.textBoxIDLokasi.Location = new System.Drawing.Point(150, 260);
            this.textBoxIDLokasi.Name = "textBoxIDLokasi";
            this.textBoxIDLokasi.Size = new System.Drawing.Size(286, 22);
            this.textBoxIDLokasi.TabIndex = 9;
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(549, 85);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(75, 29);
            this.btSimpan.TabIndex = 10;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(549, 134);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 30);
            this.btUpdate.TabIndex = 11;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(549, 187);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(75, 29);
            this.btHapus.TabIndex = 12;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(549, 237);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 31);
            this.btClear.TabIndex = 13;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // dtPemesanan
            // 
            this.dtPemesanan.AutoGenerateColumns = false;
            this.dtPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPemesanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDreservasiDataGridViewTextBoxColumn,
            this.namacustomerDataGridViewTextBoxColumn,
            this.notelponDataGridViewTextBoxColumn,
            this.jumlahpemesananDataGridViewTextBoxColumn,
            this.iDlokasiDataGridViewTextBoxColumn});
            this.dtPemesanan.DataSource = this.pemesananBindingSource;
            this.dtPemesanan.Location = new System.Drawing.Point(12, 304);
            this.dtPemesanan.Name = "dtPemesanan";
            this.dtPemesanan.RowHeadersWidth = 51;
            this.dtPemesanan.RowTemplate.Height = 24;
            this.dtPemesanan.Size = new System.Drawing.Size(681, 226);
            this.dtPemesanan.TabIndex = 14;
            this.dtPemesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPemesanan_CellContentClick);
            // 
            // wCFReservasiDataSet
            // 
            this.wCFReservasiDataSet.DataSetName = "WCFReservasiDataSet";
            this.wCFReservasiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pemesananBindingSource
            // 
            this.pemesananBindingSource.DataMember = "Pemesanan";
            this.pemesananBindingSource.DataSource = this.wCFReservasiDataSet;
            // 
            // pemesananTableAdapter
            // 
            this.pemesananTableAdapter.ClearBeforeFill = true;
            // 
            // iDreservasiDataGridViewTextBoxColumn
            // 
            this.iDreservasiDataGridViewTextBoxColumn.DataPropertyName = "ID_reservasi";
            this.iDreservasiDataGridViewTextBoxColumn.HeaderText = "ID_reservasi";
            this.iDreservasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDreservasiDataGridViewTextBoxColumn.Name = "iDreservasiDataGridViewTextBoxColumn";
            this.iDreservasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // namacustomerDataGridViewTextBoxColumn
            // 
            this.namacustomerDataGridViewTextBoxColumn.DataPropertyName = "Nama_customer";
            this.namacustomerDataGridViewTextBoxColumn.HeaderText = "Nama_customer";
            this.namacustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namacustomerDataGridViewTextBoxColumn.Name = "namacustomerDataGridViewTextBoxColumn";
            this.namacustomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // notelponDataGridViewTextBoxColumn
            // 
            this.notelponDataGridViewTextBoxColumn.DataPropertyName = "No_telpon";
            this.notelponDataGridViewTextBoxColumn.HeaderText = "No_telpon";
            this.notelponDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notelponDataGridViewTextBoxColumn.Name = "notelponDataGridViewTextBoxColumn";
            this.notelponDataGridViewTextBoxColumn.Width = 125;
            // 
            // jumlahpemesananDataGridViewTextBoxColumn
            // 
            this.jumlahpemesananDataGridViewTextBoxColumn.DataPropertyName = "Jumlah_pemesanan";
            this.jumlahpemesananDataGridViewTextBoxColumn.HeaderText = "Jumlah_pemesanan";
            this.jumlahpemesananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahpemesananDataGridViewTextBoxColumn.Name = "jumlahpemesananDataGridViewTextBoxColumn";
            this.jumlahpemesananDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDlokasiDataGridViewTextBoxColumn
            // 
            this.iDlokasiDataGridViewTextBoxColumn.DataPropertyName = "ID_lokasi";
            this.iDlokasiDataGridViewTextBoxColumn.HeaderText = "ID_lokasi";
            this.iDlokasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDlokasiDataGridViewTextBoxColumn.Name = "iDlokasiDataGridViewTextBoxColumn";
            this.iDlokasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.dtPemesanan);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.textBoxIDLokasi);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.textBoxNoTlf);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCFReservasiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNoTlf;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.TextBox textBoxIDLokasi;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.DataGridView dtPemesanan;
        private WCFReservasiDataSet wCFReservasiDataSet;
        private System.Windows.Forms.BindingSource pemesananBindingSource;
        private WCFReservasiDataSetTableAdapters.PemesananTableAdapter pemesananTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDreservasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namacustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notelponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahpemesananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDlokasiDataGridViewTextBoxColumn;
    }
}

