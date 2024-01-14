namespace Compression_Program
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
            this.Compress = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Decompress = new System.Windows.Forms.Button();
            this.Report1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Compress
            // 
            this.Compress.Location = new System.Drawing.Point(83, 80);
            this.Compress.Name = "Compress";
            this.Compress.Size = new System.Drawing.Size(193, 53);
            this.Compress.TabIndex = 0;
            this.Compress.Text = "Compress";
            this.Compress.UseVisualStyleBackColor = true;
            this.Compress.Click += new System.EventHandler(this.Compress_Click);
            // 
            // Decompress
            // 
            this.Decompress.Location = new System.Drawing.Point(410, 80);
            this.Decompress.Name = "Decompress";
            this.Decompress.Size = new System.Drawing.Size(193, 53);
            this.Decompress.TabIndex = 1;
            this.Decompress.Text = "Decompress";
            this.Decompress.UseVisualStyleBackColor = true;
            this.Decompress.Click += new System.EventHandler(this.Decompress_Click);
            // 
            // Report1
            // 
            this.Report1.AutoSize = true;
            this.Report1.Location = new System.Drawing.Point(80, 219);
            this.Report1.Name = "Report1";
            this.Report1.Size = new System.Drawing.Size(67, 18);
            this.Report1.TabIndex = 2;
            this.Report1.Text = "Report:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(740, 397);
            this.Controls.Add(this.Report1);
            this.Controls.Add(this.Decompress);
            this.Controls.Add(this.Compress);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CompressBtn;
        private System.Windows.Forms.Button DecompressBtn;
        private System.Windows.Forms.Label report;
        private System.Windows.Forms.Button Compress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Decompress;
        private System.Windows.Forms.Label Report1;
    }
}

