namespace lesson26oroperatorcombined
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
            this.rchInputBox = new System.Windows.Forms.RichTextBox();
            this.btnFindVowels = new System.Windows.Forms.Button();
            this.rchVowelsBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchInputBox
            // 
            this.rchInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.rchInputBox.Location = new System.Drawing.Point(13, 13);
            this.rchInputBox.Name = "rchInputBox";
            this.rchInputBox.Size = new System.Drawing.Size(922, 116);
            this.rchInputBox.TabIndex = 0;
            this.rchInputBox.Text = "";
            // 
            // btnFindVowels
            // 
            this.btnFindVowels.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btnFindVowels.Location = new System.Drawing.Point(12, 153);
            this.btnFindVowels.Name = "btnFindVowels";
            this.btnFindVowels.Size = new System.Drawing.Size(922, 81);
            this.btnFindVowels.TabIndex = 1;
            this.btnFindVowels.Text = "FIND THE VOWELS";
            this.btnFindVowels.UseVisualStyleBackColor = true;
            this.btnFindVowels.Click += new System.EventHandler(this.btnFindVowels_Click);
            // 
            // rchVowelsBox
            // 
            this.rchVowelsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.rchVowelsBox.Location = new System.Drawing.Point(13, 259);
            this.rchVowelsBox.Name = "rchVowelsBox";
            this.rchVowelsBox.Size = new System.Drawing.Size(922, 450);
            this.rchVowelsBox.TabIndex = 2;
            this.rchVowelsBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 736);
            this.Controls.Add(this.rchVowelsBox);
            this.Controls.Add(this.btnFindVowels);
            this.Controls.Add(this.rchInputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchInputBox;
        private System.Windows.Forms.Button btnFindVowels;
        private System.Windows.Forms.RichTextBox rchVowelsBox;
    }
}

