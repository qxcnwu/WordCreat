
namespace WordCreat
{
    partial class XMLCreatTABLE
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
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.MIDBool = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TableContent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FillBool = new System.Windows.Forms.CheckBox();
            this.Line = new System.Windows.Forms.NumericUpDown();
            this.Row = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FontColor = new System.Windows.Forms.NumericUpDown();
            this.FontSize = new System.Windows.Forms.NumericUpDown();
            this.ADDTABLE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Row)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "表格标题";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(84, 21);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(342, 23);
            this.TitleTextBox.TabIndex = 1;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // MIDBool
            // 
            this.MIDBool.AutoSize = true;
            this.MIDBool.Location = new System.Drawing.Point(456, 22);
            this.MIDBool.Name = "MIDBool";
            this.MIDBool.Size = new System.Drawing.Size(51, 21);
            this.MIDBool.TabIndex = 2;
            this.MIDBool.Text = "居中";
            this.MIDBool.UseVisualStyleBackColor = true;
            this.MIDBool.CheckedChanged += new System.EventHandler(this.MIDBool_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "表格内容";
            // 
            // TableContent
            // 
            this.TableContent.Location = new System.Drawing.Point(84, 60);
            this.TableContent.Multiline = true;
            this.TableContent.Name = "TableContent";
            this.TableContent.Size = new System.Drawing.Size(342, 114);
            this.TableContent.TabIndex = 4;
            this.TableContent.TextChanged += new System.EventHandler(this.TableContent_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "值之间以 ; 分隔";
            // 
            // FillBool
            // 
            this.FillBool.AutoSize = true;
            this.FillBool.Location = new System.Drawing.Point(522, 21);
            this.FillBool.Name = "FillBool";
            this.FillBool.Size = new System.Drawing.Size(51, 21);
            this.FillBool.TabIndex = 6;
            this.FillBool.Text = "填充";
            this.FillBool.UseVisualStyleBackColor = true;
            this.FillBool.CheckedChanged += new System.EventHandler(this.FillBool_CheckedChanged);
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(85, 183);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(120, 23);
            this.Line.TabIndex = 7;
            this.Line.ValueChanged += new System.EventHandler(this.Line_ValueChanged);
            // 
            // Row
            // 
            this.Row.Location = new System.Drawing.Point(307, 183);
            this.Row.Name = "Row";
            this.Row.Size = new System.Drawing.Size(120, 23);
            this.Row.TabIndex = 8;
            this.Row.ValueChanged += new System.EventHandler(this.Row_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "行数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "列数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "字体颜色";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "字体大小";
            // 
            // FontColor
            // 
            this.FontColor.Location = new System.Drawing.Point(307, 230);
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(120, 23);
            this.FontColor.TabIndex = 12;
            this.FontColor.ValueChanged += new System.EventHandler(this.FontColor_ValueChanged);
            // 
            // FontSize
            // 
            this.FontSize.Location = new System.Drawing.Point(85, 230);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(120, 23);
            this.FontSize.TabIndex = 11;
            this.FontSize.ValueChanged += new System.EventHandler(this.FontSize_ValueChanged);
            // 
            // ADDTABLE
            // 
            this.ADDTABLE.Location = new System.Drawing.Point(84, 272);
            this.ADDTABLE.Name = "ADDTABLE";
            this.ADDTABLE.Size = new System.Drawing.Size(343, 23);
            this.ADDTABLE.TabIndex = 15;
            this.ADDTABLE.Text = "添加";
            this.ADDTABLE.UseVisualStyleBackColor = true;
            this.ADDTABLE.Click += new System.EventHandler(this.ADDTABLE_Click);
            // 
            // XMLCreatTABLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 315);
            this.Controls.Add(this.ADDTABLE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FontColor);
            this.Controls.Add(this.FontSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Row);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.FillBool);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TableContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MIDBool);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label1);
            this.Name = "XMLCreatTABLE";
            this.Text = "XMLCreatTABLE";
            ((System.ComponentModel.ISupportInitialize)(this.Line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Row)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.CheckBox MIDBool;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TableContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox FillBool;
        private System.Windows.Forms.NumericUpDown Line;
        private System.Windows.Forms.NumericUpDown Row;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown FontColor;
        private System.Windows.Forms.NumericUpDown FontSize;
        private System.Windows.Forms.Button ADDTABLE;
    }
}