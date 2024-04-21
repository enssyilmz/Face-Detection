namespace FaceDetector
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nametbx = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.capturepbx = new System.Windows.Forms.PictureBox();
            this.camerapbx = new System.Windows.Forms.PictureBox();
            this.saveimgbtn = new System.Windows.Forms.Button();
            this.opencambtn = new System.Windows.Forms.Button();
            this.detectfacebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.capturepbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camerapbx)).BeginInit();
            this.SuspendLayout();
            // 
            // nametbx
            // 
            this.nametbx.Location = new System.Drawing.Point(415, 287);
            this.nametbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nametbx.Name = "nametbx";
            this.nametbx.Size = new System.Drawing.Size(123, 20);
            this.nametbx.TabIndex = 12;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.ForeColor = System.Drawing.SystemColors.Window;
            this.namelbl.Location = new System.Drawing.Point(370, 287);
            this.namelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namelbl.MaximumSize = new System.Drawing.Size(675, 488);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(44, 13);
            this.namelbl.TabIndex = 11;
            this.namelbl.Text = "Name : ";
            // 
            // capturepbx
            // 
            this.capturepbx.Location = new System.Drawing.Point(415, 33);
            this.capturepbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.capturepbx.Name = "capturepbx";
            this.capturepbx.Size = new System.Drawing.Size(296, 219);
            this.capturepbx.TabIndex = 10;
            this.capturepbx.TabStop = false;
            // 
            // camerapbx
            // 
            this.camerapbx.Location = new System.Drawing.Point(68, 33);
            this.camerapbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.camerapbx.Name = "camerapbx";
            this.camerapbx.Size = new System.Drawing.Size(296, 219);
            this.camerapbx.TabIndex = 9;
            this.camerapbx.TabStop = false;
            // 
            // saveimgbtn
            // 
            this.saveimgbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saveimgbtn.ForeColor = System.Drawing.SystemColors.Window;
            this.saveimgbtn.Location = new System.Drawing.Point(554, 271);
            this.saveimgbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveimgbtn.Name = "saveimgbtn";
            this.saveimgbtn.Size = new System.Drawing.Size(157, 51);
            this.saveimgbtn.TabIndex = 8;
            this.saveimgbtn.Text = "Save Image";
            this.saveimgbtn.UseVisualStyleBackColor = false;
            this.saveimgbtn.Click += new System.EventHandler(this.saveimgbtn_Click);
            // 
            // opencambtn
            // 
            this.opencambtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.opencambtn.ForeColor = System.Drawing.SystemColors.Window;
            this.opencambtn.Location = new System.Drawing.Point(68, 271);
            this.opencambtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.opencambtn.Name = "opencambtn";
            this.opencambtn.Size = new System.Drawing.Size(157, 51);
            this.opencambtn.TabIndex = 7;
            this.opencambtn.Text = "Open Camera";
            this.opencambtn.UseVisualStyleBackColor = false;
            this.opencambtn.Click += new System.EventHandler(this.opencambtn_Click);
            // 
            // detectfacebtn
            // 
            this.detectfacebtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.detectfacebtn.ForeColor = System.Drawing.SystemColors.Window;
            this.detectfacebtn.Location = new System.Drawing.Point(68, 326);
            this.detectfacebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detectfacebtn.Name = "detectfacebtn";
            this.detectfacebtn.Size = new System.Drawing.Size(157, 51);
            this.detectfacebtn.TabIndex = 13;
            this.detectfacebtn.Text = "Detect Faces";
            this.detectfacebtn.UseVisualStyleBackColor = false;
            this.detectfacebtn.Click += new System.EventHandler(this.detectfacebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 458);
            this.Controls.Add(this.detectfacebtn);
            this.Controls.Add(this.nametbx);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.capturepbx);
            this.Controls.Add(this.camerapbx);
            this.Controls.Add(this.saveimgbtn);
            this.Controls.Add(this.opencambtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 459);
            this.Name = "Form1";
            this.Text = "Face Detector";
            ((System.ComponentModel.ISupportInitialize)(this.capturepbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camerapbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametbx;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.PictureBox capturepbx;
        private System.Windows.Forms.PictureBox camerapbx;
        private System.Windows.Forms.Button saveimgbtn;
        private System.Windows.Forms.Button opencambtn;
        private System.Windows.Forms.Button detectfacebtn;
    }
}

