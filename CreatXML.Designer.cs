
namespace WordCreat
{
    partial class CreatXML
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
            this.XMLDirPath = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.XMLSavePath = new System.Windows.Forms.TextBox();
            this.XMLPathCheck = new System.Windows.Forms.Button();
            this.DirShowPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // XMLDirPath
            // 
            this.XMLDirPath.Location = new System.Drawing.Point(26, 86);
            this.XMLDirPath.Name = "XMLDirPath";
            this.XMLDirPath.Size = new System.Drawing.Size(297, 23);
            this.XMLDirPath.TabIndex = 0;
            this.XMLDirPath.Text = "浏览文件夹";
            this.XMLDirPath.UseVisualStyleBackColor = true;
            this.XMLDirPath.Click += new System.EventHandler(this.XMLDirPath_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(297, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "请选择XML文件保存位置";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(297, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "请输入XML文件名称";
            // 
            // XMLSavePath
            // 
            this.XMLSavePath.Location = new System.Drawing.Point(26, 211);
            this.XMLSavePath.Name = "XMLSavePath";
            this.XMLSavePath.Size = new System.Drawing.Size(297, 23);
            this.XMLSavePath.TabIndex = 3;
            this.XMLSavePath.TextChanged += new System.EventHandler(this.XMLSavePath_TextChanged);
            // 
            // XMLPathCheck
            // 
            this.XMLPathCheck.Location = new System.Drawing.Point(26, 266);
            this.XMLPathCheck.Name = "XMLPathCheck";
            this.XMLPathCheck.Size = new System.Drawing.Size(297, 23);
            this.XMLPathCheck.TabIndex = 4;
            this.XMLPathCheck.Text = "确定";
            this.XMLPathCheck.UseVisualStyleBackColor = true;
            this.XMLPathCheck.Click += new System.EventHandler(this.XMLPathCheck_Click);
            // 
            // DirShowPath
            // 
            this.DirShowPath.Location = new System.Drawing.Point(26, 127);
            this.DirShowPath.Name = "DirShowPath";
            this.DirShowPath.ReadOnly = true;
            this.DirShowPath.Size = new System.Drawing.Size(297, 23);
            this.DirShowPath.TabIndex = 5;
            // 
            // CreatXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 410);
            this.Controls.Add(this.DirShowPath);
            this.Controls.Add(this.XMLPathCheck);
            this.Controls.Add(this.XMLSavePath);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.XMLDirPath);
            this.Name = "CreatXML";
            this.Text = "CreatXML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button XMLDirPath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox XMLSavePath;
        private System.Windows.Forms.Button XMLPathCheck;
        private System.Windows.Forms.TextBox DirShowPath;
    }
}