using CPPWordTest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using WordCreat;

namespace WordCreat
{
    //整体结构如下
    // CLASSNAME->(TXT/TABLE/PICTURE)
    // TXT->(BOOKMARK,TXTCONTENT,FONTSIZE,FONTCOLOR,PARABOOL)
    //TABLE->(BOOKMARK,TITLE,FILLTABLE,TABLECONTENT,LINE,ROW,FONTSIZE,FONTCOLOR)
    //PICTURE->(BOOKMARK,PICPATH)

    //TXT插入结构体
    public struct TXTLN
    {
        private string bookmark;
        private string txtcontent;
        private int fontsize;
        private int fontcolor;
        private bool parabool;
        public string BOOKMARK
        {
            get { return bookmark; }
            set { bookmark = value; }
        }
        public string TXTCONTENT
        {
            get { return txtcontent; }
            set { txtcontent = value; }
        }

        public int FONTSIZE
        {
            get { return fontsize; }
            set { fontsize = value; }
        }
        public int FONTCOLOR
        {
            get { return fontcolor; }
            set { fontcolor = value; }
        }
        public bool PARABOOL
        {
            get { return parabool; }
            set { parabool = value; }
        }
    }

    //TABLE插入结构体
    public struct TABLELN
    {
        string bookmark;
        string title;
        bool filltable;
        string[] tablecontent;
        int line;
        int row;
        int fontsize;
        int fontcolor;

        public string BOOKMARK
        {
            get { return bookmark; }
            set { bookmark = value; }
        }

        public string TITLE
        {
            get { return title; }
            set { title = value; }
        }

        public bool FILLTABLE
        {
            get { return filltable; }
            set { filltable = value; }
        }

        public string[] TABLECONTENT
        {

            get { return tablecontent; }
            set { tablecontent = value; }
        }

        public int LINE
        {
            get { return line; }
            set { line = value; }
        }

        public int ROW
        {
            get { return row; }
            set { row = value; }
        }

        public int FONTSIZE
        {
            get { return fontsize; }
            set { fontsize = value; }
        }

        public int FONTCOLOR
        {
            get { return fontcolor; }
            set { fontcolor = value; }
        }
    }

    //图像插入结构体
    public struct PICTURELN
    {
        string bookmark;
        string picpath;

        public string BOOKMARK
        {
            get { return bookmark; }
            set { bookmark = value; }
        }

        public string PICPATH
        {
            get { return picpath; }
            set { picpath = value; }
        }
    }


    public class MODRESREAD
    {
        XmlDocument xmlDocument;
        WORD wORD;

