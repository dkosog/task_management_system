using System;
using System.Drawing;
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

        private void createTaskButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Уведомление о создании новой задачи.
        /// </summary>
        /// <param name="task">Новая задача</param>
        private void ShowNotification(ListView task)
        {
            var notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Information;
            notifyIcon.Visible = true;

            notifyIcon.BalloonTipTitle = "Новая задача: " + task.Title;
            notifyIcon.BalloonTipText = "Описание: " + task.Disciption + Environment.NewLine +
                                        "Приоритет: " + task.Status.ToString() + Environment.NewLine +
                                        "Дедлайн: " + task.Deadlines + Environment.NewLine +
                                        "Список ответственных: " + string.Join(", ", task.Responsible);

            notifyIcon.ShowBalloonTip(3000);

            notifyIcon.Dispose();
        }
    }
}
