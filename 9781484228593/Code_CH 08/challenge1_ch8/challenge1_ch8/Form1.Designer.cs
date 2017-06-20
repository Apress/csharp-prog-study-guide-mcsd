namespace challenge1_ch8
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblHTML = new System.Windows.Forms.Label();
            this.txtbxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(47, 38);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(120, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download HTML";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblHTML
            // 
            this.lblHTML.AutoSize = true;
            this.lblHTML.Location = new System.Drawing.Point(44, 73);
            this.lblHTML.Name = "lblHTML";
            this.lblHTML.Size = new System.Drawing.Size(37, 13);
            this.lblHTML.TabIndex = 2;
            this.lblHTML.Text = "HTML";
            // 
            // txtbxInput
            // 
            this.txtbxInput.Location = new System.Drawing.Point(47, 12);
            this.txtbxInput.Name = "txtbxInput";
            this.txtbxInput.Size = new System.Drawing.Size(246, 20);
            this.txtbxInput.TabIndex = 3;
            this.txtbxInput.Text = "https://www.google.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 191);
            this.Controls.Add(this.txtbxInput);
            this.Controls.Add(this.lblHTML);
            this.Controls.Add(this.btnDownload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblHTML;
        private System.Windows.Forms.TextBox txtbxInput;
    }
}