        //读取XML文件同时初始化
        public MODRESREAD(string xmlPath, WORD wORDLn)
        {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlPath);
            wORD = wORDLn;
            MODRELOAD();
        }
        //解析XML文件子节点
        public bool MODRELOAD()
        {
            try
            {
                Console.WriteLine("start load");
                XmlNode xn = xmlDocument.SelectSingleNode("MOD");
                XmlNodeList xns = xn.ChildNodes;
                foreach (XmlNode xn1 in xns)
                {
                    XmlElement xe = (XmlElement)xn1;
                    NODEUNPACK(xe.GetElementsByTagName("CLASS")[0].InnerText, xe);
                }
                wORD.SaveDoc();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
        //解析插入文件样式
        private void NODEUNPACK(string innerText, XmlElement xe)
        {
            switch (innerText)
            {
                case "TXT":
                    NODETXT(xe);
                    break;
                case "TABLE":
                    NODETABLE(xe);
                    break;
                case "PICTURE":
                    NODEPICTURE(xe);
                    break;
                default:
                    Console.WriteLine("None Defined mode!!");
                    break;
            }
        }
        //解析插入PICTURE文件
        private bool NODEPICTURE(XmlElement xe)
        {
            PICTURELN pICTURELN = new PICTURELN();
            try
            {
                pICTURELN.BOOKMARK = xe.GetElementsByTagName("BOOKMARK")[0].InnerText;
                pICTURELN.PICPATH = xe.GetElementsByTagName("PICPATH")[0].InnerText;
                PICTURE pICTURE = new PICTURE(wORD);
                return pICTURE.PictureAdd(pICTURELN.BOOKMARK, pICTURELN.PICPATH);
            }
            catch (Exception e)
            {
                Console.WriteLine("NODEPICTURE " + e.Message);
                return false;
            }
        }
        //解析插入TABLE文件
        private bool NODETABLE(XmlElement xe)
        {
            TABLELN tABLELN = new TABLELN();
            try
            {
                tABLELN.BOOKMARK = xe.GetElementsByTagName("BOOKMARK")[0].InnerText;
                tABLELN.TITLE = xe.GetElementsByTagName("TITLE")[0].InnerText;
                tABLELN.FILLTABLE = Convert.ToBoolean(xe.GetElementsByTagName("FILLTABLE")[0].InnerText);
                string content = xe.GetElementsByTagName("TABLECONTENT")[0].InnerText;
                tABLELN.TABLECONTENT = content.Split(";");
                tABLELN.LINE = Convert.ToInt32(xe.GetElementsByTagName("LINE")[0].InnerText);
                tABLELN.ROW = Convert.ToInt32(xe.GetElementsByTagName("ROW")[0].InnerText);
                tABLELN.FONTSIZE = Convert.ToInt32(xe.GetElementsByTagName("FONTSIZE")[0].InnerText);
                tABLELN.FONTCOLOR = Convert.ToInt32(xe.GetElementsByTagName("FONTCOLOR")[0].InnerText);

                TabelW tabelW = new TabelW(wORD);
                return tabelW.CreatTabel(tABLELN.BOOKMARK, tABLELN.TITLE, tABLELN.FILLTABLE, tABLELN.TABLECONTENT, tABLELN.LINE, tABLELN.ROW, tABLELN.FONTSIZE, tABLELN.FONTCOLOR);
            }
            catch (Exception e)
            {
                Console.WriteLine("NODETABLE " + e.Message);
                return false;
            }
        }
        //解析插入TXT文件
        private bool NODETXT(XmlElement xe)
        {
            TXTLN tXTLN = new TXTLN();
            try
            {
                tXTLN.BOOKMARK = xe.GetElementsByTagName("BOOKMARK")[0].InnerText;
                tXTLN.TXTCONTENT = xe.GetElementsByTagName("TXTCONTENT")[0].InnerText;
                tXTLN.FONTSIZE = Convert.ToInt32(xe.GetElementsByTagName("FONTSIZE")[0].InnerText);
                tXTLN.FONTCOLOR = Convert.ToInt32(xe.GetElementsByTagName("FONTCOLOR")[0].InnerText);
                tXTLN.PARABOOL = Convert.ToBoolean(xe.GetElementsByTagName("PARABOOL")[0].InnerText);
                TXT tXT = new TXT(wORD);
                return tXT.InsertTxt(tXTLN.BOOKMARK, tXTLN.TXTCONTENT, fontSize: tXTLN.FONTSIZE, fontColor: tXTLN.FONTCOLOR, paraBool: tXTLN.PARABOOL);
            }
            catch (Exception e)
            {
                Console.WriteLine("NODETXT" + e.Message);
                return false;
            }
        }
    }

    public class MODWRITE
    {
        XmlDocument xmlDocument;
        XmlNode node;
        XmlNode root;
        string savePath;

        public MODWRITE(string savePathLn)
        {
            savePath = savePathLn;
            CreatXML("MOD");
        }
        //XML文档初始化
        public void CreatXML(string nameBase)
        {
            xmlDocument = new XmlDocument();
            node = xmlDocument.CreateXmlDeclaration("1.0", "utf-8", "");
            xmlDocument.AppendChild(node);
            root = xmlDocument.CreateElement(nameBase);
            xmlDocument.AppendChild(root);
            
        }
        // 新建单个节点操作
        public void AddNodeBase(string savePath)
        {
            node = xmlDocument.CreateNode(XmlNodeType.Element, savePath, null);
        }
        //关闭当前节点操作
        public void CloseNodeBase()
        {
            root.AppendChild(node);
        }
        //插入子节点操作
        public void CreateNode(XmlDocument xmlDoc, XmlNode parentNode, string name, string value)
        {
            XmlNode node1 = xmlDoc.CreateNode(XmlNodeType.Element, name, null);
            node1.InnerText = value;
            parentNode.AppendChild(node1);
        }
        //插入TXT节点操作
        public void CreatTxtBase(TXTLN tXTLN)
        {
            CreateNode(xmlDocument, node, "CLASS", "TXT");
            CreateNode(xmlDocument, node, "BOOKMARK", tXTLN.BOOKMARK);
            CreateNode(xmlDocument, node, "TXTCONTENT", tXTLN.TXTCONTENT);
            CreateNode(xmlDocument, node, "FONTSIZE", tXTLN.FONTSIZE.ToString());
            CreateNode(xmlDocument, node, "FONTCOLOR", tXTLN.FONTCOLOR.ToString());
            CreateNode(xmlDocument, node, "PARABOOL", tXTLN.PARABOOL.ToString());
        }
        //插入列表节点操作
        public void CreatTableBase(TABLELN tTabel)
        {
            CreateNode(xmlDocument, node, "CLASS", "TABLE");
            CreateNode(xmlDocument, node, "BOOKMARK", tTabel.BOOKMARK);
            CreateNode(xmlDocument, node, "TITLE", tTabel.TITLE);
            CreateNode(xmlDocument, node, "FILLTABLE", tTabel.FILLTABLE.ToString());

            //二维文字组合生成字符串
            string ContentLn = "";
            foreach (string i in tTabel.TABLECONTENT)
            {
                ContentLn += i + ";";
            }

            CreateNode(xmlDocument, node, "TABLECONTENT", ContentLn);
            CreateNode(xmlDocument, node, "LINE", tTabel.LINE.ToString());
            CreateNode(xmlDocument, node, "ROW", tTabel.ROW.ToString());
            CreateNode(xmlDocument, node, "FONTSIZE", tTabel.FONTSIZE.ToString());
            CreateNode(xmlDocument, node, "FONTCOLOR", tTabel.FONTCOLOR.ToString());
        }
        //插入图像节点操作
        public void CreatPicBase(PICTURELN pICTURELN)
        {
            CreateNode(xmlDocument, node, "CLASS", "PICTURE");
            CreateNode(xmlDocument, node, "BOOKMARK", pICTURELN.BOOKMARK);
            CreateNode(xmlDocument, node, "PICPATH", pICTURELN.PICPATH);
        }
        //保存当前文件
        public bool SaveFile()
        {
            try
            {
                xmlDocument.Save(savePath);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

    }
}
