using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;


namespace SchoolNumber2
{
    public class WordPrint
    {
        private FileInfo _fileinfo;

        public WordPrint(string filename)
        {
            if (File.Exists(filename))
            {
                _fileinfo = new FileInfo(filename);
            }
            else
            {
                throw new ArgumentException("Файл WORD не найден!");
            }
        }

        internal bool Process(Dictionary<string, string> items)
        {          
            Word.Application app = null;
            try
            {
                app = new Word.Application();
                Object file = _fileinfo.FullName;

                Object missing = Type.Missing;

                app.Documents.Open(file);

                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replace);
                }

                var newPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

                Object newFileName = Path.Combine(newPath, DateTime.Now.ToString("yyyy/MM/dd HH/mm/ss ") + _fileinfo.Name);
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();
                MessageBox.Show("Успешно! Файл сохранен на рабочем столе", "Выполнение");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Что-то пошло не так!", MessageBoxButtons.OK);
            }
            finally
            {
                if (app != null)
                {
                  app.Quit();
                }

            }    
            return false;
        }
    }
}
