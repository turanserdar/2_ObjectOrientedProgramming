
namespace OgrenciKayitEkrani
{
    partial class OgrencıBılgıSıstemı
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
            this.btnOgrenciSorgu = new System.Windows.Forms.Button();
            this.btnOgrenciKayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOgrenciSorgu
            // 
            this.btnOgrenciSorgu.Location = new System.Drawing.Point(254, 176);
            this.btnOgrenciSorgu.Name = "btnOgrenciSorgu";
            this.btnOgrenciSorgu.Size = new System.Drawing.Size(196, 37);
            this.btnOgrenciSorgu.TabIndex = 0;
            this.btnOgrenciSorgu.Text = "Öğrenci Sorgulama Ekranı";
            this.btnOgrenciSorgu.UseVisualStyleBackColor = true;
            this.btnOgrenciSorgu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOgrenciKayit
            // 
            this.btnOgrenciKayit.Location = new System.Drawing.Point(254, 129);
            this.btnOgrenciKayit.Name = "btnOgrenciKayit";
            this.btnOgrenciKayit.Size = new System.Drawing.Size(196, 32);
            this.btnOgrenciKayit.TabIndex = 1;
            this.btnOgrenciKayit.Text = "Öğrenci Kayıt Ekranı";
            this.btnOgrenciKayit.UseVisualStyleBackColor = true;
            this.btnOgrenciKayit.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(199, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÖĞRENCİ KAYIT OTOMASYONU";
            // 
            // OgrencıBılgıSıstemı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOgrenciKayit);
            this.Controls.Add(this.btnOgrenciSorgu);
            this.Name = "OgrencıBılgıSıstemı";
            this.Text = "OgrencıBılgıSıstemı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciSorgu;
        private System.Windows.Forms.Button btnOgrenciKayit;
        private System.Windows.Forms.Label label1;
    }
}