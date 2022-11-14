
namespace MesajSistemi
{
    partial class frmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.msktxtAlici = new System.Windows.Forms.MaskedTextBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridGiden = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridGelen = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rchtxtMesaj = new System.Windows.Forms.RichTextBox();
            this.lblCikis = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGiden)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGelen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msktxtAlici
            // 
            this.msktxtAlici.Location = new System.Drawing.Point(161, 42);
            this.msktxtAlici.Mask = "0000";
            this.msktxtAlici.Name = "msktxtAlici";
            this.msktxtAlici.Size = new System.Drawing.Size(171, 34);
            this.msktxtAlici.TabIndex = 1;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(161, 92);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(171, 34);
            this.txtBaslik.TabIndex = 2;
            // 
            // btnGonder
            // 
            this.btnGonder.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGonder.ForeColor = System.Drawing.Color.Black;
            this.btnGonder.Location = new System.Drawing.Point(161, 142);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(171, 34);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ad Soyad : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numara : ";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(341, 27);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 27);
            this.lblAdSoyad.TabIndex = 13;
            this.lblAdSoyad.Text = "Null";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(130, 27);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(60, 27);
            this.lblNumara.TabIndex = 12;
            this.lblNumara.Text = "0000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridGiden);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(547, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 252);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giden Kutusu";
            // 
            // gridGiden
            // 
            this.gridGiden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGiden.Location = new System.Drawing.Point(6, 33);
            this.gridGiden.Name = "gridGiden";
            this.gridGiden.RowHeadersWidth = 51;
            this.gridGiden.RowTemplate.Height = 24;
            this.gridGiden.Size = new System.Drawing.Size(517, 219);
            this.gridGiden.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridGelen);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(12, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 252);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gelen Kutusu";
            // 
            // gridGelen
            // 
            this.gridGelen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGelen.Location = new System.Drawing.Point(6, 33);
            this.gridGelen.Name = "gridGelen";
            this.gridGelen.RowHeadersWidth = 51;
            this.gridGelen.RowTemplate.Height = 24;
            this.gridGelen.Size = new System.Drawing.Size(517, 219);
            this.gridGelen.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rchtxtMesaj);
            this.groupBox1.Controls.Add(this.msktxtAlici);
            this.groupBox1.Controls.Add(this.txtBaslik);
            this.groupBox1.Controls.Add(this.btnGonder);
            this.groupBox1.Location = new System.Drawing.Point(13, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1064, 216);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesaj Paneli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mesaj : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Başlık : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Alıcı : ";
            // 
            // rchtxtMesaj
            // 
            this.rchtxtMesaj.Location = new System.Drawing.Point(446, 42);
            this.rchtxtMesaj.Name = "rchtxtMesaj";
            this.rchtxtMesaj.Size = new System.Drawing.Size(598, 159);
            this.rchtxtMesaj.TabIndex = 4;
            this.rchtxtMesaj.Text = "";
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCikis.Font = new System.Drawing.Font("Viner Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCikis.ForeColor = System.Drawing.Color.White;
            this.lblCikis.Location = new System.Drawing.Point(1040, -1);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(45, 53);
            this.lblCikis.TabIndex = 21;
            this.lblCikis.Text = "X";
            this.lblCikis.Click += new System.EventHandler(this.lblCikis_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1088, 566);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblNumara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesaj - Anasayfa";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGiden)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGelen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox msktxtAlici;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridGiden;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridGelen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchtxtMesaj;
        private System.Windows.Forms.Label lblCikis;
    }
}