
namespace ProjectFiles
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
            this.buttonExcelOku = new System.Windows.Forms.Button();
            this.buttonDosyaOlustur = new System.Windows.Forms.Button();
            this.buttonXmlDegistir = new System.Windows.Forms.Button();
            this.buttonMosDegistir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonExcelOku
            // 
            this.buttonExcelOku.Location = new System.Drawing.Point(12, 12);
            this.buttonExcelOku.Name = "buttonExcelOku";
            this.buttonExcelOku.Size = new System.Drawing.Size(80, 80);
            this.buttonExcelOku.TabIndex = 0;
            this.buttonExcelOku.Text = "Excel Oku";
            this.buttonExcelOku.UseVisualStyleBackColor = true;
            this.buttonExcelOku.Click += new System.EventHandler(this.buttonExcelOku_Click);
            // 
            // buttonDosyaOlustur
            // 
            this.buttonDosyaOlustur.Enabled = false;
            this.buttonDosyaOlustur.Location = new System.Drawing.Point(117, 12);
            this.buttonDosyaOlustur.Name = "buttonDosyaOlustur";
            this.buttonDosyaOlustur.Size = new System.Drawing.Size(80, 80);
            this.buttonDosyaOlustur.TabIndex = 1;
            this.buttonDosyaOlustur.Text = "Dosya Oluştur";
            this.buttonDosyaOlustur.UseVisualStyleBackColor = true;
            this.buttonDosyaOlustur.Click += new System.EventHandler(this.buttonDosyaOlustur_Click);
            // 
            // buttonXmlDegistir
            // 
            this.buttonXmlDegistir.Enabled = false;
            this.buttonXmlDegistir.Location = new System.Drawing.Point(222, 12);
            this.buttonXmlDegistir.Name = "buttonXmlDegistir";
            this.buttonXmlDegistir.Size = new System.Drawing.Size(80, 80);
            this.buttonXmlDegistir.TabIndex = 3;
            this.buttonXmlDegistir.Text = "XML Değiştir";
            this.buttonXmlDegistir.UseVisualStyleBackColor = true;
            this.buttonXmlDegistir.Click += new System.EventHandler(this.buttonXmlDegistir_Click);
            // 
            // buttonMosDegistir
            // 
            this.buttonMosDegistir.Enabled = false;
            this.buttonMosDegistir.Location = new System.Drawing.Point(327, 12);
            this.buttonMosDegistir.Name = "buttonMosDegistir";
            this.buttonMosDegistir.Size = new System.Drawing.Size(80, 80);
            this.buttonMosDegistir.TabIndex = 5;
            this.buttonMosDegistir.Text = "Mos Değiştir";
            this.buttonMosDegistir.UseVisualStyleBackColor = true;
            this.buttonMosDegistir.Click += new System.EventHandler(this.buttonMosDegistir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 103);
            this.Controls.Add(this.buttonMosDegistir);
            this.Controls.Add(this.buttonXmlDegistir);
            this.Controls.Add(this.buttonDosyaOlustur);
            this.Controls.Add(this.buttonExcelOku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExcelOku;
        private System.Windows.Forms.Button buttonDosyaOlustur;
        private System.Windows.Forms.Button buttonXmlDegistir;
        private System.Windows.Forms.Button buttonMosDegistir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
    }
}

