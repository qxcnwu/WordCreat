using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using MSWord = Microsoft.Office.Interop.Word;

namespace CPPWordTest
{
    public class WORD
    {
        public object modelPath;
        public object savePath;
        public MSWord.Application wordApp;
        public MSWord.Document wordDoc;
        public object Nothing = Missing.Value;
        public object format = MSWord.WdSaveFormat.wdFormatDocument;
        public object SaveChanges = WdSaveOptions.wdSaveChanges;
        public object OriginalFormat = WdOriginalFormat.wdOriginalDocumentFormat;
        public object RouteDocument = false;

        public WORD(string dotPathIn, string savePathLn, bool VisibleBool)
        {
            modelPath = dotPathIn;
            savePath = savePathLn;
            WordInit(VisibleBool);
            CreatDocByModel(VisibleBool);
        }

        //WORD初始化方法
        private void WordInit(bool VisibleBool)
        {
            //判断保存文件路径是否已经存在，存在后删除并且重新生成
            if (File.Exists((string)savePath))
            {
                File.Delete((string)savePath);
            }
            //创建WORD APP ，设置其是否可见
            CreatDocByModel(VisibleBool);
        }

        //依赖模板创建方法
        public void CreatDocByModel(bool VisibleBool)
        {
            //关闭所有打开的WORD文档
            killWinWordProcess();
            //创建新模板文件
            wordApp = new ApplicationClass();
            wordApp.DisplayAlerts = WdAlertLevel.wdAlertsNone;
            wordApp.Visible = VisibleBool;
            wordDoc = wordApp.Documents.Open(ref modelPath, ref Nothing,
              ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing,
              ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing,
              ref Nothing, ref Nothing, ref Nothing, ref Nothing);
        }

        //保存文档方法
        public void SaveDoc()
        {
            //保存文档API
            wordDoc.SaveAs(ref savePath, ref format, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing,
              ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing,
              ref Nothing, ref Nothing, ref Nothing, ref Nothing);
            wordDoc.Close(ref SaveChanges, ref OriginalFormat, ref RouteDocument);
            wordApp.Quit(ref SaveChanges, ref OriginalFormat, ref RouteDocument);
        }

        //创建文档辅助结束进程方法
        public void killWinWordProcess()
        {
            Process[] myproc = Process.GetProcessesByName("WINWORD");
            foreach (var p in myproc)
            {
                p.Kill();
            }
        }

        //查找所属的文档书签是否存在返回Bool值
        public bool BookMarksExist(string bookMark)
        {
            if (wordApp.ActiveDocument.Bookmarks.Exists(bookMark))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class TXT
    {
        WORD wORD;

        public TXT(WORD wORDLn)
        {
            wORD = wORDLn;
        }
        //插入一段文字同时设置相应元数据
        public bool InsertTxt(string bookMark, string txt, int fontSize = 12, int fontColor = 0, bool paraBool = true)
        {
            //判断是否有bookmark标签
            if (wORD.BookMarksExist(bookMark))
            {
                object oStart = bookMark;
                MSWord.Range range = wORD.wordDoc.Bookmarks.get_Item(ref oStart).Range;
                //判断是否添加为段落，含首行缩进
                if (paraBool)
                {
                    txt = "\n" + txt + "\n";
                }
                range.Text = txt;
                range.Font.Size = fontSize;
                range.Font.Color = (WdColor)fontColor;
                range.Select();
                return true;
            }
            else
            {
                Console.WriteLine(bookMark + " not exist,Please check you bookmark name!");
                return false;
            }
        }
    }

    public class TabelW
    {
        WORD wORD;
        public TabelW(WORD wORDLn)
        {
            wORD = wORDLn;
        }

        //在WORD对象当中创建列表
        public bool CreatTabel(string bookMark, string titleLabel, bool fillTabel, string[] filled, int line = 4, int row = 5, int fontSize = 12, int fontColor = 0)
        {
            if (wORD.BookMarksExist(bookMark))
            {
                object oStart = bookMark;
                MSWord.Range range = wORD.wordDoc.Bookmarks.get_Item(ref oStart).Range;

                if (titleLabel != "")
                {
                    range.InsertBefore(titleLabel);
                    range.Font.Size = fontSize;
                    range.Font.Color = (WdColor)fontColor;
                    //标题居中
                    range.ParagraphFormat.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphCenter;
                    range.InsertParagraphAfter();
                    range.SetRange(range.End, range.End);
                }

                Table tbl = range.Tables.Add(range, row, line, ref wORD.Nothing, ref wORD.Nothing);
                tbl.Range.Font.Size = fontSize;
                tbl.Range.Font.Color = (WdColor)fontColor;
                tbl.Columns.DistributeWidth();

                if (fillTabel)
                {
                    if (FillTable(tbl, filled, line, row))
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Unable to fill tabel");
                        return false;
                    }

                }
                else
                {
                    return true;
                }
            }
            else
            {
                Console.WriteLine(bookMark + " not exist,Please check you bookmark name!");
                return false;
            }
        }

        //向表格中填入相应的值
        private bool FillTable(Table tbl, string[] filled, int line, int row)
        {
            if ((filled.Length - 1) == line * row)
            {
                for (int i = 0; i < line; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        tbl.Cell(j + 1, i + 1).Range.Text = filled[i * row + j];
                    }
                }
                return true;
            }
            else
            {
                Console.WriteLine("please check row or line number!!");
                return false;
            }
        }

    }

    public class PICTURE
    {
        WORD wORD;
        public PICTURE(WORD wORDLn)
        {
            wORD = wORDLn;
        }

        //插入图像方法
        public bool PictureAdd(string bookMark, string picPath)
        {
            if (wORD.BookMarksExist(bookMark) && File.Exists(picPath))
            {
                object oStart = bookMark;
                MSWord.Range range = wORD.wordDoc.Bookmarks.get_Item(ref oStart).Range;
                range.Select();
                range.InlineShapes.AddPicture(picPath);
                return true;
            }
            else
            {
                Console.WriteLine(bookMark + "||" + picPath + " not exist,Please check you bookmark name!");
                return false;
            }
        }

    }
}
