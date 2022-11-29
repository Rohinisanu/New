
namespace File_IO_Demo
{
    partial class Form2
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
            this.BtnXMLWrie = new System.Windows.Forms.Button();
            this.BtnXMLRead = new System.Windows.Forms.Button();
            this.txtDeptId = new System.Windows.Forms.TextBox();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.BtnBinaryWrite = new System.Windows.Forms.Button();
            this.BtnBinaryRead = new System.Windows.Forms.Button();
            this.btnSoapWrite = new System.Windows.Forms.Button();
            this.btnSoapRead = new System.Windows.Forms.Button();
            this.btnJSONWrite = new System.Windows.Forms.Button();
            this.btnJSONRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DeptId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DeptName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // BtnXMLWrie
            // 
            this.BtnXMLWrie.Location = new System.Drawing.Point(502, 117);
            this.BtnXMLWrie.Name = "BtnXMLWrie";
            this.BtnXMLWrie.Size = new System.Drawing.Size(91, 23);
            this.BtnXMLWrie.TabIndex = 3;
            this.BtnXMLWrie.Text = "XML Write";
            this.BtnXMLWrie.UseVisualStyleBackColor = true;
            this.BtnXMLWrie.Click += new System.EventHandler(this.BtnXMLWrie_Click);
            // 
            // BtnXMLRead
            // 
            this.BtnXMLRead.Location = new System.Drawing.Point(633, 117);
            this.BtnXMLRead.Name = "BtnXMLRead";
            this.BtnXMLRead.Size = new System.Drawing.Size(91, 23);
            this.BtnXMLRead.TabIndex = 4;
            this.BtnXMLRead.Text = "XML Read";
            this.BtnXMLRead.UseVisualStyleBackColor = true;
            this.BtnXMLRead.Click += new System.EventHandler(this.BtnXMLRead_Click);
            // 
            // txtDeptId
            // 
            this.txtDeptId.Location = new System.Drawing.Point(340, 57);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.Size = new System.Drawing.Size(100, 20);
            this.txtDeptId.TabIndex = 5;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(340, 117);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(100, 20);
            this.txtDeptName.TabIndex = 6;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(340, 166);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 7;
            // 
            // BtnBinaryWrite
            // 
            this.BtnBinaryWrite.Location = new System.Drawing.Point(502, 60);
            this.BtnBinaryWrite.Name = "BtnBinaryWrite";
            this.BtnBinaryWrite.Size = new System.Drawing.Size(91, 23);
            this.BtnBinaryWrite.TabIndex = 8;
            this.BtnBinaryWrite.Text = "Binary Write";
            this.BtnBinaryWrite.UseVisualStyleBackColor = true;
            this.BtnBinaryWrite.Click += new System.EventHandler(this.BtnBinaryWrite_Click);
            // 
            // BtnBinaryRead
            // 
            this.BtnBinaryRead.Location = new System.Drawing.Point(633, 60);
            this.BtnBinaryRead.Name = "BtnBinaryRead";
            this.BtnBinaryRead.Size = new System.Drawing.Size(91, 23);
            this.BtnBinaryRead.TabIndex = 9;
            this.BtnBinaryRead.Text = "Binary Read";
            this.BtnBinaryRead.UseVisualStyleBackColor = true;
            this.BtnBinaryRead.Click += new System.EventHandler(this.BtnBinaryRead_Click);
            // 
            // btnSoapWrite
            // 
            this.btnSoapWrite.Location = new System.Drawing.Point(502, 166);
            this.btnSoapWrite.Name = "btnSoapWrite";
            this.btnSoapWrite.Size = new System.Drawing.Size(91, 23);
            this.btnSoapWrite.TabIndex = 10;
            this.btnSoapWrite.Text = "Soap Write";
            this.btnSoapWrite.UseVisualStyleBackColor = true;
            this.btnSoapWrite.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSoapRead
            // 
            this.btnSoapRead.Location = new System.Drawing.Point(633, 166);
            this.btnSoapRead.Name = "btnSoapRead";
            this.btnSoapRead.Size = new System.Drawing.Size(91, 23);
            this.btnSoapRead.TabIndex = 11;
            this.btnSoapRead.Text = "Soap Read";
            this.btnSoapRead.UseVisualStyleBackColor = true;
            this.btnSoapRead.Click += new System.EventHandler(this.btnSoapRead_Click);
            // 
            // btnJSONWrite
            // 
            this.btnJSONWrite.Location = new System.Drawing.Point(502, 214);
            this.btnJSONWrite.Name = "btnJSONWrite";
            this.btnJSONWrite.Size = new System.Drawing.Size(91, 23);
            this.btnJSONWrite.TabIndex = 12;
            this.btnJSONWrite.Text = "JSON Write";
            this.btnJSONWrite.UseVisualStyleBackColor = true;
            this.btnJSONWrite.Click += new System.EventHandler(this.btnJSONWrite_Click);
            // 
            // btnJSONRead
            // 
            this.btnJSONRead.Location = new System.Drawing.Point(633, 214);
            this.btnJSONRead.Name = "btnJSONRead";
            this.btnJSONRead.Size = new System.Drawing.Size(91, 23);
            this.btnJSONRead.TabIndex = 13;
            this.btnJSONRead.Text = "JSON Read";
            this.btnJSONRead.UseVisualStyleBackColor = true;
            this.btnJSONRead.Click += new System.EventHandler(this.btnJSONRead_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJSONRead);
            this.Controls.Add(this.btnJSONWrite);
            this.Controls.Add(this.btnSoapRead);
            this.Controls.Add(this.btnSoapWrite);
            this.Controls.Add(this.BtnBinaryRead);
            this.Controls.Add(this.BtnBinaryWrite);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.BtnXMLRead);
            this.Controls.Add(this.BtnXMLWrie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Serialization Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnXMLWrie;
        private System.Windows.Forms.Button BtnXMLRead;
        private System.Windows.Forms.TextBox txtDeptId;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button BtnBinaryWrite;
        private System.Windows.Forms.Button BtnBinaryRead;
        private System.Windows.Forms.Button btnSoapWrite;
        private System.Windows.Forms.Button btnSoapRead;
        private System.Windows.Forms.Button btnJSONWrite;
        private System.Windows.Forms.Button btnJSONRead;
    }
}