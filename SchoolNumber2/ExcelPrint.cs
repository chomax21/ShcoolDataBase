using Microsoft.Office.Interop.Excel;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excelapp = Microsoft.Office.Interop.Excel;

namespace SchoolNumber2
{
    public class ExcelPrint
    {


        public static void PrintDataGridToExel(DataGridView data, SaveFileDialog saveFile)
        {

            Excelapp.Application excelApp = null;
            Workbooks workbooks = null;
            Workbook workbook = null;

            try
            {
                saveFile.InitialDirectory = "C";
                saveFile.Title = "SAVE AS EXCEL FILE";
                saveFile.FileName = DateTime.Now.ToString("yyyy/MM/dd HH/mm/ss ") + "";
                saveFile.Filter = "Excel Files (2007)|*.xlsx|Excel Files(.CSV)|*.csv";

                if (saveFile.ShowDialog() != DialogResult.Cancel)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    excelApp = new Excelapp.Application();
                    workbooks = excelApp.Workbooks;
                    workbook = workbooks.Add();
                    excelApp.Columns.ColumnWidth = 15;
                    for (int i = 1; i < data.Columns.Count + 1; i++)
                    {
                        excelApp.Cells[1, i] = data.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        for (int j = 0; j < data.Columns.Count; j++)
                        {
                            excelApp.Cells[i + 2, j + 1] = data.Rows[i].Cells[j].Value ?? "-".ToString();
                        }
                    }
                    excelApp.ActiveWorkbook.SaveCopyAs(saveFile.FileName.ToString());
                    excelApp.ActiveWorkbook.Saved = true;
                    excelApp.Quit();

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    MessageBox.Show("Успешно!", "Выполнение");
                }
                Cursor.Current = Cursors.Default;
                saveFile.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Упс! Что-то пошло не так...\n" + ex.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (workbook != null)
                {
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(workbooks);
                    Marshal.ReleaseComObject(excelApp);
                }

            }
        }
    }
}
