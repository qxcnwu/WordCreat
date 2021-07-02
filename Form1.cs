using CPPWordTest;
using System;
using System.IO;
using System.Windows.Forms;


namespace WordCreat
{
    public partial class Form1 : Form
    {
        public string XMLSavePathLn;

        public Form1()
        {
            InitializeComponent();
        }

        //LabelBox添加内容
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreatXml_Click(object sender, EventArgs e)
        {
            CreatXML form2 = new CreatXML();
            form2.ShowDialog();
            XMLSavePathLn= form2.XMLSavePathLn;
        }

        private void CreatDocButton_Click(object sender, EventArgs e)
        {
            CreatDoc form2 = new CreatDoc();
            form2.ShowDialog();
        }
    }
}
