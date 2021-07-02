using CPPWordTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WordCreat
{
    public partial class CreatDoc : Form
    {
        public string PicPathLn;
        public string XMLPathLn;
        public string SaveDirLn;
        public string SavePathLn="";

        public CreatDoc()
        {
            InitializeComponent();
        }

        private void DocPathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择文档路径";
            dialog.Filter = "文档(*.doc;*.docx)|*.doc;*.docx";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PicPathLn = dialog.FileName;
                DocPath.Text = PicPathLn;
            }
        }

        private void XMLPathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择XML文件路径";
            dialog.Filter = "文档(*.xml;*.XML)|*.xml;*.XML";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                XMLPathLn = dialog.FileName;
                XMLPath.Text = XMLPathLn;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SaveDirLn = dialog.SelectedPath;
                SaveDir.Text = SaveDirLn;
            }
        }

        private void FileName_TextChanged(object sender, EventArgs e)
        {
            SavePathLn = Path.Combine(SaveDirLn, FileName.Text);
        }

        private void Done_Click(object sender, EventArgs e)
        {
            if (SavePathLn != ""&& PicPathLn!=""&& XMLPathLn!="")
            {
                WORD wORD = new WORD(PicPathLn, SavePathLn, false);
                MODRESREAD mODWRITE1 = new MODRESREAD(XMLPathLn, wORD);
                MessageBox.Show("完成");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("请确认路径是否正确！！");
            }
        }
    }
}
