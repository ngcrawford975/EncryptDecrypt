namespace EncryptDecrypt
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
            this.EncryptionButton = new System.Windows.Forms.Button();
            this.DecryptionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EncryptionButton
            // 
            this.EncryptionButton.Location = new System.Drawing.Point(210, 55);
            this.EncryptionButton.Name = "EncryptionButton";
            this.EncryptionButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptionButton.TabIndex = 0;
            this.EncryptionButton.Text = "Encrypt";
            this.EncryptionButton.UseVisualStyleBackColor = true;
            this.EncryptionButton.Click += new System.EventHandler(this.EncryptionButton_Click);
            // 
            // DecryptionButton
            // 
            this.DecryptionButton.Location = new System.Drawing.Point(468, 55);
            this.DecryptionButton.Name = "DecryptionButton";
            this.DecryptionButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptionButton.TabIndex = 1;
            this.DecryptionButton.Text = "Decrypt";
            this.DecryptionButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DecryptionButton);
            this.Controls.Add(this.EncryptionButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EncryptionButton;
        private System.Windows.Forms.Button DecryptionButton;
    }
}

