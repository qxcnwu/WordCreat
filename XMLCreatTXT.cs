using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WordCreat
{
    public partial class XMLCreatTXT : Form
    {
        public MODWRITE mODWRITE;
        public int FontSizeLn=12;
        public int FontColorLn=0;
        public string ContentLn="";
        public Boolean paraBooleanLn=false;
        public TXTLN tXTLN=new TXTLN();
        public string BookMarkLn;

        public XMLCreatTXT()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FontSize_ValueChanged(object sender, EventArgs e)
        {
            FontSizeLn = (int)FontSize.Value;
        }

        private void FontColor_ValueChanged(object sender, EventArgs e)
        {
            FontColorLn = (int)FontColor.Value;
        }

        private void ParaBoolean_CheckedChanged(object sender, EventArgs e)
        {
            if (ParaBoolean.Checked==true)
            {
                paraBooleanLn = true;
            }
        }

        private void TXTcontent_TextChanged(object sender, EventArgs e)
        {
            ContentLn = TXTcontent.Text;
        }

        private void ADDTXT_Click(object sender, EventArgs e)
        {
            ContentLn = TXTcontent.Text;
            if (ContentLn != "")
            {
                tXTLN.BOOKMARK = BookMarkLn;
                tXTLN.TXTCONTENT = ContentLn;
                tXTLN.FONTSIZE = FontSizeLn;
                tXTLN.FONTCOLOR = FontColorLn;
                tXTLN.PARABOOL = paraBooleanLn;
                mODWRITE.AddNodeBase(BookMarkLn);
                mODWRITE.CreatTxtBase(tXTLN);
                mODWRITE.CloseNodeBase();
                this.Dispose();
            }
            else 
            {
                MessageBox.Show("Can not write null in XML");
            }
        }
    }
}
