
namespace APKTools
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Open_Apk = new System.Windows.Forms.Button();
            this.XApkFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Open_Xapk = new System.Windows.Forms.Button();
            this.ApkFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Open_Apk
            // 
            this.Open_Apk.Location = new System.Drawing.Point(12, 52);
            this.Open_Apk.Name = "Open_Apk";
            this.Open_Apk.Size = new System.Drawing.Size(201, 34);
            this.Open_Apk.TabIndex = 0;
            this.Open_Apk.Text = "De-Compile APK";
            this.Open_Apk.UseVisualStyleBackColor = true;
            this.Open_Apk.Click += new System.EventHandler(this.Open_Apk_Click);
            // 
            // Open_Xapk
            // 
            this.Open_Xapk.Location = new System.Drawing.Point(12, 12);
            this.Open_Xapk.Name = "Open_Xapk";
            this.Open_Xapk.Size = new System.Drawing.Size(201, 34);
            this.Open_Xapk.TabIndex = 1;
            this.Open_Xapk.Text = "De-Compile XAPK";
            this.Open_Xapk.UseVisualStyleBackColor = true;
            this.Open_Xapk.Click += new System.EventHandler(this.Open_Xapk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 98);
            this.Controls.Add(this.Open_Xapk);
            this.Controls.Add(this.Open_Apk);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Open_Apk;
        private System.Windows.Forms.OpenFileDialog XApkFileDialog;
        private System.Windows.Forms.Button Open_Xapk;
        private System.Windows.Forms.OpenFileDialog ApkFileDialog;
    }
}

