﻿
namespace LibraryProjectWinForm.Kullanici
{
    partial class KullaniciGuncelleForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.kullaniciCezatxt = new System.Windows.Forms.TextBox();
            this.kullaniciMailtxt = new System.Windows.Forms.TextBox();
            this.kullaniciTctxt = new System.Windows.Forms.TextBox();
            this.kullaniciteltxt = new System.Windows.Forms.TextBox();
            this.kullaniciSoyadtxt = new System.Windows.Forms.TextBox();
            this.kullaniciAdtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullaniciCezatxt
            // 
            this.kullaniciCezatxt.Location = new System.Drawing.Point(94, 139);
            this.kullaniciCezatxt.Name = "kullaniciCezatxt";
            this.kullaniciCezatxt.Size = new System.Drawing.Size(152, 20);
            this.kullaniciCezatxt.TabIndex = 13;
            // 
            // kullaniciMailtxt
            // 
            this.kullaniciMailtxt.Location = new System.Drawing.Point(94, 117);
            this.kullaniciMailtxt.Name = "kullaniciMailtxt";
            this.kullaniciMailtxt.Size = new System.Drawing.Size(152, 20);
            this.kullaniciMailtxt.TabIndex = 14;
            // 
            // kullaniciTctxt
            // 
            this.kullaniciTctxt.Location = new System.Drawing.Point(94, 69);
            this.kullaniciTctxt.Name = "kullaniciTctxt";
            this.kullaniciTctxt.Size = new System.Drawing.Size(152, 20);
            this.kullaniciTctxt.TabIndex = 15;
            // 
            // kullaniciteltxt
            // 
            this.kullaniciteltxt.Location = new System.Drawing.Point(94, 95);
            this.kullaniciteltxt.Name = "kullaniciteltxt";
            this.kullaniciteltxt.Size = new System.Drawing.Size(152, 20);
            this.kullaniciteltxt.TabIndex = 16;
            // 
            // kullaniciSoyadtxt
            // 
            this.kullaniciSoyadtxt.Location = new System.Drawing.Point(93, 41);
            this.kullaniciSoyadtxt.Name = "kullaniciSoyadtxt";
            this.kullaniciSoyadtxt.Size = new System.Drawing.Size(152, 20);
            this.kullaniciSoyadtxt.TabIndex = 17;
            // 
            // kullaniciAdtxt
            // 
            this.kullaniciAdtxt.Location = new System.Drawing.Point(93, 19);
            this.kullaniciAdtxt.Name = "kullaniciAdtxt";
            this.kullaniciAdtxt.Size = new System.Drawing.Size(152, 20);
            this.kullaniciAdtxt.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ceza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 170);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // KullaniciGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 371);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kullaniciCezatxt);
            this.Controls.Add(this.kullaniciMailtxt);
            this.Controls.Add(this.kullaniciTctxt);
            this.Controls.Add(this.kullaniciteltxt);
            this.Controls.Add(this.kullaniciSoyadtxt);
            this.Controls.Add(this.kullaniciAdtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KullaniciGuncelleForm";
            this.Text = "KullaniciGuncelleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KullaniciGuncelleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kullaniciCezatxt;
        private System.Windows.Forms.TextBox kullaniciMailtxt;
        private System.Windows.Forms.TextBox kullaniciTctxt;
        private System.Windows.Forms.TextBox kullaniciteltxt;
        private System.Windows.Forms.TextBox kullaniciSoyadtxt;
        private System.Windows.Forms.TextBox kullaniciAdtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}