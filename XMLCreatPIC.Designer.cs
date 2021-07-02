
namespace WordCreat
{
    partial class XMLCreatPIC
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
            this.ADDPIC = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChosePicPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ADDPIC
            // 
            this.ADDPIC.Location = new System.Drawing.Point(28, 177);
            this.ADDPIC.Name = "ADDPIC";
            this.ADDPIC.Size = new System.Drawing.Size(259, 23);
            this.ADDPIC.TabIndex = 0;
            this.ADDPIC.Text = "添加";
            this.ADDPIC.UseVisualStyleBackColor = true;
            this.ADDPIC.Click += new System.EventHandler(this.ADDPIC_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(197, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "图像路径";
            // 
            // ChosePicPath
            // 
            this.ChosePicPath.Location = new System.Drawing.Point(28, 132);
            this.ChosePicPath.Name = "ChosePicPath";
            this.ChosePicPath.Size = new System.Drawing.Size(259, 23);
            this.ChosePicPath.TabIndex = 3;
            this.ChosePicPath.Text = "选择图像路径";
            this.ChosePicPath.UseVisualStyleBackColor = true;
            this.ChosePicPath.Click += new System.EventHandler(this.ChosePicPath_Click);
            // 
            // XMLCreatPIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 269);
            this.Controls.Add(this.ChosePicPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ADDPIC);
            this.Name = "XMLCreatPIC";
            this.Text = "XMLCreatPIC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADDPIC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChosePicPath;
    }
}