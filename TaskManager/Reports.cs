using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;
using System.IO;
using System.Collections;

namespace TaskManager
{
  internal class Reports
  {
    private ListView tasksListView;

    /// <summary>
    /// Список заголовков.
    /// </summary>
    private List<string> namesCellsTask = new List<string>();

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="list">ListView.</param>
    public Reports(ListView list)
    {
      tasksListView = list;
    }

    /// <summary>
    /// Создание отчета.
    /// </summary>
    public void ReportCreate()
    {
      string fileName = $"{DateTime.Now.ToString("ddMMyyy")}.xlsx";
      string path = Directory.GetCurrentDirectory();

      NamesListView();
      MainForm mainForm = new MainForm();

      Microsoft.Office.Interop.Excel.Application appExcel = new Microsoft.Office.Interop.Excel.Application();
      Workbook workbook = appExcel.Workbooks.Add(XlSheetType.xlWorksheet);
      Worksheet worksheet = (Worksheet)appExcel.ActiveSheet;
      appExcel.Visible = false;
      int counter = 1;

      // Заполнение названия столбцов
      foreach (var nameCell in namesCellsTask)
      {
        worksheet.Cells[1, counter] = nameCell;
        counter++;
      }
      int cellCurrent = 1;
      int cellsStarting = 2;

      // Заполнение остальных строк
      foreach (ListViewItem cell in tasksListView.Items)
      {
        foreach (ListViewItem.ListViewSubItem rows in cell.SubItems)
        {
          worksheet.Cells[cellsStarting, cellCurrent] = rows.Text;
          cellCurrent++;
        }
        cellsStarting++;
      }
      workbook.SaveAs(Path.Combine(path, fileName), XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
      appExcel.Quit();

      Marshal.ReleaseComObject(workbook);
      Marshal.ReleaseComObject(worksheet);
      Marshal.ReleaseComObject(appExcel);
      MessageBox.Show("Экспорт данных выполнен успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Создание списка заголовков.
    /// </summary>
    private void NamesListView()
    {
      int number = 1;
      foreach (ColumnHeader column in tasksListView.Columns)
      {
        string[] name = column.Text.Split(':');
        namesCellsTask.Add(name.Last());
        number++;
      }
    }
  }
}
