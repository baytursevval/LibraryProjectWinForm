
namespace LibraryProjectWinForm.NewFolder1
{
    partial class KullaniciEkleForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kullaniciAdtxt = new System.Windows.Forms.TextBox();
            this.kullaniciSoyadtxt = new System.Windows.Forms.TextBox();
            this.kullaniciTctxt = new System.Windows.Forms.TextBox();
            this.kullaniciteltxt = new System.Windows.Forms.TextBox();
            this.kullaniciMailtxt = new System.Windows.Forms.TextBox();
            this.kullaniciCezatxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ceza";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 2;
            // 
            // kullaniciAdtxt
            // 
            this.kullaniciAdtxt.Location = new System.Drawing.Point(83, 9);
            this.kullaniciAdtxt.Name = "kullaniciAdtxt";
            this.kullaniciAdtxt.Size = new System.Drawing.Size(152, 22);
            this.kullaniciAdtxt.TabIndex = 3;
            // 
            // kullaniciSoyadtxt
            // 
            this.kullaniciSoyadtxt.Location = new System.Drawing.Point(83, 33);
            this.kullaniciSoyadtxt.Name = "kullaniciSoyadtxt";
            this.kullaniciSoyadtxt.Size = new System.Drawing.Size(152, 22);
            this.kullaniciSoyadtxt.TabIndex = 3;
            // 
            // kullaniciTctxt
            // 
            this.kullaniciTctxt.Location = new System.Drawing.Point(83, 61);
            this.kullaniciTctxt.Name = "kullaniciTctxt";
            this.kullaniciTctxt.Size = new System.Drawing.Size(152, 22);
            this.kullaniciTctxt.TabIndex = 3;
            // 
            // kullaniciteltxt
            // 
            this.kullaniciteltxt.Location = new System.Drawing.Point(83, 87);
            this.kullaniciteltxt.Name = "kullaniciteltxt";
            this.kullaniciteltxt.Size = new System.Drawing.Size(152, 22);
            this.kullaniciteltxt.TabIndex = 3;
            // 
            // kullaniciMailtxt
            // 
            this.kullaniciMailtxt.Location = new System.Drawing.Point(83, 109);
            this.kullaniciMailtxt.Name = "kullaniciMailtxt";
            this.kullaniciMailtxt.Size = new System.Drawing.Size(152, 22);
            this.kullaniciMailtxt.TabIndex = 3;
            // 
            // kullaniciCezatxt
            // 
            this.kullaniciCezatxt.Location = new System.Drawing.Point(83, 131);
            this.kullaniciCezatxt.Name = "kullaniciCezatxt";
            this.kullaniciCezatxt.Size = new System.Drawing.Size(152, 22);
            this.kullaniciCezatxt.TabIndex = 3;
            this.kullaniciCezatxt.TextChanged += new System.EventHandler(this.kullaniciCezatxt_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 149);
            this.dataGridView1.TabIndex = 7;
            // 
            // KullaniciEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(663, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kullaniciCezatxt);
            this.Controls.Add(this.kullaniciMailtxt);
            this.Controls.Add(this.kullaniciTctxt);
            this.Controls.Add(this.kullaniciteltxt);
            this.Controls.Add(this.kullaniciSoyadtxt);
            this.Controls.Add(this.kullaniciAdtxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "KullaniciEkleForm";
            this.Text = "KullaniciEkleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KullaniciEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kullaniciAdtxt;
        private System.Windows.Forms.TextBox kullaniciSoyadtxt;
        private System.Windows.Forms.TextBox kullaniciTctxt;
        private System.Windows.Forms.TextBox kullaniciteltxt;
        private System.Windows.Forms.TextBox kullaniciMailtxt;
        private System.Windows.Forms.TextBox kullaniciCezatxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}