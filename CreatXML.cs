using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WordCreat
{

    public partial class CreatXML : Form
    {
        public string XMLDirLn;
        public string XMLNameLn;
        public string XMLSavePathLn;

        public CreatXML()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void XMLSavePath_TextChanged(object sender, EventArgs e)
        {
            XMLNameLn = XMLSavePath.Text;
        }

        private void XMLDirPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                XMLDirLn = dialog.SelectedPath;
                DirShowPath.Text = XMLDirLn;
            }
        }

        private void XMLPathCheck_Click(object sender, EventArgs e)
        {
            try
            {
                XMLSavePathLn = System.IO.Path.Combine(XMLDirLn, XMLNameLn);
                this.Dispose();
                XMLAdd form3 = new XMLAdd();
                form3.XMLSavePathLn = XMLSavePathLn;
                form3.mODWRITE = new MODWRITE(XMLSavePathLn);
                form3.ShowDialog();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            
        }
    }
}
