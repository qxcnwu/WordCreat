using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WordCreat
{
    public partial class XMLCreatPIC : Form
    {
        public MODWRITE mODWRITE;
        public PICTURELN pICTURELN = new PICTURELN();
        public string BookMarkLn;
        public string PicPathLn;

        public XMLCreatPIC()
        {
            InitializeComponent();
        }

        private void ChosePicPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择图片";
            dialog.Filter = "图片(*.jpg;*.png)|*.jpg;*.png";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PicPathLn = dialog.FileName;
                textBox1.Text = PicPathLn;

            }
        }

        private void ADDPIC_Click(object sender, EventArgs e)
        {
            try
            {
                pICTURELN.BOOKMARK = BookMarkLn;
                pICTURELN.PICPATH =PicPathLn;
                mODWRITE.AddNodeBase(BookMarkLn);
                mODWRITE.CreatPicBase(pICTURELN);
                mODWRITE.CloseNodeBase();
                this.Dispose();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
