﻿namespace TokoPunakawan
{
    partial class DaftarMenu
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Harga = new System.Windows.Forms.TextBox();
            this.Jenis_Menu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Id_Menu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nama_Makanan = new System.Windows.Forms.TextBox();
            this.menuMakananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toko_Punakawan1DataSet = new TokoPunakawan.Toko_Punakawan1DataSet();
            this.menuMakananBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menu_MakananTableAdapter = new TokoPunakawan.Toko_Punakawan1DataSetTableAdapters.Menu_MakananTableAdapter();
            this.idMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaMakananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuMakananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_Punakawan1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuMakananBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 66);
            this.label1.TabIndex = 29;
            this.label1.Text = "Daftar Menu";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(400, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMenuDataGridViewTextBoxColumn,
            this.namaMakananDataGridViewTextBoxColumn,
            this.jenisMenuDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.menuMakananBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(131, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(965, 253);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Harga
            // 
            this.Harga.Location = new System.Drawing.Point(350, 164);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(147, 22);
            this.Harga.TabIndex = 23;
            // 
            // Jenis_Menu
            // 
            this.Jenis_Menu.Location = new System.Drawing.Point(350, 118);
            this.Jenis_Menu.Name = "Jenis_Menu";
            this.Jenis_Menu.Size = new System.Drawing.Size(147, 22);
            this.Jenis_Menu.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Jenis Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nama Makanan / Minuman";
            // 
            // Id_Menu
            // 
            this.Id_Menu.Location = new System.Drawing.Point(350, 32);
            this.Id_Menu.Name = "Id_Menu";
            this.Id_Menu.Size = new System.Drawing.Size(147, 22);
            this.Id_Menu.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID Menu";
            // 
            // Nama_Makanan
            // 
            this.Nama_Makanan.Location = new System.Drawing.Point(350, 73);
            this.Nama_Makanan.Name = "Nama_Makanan";
            this.Nama_Makanan.Size = new System.Drawing.Size(147, 22);
            this.Nama_Makanan.TabIndex = 16;
            // 
            // menuMakananBindingSource
            // 
            this.menuMakananBindingSource.DataMember = "Menu_Makanan";
            // 
            // toko_Punakawan1DataSet
            // 
            this.toko_Punakawan1DataSet.DataSetName = "Toko_Punakawan1DataSet";
            this.toko_Punakawan1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuMakananBindingSource1
            // 
            this.menuMakananBindingSource1.DataMember = "Menu_Makanan";
            this.menuMakananBindingSource1.DataSource = this.toko_Punakawan1DataSet;
            // 
            // menu_MakananTableAdapter
            // 
            this.menu_MakananTableAdapter.ClearBeforeFill = true;
            // 
            // idMenuDataGridViewTextBoxColumn
            // 
            this.idMenuDataGridViewTextBoxColumn.DataPropertyName = "Id_Menu";
            this.idMenuDataGridViewTextBoxColumn.HeaderText = "Id_Menu";
            this.idMenuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMenuDataGridViewTextBoxColumn.Name = "idMenuDataGridViewTextBoxColumn";
            // 
            // namaMakananDataGridViewTextBoxColumn
            // 
            this.namaMakananDataGridViewTextBoxColumn.DataPropertyName = "Nama_Makanan";
            this.namaMakananDataGridViewTextBoxColumn.HeaderText = "Nama_Makanan";
            this.namaMakananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaMakananDataGridViewTextBoxColumn.Name = "namaMakananDataGridViewTextBoxColumn";
            // 
            // jenisMenuDataGridViewTextBoxColumn
            // 
            this.jenisMenuDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Menu";
            this.jenisMenuDataGridViewTextBoxColumn.HeaderText = "Jenis_Menu";
            this.jenisMenuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenisMenuDataGridViewTextBoxColumn.Name = "jenisMenuDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // DaftarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.Jenis_Menu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Id_Menu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nama_Makanan);
            this.Name = "DaftarMenu";
            this.Text = "DaftarMenu";
            this.Load += new System.EventHandler(this.DaftarMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuMakananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_Punakawan1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuMakananBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource menuMakananBindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Harga;
        private System.Windows.Forms.TextBox Jenis_Menu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Id_Menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nama_Makanan;
        private Toko_Punakawan1DataSet toko_Punakawan1DataSet;
        private System.Windows.Forms.BindingSource menuMakananBindingSource1;
        private Toko_Punakawan1DataSetTableAdapters.Menu_MakananTableAdapter menu_MakananTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMakananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisMenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
    }
}