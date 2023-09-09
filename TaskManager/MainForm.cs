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
    private ListViewItem CreateTaskItem(string title, string description, 
      DateTime startDate, DateTime endDate, int priority, List<string> responsible)
    {
      var taskItem = new ListViewItem(title, tasksListView.Groups[0]);
      taskItem.ToolTipText = description;
      taskItem.SubItems.Add(Math.Round((endDate - startDate).TotalDays).ToString());
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

      tasksListView.Items.Add(
        CreateTaskItem(
        "Задача 1",
        "Описание",
        DateTime.Now,
        DateTime.Now,
        1,
        new List<string>() { "Имя1", "Имя2" }
        ));

      tasksListView.Items.Add(
        CreateTaskItem(
        "Задача 1",
        "Описание",
        DateTime.Now,
        DateTime.Now,
        1,
        new List<string>() { "Имя1", "Имя2" }
        ));

      tasksListView.Items.Add(
        CreateTaskItem(
        "Задача 1",
        "Описание",
        DateTime.Now,
        DateTime.Now,
        1,
        new List<string>() { "Имя1", "Имя2" }
        ));

      tasksListView.Items.Add(
        CreateTaskItem(
        "Задача 1",
        "Описание",
        DateTime.Now,
        DateTime.Now,
        1,
        new List<string>() { "Имя1", "Имя2" }
        ));

      tasksListView.Items.Add(
        CreateTaskItem(
        "Задача 1",
        "Описание",
        DateTime.Now,
        DateTime.Now,
        1,
        new List<string>() { "Имя1", "Имя2" }
        ));

      tasksListView.Items.Add(
        CreateTaskItem(
        "Задача 1",
        "Описание",
        DateTime.Now,
        DateTime.Now,
        1,
        new List<string>() { "Имя1", "Имя2" }
        ));

      tasksListView.Items.Add(
        CreateTaskItem(
        "Задача 1",
        "Описание",
        DateTime.Now,
        DateTime.Now,
        1,
        new List<string>() { "Имя1", "Имя2" }
        ));

      tasksListView.Items.Add(
        CreateTaskItem(
        "Задача 1",
        "Описание",
        DateTime.Now,
        DateTime.Now,
        1,
        new List<string>() { "Имя1", "Имя2" }
        ));

      tasksListView.Items.Add(
        CreateTaskItem(
        "Задача 1",
        "Описание",
        DateTime.Now,
        DateTime.Now,
        1,
        new List<string>() { "Имя1", "Имя2" }
        ));
    }
  }
}
