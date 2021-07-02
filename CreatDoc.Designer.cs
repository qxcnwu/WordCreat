
namespace WordCreat
{
    partial class CreatDoc
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
            this.DocPath = new System.Windows.Forms.TextBox();
            this.XMLPath = new System.Windows.Forms.TextBox();
            this.DocPathButton = new System.Windows.Forms.Button();
            this.XMLPathButton = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveDir = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "模板文档路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "XML文档路径";
            // 
            // DocPath
            // 
            this.DocPath.Location = new System.Drawing.Point(99, 44);
            this.DocPath.Name = "DocPath";
            this.DocPath.ReadOnly = true;
            this.DocPath.Size = new System.Drawing.Size(339, 23);
            this.DocPath.TabIndex = 2;
            // 
            // XMLPath
            // 
            this.XMLPath.Location = new System.Drawing.Point(99, 129);
            this.XMLPath.Name = "XMLPath";
            this.XMLPath.ReadOnly = true;
            this.XMLPath.Size = new System.Drawing.Size(339, 23);
            this.XMLPath.TabIndex = 3;
            // 
            // DocPathButton
            // 
            this.DocPathButton.Location = new System.Drawing.Point(99, 89);
            this.DocPathButton.Name = "DocPathButton";
            this.DocPathButton.Size = new System.Drawing.Size(339, 23);
            this.DocPathButton.TabIndex = 4;
            this.DocPathButton.Text = "DOC文件浏览";
            this.DocPathButton.UseVisualStyleBackColor = true;
            this.DocPathButton.Click += new System.EventHandler(this.DocPathButton_Click);
            // 
            // XMLPathButton
            // 
            this.XMLPathButton.Location = new System.Drawing.Point(99, 181);
            this.XMLPathButton.Name = "XMLPathButton";
            this.XMLPathButton.Size = new System.Drawing.Size(339, 23);
            this.XMLPathButton.TabIndex = 5;
            this.XMLPathButton.Text = "XML文件浏览";
            this.XMLPathButton.UseVisualStyleBackColor = true;
            this.XMLPathButton.Click += new System.EventHandler(this.XMLPathButton_Click);
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(99, 366);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(339, 23);
            this.Done.TabIndex = 6;
            this.Done.Text = "生成";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "文档保存路径";
            // 
            // SaveDir
            // 
            this.SaveDir.Location = new System.Drawing.Point(100, 231);
            this.SaveDir.Name = "SaveDir";
            this.SaveDir.ReadOnly = true;
            this.SaveDir.Size = new System.Drawing.Size(338, 23);
            this.SaveDir.TabIndex = 8;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(100, 275);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(338, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "保存路径浏览";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "文档名称";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(100, 319);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(338, 23);
            this.FileName.TabIndex = 11;
            this.FileName.TextChanged += new System.EventHandler(this.FileName_TextChanged);
            // 
            // CreatDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 410);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SaveDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.XMLPathButton);
            this.Controls.Add(this.DocPathButton);
            this.Controls.Add(this.XMLPath);
            this.Controls.Add(this.DocPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreatDoc";
            this.Text = "CreatDoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DocPath;
        private System.Windows.Forms.TextBox XMLPath;
        private System.Windows.Forms.Button DocPathButton;
        private System.Windows.Forms.Button XMLPathButton;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SaveDir;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FileName;
    }
}