using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManager
{
  public partial class MainForm : Form
  {
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
        new List<string>() { "Имя1", "Имя2"}
        ));    
    }

    private ListViewItem CreateTaskItem(string title, string description, 
      DateTime startDate, DateTime endDate, int priority, List<string> responsible)
    {
      var taskItem = new ListViewItem(title, tasksListView.Groups[0]);
      taskItem.ToolTipText = description;
      taskItem.SubItems.Add(Math.Round((endDate - startDate).TotalDays).ToString());
      taskItem.SubItems.Add(priority.ToString());
      taskItem.SubItems.Add(string.Join(", ", responsible));

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

    private void upStatusButton_Click(object sender, EventArgs e)
    {
      foreach (ListViewItem item in tasksListView.SelectedItems)
      {
        var itemGoupIndex = tasksListView.Groups.IndexOf(item.Group);

        if (itemGoupIndex > 0)
          tasksListView.Groups[itemGoupIndex - 1].Items.Add(item);
      }
    }

    private void downStatusButton_Click(object sender, EventArgs e)
    {
      foreach (ListViewItem item in tasksListView.SelectedItems)
      {
        var itemGoupIndex = tasksListView.Groups.IndexOf(item.Group);

        if (itemGoupIndex < tasksListView.Groups.Count - 1)
          tasksListView.Groups[itemGoupIndex + 1].Items.Add(item);
      }
    }

    private void createTaskButton_Click(object sender, EventArgs e)
    {
      var userList = new List<string>();

      for (int i = 0; i < usersCheckedListBox.Items.Count; i++)
      {
        if (usersCheckedListBox.GetItemCheckState(i) == CheckState.Checked)
        {
          userList.Add(usersCheckedListBox.Items[i].ToString());
        }
      }

      tabMenu.SelectTab(0);

      tasksListView.Items.Add(
        CreateTaskItem(
        titleTextBox.Text,
        descriptionTextBox.Text,
        startDateTimePicker.Value,
        endDateTimePicker.Value,
        (int)priorityNumericUpDown.Value,
        userList
        ));
    }

    private void sendCommentButton_Click(object sender, EventArgs e)
    {
      sendCommentTextBox.Clear();
    }

    private void deleteTasksButton_Click(object sender, EventArgs e)
    {
      foreach (ListViewItem item in tasksListView.SelectedItems)
      {
        tasksListView.Items.Remove(item);
      }
    }
  }
}
