using System;
using System.Windows.Forms;

namespace TaskManager
{
  /// <summary>
  /// Форма создания задачи.
  /// </summary>
  public partial class CreateTaskForm : Form
  {
    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    /// <summary>
    /// Конструктор.
    /// </summary>
    public CreateTaskForm()
    {
      InitializeComponent();
    }
  }
}
