namespace lesson65copyfiles
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
            this.btnChooseFiles = new System.Windows.Forms.Button();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnChooseFiles
            // 
            this.btnChooseFiles.Location = new System.Drawing.Point(13, 13);
            this.btnChooseFiles.Name = "btnChooseFiles";
            this.btnChooseFiles.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFiles.TabIndex = 0;
            this.btnChooseFiles.Text = "Choose Files";
            this.btnChooseFiles.UseVisualStyleBackColor = true;
            this.btnChooseFiles.Click += new System.EventHandler(this.btnChooseFiles_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Enabled = false;
            this.chkAll.Location = new System.Drawing.Point(94, 19);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(71, 17);
            this.chkAll.TabIndex = 1;
            this.chkAll.Text = "Check All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(13, 43);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(460, 499);
            this.checkedListBox1.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 548);
            this.progressBar1.Minimum = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(460, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 1;
            // 
            // btnCopy
            // 
            this.btnCopy.Enabled = false;
            this.btnCopy.Location = new System.Drawing.Point(477, 13);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(614, 15);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(111, 23);
            this.btnChooseFolder.TabIndex = 5;
            this.btnChooseFolder.Text = "Choose Folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(614, 45);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 13);
            this.lblPath.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All Files (*.*)|*.*";
            this.openFileDialog1.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 649);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.btnChooseFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFiles;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

