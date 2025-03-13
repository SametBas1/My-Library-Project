namespace KitaplıkProjesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.btngnclle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkyt = new System.Windows.Forms.Button();
            this.btnlst = new System.Windows.Forms.Button();
            this.txtyynevi = new System.Windows.Forms.TextBox();
            this.txtfyt = new System.Windows.Forms.TextBox();
            this.txtsyf = new System.Windows.Forms.TextBox();
            this.txtyzr = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.cmbTur);
            this.splitContainer1.Panel1.Controls.Add(this.btngnclle);
            this.splitContainer1.Panel1.Controls.Add(this.btnsil);
            this.splitContainer1.Panel1.Controls.Add(this.btnkyt);
            this.splitContainer1.Panel1.Controls.Add(this.btnlst);
            this.splitContainer1.Panel1.Controls.Add(this.txtyynevi);
            this.splitContainer1.Panel1.Controls.Add(this.txtfyt);
            this.splitContainer1.Panel1.Controls.Add(this.txtsyf);
            this.splitContainer1.Panel1.Controls.Add(this.txtyzr);
            this.splitContainer1.Panel1.Controls.Add(this.txtad);
            this.splitContainer1.Panel1.Controls.Add(this.txtıd);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1443, 650);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.TabIndex = 0;
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(133, 284);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(200, 24);
            this.cmbTur.TabIndex = 17;
            // 
            // btngnclle
            // 
            this.btngnclle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btngnclle.FlatAppearance.BorderSize = 0;
            this.btngnclle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngnclle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngnclle.Location = new System.Drawing.Point(42, 462);
            this.btngnclle.Name = "btngnclle";
            this.btngnclle.Size = new System.Drawing.Size(295, 36);
            this.btngnclle.TabIndex = 16;
            this.btngnclle.Text = "GÜNCELLE";
            this.btngnclle.UseVisualStyleBackColor = false;
            this.btngnclle.Click += new System.EventHandler(this.btngnclle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Crimson;
            this.btnsil.FlatAppearance.BorderSize = 0;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(42, 420);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(295, 36);
            this.btnsil.TabIndex = 15;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkyt
            // 
            this.btnkyt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnkyt.FlatAppearance.BorderSize = 0;
            this.btnkyt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkyt.Location = new System.Drawing.Point(42, 378);
            this.btnkyt.Name = "btnkyt";
            this.btnkyt.Size = new System.Drawing.Size(295, 36);
            this.btnkyt.TabIndex = 14;
            this.btnkyt.Text = "KAYDET";
            this.btnkyt.UseVisualStyleBackColor = false;
            this.btnkyt.Click += new System.EventHandler(this.btnkyt_Click);
            // 
            // btnlst
            // 
            this.btnlst.BackColor = System.Drawing.SystemColors.Info;
            this.btnlst.FlatAppearance.BorderSize = 0;
            this.btnlst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlst.Location = new System.Drawing.Point(42, 336);
            this.btnlst.Name = "btnlst";
            this.btnlst.Size = new System.Drawing.Size(295, 36);
            this.btnlst.TabIndex = 13;
            this.btnlst.Text = "LİSTELE";
            this.btnlst.UseVisualStyleBackColor = false;
            this.btnlst.Click += new System.EventHandler(this.btnlst_Click);
            // 
            // txtyynevi
            // 
            this.txtyynevi.Location = new System.Drawing.Point(133, 246);
            this.txtyynevi.Name = "txtyynevi";
            this.txtyynevi.Size = new System.Drawing.Size(200, 22);
            this.txtyynevi.TabIndex = 11;
            // 
            // txtfyt
            // 
            this.txtfyt.Location = new System.Drawing.Point(133, 207);
            this.txtfyt.Name = "txtfyt";
            this.txtfyt.Size = new System.Drawing.Size(200, 22);
            this.txtfyt.TabIndex = 1;
            // 
            // txtsyf
            // 
            this.txtsyf.Location = new System.Drawing.Point(133, 168);
            this.txtsyf.Name = "txtsyf";
            this.txtsyf.Size = new System.Drawing.Size(200, 22);
            this.txtsyf.TabIndex = 10;
            // 
            // txtyzr
            // 
            this.txtyzr.Location = new System.Drawing.Point(133, 127);
            this.txtyzr.Name = "txtyzr";
            this.txtyzr.Size = new System.Drawing.Size(200, 22);
            this.txtyzr.TabIndex = 9;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(133, 84);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(200, 22);
            this.txtad.TabIndex = 8;
            // 
            // txtıd
            // 
            this.txtıd.Enabled = false;
            this.txtıd.Location = new System.Drawing.Point(133, 42);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(200, 22);
            this.txtıd.TabIndex = 7;
            this.txtıd.Leave += new System.EventHandler(this.Form1_Load);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tür:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yayın Evi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sayfa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap ID:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1103, 650);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1097, 530);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 539);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1097, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 650);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplık Projesi ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsyf;
        private System.Windows.Forms.TextBox txtyzr;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtyynevi;
        private System.Windows.Forms.TextBox txtfyt;
        private System.Windows.Forms.Button btngnclle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkyt;
        private System.Windows.Forms.Button btnlst;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

