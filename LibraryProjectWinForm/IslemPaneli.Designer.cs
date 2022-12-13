
namespace LibraryProjectWinForm
{
    partial class IslemPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IslemPaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.silKullanicibtn = new System.Windows.Forms.Button();
            this.gnclleKullanicibtn = new System.Windows.Forms.Button();
            this.ekleKullanicibtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kullaniciBilgiPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.silKullanicibtn);
            this.panel1.Controls.Add(this.gnclleKullanicibtn);
            this.panel1.Controls.Add(this.ekleKullanicibtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 359);
            this.panel1.TabIndex = 0;
            // 
            // silKullanicibtn
            // 
            this.silKullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.silKullanicibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silKullanicibtn.Image = ((System.Drawing.Image)(resources.GetObject("silKullanicibtn.Image")));
            this.silKullanicibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.silKullanicibtn.Location = new System.Drawing.Point(0, 170);
            this.silKullanicibtn.Name = "silKullanicibtn";
            this.silKullanicibtn.Size = new System.Drawing.Size(220, 55);
            this.silKullanicibtn.TabIndex = 5;
            this.silKullanicibtn.Text = "Sil";
            this.silKullanicibtn.UseVisualStyleBackColor = true;
            // 
            // gnclleKullanicibtn
            // 
            this.gnclleKullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gnclleKullanicibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gnclleKullanicibtn.Image = ((System.Drawing.Image)(resources.GetObject("gnclleKullanicibtn.Image")));
            this.gnclleKullanicibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gnclleKullanicibtn.Location = new System.Drawing.Point(0, 115);
            this.gnclleKullanicibtn.Name = "gnclleKullanicibtn";
            this.gnclleKullanicibtn.Size = new System.Drawing.Size(220, 55);
            this.gnclleKullanicibtn.TabIndex = 4;
            this.gnclleKullanicibtn.Text = "Güncelle";
            this.gnclleKullanicibtn.UseVisualStyleBackColor = true;
            // 
            // ekleKullanicibtn
            // 
            this.ekleKullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ekleKullanicibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleKullanicibtn.Image = ((System.Drawing.Image)(resources.GetObject("ekleKullanicibtn.Image")));
            this.ekleKullanicibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekleKullanicibtn.Location = new System.Drawing.Point(0, 60);
            this.ekleKullanicibtn.Name = "ekleKullanicibtn";
            this.ekleKullanicibtn.Size = new System.Drawing.Size(220, 55);
            this.ekleKullanicibtn.TabIndex = 3;
            this.ekleKullanicibtn.Text = "Yeni Kullanıcı";
            this.ekleKullanicibtn.UseVisualStyleBackColor = true;
            this.ekleKullanicibtn.Click += new System.EventHandler(this.ekleKullanicibtn_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kullanıcılar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullaniciBilgiPanel
            // 
            this.kullaniciBilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullaniciBilgiPanel.Location = new System.Drawing.Point(220, 0);
            this.kullaniciBilgiPanel.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciBilgiPanel.Name = "kullaniciBilgiPanel";
            this.kullaniciBilgiPanel.Size = new System.Drawing.Size(537, 63);
            this.kullaniciBilgiPanel.TabIndex = 1;
            // 
            // IslemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 359);
            this.Controls.Add(this.kullaniciBilgiPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IslemPaneli";
            this.Text = "IslemPaneli";
            this.Load += new System.EventHandler(this.IslemPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel kullaniciBilgiPanel;
        private System.Windows.Forms.Button silKullanicibtn;
        private System.Windows.Forms.Button gnclleKullanicibtn;
        private System.Windows.Forms.Button ekleKullanicibtn;
    }
}