using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManager
{
  /// <summary>
  /// Форма основного приложения.
  /// </summary>
  public partial class MainForm : Form
  {
    /// <summary>
    /// Создание элемента задачи для ListView.
    /// </summary>
    /// <param name="title">Заголовок.</param>
    /// <param name="description">Описание.</param>
    /// <param name="deadlines">Дней на исполнение.</param>
    /// <param name="priority">Приоритет.</param>
    /// <param name="responsible">Ответственные.</param>
    /// <returns>Элемент задачи ListViewItem.</returns>
    private ListViewItem CreateTaskItem(string title, string description, int deadlines, int priority, List<string> responsible)
    {
      var taskItem = new ListViewItem(title, tasksListView.Groups[0]);
      taskItem.ToolTipText = description;
      taskItem.SubItems.Add(deadlines.ToString());
      taskItem.SubItems.Add(priority.ToString());
      taskItem.SubItems.Add(string.Join(", ", responsible));

      // Цвет текста у приоритета.
      taskItem.UseItemStyleForSubItems = false;
      switch (priority)
      {
        case 1: 
          taskItem.SubItems[2].ForeColor = Color.DarkGreen;
          break;
        case 2:
          taskItem.SubItems[2].ForeColor = Color.DarkOliveGreen;
          break;
        case 3:
          taskItem.SubItems[2].ForeColor = Color.DarkOrange;
          break;
        case 4:
          taskItem.SubItems[2].ForeColor = Color.OrangeRed;
          break;
        case 5:
          taskItem.SubItems[2].ForeColor = Color.Red;
          break;
      }

      return taskItem;
    }

    private void CreateMockTaskItems()
    {
      for (int i = 0; i < 10; i++)
      {
        var item = CreateTaskItem($"Задача {i + 1}", $"Описание {i + 1}", i, 1, new List<string>());
        tasksListView.Items.Add(item);
      }
    }

    private void tasksListView_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (tasksListView.SelectedItems.Count > 0)
      {
        upStatusToolStripButton.Enabled = true;
        downStatusToolStripButton.Enabled = true;
        deleteTaskToolStripButton.Enabled = true;
      }
      else
      {
        upStatusToolStripButton.Enabled = false;
        downStatusToolStripButton.Enabled = false;
        deleteTaskToolStripButton.Enabled = false;
      }
    }

    private void createTaskToolStripButton_Click(object sender, EventArgs e)
    {
      var createTaskForm = new CreateTaskForm();
      createTaskForm.ShowDialog();
    }

    private void upStatusToolStripButton_Click(object sender, EventArgs e)
    {
      foreach (ListViewItem item in tasksListView.SelectedItems)
      {
        var itemGoupIndex = tasksListView.Groups.IndexOf(item.Group);

        if (itemGoupIndex > 0)
          tasksListView.Groups[itemGoupIndex - 1].Items.Add(item);
      }
    }

    private void downStatusToolStripButton_Click(object sender, EventArgs e)
    {
      foreach (ListViewItem item in tasksListView.SelectedItems)
      {
        var itemGoupIndex = tasksListView.Groups.IndexOf(item.Group);

        if (itemGoupIndex < tasksListView.Groups.Count - 1)
          tasksListView.Groups[itemGoupIndex + 1].Items.Add(item);
      }
    }

    private void deleteTaskToolStripButton_Click(object sender, EventArgs e)
    {
      MessageBox.Show(
        "Вы действительно хотите удалить выделенные задачи?", 
        "Удаление задач", 
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
        );
    }

    /// <summary>
    /// Конструктор.
    /// </summary>
    public MainForm()
    {
      InitializeComponent();
      CreateMockTaskItems();
    }
  }
}
