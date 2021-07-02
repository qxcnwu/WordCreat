
namespace WordCreat
{
    partial class XMLAdd
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
            this.ClassBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BookMarkText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LOGBOX = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassBox
            // 
            this.ClassBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Location = new System.Drawing.Point(80, 19);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(113, 25);
            this.ClassBox.TabIndex = 1;
            this.ClassBox.SelectedIndexChanged += new System.EventHandler(this.ClassBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "插入类型";
            // 
            // BookMarkText
            // 
            this.BookMarkText.Location = new System.Drawing.Point(270, 19);
            this.BookMarkText.Name = "BookMarkText";
            this.BookMarkText.Size = new System.Drawing.Size(113, 23);
            this.BookMarkText.TabIndex = 4;
            this.BookMarkText.TextChanged += new System.EventHandler(this.BookMarkText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "插入标签";
            // 
            // LOGBOX
            // 
            this.LOGBOX.Location = new System.Drawing.Point(12, 122);
            this.LOGBOX.Multiline = true;
            this.LOGBOX.Name = "LOGBOX";
            this.LOGBOX.ReadOnly = true;
            this.LOGBOX.Size = new System.Drawing.Size(371, 303);
            this.LOGBOX.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 61);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(181, 36);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "添加";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(208, 61);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(175, 36);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // XMLAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.LOGBOX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BookMarkText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassBox);
            this.Name = "XMLAdd";
            this.Text = "XMLAdd";
            this.Load += new System.EventHandler(this.XMLAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ClassBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BookMarkText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LOGBOX;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SaveButton;
    }
}