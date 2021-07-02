using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WordCreat
{
    public partial class XMLAdd : Form
    {
        public string XMLSavePathLn;
        public string ClassName;
        public MODWRITE mODWRITE;
        public string BookMark;

        public XMLAdd()
        {
            InitializeComponent();
        }


        private void XMLAdd_Load(object sender, EventArgs e)
        {
            string[] BoxList = new string[] { "路径", "文本", "表格", "图像" };
            foreach (string i in BoxList)
            {
                ClassBox.Items.Add(i);
            }
        }

        private void ClassBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassName = ClassBox.Text;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ClassName== "文本" && XMLSavePathLn!=""&& BookMark!="")
            {
                XMLCreatTXT form3 = new XMLCreatTXT();
                form3.BookMarkLn = BookMark;
                form3.mODWRITE = mODWRITE;
                form3.ShowDialog();
                LOGBOX.AppendText(BookMark+" 位置注入TXTINSERT完成\r\n");
                BookMarkText.Text = "";
                ClassBox.Text = null;
            }
            else if (ClassName == "表格" && XMLSavePathLn != "" && BookMark != "")
            {
                XMLCreatTABLE form3 = new XMLCreatTABLE();
                form3.BookMarkLn = BookMark;
                form3.mODWRITE = mODWRITE;
                form3.ShowDialog(); 
                LOGBOX.AppendText(BookMark + " 位置注入TABLEINSERT完成\r\n");
                BookMarkText.Text = "";
                ClassBox.Text = null;
            }
            else if (ClassName == "图像" && XMLSavePathLn != "" && BookMark != "")
            {
                XMLCreatPIC form3 = new XMLCreatPIC();
                form3.BookMarkLn = BookMark;
                form3.mODWRITE = mODWRITE;
                form3.ShowDialog();
                LOGBOX.AppendText(BookMark + " 位置注入PICTUREINSERT完成\r\n");
                BookMarkText.Text = "";
                ClassBox.Text = null;
            }
            else
            {
                MessageBox.Show("Please check your class name && save path && bookmark");
                LOGBOX.AppendText(BookMark+ " 位置注入INSERT失败\r\n");
                BookMarkText.Text = "";
                ClassBox.Text = null;
            }
        }

        private void BookMarkText_TextChanged(object sender, EventArgs e)
        {
            BookMark = BookMarkText.Text;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                mODWRITE.SaveFile();
                LOGBOX.AppendText("文件保存成功 "+ XMLSavePathLn);
                this.Dispose();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
