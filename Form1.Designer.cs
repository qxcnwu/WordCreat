
namespace WordCreat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreatXml = new System.Windows.Forms.Button();
            this.CreatDocButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatXml
            // 
            this.CreatXml.Location = new System.Drawing.Point(17, 18);
            this.CreatXml.Name = "CreatXml";
            this.CreatXml.Size = new System.Drawing.Size(225, 28);
            this.CreatXml.TabIndex = 11;
            this.CreatXml.Text = "创建XML";
            this.CreatXml.UseVisualStyleBackColor = true;
            this.CreatXml.Click += new System.EventHandler(this.CreatXml_Click);
            // 
            // CreatDocButton
            // 
            this.CreatDocButton.Location = new System.Drawing.Point(17, 146);
            this.CreatDocButton.Name = "CreatDocButton";
            this.CreatDocButton.Size = new System.Drawing.Size(225, 32);
            this.CreatDocButton.TabIndex = 12;
            this.CreatDocButton.Text = "生成文档";
            this.CreatDocButton.UseVisualStyleBackColor = true;
            this.CreatDocButton.Click += new System.EventHandler(this.CreatDocButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 260);
            this.Controls.Add(this.CreatDocButton);
            this.Controls.Add(this.CreatXml);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreatXml;
        private System.Windows.Forms.Button CreatDocButton;
    }
}

