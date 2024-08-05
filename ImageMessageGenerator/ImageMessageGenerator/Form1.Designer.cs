
namespace ImageMessageGenerator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFontFamily = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fontFamily = new System.Windows.Forms.ComboBox();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.boxImage = new System.Windows.Forms.PictureBox();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblColor);
            this.groupBox1.Controls.Add(this.btnFontColor);
            this.groupBox1.Controls.Add(this.btnImage);
            this.groupBox1.Controls.Add(this.lblImage);
            this.groupBox1.Controls.Add(this.fontSize);
            this.groupBox1.Controls.Add(this.fontFamily);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblFontFamily);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Font -size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Font family";
            // 
            // lblFontFamily
            // 
            this.lblFontFamily.AutoSize = true;
            this.lblFontFamily.Location = new System.Drawing.Point(6, 165);
            this.lblFontFamily.Name = "lblFontFamily";
            this.lblFontFamily.Size = new System.Drawing.Size(83, 20);
            this.lblFontFamily.TabIndex = 3;
            this.lblFontFamily.Text = "Font Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(10, 242);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(352, 132);
            this.txtMessage.TabIndex = 5;
            this.txtMessage.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(217, 380);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(136, 40);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMessage);
            this.groupBox2.Controls.Add(this.boxImage);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Location = new System.Drawing.Point(399, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // fontFamily
            // 
            this.fontFamily.FormattingEnabled = true;
            this.fontFamily.Location = new System.Drawing.Point(105, 120);
            this.fontFamily.Name = "fontFamily";
            this.fontFamily.Size = new System.Drawing.Size(168, 28);
            this.fontFamily.TabIndex = 7;
            this.fontFamily.SelectedIndexChanged += new System.EventHandler(this.fontFamily_SelectedIndexChanged);
            // 
            // fontSize
            // 
            this.fontSize.Location = new System.Drawing.Point(105, 80);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(120, 26);
            this.fontSize.TabIndex = 8;
            this.fontSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(154, 40);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(96, 20);
            this.lblImage.TabIndex = 9;
            this.lblImage.Text = "<No Image>";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(280, 385);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(80, 30);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Send To:";
            // 
            // btnImage
            // 
            this.btnImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImage.Location = new System.Drawing.Point(66, 35);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(82, 33);
            this.btnImage.TabIndex = 10;
            this.btnImage.Text = "Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // boxImage
            // 
            this.boxImage.Location = new System.Drawing.Point(6, 25);
            this.boxImage.Name = "boxImage";
            this.boxImage.Size = new System.Drawing.Size(377, 184);
            this.boxImage.TabIndex = 3;
            this.boxImage.TabStop = false;
            // 
            // btnFontColor
            // 
            this.btnFontColor.Location = new System.Drawing.Point(105, 160);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(84, 30);
            this.btnFontColor.TabIndex = 11;
            this.btnFontColor.Text = "Select";
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColor.Location = new System.Drawing.Point(213, 165);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(33, 25);
            this.lblColor.TabIndex = 12;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(17, 242);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(92, 20);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "<Message>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.ComboBox fontFamily;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFontFamily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.PictureBox boxImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblMessage;
    }
}

