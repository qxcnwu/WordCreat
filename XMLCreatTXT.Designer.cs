
namespace WordCreat
{
    partial class XMLCreatTXT
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
            this.TXTcontent = new System.Windows.Forms.TextBox();
            this.ADDTXT = new System.Windows.Forms.Button();
            this.FontSize = new System.Windows.Forms.NumericUpDown();
            this.FontColor = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ParaBoolean = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.FontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontColor)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTcontent
            // 
            this.TXTcontent.Location = new System.Drawing.Point(23, 118);
            this.TXTcontent.Multiline = true;
            this.TXTcontent.Name = "TXTcontent";
            this.TXTcontent.Size = new System.Drawing.Size(447, 264);
            this.TXTcontent.TabIndex = 0;
            this.TXTcontent.TextChanged += new System.EventHandler(this.TXTcontent_TextChanged);
            // 
            // ADDTXT
            // 
            this.ADDTXT.Location = new System.Drawing.Point(23, 392);
            this.ADDTXT.Name = "ADDTXT";
            this.ADDTXT.Size = new System.Drawing.Size(447, 23);
            this.ADDTXT.TabIndex = 1;
            this.ADDTXT.Text = "添加";
            this.ADDTXT.UseVisualStyleBackColor = true;
            this.ADDTXT.Click += new System.EventHandler(this.ADDTXT_Click);
            // 
            // FontSize
            // 
            this.FontSize.Location = new System.Drawing.Point(92, 14);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(120, 23);
            this.FontSize.TabIndex = 2;
            this.FontSize.ValueChanged += new System.EventHandler(this.FontSize_ValueChanged);
            // 
            // FontColor
            // 
            this.FontColor.Location = new System.Drawing.Point(92, 54);
            this.FontColor.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(120, 23);
            this.FontColor.TabIndex = 3;
            this.FontColor.ValueChanged += new System.EventHandler(this.FontColor_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "字体大小";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "字体颜色";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "文本输入";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ParaBoolean
            // 
            this.ParaBoolean.AutoSize = true;
            this.ParaBoolean.Location = new System.Drawing.Point(92, 94);
            this.ParaBoolean.Name = "ParaBoolean";
            this.ParaBoolean.Size = new System.Drawing.Size(75, 21);
            this.ParaBoolean.TabIndex = 7;
            this.ParaBoolean.Text = "段落标记";
            this.ParaBoolean.UseVisualStyleBackColor = true;
            this.ParaBoolean.CheckedChanged += new System.EventHandler(this.ParaBoolean_CheckedChanged);
            // 
            // XMLCreatTXT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 427);
            this.Controls.Add(this.ParaBoolean);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FontColor);
            this.Controls.Add(this.FontSize);
            this.Controls.Add(this.ADDTXT);
            this.Controls.Add(this.TXTcontent);
            this.Name = "XMLCreatTXT";
            this.Text = "XMLCreatTXT";
            ((System.ComponentModel.ISupportInitialize)(this.FontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTcontent;
        private System.Windows.Forms.Button ADDTXT;
        private System.Windows.Forms.NumericUpDown FontSize;
        private System.Windows.Forms.NumericUpDown FontColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ParaBoolean;
    }
}