
namespace File_IO_Demo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnBinaryWrite = new System.Windows.Forms.Button();
            this.BtnBinaryRead = new System.Windows.Forms.Button();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.BtnCreateFolder = new System.Windows.Forms.Button();
            this.BtnCreateFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnStreamWrite = new System.Windows.Forms.Button();
            this.btnStramRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emp Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Emp Salary";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnBinaryWrite
            // 
            this.BtnBinaryWrite.Location = new System.Drawing.Point(201, 215);
            this.BtnBinaryWrite.Name = "BtnBinaryWrite";
            this.BtnBinaryWrite.Size = new System.Drawing.Size(75, 23);
            this.BtnBinaryWrite.TabIndex = 3;
            this.BtnBinaryWrite.Text = "Binary Write";
            this.BtnBinaryWrite.UseVisualStyleBackColor = true;
            this.BtnBinaryWrite.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnBinaryRead
            // 
            this.BtnBinaryRead.Location = new System.Drawing.Point(361, 215);
            this.BtnBinaryRead.Name = "BtnBinaryRead";
            this.BtnBinaryRead.Size = new System.Drawing.Size(75, 23);
            this.BtnBinaryRead.TabIndex = 4;
            this.BtnBinaryRead.Text = "Binary Read";
            this.BtnBinaryRead.UseVisualStyleBackColor = true;
            this.BtnBinaryRead.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(325, 60);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(100, 20);
            this.txtEmpId.TabIndex = 5;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(325, 101);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 20);
            this.txtEmpName.TabIndex = 6;
            this.txtEmpName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(325, 144);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 7;
            // 
            // BtnCreateFolder
            // 
            this.BtnCreateFolder.Location = new System.Drawing.Point(472, 74);
            this.BtnCreateFolder.Name = "BtnCreateFolder";
            this.BtnCreateFolder.Size = new System.Drawing.Size(88, 23);
            this.BtnCreateFolder.TabIndex = 8;
            this.BtnCreateFolder.Text = "Create Folder";
            this.BtnCreateFolder.UseVisualStyleBackColor = true;
            this.BtnCreateFolder.Click += new System.EventHandler(this.BtnCreateFolder_Click);
            // 
            // BtnCreateFile
            // 
            this.BtnCreateFile.Location = new System.Drawing.Point(472, 121);
            this.BtnCreateFile.Name = "BtnCreateFile";
            this.BtnCreateFile.Size = new System.Drawing.Size(88, 23);
            this.BtnCreateFile.TabIndex = 9;
            this.BtnCreateFile.Text = "Create File";
            this.BtnCreateFile.UseVisualStyleBackColor = true;
            this.BtnCreateFile.Click += new System.EventHandler(this.BtnCreateFile_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(592, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(196, 104);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // btnStreamWrite
            // 
            this.btnStreamWrite.Location = new System.Drawing.Point(578, 215);
            this.btnStreamWrite.Name = "btnStreamWrite";
            this.btnStreamWrite.Size = new System.Drawing.Size(86, 23);
            this.btnStreamWrite.TabIndex = 11;
            this.btnStreamWrite.Text = "Stream Write";
            this.btnStreamWrite.UseVisualStyleBackColor = true;
            this.btnStreamWrite.Click += new System.EventHandler(this.btnStreamWrite_Click);
            // 
            // btnStramRead
            // 
            this.btnStramRead.Location = new System.Drawing.Point(705, 215);
            this.btnStramRead.Name = "btnStramRead";
            this.btnStramRead.Size = new System.Drawing.Size(83, 23);
            this.btnStramRead.TabIndex = 12;
            this.btnStramRead.Text = "Stream Read";
            this.btnStramRead.UseVisualStyleBackColor = true;
            this.btnStramRead.Click += new System.EventHandler(this.btnStramRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStramRead);
            this.Controls.Add(this.btnStreamWrite);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnCreateFile);
            this.Controls.Add(this.BtnCreateFolder);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.BtnBinaryRead);
            this.Controls.Add(this.BtnBinaryWrite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "File Io Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBinaryWrite;
        private System.Windows.Forms.Button BtnBinaryRead;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button BtnCreateFolder;
        private System.Windows.Forms.Button BtnCreateFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnStreamWrite;
        private System.Windows.Forms.Button btnStramRead;
    }
}

