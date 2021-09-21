
namespace GCloud2WP_GUI_Edition
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.onlyurl = new System.Windows.Forms.CheckBox();
            this.Launch = new System.Windows.Forms.Button();
            this.openfolder = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(259, 160);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "ここにURLを貼り付けてください。\r\n複数のURLを変換したい場合は、改行して入力してください。";
            // 
            // onlyurl
            // 
            this.onlyurl.AutoSize = true;
            this.onlyurl.Location = new System.Drawing.Point(12, 178);
            this.onlyurl.Name = "onlyurl";
            this.onlyurl.Size = new System.Drawing.Size(92, 19);
            this.onlyurl.TabIndex = 1;
            this.onlyurl.Text = "URLのみ出力";
            this.onlyurl.UseVisualStyleBackColor = true;
            // 
            // Launch
            // 
            this.Launch.Location = new System.Drawing.Point(12, 204);
            this.Launch.Name = "Launch";
            this.Launch.Size = new System.Drawing.Size(259, 45);
            this.Launch.TabIndex = 2;
            this.Launch.Text = "実行";
            this.Launch.UseVisualStyleBackColor = true;
            this.Launch.Click += new System.EventHandler(this.Launch_Click);
            // 
            // openfolder
            // 
            this.openfolder.AutoSize = true;
            this.openfolder.Location = new System.Drawing.Point(165, 179);
            this.openfolder.Name = "openfolder";
            this.openfolder.Size = new System.Drawing.Size(106, 15);
            this.openfolder.TabIndex = 3;
            this.openfolder.TabStop = true;
            this.openfolder.Text = "出力先フォルダを開く";
            this.openfolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openfolder_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.openfolder);
            this.Controls.Add(this.Launch);
            this.Controls.Add(this.onlyurl);
            this.Controls.Add(this.textBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "GCloud2WP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.CheckBox onlyurl;
        private System.Windows.Forms.Button Launch;
        private System.Windows.Forms.LinkLabel openfolder;
    }
}

