using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WordCreat
{
    public partial class XMLCreatTABLE : Form
    {
        public MODWRITE mODWRITE;
        public int FontSizeLn = 12;
        public int FontColorLn = 0;
        public int LineLn = 0;
        public int RowLn = 0;
        public string[] ContentLn = new string[] { };
        public Boolean MidBoolLn = false;
        public Boolean FillBoolLn = false;
        public string TitleLn = "";
        public TABLELN tTable = new TABLELN();
        public string BookMarkLn;

        public XMLCreatTABLE()
        {
            InitializeComponent();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            TitleLn = TitleTextBox.Text;
        }

        private void MIDBool_CheckedChanged(object sender, EventArgs e)
        {
            if (MIDBool.Checked==true)
            {
                MidBoolLn = true;
            }
        }

        private void FillBool_CheckedChanged(object sender, EventArgs e)
        {
            if (FillBool.Checked==true)
            {
                FillBoolLn = true;
            }
        }

        private void TableContent_TextChanged(object sender, EventArgs e)
        {
            ContentLn = TableContent.Text.Split(";");
        }

        private void Line_ValueChanged(object sender, EventArgs e)
        {
            LineLn = (int)Line.Value;
        }

        private void Row_ValueChanged(object sender, EventArgs e)
        {
            RowLn = (int)Row.Value;
        }

        private void FontSize_ValueChanged(object sender, EventArgs e)
        {
            FontSizeLn = (int)FontSize.Value;
        }

        private void FontColor_ValueChanged(object sender, EventArgs e)
        {
            FontColorLn = (int)FontColor.Value;
        }

        private void ADDTABLE_Click(object sender, EventArgs e)
        {
            try
            {
                tTable.BOOKMARK = BookMarkLn;
                tTable.FILLTABLE = FillBoolLn;
                tTable.TABLECONTENT= TableContent.Text.Split(";");
                tTable.LINE = LineLn;
                tTable.ROW = RowLn;
                tTable.FONTSIZE = FontSizeLn;
                tTable.FONTCOLOR = FontColorLn;
                tTable.TITLE = TitleLn;
                mODWRITE.AddNodeBase(BookMarkLn);
                mODWRITE.CreatTableBase(tTable);
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
